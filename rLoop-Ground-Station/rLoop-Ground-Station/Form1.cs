using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Windows.Documents;

namespace rLoop_Ground_Station
{
    public partial class Form1 : Form
    {
        // Grid settings
        //------------------------------------------------
        int GRID_ROWS = 18;
        int GRID_CELL_COLUMNS = 6;
        //------------------------------------------------

        // strings for displaying the battery grid values
        String stateCellNegativeTemperature;
        String stateCellPositiveTemperature;
        String stateRowDischarge;

        rPodNetworking net;
        Label[,] lblCellRowsTempPositiveTabs;
        Label[,] lblCellRowsTempNegativeTabs;
        Label[] lblCellRowsTransistors;
        Label[] lblCellRowsVoltages;

        public Form1()
        {
            InitializeComponent();
            net = new rPodNetworking();

            // arrays to store all the labels in the grid
            lblCellRowsTempPositiveTabs = new Label[18, 6];
            lblCellRowsTempNegativeTabs = new Label[18, 6];
            lblCellRowsTransistors = new Label[18];
            lblCellRowsVoltages = new Label[18];
            if (!rPodNodeDiscovery.beginUDPListen())
            {
                MessageBox.Show("There was an error listening to the network for available nodes.");
            }

            generateBatteryTable();
        }

        private void generateBatteryTable()
        {
            FlowLayoutPanel headerRow = new   FlowLayoutPanel();
            headerRow.AutoSize = true;
            headerRow.FlowDirection = FlowDirection.LeftToRight;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            FlowLayoutPanel row;
            Label label;
            bool isOdd;

            // create the header labels
            for (int x = 0; x < GRID_CELL_COLUMNS; x++)
            {
                isOdd = (x % 2) == 1;
                // add top labels
                Label labelTop = new Label();
                labelTop.Text = alphabet[x].ToString();
                labelTop.Margin = new Padding(40, 0, 23, 0);
                labelTop.Location = new System.Drawing.Point( 50 * x , 15);
                labelTop.Size = new System.Drawing.Size(30, 25);
                labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelTop.ForeColor = System.Drawing.SystemColors.ButtonFace;
                labelTop.Name = "header" + x;
                headerRow.Controls.Add(labelTop);
            }
            this.flowLayoutPanel1.Controls.Add(headerRow);

            // rows
            for (int y = 0; y < GRID_ROWS; y++)
            {                
                // create row
                row = new FlowLayoutPanel();
                //row.BorderStyle = BorderStyle.Fixed3D;
                row.AutoSize = true;
                row.FlowDirection = FlowDirection.LeftToRight;

                // We multiply by two because the interface shows two temperature values per column
                for (int x = 0; x < 2 * GRID_CELL_COLUMNS; x++) 
                {
                    isOdd = (x % 2) == 1;

                    // create label and append to row
                    label = new Label();
                    label.Margin = new Padding(0, 0, 15 * (isOdd?0:1), 0); // add spacing between odd columns. Could be replaced with a better component
                    label.Text = "";
                    label.Location = new System.Drawing.Point( 30 * x, 15 * y );
                    label.Size = new System.Drawing.Size(40, 20);
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = System.Drawing.SystemColors.ButtonFace;
                    label.Name = "cell" + x + y;

                    // store label to array (temperature negative/positive, voltage, transistor )
                    if (!isOdd)
                    {
                        int ix = ((x / 2) - 1) + 1;
                        lblCellRowsTempNegativeTabs[y, ix] = label;
                    }
                    else
                    {
                        int ix = (int)(((x / 2) - 1) + 1.5);
                        lblCellRowsTempPositiveTabs[y, ix] = label;
                    }

                    // add to interface
                    row.Controls.Add(label);

                    if (x == 11)
                    {
                        int transistorValue = 0;
                        Label transistorLabel = new Label();
                        transistorLabel.Text = transistorValue.ToString();
                        transistorLabel.Location = new System.Drawing.Point(110 * x, 135 * y);
                        transistorLabel.Size = new System.Drawing.Size(65, 15);
                        transistorLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
                        transistorLabel.Name = "transistor" + x + y;
                        lblCellRowsTransistors[y] = transistorLabel;
                        row.Controls.Add(transistorLabel);


                        int rowVoltageValue = 0;
                        Label rowVoltageLabel = new Label();
                        rowVoltageLabel.Text = rowVoltageValue + "V";
                        rowVoltageLabel.Location = new System.Drawing.Point(110 * x, 160 * y);
                        rowVoltageLabel.Size = new System.Drawing.Size(65, 15);
                        rowVoltageLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
                        rowVoltageLabel.Name = "rowVoltage" + x + y;
                        lblCellRowsVoltages[y] = rowVoltageLabel;
                        row.Controls.Add(rowVoltageLabel);
                    }
                }
                this.flowLayoutPanel1.Controls.Add(row);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a node from the list.");
                return;
            }
            if(!File.Exists(openFileDialog1.FileName))
            {
                MessageBox.Show("Choose a valid file.");
                return;
            }
            net.uploadFile(label2.Text, "root", "MoreCowbell", openFileDialog1.FileName, openFileDialog1.SafeFileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<rPodNetworkNode> toRemove = new List<rPodNetworkNode>();
            if (rPodNodeDiscovery.ActiveNodes != null)
            {
                foreach (rPodNetworkNode i in rPodNodeDiscovery.ActiveNodes)
                {
                    if (!listBox1.Items.Contains(i))
                        listBox1.Items.Add(i);
                }
                foreach(rPodNetworkNode i in listBox1.Items )
                {
                    if (!rPodNodeDiscovery.ActiveNodes.Contains(i))
                        toRemove.Add(i);
                }
            }
            foreach (rPodNetworkNode i in toRemove)
                listBox1.Items.Remove(i);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                label2.Text = (listBox1.Items[listBox1.SelectedIndex] as rPodNetworkNode).IP;
                dataGridView1.Rows.Clear();
            }
        }

        private void UpdateDGVTimer_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                dataGridView1.Rows.Clear();
                return;
            }
            string node = listBox1.Items[listBox1.SelectedIndex].ToString();
            LatestNodeDataNode nodeData = net.LatestNodeData.FirstOrDefault(x => (x.NodeName.Substring(0,1).ToUpper() + x.NodeName.Substring(1) + " Node") == node);
            if (nodeData != null)
            {
                foreach(NodeDataPoint p in nodeData.DataValues)
                {
                    bool found = false;
                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == p.Index.ToString())
                        {
                            row.Cells[1].Value = p.Value.ToString();
                            found = true;
                            break;
                        }
                    }
                    if(!found)
                    {
                        int row = dataGridView1.Rows.Add();
                        dataGridView1.Rows[row].Cells[0].Value = p.Index.ToString();
                        dataGridView1.Rows[row].Cells[1].Value = p.Value;

                        nodeTypes t = net.nodeParameterData.NodeTypes.FirstOrDefault(x => node == (x.Name.Substring(0, 1).ToUpper() + x.Name.Substring(1) + " Node"));
                        if(t != null)
                        {
                            NodeParameterDefinition def = t.ParameterDefs.FirstOrDefault(x => x.Index == p.Index);
                            if (def != null)
                            {
                                dataGridView1.Rows[row].Cells[2].Value = def.Units;
                                dataGridView1.Rows[row].Cells[3].Value = def.Description;
                            }

                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            podStateControl2.HE1Height = trackBar1.Value;
            podStateControl2.HE2Height = trackBar1.Value;
            podStateControl2.HE3Height = trackBar1.Value;
            podStateControl2.HE4Height = trackBar1.Value;
            podStateControl2.HE5Height = trackBar1.Value;
            podStateControl2.HE6Height = trackBar1.Value;
            podStateControl2.HE7Height = trackBar1.Value;
            podStateControl2.HE8Height = trackBar1.Value;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            podStateControl2.HE1Percent = trackBar4.Value / 100.0;
            podStateControl2.HE2Percent = trackBar4.Value / 100.0;
            podStateControl2.HE3Percent = trackBar4.Value / 100.0;
            podStateControl2.HE4Percent = trackBar4.Value / 100.0;
            podStateControl2.HE5Percent = trackBar4.Value / 100.0;
            podStateControl2.HE6Percent = trackBar4.Value / 100.0;
            podStateControl2.HE7Percent = trackBar4.Value / 100.0;
            podStateControl2.HE8Percent = trackBar4.Value / 100.0;

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            podStateControl2.HE1RPM = trackBar2.Value;
            podStateControl2.HE2RPM = trackBar2.Value;
            podStateControl2.HE3RPM = trackBar2.Value;
            podStateControl2.HE4RPM = trackBar2.Value;
            podStateControl2.HE5RPM = trackBar2.Value;
            podStateControl2.HE6RPM = trackBar2.Value;
            podStateControl2.HE7RPM = trackBar2.Value;
            podStateControl2.HE8RPM = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            podStateControl2.HE1Power = trackBar3.Value;
            podStateControl2.HE2Power = trackBar3.Value;
            podStateControl2.HE3Power = trackBar3.Value;
            podStateControl2.HE4Power = trackBar3.Value;
            podStateControl2.HE5Power = trackBar3.Value;
            podStateControl2.HE6Power = trackBar3.Value;
            podStateControl2.HE7Power = trackBar3.Value;
            podStateControl2.HE8Power = trackBar3.Value;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            double newP = (podStateControl2.HE1Percent + .01) ;
            if(newP > 1)
                newP = 0;
            podStateControl2.HE1Percent = newP;
            podStateControl2.HE2Percent = newP;
            podStateControl2.HE3Percent = newP;
            podStateControl2.HE4Percent = newP;
            podStateControl2.HE5Percent = newP;
            podStateControl2.HE6Percent = newP;
            podStateControl2.HE7Percent = newP;
            podStateControl2.HE8Percent = newP;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            rPodSpeedometer1.currentSpeed = trackBar5.Value;
            rPodSpeedometer1.Refresh();
        }

        private void rLoopTabControl_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            net.IsRunning = false;
            rPodNodeDiscovery.IsRunning = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            try {
                if (Form1.ActiveForm != null)
                    customTabControl1.Size = new Size(Form1.ActiveForm.Width - 28, Form1.ActiveForm.Height - 50);
                customTabControl1.Location = new Point(5, 5);
            }
            catch (Exception formResizeException)
            {
                Console.Write(formResizeException.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a node from the list.");
                return;
            }
            net.changeNodeName(label2.Text, "root", "MoreCowbell", textBox1.Text);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rPodBatteryIndicator1_Load(object sender, EventArgs e)
        {

        }

        private void sendTestData_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a node from the list.");
                return;
            }

            List<DataParameter> paramsToSend = new List<DataParameter>();
            UInt16 index;
            object value = null;
            UInt16.TryParse(testDataIndexTxt.Text, out index);
            switch(testDataType.SelectedIndex)
            {
                case 0:  sbyte sbyteVal;
                    if(!sbyte.TryParse(testDataToSendTxt.Text, out sbyteVal))
                        goto error;
                    value = sbyteVal;
                    break;
                case 1: byte byteVal;
                    if (!byte.TryParse(testDataToSendTxt.Text, out byteVal))
                        goto error;
                    value = byteVal;
                    break;
                case 2: Int16 int16Val;
                    if (!Int16.TryParse(testDataToSendTxt.Text, out int16Val))
                        goto error;
                    value = int16Val;
                    break;
                case 3: UInt16 uint16Val;
                    if (!UInt16.TryParse(testDataToSendTxt.Text, out uint16Val))
                        goto error;
                    value = uint16Val;
                    break;
                case 4: Int32 Int32Val;
                    if (!Int32.TryParse(testDataToSendTxt.Text, out Int32Val))
                        goto error;
                    value = Int32Val;
                    break;
                case 5: UInt32 UInt32Val;
                    if (!UInt32.TryParse(testDataToSendTxt.Text, out UInt32Val))
                        goto error;
                    value = UInt32Val;
                    break;
                case 6: Int64 Int64Val;
                    if (!Int64.TryParse(testDataToSendTxt.Text, out Int64Val))
                        goto error;
                    value = Int64Val;
                    break;
                case 7: UInt64 UInt64Val;
                    if (!UInt64.TryParse(testDataToSendTxt.Text, out UInt64Val))
                        goto error;
                    value = UInt64Val;
                    break;
                case 8: float floatVal;
                    if (!float.TryParse(testDataToSendTxt.Text, out floatVal))
                        goto error;
                    value = floatVal;
                    break;
                case 9: double doubleVal;
                    if (!double.TryParse(testDataToSendTxt.Text, out doubleVal))
                        goto error;
                    value = doubleVal;
                    break;
            }

            DataParameter p = new DataParameter();
            p.Index = index;
            p.Data = value;

            paramsToSend.Add(p);

            if (!net.setParameters(listBox1.SelectedItem.ToString(), paramsToSend))
                MessageBox.Show("There was an error sending the message.");

            return;

            error:
                MessageBox.Show("Coud not parse one of the fields.");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BatteryPackAStatusTab_Tick(object sender, EventArgs e)
        {
            if (rPodPodState.PowerNodeA == null)
                return;

            BrakesAPackVoltage.Text = "Voltage: " + rPodPodState.PowerNodeA.BatteryPackVoltage.ToString() + "V";
            BrakesAPackTemperature.Text = "Temperature: " + rPodPodState.PowerNodeA.BatteryPackTemperature.ToString() + "°C";

            float totalRowVoltage;
            for (int y = 0; y < GRID_ROWS; y++)
            {
                totalRowVoltage = 0;
                for (int x = 0; x < GRID_CELL_COLUMNS; x++)
                {
                    stateCellNegativeTemperature = rPodPodState.PowerNodeA.CellNegativeTabTemperature[y, x].ToString() + "°C";
                    stateCellPositiveTemperature = rPodPodState.PowerNodeA.CellPositiveTabTemperature[y, x].ToString() + "°C";
                    if (lblCellRowsTempNegativeTabs[y, x].Text != stateCellNegativeTemperature)
                        lblCellRowsTempNegativeTabs[y, x].Text = stateCellNegativeTemperature;

                    if (lblCellRowsTempPositiveTabs[y, x].Text != stateCellPositiveTemperature)
                        lblCellRowsTempPositiveTabs[y, x].Text = stateCellPositiveTemperature;


                    totalRowVoltage += rPodPodState.PowerNodeA.CellVoltages[y, x];
                }
                stateRowDischarge = rPodPodState.PowerNodeA.BatteryRowDischarging[y].ToString();
                if (lblCellRowsTransistors[y].Text != stateRowDischarge)
                    lblCellRowsTransistors[y].Text = stateRowDischarge;

                if (lblCellRowsVoltages[y].Text != totalRowVoltage + "V")
                    lblCellRowsVoltages[y].Text = totalRowVoltage + "V";
            }
        }
    }
}
