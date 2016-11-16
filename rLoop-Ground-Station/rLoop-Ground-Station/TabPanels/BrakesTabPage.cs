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
            

            switch (comboBrakeParameters.SelectedText)
            {
                case "Left - micro-steps per revolution": //U32
                    UInt32 UInt32Val;
                    if (!UInt32.TryParse(txtBrakeParameter.Text, out UInt32Val))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBLeftMicroStepsPerRevolution(UInt32Val);
                    }
                    break;
                case "Left - max acceleration, microns / sec^2": //S32
                    Int32 Int32Val1;
                    if (!Int32.TryParse(txtBrakeParameter.Text, out Int32Val1))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBLeftMaxAcceleration(Int32Val1);
                    }
                    break;
                case "Left - Linear Microns per revolution": //S32
                    Int32 Int32Val2;
                    if (!Int32.TryParse(txtBrakeParameter.Text, out Int32Val2))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBLeftLinearMicronsPerRevolution(Int32Val2);
                    }
                    break;
                case "Left - Steps per revolution": //U32
                    UInt32 UInt32Val3;
                    if (!UInt32.TryParse(txtBrakeParameter.Text, out UInt32Val3))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBLeftStepsPerRevolution(UInt32Val3);
                    }
                    break;
                case "Left - Max Angluar Velocity": //S32
                    Int32 Int32Val4;
                    if (!Int32.TryParse(txtBrakeParameter.Text, out Int32Val4))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBLeftMaxAngularVeolocity(Int32Val4) ;
                    }
                    break;
                case "Right - micro-steps per revolution": //U32
                    UInt32 Int32Val5;
                    if (!UInt32.TryParse(txtBrakeParameter.Text, out Int32Val5))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBRightMicroStepsPerRevolution(Int32Val5);
                    }
                    break;
                case "Right - max acceleration, microns / sec^2": //S32
                    Int32 Int32Val6;
                    if (!Int32.TryParse(txtBrakeParameter.Text, out Int32Val6))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBRightMaxAcceleration(Int32Val6);
                    }
                    break;
                case "Right - Linear Microns per revolution": //S32
                    Int32 Int32Val7;
                    if (!Int32.TryParse(txtBrakeParameter.Text, out Int32Val7))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBRightLinearMicronsPerRevolution(Int32Val7);
                    }
                    break;
                case "Right - Steps per revolution": //U32
                    UInt32 Int32Val8;
                    if (!UInt32.TryParse(txtBrakeParameter.Text, out Int32Val8))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBRightStepsPerRevolution(Int32Val8);
                    }
                    break;
                case "Right - Max Angluar Velocity": //S32
                    Int32 Int32Val9;
                    if (!Int32.TryParse(txtBrakeParameter.Text, out Int32Val9))
                    {
                        MessageBox.Show("Could not parse the value. Command not sent.");
                    }
                    else
                    {
                        rPodPodState.FlightControlUnitNode.SetEBRightMaxAngularVeolocity(Int32Val9);
                    }
                    break;
            }

        }
    }
}
