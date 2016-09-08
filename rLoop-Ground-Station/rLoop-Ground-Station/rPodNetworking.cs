using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using Newtonsoft.Json;
using NetMQ;
using NetMQ.Sockets;
using Renci.SshNet;
using rLoop_Ground_Station.Pod_State.Nodes;
using rLoop_Ground_Station.Pod_State;

namespace rLoop_Ground_Station
{
    //The top class to handle data flow
    //between the ground station and the pod
    //Could make this class static
    public class rPodNetworking
    {
        //constains metadata on the various parameters from the nodes
        public nodeParameterDescription nodeParameterData;

        //The last frames received from the nodese
        //Contains one entry per nod
        public List<LatestNodeDataNode> LatestNodeData;

        //Used to shutdown the processing threads
        bool _IsRunning;

        //There might be a better way to kill the threads but this should do for now
        public bool IsRunning { set { _IsRunning = value; if (value == false) foreach (Thread t in runningThreads) t.Abort(); } get { return _IsRunning; } }

        //The running threads processing ZMQ messages
        public List<Thread> runningThreads;

        public rPodNetworking()
        {
            IsRunning = true;
            nodeParameterData = new nodeParameterDescription();
            runningThreads = new List<Thread>();
            ZMQTelemetryProcessor.NetworkClass = this;
            LatestNodeData = new List<LatestNodeDataNode>();
            rPodNodeDiscovery.FoundNewNode += new FoundNewNodeHandler(NewNodeDetected);
        }

        //Called when a new node is detected on the network
        public void NewNodeDetected(rPodNetworkNode node)
        {
            ZMQTelemetryProcessor processor = new ZMQTelemetryProcessor();
            processor.Ip = node.IP;
            Thread newThread = new Thread(processor.zmqBeginListen);
            runningThreads.Add(newThread);
            newThread.Start();
        }

        //Called every time a ZMQ telemetry message is received
        public void ProcessZMQTelemetryFrame(byte[] frame, string nodeName)
        {
            rPodI2CRX rxProcessor = new rPodI2CRX();
            List<DataParameter> parameterList = rxProcessor.ProcessFrame(frame);

            LatestNodeDataNode n;
            n = LatestNodeData.FirstOrDefault(x => x.NodeName == (nodeName));
            if (n == null)
                LatestNodeData.Add(new LatestNodeDataNode(nodeName));
            n = LatestNodeData.Last();

            foreach(DataParameter param in parameterList)
            {
                NodeDataPoint p = n.DataValues.FirstOrDefault(x => x.Index == param.Index);
                if (p == null)
                {
                    double data;
                    double.TryParse( param.Data.ToString(), out data);
                    n.DataValues.Add(new NodeDataPoint(param.Index, DateTime.Now, data));
                }
                else
                {
                    double data;
                    double.TryParse(param.Data.ToString(), out data);
                    p.Value = data;
                    p.Time = DateTime.Now;
                }
            }

            //TODO, pass each parameter to the appropriate Pod State Object
        }

        //Renames a node by changing the config file in the Pi and reloading the services
        //that depend on the name.
        //This could use some error checking or could be done by a script on the Pi instead
        //of a pseudo bash script here.
        public void changeNodeName(string host_ip, string username, string password, string newName)
        {
            using (SshClient ssh = new SshClient(host_ip, username, password))
            {
                ssh.Connect();
                ssh.RunCommand("rm /mnt/data/config/nodename");
                ssh.RunCommand("echo " + "\"" + newName + "\" > /mnt/data/config/nodename" );
                ssh.RunCommand("/etc/init.d/S55telemetry restart");
                ssh.RunCommand("/etc/init.d/S55udpBeacon restart");
                ssh.Disconnect();
            }
        }

        //Uploades a hex file to the Pi and programs it to the Teensy
        //Would be good to parse feedback from the Teensy cli loader
        //Validating the file would good too.
        //The ssh upload library is pretty unforgiving, need to parse and handle errors from it
        public void uploadFile(string host_ip, string username, string password, string localFile, string remoteFile)
        {
            using (SftpClient ssh = new SftpClient(host_ip, username, password))
            {
                ssh.Connect();
                FileStream stream = new FileStream(localFile, FileMode.Open);
                if (ssh.ListDirectory("/").FirstOrDefault(x => x.Name == "teensyTemp") == null)
                    ssh.CreateDirectory("/teensyTemp");
                ssh.ChangeDirectory("/teensyTemp");
                ssh.UploadFile(stream, remoteFile);
                ssh.Disconnect();
                stream.Close();
            }

            using (SshClient ssh = new SshClient(host_ip, username, password))
            {
                ssh.Connect();
                ssh.RunCommand("prog_teensy " + "\"/teensyTemp/" + remoteFile + "\"");
                ssh.RunCommand("rm " + "\"/teensyTemp/" + remoteFile + "\"");
                ssh.Disconnect();
            }
        }

        //Allows interaction with teensy control parameters
        //Can be used from the pod state classes or more
        //directly from the gui during developement
        public void setParameters(List<Tuple<int,object>> paramList)
        {
            //TODO: Either SSH with i2cSetParameter or write
            //another module on the pi to listen
            //for parameter change requests
        }

    }

    //The basic structure of the telemetry ZMQ frames
    public class TelemetryJSONFrame
    {
        [JsonProperty("node")]
        public string Node;

        [JsonProperty("mts")]
        public string Time;

        [JsonProperty("data")]
        public List<double> Data;
    }

    //One of these is created for each node connection
    //since ZMQ likes to live in it's own threads
    class ZMQTelemetryProcessor
    {
        public string Ip;
        public static List<SubscriberSocket> subscribers;
        public static rPodNetworking NetworkClass;

        public void zmqBeginListen(object data)
        {
            if (subscribers == null)
                subscribers = new List<SubscriberSocket>();

            SubscriberSocket subscriber = new SubscriberSocket();
            subscribers.Add(subscriber);

            string connect_to = "tcp://" + Ip + ":3000";
            Console.WriteLine("I: Connecting to {0}...", connect_to);
            subscriber.Connect(connect_to);

            subscriber.Subscribe("telemetry");

            subscribers.Add(subscriber);

            var poller = new NetMQPoller { subscriber };

            subscriber.ReceiveReady += (s, a) =>
            {
                byte[] reply = a.Socket.ReceiveFrameBytes();

                string nodeName = "";
                int i = 10;
                while (reply[i] != 0xd5)
                {
                    nodeName += (char)reply[i];
                    i++;
                }
                NetworkClass.ProcessZMQTelemetryFrame(reply.Skip(i).ToArray(),nodeName);
            };
            poller.Run();
        }
    }

    public class LatestNodeDataNode
    {
        public string NodeName;
        public List<NodeDataPoint> DataValues;
        public LatestNodeDataNode(string nodeName)
        {
            NodeName = nodeName;
            DataValues = new List<NodeDataPoint>();
        }
    }

    public class NodeDataPoint
    {
        public double Index;
        public DateTime Time;
        public double Value; //Not ideal but double should work for most things.
        public NodeDataPoint(double index, DateTime time, double value)
        {
            Index = index;
            Time = time;
            Value = value;
        }
    }

    public class nodeParameterDescription
    {
        public List<nodeTypes> NodeTypes;
        public nodeParameterDescription()
        {
            NodeTypes = new List<nodeTypes>();
            using (StreamReader r = new StreamReader("parameters.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    nodeTypes t = new nodeTypes();
                    NodeTypes.Add(t);
                    t.Name = item.Name;
                    foreach (var item2 in item.Value)
                    {
                        NodeParameterDefinition pd = new NodeParameterDefinition();
                        t.ParameterDefs.Add(pd); 
                        pd.Index = item2[0];
                        if(item2[1] != null)
                            pd.Min = item2[1];
                        if (item2[2] != null)
                            pd.Max = item2[2];
                        pd.Units = item2[3];
                        pd.Description = item2[4];
                    }
                }
                
            }
        }
    }

    public class nodeTypes
    {
        public string Name;
        public List<NodeParameterDefinition> ParameterDefs;
        public nodeTypes()
        {
            ParameterDefs = new List<NodeParameterDefinition>();
        }
    }
    public class NodeParameterDefinition
    {
        public int Index;
        public float Min;
        public float Max;
        public string Units;
        public string Description;
    }
}
