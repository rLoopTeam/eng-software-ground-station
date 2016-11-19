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
using NetMQ;
using NetMQ.Sockets;
using Microsoft.VisualBasic.FileIO;
using System.Net.NetworkInformation;


/*
 * This class is responsible for listening for the udp beacon
 * from the Pi's and adding them to the list of available noedes.
 * It also supports adding nodes manually if need be or working across
 * VPN or router boundaries during development.
 * 
 */


namespace rLoop_Ground_Station
{
    public delegate void FoundNewNodeHandler(rPodNetworkNode node);

    public static class rPodNodeDiscovery
    {
        public static List<rPodNetworkNode> ActiveNodes;
        public static bool IsRunning { get { return _IsRunning; } set { _IsRunning = value; if (value == false && s != null) s.u.Close(); } }
        static bool _IsRunning = true;
        static UdpState s;
        public static bool Paused = false;
        public static event FoundNewNodeHandler FoundNewNode;
        static UdpClient u;

        static rPodNodeDiscovery()
        {

        }

        public static bool beginUDPListen()
        {
            IPEndPoint e = new IPEndPoint(IPAddress.Any, 50051);
            u = new UdpClient(e);
            u.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            try
            {
                u.JoinMulticastGroup(IPAddress.Parse("239.3.14.159"));
            }
            catch (SocketException se)
            {
                Console.WriteLine("Socket error listening for nodes {0}", se.Message);
                return false;
            }

            s = new UdpState();
            s.e = e;
            s.u = u;

            Console.WriteLine("listening for messages");
            if (IsRunning)
                u.BeginReceive(new AsyncCallback(ReceiveCallback), s);

            return true;
        }

        public static void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)((UdpState)(ar.AsyncState)).u;
            IPEndPoint e = (IPEndPoint)((UdpState)(ar.AsyncState)).e;

            if(Paused)
            {
                if (IsRunning)
                    u.BeginReceive(new AsyncCallback(ReceiveCallback), ((UdpState)(ar.AsyncState)));
                return;
            }

            Byte[] receiveBytes;

            try
            {
                receiveBytes = u.EndReceive(ar, ref e);
            }
            catch (ObjectDisposedException ex)
            {
                return;
            }

            string receiveString = Encoding.ASCII.GetString(receiveBytes);

            Console.WriteLine("Received: {0}\n", receiveString);

            string[] tokens = receiveString.Split(',');
            if (tokens.Length == 5)
            {
                if (tokens[0] == "rPod!")
                {
                    int id = int.Parse(tokens[1]);
                    DateTime PiTime = DateTime.Parse(tokens[3]);
                    bool logging = false;
                    if (tokens[4] == "yes")
                        logging = true;
                    rPodNetworkNode n = new rPodNetworkNode(tokens[2], e.Address.ToString(), false, logging, PiTime);
                    n.NodeAnnounceSeen(logging, PiTime);

                    if (ActiveNodes == null)
                        ActiveNodes = new List<rPodNetworkNode>();

                    if (ActiveNodes.Contains(n) == false)
                    {
                        ActiveNodes.Add(n);
                        if(FoundNewNode != null)
                            FoundNewNode(n);
                    }
                    else
                    {
                        ActiveNodes.FirstOrDefault(x => x.Equals(n)).NodeAnnounceSeen(logging,PiTime);
                    }
                }
            }
            if (IsRunning)
                u.BeginReceive(new AsyncCallback(ReceiveCallback), ((UdpState)(ar.AsyncState)));
        }
    }

    class UdpState
    {
        public IPEndPoint e;
        public UdpClient u;
    }

    public class rPodNetworkNode : IEquatable<rPodNetworkNode>
    {
        private string _nodeName;
        public string NodeNamePretty { get { return this.ToString(); } } //Basically short + " Node"
        public string NodeNameShort { get { return _nodeName; } set { _nodeName = value; } }//As read from the Pi
        public string IP;
        public DateTime AnnounceLastSeen;
        public DateTime ZMQLastSeen;
        public bool ManuallyAdded;
        public ZMQTelemetryProcessor TelemetryProcessor;
        public RequestSocket RequestSocket;
        public bool IsDataLogging;
        public DateTime NodeTime;

        public void NodeAnnounceSeen(bool isLogging, DateTime nodeTime)
        {
            IsDataLogging = isLogging;
            NodeTime = nodeTime;
            AnnounceLastSeen = DateTime.Now;
            if ((nodeTime - DateTime.Now).TotalMinutes > 5 || (nodeTime - DateTime.Now).TotalMinutes < -5)
                rPodNetworking.setNodeTime(IP, "root", "MoreCowbell");
        }

        public void NodeZMQSeen()
        {
            ZMQLastSeen = DateTime.Now;
        }

        public bool NodeAnnounceIsAlive()
        {
            if ((DateTime.Now - AnnounceLastSeen) > (new TimeSpan(0, 0, 10)))
                return false;
            else
                return true;
        }

        public bool NodeZMQIsAlive()
        {
            if ((DateTime.Now - ZMQLastSeen) > (new TimeSpan(0, 0, 1)))
                return false;
            else
                return true;
        }

        public rPodNetworkNode(string name, string ip, bool manual, bool isDataLogging, DateTime nodeTime)
        {
            _nodeName = name;
            IP = ip;
            ManuallyAdded = manual;
            IsDataLogging = isDataLogging;
            NodeTime = nodeTime;
        }

        public override string ToString()
        {
            return _nodeName.Substring(0, 1).ToUpper() + _nodeName.Substring(1) + " Node";
        }
        public bool Equals(rPodNetworkNode n)
        {
            if (n.IP == IP && n._nodeName == _nodeName)
                return true;
            else
                return false;
        }
    }
}
