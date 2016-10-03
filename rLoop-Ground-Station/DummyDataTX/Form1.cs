using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using rLoop_Ground_Station;
using NetMQ;
using NetMQ.Sockets;

namespace DummyDataTX
{
    public partial class Form1 : Form
    {
        PublisherSocket pubSocket;
        public Form1()
        {
            InitializeComponent();
            testDataType.SelectedIndex = 8;
            pubSocket = new PublisherSocket("tcp://*:3000");
        }

        private void UDPTimer_Tick(object sender, EventArgs e)
        {
            String preamble = "rPod! ";
            //Send UDP Announce on every interface on the system
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up && ni.SupportsMulticast && ni.GetIPProperties().GetIPv4Properties() != null)
                {
                    int id = ni.GetIPProperties().GetIPv4Properties().Index;
                    if (NetworkInterface.LoopbackInterfaceIndex != id)
                    {
                        foreach (UnicastIPAddressInformation uip in ni.GetIPProperties().UnicastAddresses)
                        {
                            if (uip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                IPEndPoint local = new IPEndPoint(uip.Address.Address, 0);
                                UdpClient udpc = new UdpClient(local);
                                udpc.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
                                udpc.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontRoute, 1);
                                
                                IPAddress transmitIP;
                                if (IPAddress.TryParse("239.3.14.159", out transmitIP))
                                {
                                    IPEndPoint target = new IPEndPoint(transmitIP, 54545);
                                    byte[] data = Encoding.ASCII.GetBytes(preamble + UDPAnnounceTXT.Text);
                                    udpc.Send(data , data.Length, target);
                                    Console.WriteLine(data);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ZMQTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("ZMQ TICK");
            List<DataParameter> paramsToSend = new List<DataParameter>();
            UInt16 index;
            object value = null;
            UInt16.TryParse(testDataIndexTxt.Text, out index);
            Console.WriteLine(testDataIndexTxt);
            switch (testDataType.SelectedIndex)
            {
                case 0:
                    sbyte sbyteVal;
                    if (!sbyte.TryParse(testDataToSendTxt.Text, out sbyteVal))
                        goto error;
                    value = sbyteVal;
                    break;
                case 1:
                    byte byteVal;
                    if (!byte.TryParse(testDataToSendTxt.Text, out byteVal))
                        goto error;
                    value = byteVal;
                    break;
                case 2:
                    Int16 int16Val;
                    if (!Int16.TryParse(testDataToSendTxt.Text, out int16Val))
                        goto error;
                    value = int16Val;
                    break;
                case 3:
                    UInt16 uint16Val;
                    if (!UInt16.TryParse(testDataToSendTxt.Text, out uint16Val))
                        goto error;
                    value = uint16Val;
                    break;
                case 4:
                    Int32 Int32Val;
                    if (!Int32.TryParse(testDataToSendTxt.Text, out Int32Val))
                        goto error;
                    value = Int32Val;
                    break;
                case 5:
                    UInt32 UInt32Val;
                    if (!UInt32.TryParse(testDataToSendTxt.Text, out UInt32Val))
                        goto error;
                    value = UInt32Val;
                    break;
                case 6:
                    Int64 Int64Val;
                    if (!Int64.TryParse(testDataToSendTxt.Text, out Int64Val))
                        goto error;
                    value = Int64Val;
                    break;
                case 7:
                    UInt64 UInt64Val;
                    if (!UInt64.TryParse(testDataToSendTxt.Text, out UInt64Val))
                        goto error;
                    value = UInt64Val;
                    break;
                case 8:
                    float floatVal;
                    if (!float.TryParse(testDataToSendTxt.Text, out floatVal))
                        goto error;
                    value = floatVal;
                    break;
                case 9:
                    double doubleVal;
                    if (!double.TryParse(testDataToSendTxt.Text, out doubleVal))
                        goto error;
                    value = doubleVal;
                    break;

            }
            DataParameter p = new DataParameter();
            p.Index = index;
            p.Data = value;
            Console.WriteLine(p);

            paramsToSend.Add(p);

            rPodI2CTX formatter = new rPodI2CTX();

            byte[] paramData = formatter.formatTransmitParameters(paramsToSend);
            byte[] header = Encoding.ASCII.GetBytes("telemetry " + ZMQNodeTXT.Text);
            byte[] toSend = header.Concat(paramData).ToArray();

            Console.WriteLine(paramsToSend);
            pubSocket.TrySendFrame(TimeSpan.FromSeconds(1), toSend);

        error:
                return;
        }

        private void testDataType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
