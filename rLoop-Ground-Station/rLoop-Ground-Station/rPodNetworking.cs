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

namespace rLoop_Ground_Station
{
    //Could make this class static
    public class rPodNetworking
    {
        public nodeParameterDescription nodeParameterData;
        public List<LatestNodeDataNode> LatestNodeData;
        bool _IsRunning;

        //There might be a better way to kill the threads but this should do for now
        public bool IsRunning { set { _IsRunning = value; if (value == false) foreach (Thread t in runningThreads) t.Abort(); } get { return _IsRunning; } }

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

        public void NewNodeDetected(rPodNetworkNode node)
        {
            ZMQTelemetryProcessor processor = new ZMQTelemetryProcessor();
            processor.Ip = node.IP;
            Thread newThread = new Thread(processor.zmqBeginListen);
            runningThreads.Add(newThread);
            newThread.Start();
        }

        public void ProcessZMQTelemetryFrame(string frame)
        {
            TelemetryJSONFrame frameData = JsonConvert.DeserializeObject<TelemetryJSONFrame>(frame.Substring(9));
            LatestNodeDataNode n;
            n = LatestNodeData.FirstOrDefault(x => x.NodeName == (frameData.Node));
            if (n == null)
                LatestNodeData.Add(new LatestNodeDataNode(frameData.Node));
            n = LatestNodeData.Last();

            for(int i = 0;i<frameData.Data.Count;i+=2)
            {
                NodeDataPoint p = n.DataValues.FirstOrDefault(x => x.Index == frameData.Data[i]);
                if (p == null)
                {
                    n.DataValues.Add(new NodeDataPoint(frameData.Data[i], DateTime.Now, frameData.Data[i + 1]));
                }
                else
                {
                    p.Value = frameData.Data[i + 1];
                    p.Time = DateTime.Now;
                }
            }
        }

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
    }

    public class TelemetryJSONFrame
    {
        [JsonProperty("node")]
        public string Node;

        [JsonProperty("mts")]
        public string Time;

        [JsonProperty("data")]
        public List<double> Data;
    }

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
                string reply = a.Socket.ReceiveFrameString();
                NetworkClass.ProcessZMQTelemetryFrame(reply);
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
