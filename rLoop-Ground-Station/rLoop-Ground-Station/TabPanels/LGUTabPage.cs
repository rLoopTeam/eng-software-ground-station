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
    public partial class LGUTabPage : UserControl
    {
        public LGUTabPage()
        {
            InitializeComponent();
        }

        private void LGUTabPage_Load(object sender, EventArgs e)
        {

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {

        }

        private void LMForward1Direction_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = Utility.GetCheckedRadio(groupForward1);
            int direction = 0;
            if (radioButton == null)
            {
                MessageBox.Show("Please select a direction for landing gear forward 1.");
                return;
            }
            // TODO rework this section. need to clarify what type direction should be
            if (radioButton.Text == "Up")
                direction = 1;
            else if (radioButton.Text == "Down")
                direction = 0;
            else
            {
                MessageBox.Show("Not a valid direction.");
                return;
            }
                

            if (!rPodPodState.LandingGearUnitNode.setLMForward1Direction(direction))
                    MessageBox.Show("There was an error sending the command.");
        }

        private void LMForward2Direction_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = Utility.GetCheckedRadio(groupForward2);
            int direction = 0;
            if (radioButton == null)
            {
                MessageBox.Show("Please select a direction for landing gear forward 2.");
                return;
            }
            // TODO rework this section. need to clarify what type direction should be
            if (radioButton.Text == "Up")
                direction = 1;
            else if (radioButton.Text == "Down")
                direction = 0;
            else
            {
                MessageBox.Show("Not a valid direction.");
                return;
            }


            if (!rPodPodState.LandingGearUnitNode.setLMForward2Direction(direction))
                MessageBox.Show("There was an error sending the command.");
        }

        private void LMAft1Direction_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = Utility.GetCheckedRadio(groupAft1);
            int direction = 0;
            if (radioButton == null)
            {
                MessageBox.Show("Please select a direction for landing gear aft 1.");
                return;
            }
            // TODO rework this section. need to clarify what type direction should be
            if (radioButton.Text == "Up")
                direction = 1;
            else if (radioButton.Text == "Down")
                direction = 0;
            else
            {
                MessageBox.Show("Not a valid direction.");
                return;
            }


            if (!rPodPodState.LandingGearUnitNode.setLMAft1Direction(direction))
                MessageBox.Show("There was an error sending the command.");
        }

        private void LMAft2Direction_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = Utility.GetCheckedRadio(groupAft2);
            int direction = 0;
            if (radioButton == null)
            {
                MessageBox.Show("Please select a direction for landing gear aft 2.");
                return;
            }
            // TODO rework this section. need to clarify what type direction should be
            if (radioButton.Text == "Up")
                direction = 1;
            else if (radioButton.Text == "Down")
                direction = 0;
            else
            {
                MessageBox.Show("Not a valid direction.");
                return;
            }


            if (!rPodPodState.LandingGearUnitNode.setLMAft2Direction(direction))
                MessageBox.Show("There was an error sending the command.");
        }

        private void LMForward1Speed_Click(object sender, EventArgs e)
        {
            int speed = trackBFwd1Speed.Value * 1000;

            if (speed < 0 || speed > 10000)
            {
                MessageBox.Show("Not a valid speed.");
                return;
            }

            if (!rPodPodState.LandingGearUnitNode.setLMForward1Speed(speed))
                MessageBox.Show("There was an error sending the command.");
        }

        private void LMForward2Speed_Click(object sender, EventArgs e)
        {
            int speed = trackBFwd2Speed.Value * 1000;

            if (speed < 0 || speed > 10000)
            {
                MessageBox.Show("Not a valid speed.");
                return;
            }

            if (!rPodPodState.LandingGearUnitNode.setLMForward2Speed(speed))
                MessageBox.Show("There was an error sending the command.");
        }

        private void LMAft1Speed_Click(object sender, EventArgs e)
        {
            int speed = trackBAft1Speed.Value * 1000;

            if (speed < 0 || speed > 10000)
            {
                MessageBox.Show("Not a valid speed.");
                return;
            }

            if (!rPodPodState.LandingGearUnitNode.setLMAft1Speed(speed))
                MessageBox.Show("There was an error sending the command.");
        }

        private void LMAft2Speed_Click(object sender, EventArgs e)
        {
            int speed = trackBAft2Speed.Value * 1000;

            if (speed < 0 || speed > 10000)
            {
                MessageBox.Show("Not a valid speed.");
                return;
            }

            if (!rPodPodState.LandingGearUnitNode.setLMAft2Speed(speed))
                MessageBox.Show("There was an error sending the command.");
        }

        private void scrollBLMForward1Speed_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = ((TrackBar)sender);
            lblFwd1SpeedVal.Text = (float)((float)trackBar.Value / (float)trackBar.Maximum * 100) + "%";
        }

        private void scrollBLMForward2Speed_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = ((TrackBar)sender);
            lblFwd2SpeedVal.Text = (float)((float)trackBar.Value / (float)trackBar.Maximum * 100) + "%";
        }

        private void scrollBLMAft1Speed_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = ((TrackBar)sender);
            lblAft1SpeedVal.Text = (float)((float)trackBar.Value / (float)trackBar.Maximum * 100) + "%";
        }

        private void scrollBLMAft2Speed_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = ((TrackBar)sender);
            lblAft2SpeedVal.Text = (float)((float)trackBar.Value / (float)trackBar.Maximum * 100) + "%";
        }
    }
}
