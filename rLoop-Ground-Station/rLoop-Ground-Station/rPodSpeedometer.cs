using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rLoop_Ground_Station
{
    public partial class rPodSpeedometer : UserControl
    {
        public rPodSpeedometer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void rPodSpeedometer_Load(object sender, EventArgs e)
        {
        }

        Tuple<double,double> polarToLinear(double r, double degree,double x, double y)
        {
            return new Tuple<double,double>(r*Math.Cos(degree*(2*Math.PI)/360)+x,
                r * Math.Sin(degree * (2 * Math.PI) / 360)+y);

        
        }


        protected override void OnPaint(PaintEventArgs e)
        {


            System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Black);
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.White);


            float smallArcHeight = this.Height / 2;
            float smallArcWidth = this.Width / 2;
            float smallArcCenterX = this.Width / 2;
            float smallArcCenterY = this.Height / 2;

            e.Graphics.DrawArc(new System.Drawing.Pen(Color.White, 2), smallArcCenterX - smallArcWidth/2, smallArcCenterY - smallArcHeight/2, smallArcWidth, smallArcHeight, 135, 270);
            double majorRin = this.Width/4+30;
            double majorRout = this.Width/4+50;

            int beginDeg = 135;
            int endDeg = beginDeg+270;
            int numOfTicks = 41;
            int major = 5;
            float degSep = ((float)endDeg - beginDeg) / (float)(numOfTicks-1);


            for (int i = 0; i < numOfTicks; i++)
            {
                
                if(i%major == 0){
                    Tuple<double, double> innerPoint = polarToLinear(majorRin, (int)( (float)beginDeg + degSep*i), this.Size.Width / 2, this.Size.Height / 2);
                    Tuple<double, double> outerPoint = polarToLinear(majorRout, (int)((float)beginDeg + degSep * i), this.Size.Width / 2, this.Size.Height / 2);
                    e.Graphics.DrawLine(new System.Drawing.Pen(Color.White, 3), new Point((int)innerPoint.Item1, (int)innerPoint.Item2), new Point((int)outerPoint.Item1, (int)outerPoint.Item2));
                }

                else
                {
                    Tuple<double, double> innerPoint = polarToLinear(majorRin + 5, (int)((float)beginDeg + degSep * i), this.Size.Width / 2, this.Size.Height / 2);
                    Tuple<double, double> outerPoint = polarToLinear(majorRout - 5, (int)((float)beginDeg + degSep * i), this.Size.Width / 2, this.Size.Height / 2);
                    e.Graphics.DrawLine(new System.Drawing.Pen(Color.White, 1), new Point((int)innerPoint.Item1, (int)innerPoint.Item2), new Point((int)outerPoint.Item1, (int)outerPoint.Item2));
                }
            }

            double value = .3;
            Tuple<double, double> speedPos = polarToLinear(this.Width/4, ((double)endDeg - beginDeg) * value + beginDeg, this.Width / 2, this.Height / 2);
            fillCircle(e.Graphics,new SolidBrush(Color.Orange),(float)speedPos.Item1,(float)speedPos.Item2,(float)5.0);
        }   

        public void fillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }
    }
}

