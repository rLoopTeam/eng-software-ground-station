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

            // these are the actual labels that need to be updated
            lblCGHeight.Text = rPodPodState.FlightControlUnitNode.CGHeight + "m";
            lblXCG.Text = rPodPodState.FlightControlUnitNode.XCG + "m";
            lblYCG.Text = rPodPodState.FlightControlUnitNode.YCG + "m";
            lblPitch.Text = rPodPodState.FlightControlUnitNode.Pitch + "°";
            lblYaw.Text = rPodPodState.FlightControlUnitNode.Yaw + "°";
            lblRoll.Text = rPodPodState.FlightControlUnitNode.Roll + "°";
            lblAcceleration.Text = rPodPodState.FlightControlUnitNode.Acceleration + "m/s²";
            lblSpeed.Text = rPodPodState.FlightControlUnitNode.Speed + "m/s";

            // update Brake lables
            lblEBLeftLimitSwitch.Text = rPodPodState.FlightControlUnitNode.EBLeftLimitSwitch.ToString();
            lblEBRightLimitSwitch.Text = rPodPodState.FlightControlUnitNode.EBRightLimitSwitch.ToString();
            lblEBLeftMLP.Text = rPodPodState.FlightControlUnitNode.EBLeftMLP + "m";
            lblEBRightMLP.Text = rPodPodState.FlightControlUnitNode.EBRightMLP + "m";
            lblEBLeftDistanceBeam.Text = rPodPodState.FlightControlUnitNode.EBLeftDistance + "m";
            lblEBRightDistanceBeam.Text = rPodPodState.FlightControlUnitNode.EBRightDistance + "m";

            // update distance sensor labels
            lblHDS1Value.Text = rPodPodState.FlightControlUnitNode.HDS1Value + "m";
            lblHDS2Value.Text = rPodPodState.FlightControlUnitNode.HDS2Value + "m";
            lblHDS3Value.Text = rPodPodState.FlightControlUnitNode.HDS3Value + "m";
            lblHDS4Value.Text = rPodPodState.FlightControlUnitNode.HDS4Value + "m";
            lblIBDS1Value.Text = rPodPodState.FlightControlUnitNode.IBDS1Value + "m";
            lblIBDS2Value.Text = rPodPodState.FlightControlUnitNode.IBDS2Value + "m";

            if (rPodPodState.LandingGearUnitNode == null)
                return;

            // update LCU lables
            lblLMLimitSwitch1.Text = rPodPodState.LandingGearUnitNode.LM1LimitSwitch.ToString();
            lblLMLimitSwitch2.Text = rPodPodState.LandingGearUnitNode.LM2LimitSwitch.ToString();
            lblLMForwardLimitSwitch1.Text = rPodPodState.LandingGearUnitNode.LMForward1LimitSwitch.ToString();
            lblLMForwardLimitSwitch2.Text = rPodPodState.LandingGearUnitNode.LMForward2LimitSwitch.ToString();
            lblFT1MLP.Text = rPodPodState.LandingGearUnitNode.LMAft1MLP + "m";
            lblLMFT2MLP.Text = rPodPodState.LandingGearUnitNode.LMAft2MLP + "m";
            lblLMForward1MLP.Text = rPodPodState.LandingGearUnitNode.LMAForward1MLP + "m";
            lblLMForward2MLP.Text = rPodPodState.LandingGearUnitNode.LMAForward2MLP + "m";
        }
    }
}
