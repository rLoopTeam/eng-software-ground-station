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
using System.Xml;
using System.IO;

namespace DummyDataTX
{
    public partial class Form1 : Form
    {
        PublisherSocket pubSocket;
        //string PARAMETERS_XML_PATH = @"PARAMETERS.xml";
        string PARAMETERS_XML_PATH;

        public Form1()
        {

            InitializeComponent();
            PARAMETERS_XML_PATH = txtParameterPath.Text;
            testDataType.SelectedIndex = 8;
            pubSocket = new PublisherSocket("tcp://*:3000");
            populateDataGrid();
        }

        /*
        //
        // Need to move this functionality to a button or something
        //
        private void Form1_Closing(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            Console.WriteLine("Save!");
            string path = PARAMETERS_XML_PATH;
            DataSet ds = (DataSet)dataGridView1.DataSource;
            ds.WriteXml(path);
        }*/


        private void UDPTimer_Tick(object sender, EventArgs e)
        {
            String preamble = "rPod!,0,";
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
                                    IPEndPoint target = new IPEndPoint(transmitIP, 50051);
                                    byte[] data = Encoding.ASCII.GetBytes(preamble + UDPAnnounceTXT.Text + "," + DateTime.Now.ToString("MM/dd/yyyy H:m:s") + ",no");
                                    udpc.Send(data , data.Length, target);
                                    //Console.WriteLine(data);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ZMQTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("TX: ZMQ TICK");
            List<DataParameter> paramsToSend = new List<DataParameter>();
            
            // parameter grid
            if (dataGridView1 != null)
            {
                try
                {
                    //Console.WriteLine("TX: ========");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow)
                            continue;

                        object cell1Value = row.Cells[0].Value;
                        object cell2Value = row.Cells[1].Value;
                        object cell3Value = row.Cells[2].Value;

                        if (cell1Value == null || cell2Value == null || cell3Value == null)
                        {
                            Console.WriteLine("TX: Cell value is null: "+cell1Value + ", " + cell2Value + ", " + cell3Value);
                            continue;
                        }

                        string parameterIndex = cell1Value.ToString(); ;
                        string parameterValue = cell2Value.ToString();
                        string parameterType = cell3Value.ToString();
                        
                        // get index value and parse to UInt16
                        UInt16 index;
                        UInt16.TryParse(parameterIndex, out index);
                        object value = null;

                        // parse the value
                        switch (parameterType)
                        {
                            case "Int 8":
                                sbyte sbyteVal;
                                if (!sbyte.TryParse(parameterValue, out sbyteVal))
                                    goto error;
                                value = sbyteVal;
                                break;
                            case "UInt 8":
                                byte byteVal;
                                if (!byte.TryParse(parameterValue, out byteVal))
                                    goto error;
                                value = byteVal;
                                break;
                            case "Int 16":
                                Int16 int16Val;
                                if (!Int16.TryParse(parameterValue, out int16Val))
                                    goto error;
                                value = int16Val;
                                break;
                            case "UInt 16":
                                UInt16 uint16Val;
                                if (!UInt16.TryParse(parameterValue, out uint16Val))
                                    goto error;
                                value = uint16Val;
                                break;
                            case "Int 32":
                                Int32 Int32Val;
                                if (!Int32.TryParse(parameterValue, out Int32Val))
                                    goto error;
                                value = Int32Val;
                                break;
                            case "UInt 32":
                                UInt32 UInt32Val;
                                if (!UInt32.TryParse(parameterValue, out UInt32Val))
                                    goto error;
                                value = UInt32Val;
                                break;
                            case "Int 64":
                                Int64 Int64Val;
                                if (!Int64.TryParse(parameterValue, out Int64Val))
                                    goto error;
                                value = Int64Val;
                                break;
                            case "UInt 64":
                                UInt64 UInt64Val;
                                if (!UInt64.TryParse(parameterValue, out UInt64Val))
                                    goto error;
                                value = UInt64Val;
                                break;
                            case "Float":
                                float floatVal;
                                if (!float.TryParse(parameterValue, out floatVal))
                                    goto error;
                                value = floatVal;
                                break;
                            case "Double":
                                double doubleVal;
                                if (!double.TryParse(parameterValue, out doubleVal))
                                    goto error;
                                value = doubleVal;
                                break;
                            default:
                                Console.WriteLine("Type %s not supported.", parameterType);
                                goto error;
                        }
                        

                        // define new parameter object
                        DataParameter p = new DataParameter();
                        p.Index = index;
                        p.Data = value;

                        // add parameter to the list of parameters to send
                        paramsToSend.Add(p);
                        //Console.WriteLine("TX: " + index + ": " + value + "(" + parameterType + ")");

                    }
                } catch(Exception ee) {
                    Console.WriteLine("ERROR: Something wrong with data table");
                    Console.WriteLine(ee.ToString());
                }
            } else
            {
                Console.WriteLine("gridview is null");
            }

            //dataGridView1.Update();
            //dataGridView1.Refresh();

            rPodI2CTX formatter = new rPodI2CTX();

            byte[] paramData = formatter.formatTransmitParameters(paramsToSend);
            byte[] header = Encoding.ASCII.GetBytes("telemetry " + ZMQNodeTXT.Text);
            byte[] toSend = header.Concat(paramData).ToArray();

            //Console.WriteLine(paramsToSend);
            pubSocket.TrySendFrame(TimeSpan.FromSeconds(1), toSend);

            error:
                return;
        }

        private void populateDataGrid()
        {

            dataGridView1.AutoGenerateColumns = false;

            if (File.Exists(PARAMETERS_XML_PATH))
                ParametersDataSet.ReadXml(PARAMETERS_XML_PATH);
            else
                Console.WriteLine("Cannot open XML. %s not found.", PARAMETERS_XML_PATH);

            try
            {
                dataGridView1.DataSource = ParametersDataSet;
                dataGridView1.DataMember = "parameter";
            }
            catch
            {
                Console.WriteLine("Error in populateDataGrid");
            }

        }

        private void testDataType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtParameterPath_Leave(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            //populateDataGrid();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
