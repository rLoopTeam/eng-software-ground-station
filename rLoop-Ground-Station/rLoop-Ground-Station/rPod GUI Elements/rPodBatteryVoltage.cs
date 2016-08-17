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
    public partial class rPodBatteryVoltage : UserControl
    {
        public double MaxVoltage;
        public double MinVoltage;
        public double CurrentVoltage;
        float fontSize = 2;
        int _lastWidth = 0;
        int _lastHeight = 0;

        public rPodBatteryVoltage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            MinVoltage = 30;
            MaxVoltage = 92;
            CurrentVoltage = 90;
        }

        private void rPodBatteryIndicator_Load(object sender, EventArgs e)
        {

        }

        private bool _isNewSize()
        {
            bool ret = _lastWidth != this.Size.Width || _lastHeight != this.Size.Height;
            _lastWidth = this.Size.Width;
            _lastHeight = this.Size.Height;
            return ret;
        }

        void recalcFontSize(Graphics g)
        {
            Font drawFont = new Font("Arial", 1);
            fontSize = findFontSize(drawFont, "99.9 V", (float)(this.Size.Width * .9), (float)this.Size.Height, (float)2, (float)100, (float).5, g);
        }

        float findFontSize(Font font, string text, float width, float height, float minSize, float maxSize, float stepSize, Graphics g)
        {
            float bestSize = minSize;
            Font testFont = (Font)font.Clone();
            for (float i = minSize; i < maxSize; i += stepSize)
            {
                testFont = new Font(font.Name,i,font.Style);
                if (testFont.Height > height || g.MeasureString(text, testFont).Width > width)
                {
                    bestSize = i - stepSize;
                    if (bestSize < minSize)
                        return minSize;
                    else
                        return bestSize;
                }
                
            }
            return maxSize;
        }

        private void rPodBatteryIndicator_Paint(object sender, PaintEventArgs e)
        {
            if (_isNewSize())
                recalcFontSize(e.Graphics);
            
            double voltagePercent;
            if(CurrentVoltage < MinVoltage)
            {
                voltagePercent = 0;
            }else if(CurrentVoltage > MaxVoltage)
            {
                voltagePercent = 1;
            }
            else
            {
                voltagePercent = (CurrentVoltage - MinVoltage) / (MaxVoltage - MinVoltage);
            }
            SolidBrush drawBrush = new SolidBrush(Color.Gray);
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(13, 107, 250));
            e.Graphics.FillRectangle(drawBrush, 0, 0,(int)(this.Width * .9),this.Height-1);
            e.Graphics.FillRectangle(drawBrush, (int)(this.Width * .9), (int)(this.Height * .3), (int)(this.Width * .1 - 1), (int)(this.Height * .4));
            if (voltagePercent > .9)
            {
                e.Graphics.FillRectangle(blueBrush, 0, 0, (int)(this.Width * .9), this.Height - 1);
                e.Graphics.FillRectangle(blueBrush, (int)(this.Width * .9), (int)(this.Height * .3), (int)(this.Width * .1 * (voltagePercent-.9)/.1 - 1), (int)(this.Height * .4));
            }
            else
            {
                e.Graphics.FillRectangle(blueBrush, 0, 0, (int)(this.Width * voltagePercent), this.Height - 1);
            }


            string text = string.Format("{0:0.0}", CurrentVoltage) + " V";
            SolidBrush whiteBrush = new SolidBrush(Color.White);


            Font drawFont = new Font("Arial", fontSize);

            float stringWidth = e.Graphics.MeasureString(text, drawFont).Width;
            e.Graphics.DrawString(text, drawFont, whiteBrush, (float)((this.Size.Width * .9)*.5 - stringWidth/2), this.Height / 2 - drawFont.Height / 2);


        }
    }
}
