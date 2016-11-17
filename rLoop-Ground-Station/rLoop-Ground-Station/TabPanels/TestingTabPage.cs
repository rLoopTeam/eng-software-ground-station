using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rLoop_Ground_Station.TabPanels
{
    public partial class TestingTabPage : UserControl
    {
        public TestingTabPage()
        {
            InitializeComponent();
        }

        private void TESTTabTimer_Tick(object sender, EventArgs e)
        {
            if (rPodPodState.FlightControlUnitNode == null)
                return;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to stop the FCU?",
          "Pod Stop?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes: break;
                case DialogResult.No: return; break;
            }


            if (!rPodPodState.FlightControlUnitNode.SendPodStop())
                MessageBox.Show("Unable to communicate with FCU.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to safe the pod?",
                      "Pod Safe?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes: break;
                case DialogResult.No: return;  break;
            }

            bool PowerAResult;
            bool PowerBResult;

            DateTime started = DateTime.Now;
            do
            {
                PowerAResult = rPodPodState.PowerNodeA.SendPodSafe();
                PowerBResult = rPodPodState.PowerNodeB.SendPodSafe();
            } while ((Math.Abs((rPodPodState.PowerNodeA.LastHeard - DateTime.Now).TotalMilliseconds) < 1000 || Math.Abs((rPodPodState.PowerNodeB.LastHeard - DateTime.Now).TotalMilliseconds) < 1000) && (DateTime.Now - started).TotalMilliseconds < 2000);

            if (!PowerAResult)
                MessageBox.Show("Unable to communicate with Power Node A.");

            if (!PowerBResult)
                MessageBox.Show("Unable to communicate with Power Node B.");

            if (Math.Abs((rPodPodState.PowerNodeA.LastHeard - DateTime.Now).TotalMilliseconds) < 2000)
                MessageBox.Show("Power Node A was not shut down.");

            if (Math.Abs((rPodPodState.PowerNodeB.LastHeard - DateTime.Now).TotalMilliseconds) < 2000)
                MessageBox.Show("Power Node B was not shut down.");
        }

        private void trackBrakePos_Scroll(object sender, EventArgs e)
        {
           // lblBrakePosSP.Text = ((float)trackBrakePos.Value / 10).ToString() + " mm";
        }

        private void btnSendBrakePos_Click(object sender, EventArgs e)
        {
           // rPodPodState.FlightControlUnitNode.setIBeamDistance((float)trackBrakePos.Value / 10);
        }
    }
}
