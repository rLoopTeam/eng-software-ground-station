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


namespace rLoop_Ground_Station
{
    public partial class Form1 : Form
    {
        rPodNetworking net;
        public Form1()
        {
            InitializeComponent();
            net = new rPodNetworking();
            net.beginUDPListen();
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
            net.uploadFile(label2.Text, "root", "MoreCowbell", openFileDialog1.FileName, openFileDialog1.SafeFileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (nodeItem i in net.activeNodes)
            {
                if (!listBox1.Items.Contains(i))
                    listBox1.Items.Add(i);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = (listBox1.Items[listBox1.SelectedIndex] as nodeItem).ip;
        }

        private void UpdateDGVTimer_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
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
            rLoopTabControl.Size = new Size(Form1.ActiveForm.Width-28, Form1.ActiveForm.Height-50);
            rLoopTabControl.Location = new Point(5, 5);
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            rPodSpeedometer1.currentSpeed = trackBar5.Value;
            rPodSpeedometer1.Refresh();
        }

        private void rLoopTabControl_MouseDown(object sender, MouseEventArgs e)
        {

        }

    }
}
