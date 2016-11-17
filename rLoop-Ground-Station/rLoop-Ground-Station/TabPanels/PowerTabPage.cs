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
    public partial class PowerTabPage : UserControl
    {
        public PowerTabPage()
        {
            InitializeComponent();
        }

        private void btnStreamPressureOn_Click(object sender, EventArgs e)
        {
            if (!rPodPodState.PowerNodeA.SetStreamPressure(true))
                MessageBox.Show("There was an error sending the command.");
        }

        private void btnStreamPressureOff_Click(object sender, EventArgs e)
        {
            if (!rPodPodState.PowerNodeA.SetStreamPressure(false))
                MessageBox.Show("There was an error sending the command.");
        }

        private void btnStreamTemperatureOn_Click(object sender, EventArgs e)
        {
            if (!rPodPodState.PowerNodeA.SetStreamTemp(true))
                MessageBox.Show("There was an error sending the command.");
        }

        private void btnStreamTemperatureOff_Click(object sender, EventArgs e)
        {
            if (!rPodPodState.PowerNodeA.SetStreamTemp(false))
                MessageBox.Show("There was an error sending the command.");
        }

        private void btnChargeRelayOn_Click(object sender, EventArgs e)
        {
            if (!rPodPodState.PowerNodeA.SetChargeRelay(true)) 
                MessageBox.Show("There was an error sending the command.");
        }

        private void btnChargeRelayOff_Click(object sender, EventArgs e)
        {
            if (!rPodPodState.PowerNodeA.SetChargeRelay(true))
                MessageBox.Show("There was an error sending the command.");
        }

        private void lblUpdateTimer_Tick(object sender, EventArgs e)
        {
            lblTemperatureVal.Text = rPodPodState.PowerNodeA.BatteryPackTemperature.ToString("0.0") + " C";
            lblPressureVal.Text = rPodPodState.PowerNodeA.BatteryPackPressure.ToString("0.0") + " Bar";
        }

        private void PowerTabPage_Load(object sender, EventArgs e)
        {

        }
    }
}
