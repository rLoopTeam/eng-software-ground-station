using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace rLoop_Ground_Station
{
    public partial class rPodSpeedometer : UserControl
    {

        public rPodSpeedometer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public double currentSpeed = 0;
        public double maxSpeed=450;

        private void rPodSpeedometer_Load(object sender, EventArgs e)
        {
        }

        Tuple<double,double> polarToLinear(double r, double degree,double x, double y)
        {
            return new Tuple<double,double>(r*Math.Cos(degree*(2*Math.PI)/360)+x,
                r * Math.Sin(degree * (2 * Math.PI) / 360)+y);
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

        private void redrawBackground()
        {
            backgroundBuffer = new Bitmap(this.Size.Width, this.Size.Height);
            Graphics g = Graphics.FromImage(backgroundBuffer);

            System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Black);
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            int size = this.Size.Width > this.Size.Height ? this.Size.Height : this.Size.Width;

            float smallArcHeight = size / 2;
            float smallArcWidth = size / 2;
            float smallArcCenterX = size / 2;
            float smallArcCenterY = size / 2;

            g.DrawArc(new System.Drawing.Pen(Color.FromArgb(125, 255, 255, 255), 2), smallArcCenterX - smallArcWidth / 2, smallArcCenterY - smallArcHeight / 2, smallArcWidth, smallArcHeight, 135, 270);
            double majorRin = size / 2.5;
            double majorRout = majorRin + size / 20;

            int beginDeg = 135;
            int endDeg = beginDeg + 270;
            int numOfTicks = 46;
            int major = 5;
            float degSep = ((float)endDeg - beginDeg) / (float)(numOfTicks - 1);

            Font textFont = new Font("Arial", size / 30);
            SolidBrush textBrush = new SolidBrush(Color.White);

            for (int i = 0; i < numOfTicks; i++)
            {

                if (i % major == 0)
                {
                    Tuple<double, double> innerPoint = polarToLinear(majorRin, (int)((float)beginDeg + degSep * i), size / 2, size / 2);
                    Tuple<double, double> outerPoint = polarToLinear(majorRout, (int)((float)beginDeg + degSep * i), size / 2, size / 2);
                    g.DrawLine(new System.Drawing.Pen(Color.White, 3), new Point((int)innerPoint.Item1, (int)innerPoint.Item2), new Point((int)outerPoint.Item1, (int)outerPoint.Item2));

                    Tuple<double, double> innerTextPoint = polarToLinear((majorRin + size / 4) / 2, (int)((float)beginDeg + degSep * i), size / 2, size / 2);
                    int speedPoint = (int)((maxSpeed / (numOfTicks - 1)) * i);
                    SizeF textSize = g.MeasureString(speedPoint.ToString(), textFont);
                    g.DrawString(speedPoint.ToString(), textFont, textBrush, new Point((int)innerTextPoint.Item1 - (int)textSize.Width / 2, (int)innerTextPoint.Item2 - (int)textSize.Height / 2));
                }

                else
                {
                    Tuple<double, double> innerPoint = polarToLinear(majorRin + 3, (int)((float)beginDeg + degSep * i), size / 2, size / 2);
                    Tuple<double, double> outerPoint = polarToLinear(majorRout - 3, (int)((float)beginDeg + degSep * i), size / 2, size / 2);
                    g.DrawLine(new System.Drawing.Pen(Color.FromArgb(125, 255, 255, 255), 2), new Point((int)innerPoint.Item1, (int)innerPoint.Item2), new Point((int)outerPoint.Item1, (int)outerPoint.Item2));
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

        //    if (_isNewSize())
                redrawBackground();
            if(backgroundBuffer != null)
                e.Graphics.DrawImageUnscaled(backgroundBuffer, 0, 0);

            System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Black);
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            int size = this.Size.Width > this.Size.Height ? this.Size.Height : this.Size.Width;

            int beginDeg = 135;
            int endDeg = beginDeg+270;
            int numOfTicks = 46;
            float degSep = ((float)endDeg - beginDeg) / (float)(numOfTicks-1);

            double value = currentSpeed/maxSpeed;
            Tuple<double, double> speedPos = polarToLinear(size / 4, ((double)endDeg - beginDeg) * value + beginDeg, size / 2, size / 2);

            Font bigSpeedFont = new Font("Arial", size/13);
            SolidBrush bigSpeedBrush = new SolidBrush(Color.White);
            SizeF bigSpeedTextSize = e.Graphics.MeasureString("km/h",bigSpeedFont);
            e.Graphics.DrawString("km/h", bigSpeedFont, bigSpeedBrush, (float)( size / 2 - bigSpeedTextSize.Width / 2),(float)( size * .57 - bigSpeedTextSize.Height / 2));

            bigSpeedTextSize = e.Graphics.MeasureString(currentSpeed.ToString(), bigSpeedFont);
            e.Graphics.DrawString(currentSpeed.ToString(), bigSpeedFont, bigSpeedBrush, (float)(size / 2 - bigSpeedTextSize.Width / 2), (float)(size*.43 - bigSpeedTextSize.Height / 2));

            Rectangle bounds = new Rectangle((int)speedPos.Item1 - 45,(int)speedPos.Item2 - 45,90,90);
            using (var ellipsePath = new GraphicsPath())
            {
                ellipsePath.AddEllipse(bounds);
                using (var brush = new PathGradientBrush(ellipsePath))
                {
                    brush.CenterPoint = new PointF(bounds.Width/2f + bounds.X, bounds.Height/2f + bounds.Y);
                    brush.CenterColor = Color.FromArgb(150,0xf0,0xa1,0x0a);
                    brush.SurroundColors = new[] { Color.FromArgb(0,0xf0,0xa1,0x0a)};
                    brush.FocusScales = new PointF(0, 0);

                    e.Graphics.FillRectangle(brush, bounds);
                }
            }

            fillCircle(e.Graphics, new SolidBrush(Color.FromArgb(0xf0, 0xa1, 0x0a)), (float)speedPos.Item1, (float)speedPos.Item2, (float)5.0);
        }   

        public void fillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }
    }
}

