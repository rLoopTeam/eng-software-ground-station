using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
    }


}
