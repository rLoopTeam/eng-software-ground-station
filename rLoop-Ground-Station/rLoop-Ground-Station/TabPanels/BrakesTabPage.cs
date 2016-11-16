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
    public partial class BrakesTabPage : UserControl
    {
        public BrakesTabPage()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateTmr_Tick(object sender, EventArgs e)
        {
            lblLeftScrewPositionVal.Text = rPodPodState.FlightControlUnitNode.EBLeftScrewPosition.ToString("0.00") + " mm";
            lblRightScrewPositionVal.Text = rPodPodState.FlightControlUnitNode.EBRightScrewPosition.ToString("0.00") + " mm";

            if (rPodPodState.FlightControlUnitNode.EBLeftLimitSwitchExtend == 0)
                lblLeftExtendLimitVal.Text = "Open";
            else if (rPodPodState.FlightControlUnitNode.EBLeftLimitSwitchExtend == 1)
                lblLeftExtendLimitVal.Text = "Closed";
            else
                lblLeftExtendLimitVal.Text = "?";

            if (rPodPodState.FlightControlUnitNode.EBRightLimitSwitchExtend == 0)
                lblRightExtendLimitVal.Text = "Open";
            else if (rPodPodState.FlightControlUnitNode.EBRightLimitSwitchExtend == 1)
                lblRightExtendLimitVal.Text = "Closed";
            else
                lblRightExtendLimitVal.Text = "?";

            if (rPodPodState.FlightControlUnitNode.EBLeftLimitSwitchRetract == 0)
                lblLeftRetractLimitVal.Text = "Open";
            else if (rPodPodState.FlightControlUnitNode.EBLeftLimitSwitchRetract == 1)
                lblLeftRetractLimitVal.Text = "Closed";
            else
                lblLeftRetractLimitVal.Text = "?";

            if (rPodPodState.FlightControlUnitNode.EBRightLimitSwitchRetract == 0)
                lblRightRetractLimitVal.Text = "Open";
            else if (rPodPodState.FlightControlUnitNode.EBRightLimitSwitchRetract == 1)
                lblRightRetractLimitVal.Text = "Closed";
            else
                lblRightRetractLimitVal.Text = "?";

            lblLeftIBeamDistVal.Text = rPodPodState.FlightControlUnitNode.EBLeftIBeamDist.ToString("0.00") + " mm";
            lblRightIBeamDistVal.Text = rPodPodState.FlightControlUnitNode.EBRightIBeamDist.ToString("0.00") + " mm";

            lblLeftMLPADCRawVal.Text = rPodPodState.FlightControlUnitNode.EBLeftMLPADCRaw.ToString();
            lblRightMLPADCRawVal.Text = rPodPodState.FlightControlUnitNode.EBRightMLPADCRaw.ToString();

            lblLeftMLPADCRawVal.Text = rPodPodState.FlightControlUnitNode.EBLeftMLPScaled.ToString("0.00") + " mm";
            lblRightMLPADCRawVal.Text = rPodPodState.FlightControlUnitNode.EBRightMLPScaled.ToString("0.00") + " mm";
        }

        private void btnSetIBeamDist_Click(object sender, EventArgs e)
        {
            float outVal;
            if (!float.TryParse(txtIBeamDist.Text, out outVal))
            {
                MessageBox.Show("Could not parse the number you inputted.");
                return;
            }

            if (!rPodPodState.FlightControlUnitNode.setIBeamDistance(outVal))
                MessageBox.Show("There was an error sending the command.");

        }

        private void btnBrakeParameter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!");
        }
    }
}
