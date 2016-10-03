using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace rLoop_Ground_Station
{
    public partial class rPodGyro : UserControl
    {
        private Image podOutlineImage;
        public rPodGyro()
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();

            Stream imageStream = assembly.GetManifestResourceStream("rLoop_Ground_Station.g6034.png");

            podOutlineImage = Image.FromStream(imageStream);
            this.DoubleBuffered = true;

            calcGraphicsConsts();
        }

        public double Pitch = 0;
        public double Roll = 0;
        public double Yaw = 0;

        private void rPodGyro_Load(object sender, EventArgs e)
        {

        }

        int _lastWidth = 0;
        int _lastHeight = 0;
        Bitmap backgroundBuffer;

        private bool _isNewSize()
        {
            bool ret = _lastWidth != this.Size.Width || _lastHeight != this.Size.Height;
            _lastWidth = this.Size.Width;
            _lastHeight = this.Size.Height;
            return ret;
        }

        int finalOutlineWidth;
        int finalOutlineHeight;
        int fontSize;
        int fontPadding;
        int fontHeight;
        Font drawFont;

        private void calcGraphicsConsts()
        {
            finalOutlineWidth = this.Size.Width;
            finalOutlineHeight = this.Size.Height / 2;
            fontSize = this.Size.Height / 20;
            if (fontSize < 1)
            {
                fontSize = 1;
            }
            drawFont = new Font("Arial", fontSize);
            fontHeight = drawFont.Height;
            fontPadding = (int)((this.Height / 2.0 - fontHeight * 3.0) / 4.0);
        }

        private void redrawBackground()
        {
            backgroundBuffer = new Bitmap(this.Size.Width, this.Size.Height);
            Graphics g = Graphics.FromImage(backgroundBuffer);

            calcGraphicsConsts();

            g.DrawImage(podOutlineImage, new Rectangle(new Point(this.Width / 2 - finalOutlineWidth / 2, 0), new Size(finalOutlineWidth, finalOutlineHeight)));
        }

        private void rPodGyro_Paint(object sender, PaintEventArgs e)
        {
          if (_isNewSize())
                redrawBackground();

            e.Graphics.DrawImageUnscaled(backgroundBuffer, 0, 0);

            System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            SizeF bigSpeedTextSize = e.Graphics.MeasureString("km/h", drawFont);
            
            int RollY = this.Height/2+ fontPadding;
            int PitchY = this.Height / 2 + fontPadding * 2 + fontHeight;
            int YawY = (int)(this.Height / 2 + fontPadding * 3 + 2 * fontHeight);
            string rollText = "Roll";// +string.Format("{0:0}", Roll);
            string pitchText = "Pitch";// + string.Format("{0:0}", Pitch);
            string YawText = "Yaw";// +string.Format("{0:0}", Yaw);
            e.Graphics.DrawString(rollText,drawFont,drawBrush,(float)(this.Size.Width*.2),RollY);
            e.Graphics.DrawString(pitchText, drawFont, drawBrush, (float)(this.Size.Width * .2), PitchY);
            e.Graphics.DrawString(YawText, drawFont, drawBrush, (float)(this.Size.Width * .2), YawY);       
        }
    }
}
