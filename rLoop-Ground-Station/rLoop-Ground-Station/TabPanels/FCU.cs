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
    public partial class FCU : UserControl
    {
        public FCU()
        {
            InitializeComponent();
        }

        private void FCU_Load(object sender, EventArgs e)
        {

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            lblHeight1Val.Text = rPodPodState.FlightControlUnitNode.HDS1Value.ToString("0.00") + " mm";
            lblHeight2Val.Text = rPodPodState.FlightControlUnitNode.HDS2Value.ToString("0.00") + " mm";
            lblHeight3Val.Text = rPodPodState.FlightControlUnitNode.HDS3Value.ToString("0.00") + " mm";
            lblHeight4Val.Text = rPodPodState.FlightControlUnitNode.HDS4Value.ToString("0.00") + " mm";
            lblIBeam1Val.Text = rPodPodState.FlightControlUnitNode.IBDS1Value.ToString("0.00") + " mm";
            lblIBeam2Val.Text = rPodPodState.FlightControlUnitNode.IBDS2Value.ToString("0.00") + " mm";

            if (rPodPodState.FlightControlUnitNode.PusherSwitchA == 0)
                lblPusherSwitchAVal.Text = "Open";
            else if (rPodPodState.FlightControlUnitNode.PusherSwitchA == 1)
                lblPusherSwitchAVal.Text = "Closed";
            else
                lblPusherSwitchAVal.Text = "?";

            if (rPodPodState.FlightControlUnitNode.PusherSwitchB == 0)
                lblPusherSwitchBVal.Text = "Open";
            else if (rPodPodState.FlightControlUnitNode.PusherSwitchB == 1)
                lblPusherSwitchBVal.Text = "Closed";
            else
                lblPusherSwitchBVal.Text = "?";

            switch (rPodPodState.FlightControlUnitNode.PusherState)
            {
                case 0: lblPusherStateVal.Text = "Idle"; break;
                case 1: lblPusherStateVal.Text = "Sample Switches"; break;
                case 2: lblPusherStateVal.Text = "Wait SW Stable"; break;
                case 3: lblPusherStateVal.Text = "Determine Pusher State"; break;
                case 4: lblPusherStateVal.Text = "Check Disagree"; break;
                default: lblPusherStateVal.Text = "Unknown"; break;
            }

            lblAccel1XVal.Text = rPodPodState.FlightControlUnitNode.Accel1X.ToString("0.00");
            lblAccel1YVal.Text = rPodPodState.FlightControlUnitNode.Accel1Y.ToString("0.00");
            lblAccel1ZVal.Text = rPodPodState.FlightControlUnitNode.Accel1Z.ToString("0.00");
        }
    }
}


