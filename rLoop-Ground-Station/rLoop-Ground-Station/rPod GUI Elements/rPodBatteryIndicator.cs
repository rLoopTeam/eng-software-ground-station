using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rLoop_Ground_Station.rPod_GUI_Elements
{
    public partial class rPodBatteryIndicator : UserControl
    {
        public double MaxVoltage;
        public double MinVoltage;
        public double CurrentVoltage;
        public double YellowVoltage;
        public double RedVoltage;

        public double BatteryCurrent;
        public double BatteryPower;


        public rPodBatteryIndicator()
        {
            InitializeComponent();
        }

        private void rPodBatteryIndicator_Load(object sender, EventArgs e)
        {

        }
    }
}
