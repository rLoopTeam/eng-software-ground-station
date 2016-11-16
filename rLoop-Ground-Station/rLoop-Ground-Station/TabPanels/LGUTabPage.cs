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

            if (radioButton == null)
            {
                MessageBox.Show("Please select a direction for landing gear forward 1.");
                return;
            }
                
            if (!rPodPodState.LandingGearUnitNode.setLMDirection(radioButton))
                MessageBox.Show("There was an error sending the command.");
        }

        private void LMForward2Direction_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = Utility.GetCheckedRadio(groupForward2);

            if (radioButton == null)
            {
                MessageBox.Show("Please select a direction for landing gear forward 2.");
                return;
            }

            if (!rPodPodState.LandingGearUnitNode.setLMDirection(radioButton))
                MessageBox.Show("There was an error sending the command.");
        }

        private void LMAft1Direction_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = Utility.GetCheckedRadio(groupAft1);

            if (radioButton == null)
            {
                MessageBox.Show("Please select a direction for landing gear aft 1.");
                return;
            }

            if (!rPodPodState.LandingGearUnitNode.setLMDirection(radioButton))
                MessageBox.Show("There was an error sending the command.");
        }

        private void LMAft2Direction_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = Utility.GetCheckedRadio(groupAft2);

            if (radioButton == null)
            {
                MessageBox.Show("Please select a direction for landing gear aft 2.");
                return;
            }

            if (!rPodPodState.LandingGearUnitNode.setLMDirection(radioButton))
                MessageBox.Show("There was an error sending the command.");
        }
    }
}
