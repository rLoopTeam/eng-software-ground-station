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

        private void EBForward1Direction_Click(object sender, EventArgs e)
        {
            MessageBox.Show( Utility.GetCheckedRadio(this.Parent).Text );
        }
    }
}
