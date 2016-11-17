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

        private void ErrorIfFalse(bool val)
        {
            if(!val)
                MessageBox.Show("THere was an error sending the command.");
        }

        #region Control Callbacks

        private void btnFwd1DirSend_Click(object sender, EventArgs e)
        {
            if (radioFwd1Up.Checked)
                ErrorIfFalse(rPodPodState.LandingGearUnitNode.SetForward1Up());
            if (radioFwd1Down.Checked)
                ErrorIfFalse(rPodPodState.LandingGearUnitNode.SetForward1Down());
        }

        private void btnFwd2DirSend_Click(object sender, EventArgs e)
        {
            if (radioFwd2Up.Checked)
                ErrorIfFalse(rPodPodState.LandingGearUnitNode.SetForward2Up());
            if (radioFwd2Down.Checked)
                ErrorIfFalse(rPodPodState.LandingGearUnitNode.SetForward2Down());
        }

        private void btnAft1DirSend_Click(object sender, EventArgs e)
        {
            if (radioAft1Up.Checked)
                ErrorIfFalse(rPodPodState.LandingGearUnitNode.SetAft1Up());
            if (radioAft1Down.Checked)
                ErrorIfFalse(rPodPodState.LandingGearUnitNode.SetAft1Down());
        }

        private void btnAft2DirSend_Click(object sender, EventArgs e)
        {
            if (radioAft2Up.Checked)
                ErrorIfFalse(rPodPodState.LandingGearUnitNode.SetAft2Up());
            if (radioAft2Down.Checked)
                ErrorIfFalse(rPodPodState.LandingGearUnitNode.SetAft2Down());
        }

        private void trackBFwd1Speed_Scroll(object sender, EventArgs e)
        {
            lblFwd1SpeedVal.Text = ((float)trackBFwd1Speed.Value / 10.0).ToString("0.0");
        }

        private void trackBFwd2Speed_Scroll(object sender, EventArgs e)
        {
            lblFwd2SpeedVal.Text = ((float)trackBFwd2Speed.Value / 10.0).ToString("0.0");
        }

        private void trackBAft1Speed_Scroll(object sender, EventArgs e)
        {
            lblAft1SpeedVal.Text = ((float)trackBAft1Speed.Value / 10.0).ToString("0.0");
        }

        private void trackBAft2Speed_Scroll(object sender, EventArgs e)
        {
            lblAft2SpeedVal.Text = ((float)trackBAft2Speed.Value / 10.0).ToString("0.0");
        }

        private void btnFwd1SpeedSend_Click(object sender, EventArgs e)
        {
            rPodPodState.LandingGearUnitNode.SetForward1Speed((float)trackBFwd1Speed.Value / 10.0F);
        }

        private void btnFwd2SpeedSend_Click(object sender, EventArgs e)
        {
            rPodPodState.LandingGearUnitNode.SetForward2Speed((float)trackBFwd2Speed.Value / 10.0F);
        }

        private void btnAft1SpeedSend_Click(object sender, EventArgs e)
        {
            rPodPodState.LandingGearUnitNode.SetAft1Speed((float)trackBAft1Speed.Value / 10.0F);
        }

        private void btnAft2SpeedSend_Click(object sender, EventArgs e)
        {
            rPodPodState.LandingGearUnitNode.SetAft2Speed((float)trackBAft2Speed.Value / 10.0F);
       }

        #endregion
    }
}
