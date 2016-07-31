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
    public partial class PodStateControl : UserControl
    {
        private Image podOutlineImage;
        public PodStateControl()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();

            Stream imageStream = assembly
                .GetManifestResourceStream("rLoop_Ground_Station.image8695.png");

            podOutlineImage = Image.FromStream(imageStream);
            this.DoubleBuffered = true;
        }

        private void PodStateControl_Load(object sender, EventArgs e)
        {

        }

        #region Properties

        double _HE1Height = 12.23;
        double _HE2Height = 12.2;
        double _HE3Height = 12.2;
        double _HE4Height = 12.2;
        double _HE5Height = 12.2;
        double _HE6Height = 12.2;
        double _HE7Height = 12.2;
        double _HE8Height = 12.2;
        double _HE1Percent = .8;
        double _HE2Percent = .8;
        double _HE3Percent = .8;
        double _HE4Percent = .8;
        double _HE5Percent = .8;
        double _HE6Percent = .8;
        double _HE7Percent = .8;
        double _HE8Percent = .8;
        double _HE1RPM = 3000;
        double _HE2RPM = 3000;
        double _HE3RPM = 3000;
        double _HE4RPM = 3000;
        double _HE5RPM = 3000;
        double _HE6RPM = 3000;
        double _HE7RPM = 3000;
        double _HE8RPM = 3000;
        double _HE1Power = 3000;
        double _HE2Power = 3000;
        double _HE3Power = 3000;
        double _HE4Power = 3000;
        double _HE5Power = 3000;
        double _HE6Power = 3000;
        double _HE7Power = 3000;
        double _HE8Power = 3000;

        public double HE1Height { get { return _HE1Height; } set { _HE1Height = value; this.Refresh(); } }
        public double HE2Height { get { return _HE2Height; } set { _HE2Height = value; this.Refresh(); } }
        public double HE3Height { get { return _HE3Height; } set { _HE3Height = value; this.Refresh(); } }
        public double HE4Height { get { return _HE4Height; } set { _HE4Height = value; this.Refresh(); } }
        public double HE5Height { get { return _HE5Height; } set { _HE5Height = value; this.Refresh(); } }
        public double HE6Height { get { return _HE6Height; } set { _HE6Height = value; this.Refresh(); } }
        public double HE7Height { get { return _HE7Height; } set { _HE7Height = value; this.Refresh(); } }
        public double HE8Height { get { return _HE8Height; } set { _HE8Height = value; this.Refresh(); } }

        public double HE1Percent { get { return _HE1Percent; } set { _HE1Percent = value; if (_HE1Percent > 1) _HE1Percent = 1; if (_HE1Percent < 0) _HE1Percent = 0; this.Refresh(); } }
        public double HE2Percent { get { return _HE2Percent; } set { _HE2Percent = value; if (_HE2Percent > 1) _HE2Percent = 1; if (_HE2Percent < 0) _HE2Percent = 0; this.Refresh(); } }
        public double HE3Percent { get { return _HE3Percent; } set { _HE3Percent = value; if (_HE3Percent > 1) _HE3Percent = 1; if (_HE3Percent < 0) _HE3Percent = 0; this.Refresh(); } }
        public double HE4Percent { get { return _HE4Percent; } set { _HE4Percent = value; if (_HE4Percent > 1) _HE4Percent = 1; if (_HE4Percent < 0) _HE4Percent = 0; this.Refresh(); } }
        public double HE5Percent { get { return _HE5Percent; } set { _HE5Percent = value; if (_HE5Percent > 1) _HE5Percent = 1; if (_HE5Percent < 0) _HE5Percent = 0; this.Refresh(); } }
        public double HE6Percent { get { return _HE6Percent; } set { _HE6Percent = value; if (_HE6Percent > 1) _HE6Percent = 1; if (_HE6Percent < 0) _HE6Percent = 0; this.Refresh(); } }
        public double HE7Percent { get { return _HE7Percent; } set { _HE7Percent = value; if (_HE7Percent > 1) _HE7Percent = 1; if (_HE7Percent < 0) _HE7Percent = 0; this.Refresh(); } }
        public double HE8Percent { get { return _HE8Percent; } set { _HE8Percent = value; if (_HE8Percent > 1) _HE8Percent = 1; if (_HE8Percent < 0) _HE8Percent = 0; this.Refresh(); } }

        public double HE1RPM { get { return _HE1RPM; } set { _HE1RPM = value; this.Refresh(); } }
        public double HE2RPM { get { return _HE2RPM; } set { _HE2RPM = value; this.Refresh(); } }
        public double HE3RPM { get { return _HE3RPM; } set { _HE3RPM = value; this.Refresh(); } }
        public double HE4RPM { get { return _HE4RPM; } set { _HE4RPM = value; this.Refresh(); } }
        public double HE5RPM { get { return _HE5RPM; } set { _HE5RPM = value; this.Refresh(); } }
        public double HE6RPM { get { return _HE6RPM; } set { _HE6RPM = value; this.Refresh(); } }
        public double HE7RPM { get { return _HE7RPM; } set { _HE7RPM = value; this.Refresh(); } }
        public double HE8RPM { get { return _HE8RPM; } set { _HE8RPM = value; this.Refresh(); } }

        public double HE1Power { get { return _HE1Power; } set { _HE1Power = value; this.Refresh(); } }
        public double HE2Power { get { return _HE2Power; } set { _HE2Power = value; this.Refresh(); } }
        public double HE3Power { get { return _HE3Power; } set { _HE3Power = value; this.Refresh(); } }
        public double HE4Power { get { return _HE4Power; } set { _HE4Power = value; this.Refresh(); } }
        public double HE5Power { get { return _HE5Power; } set { _HE5Power = value; this.Refresh(); } }
        public double HE6Power { get { return _HE6Power; } set { _HE6Power = value; this.Refresh(); } }
        public double HE7Power { get { return _HE7Power; } set { _HE7Power = value; this.Refresh(); } }
        public double HE8Power { get { return _HE8Power; } set { _HE8Power = value; this.Refresh(); } }

        #endregion

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

            double imageRatio = (double)podOutlineImage.Height / podOutlineImage.Width;
            int imageWidth1 = (int)(this.Size.Height / imageRatio);
            int imageHeight1 = this.Size.Height;
            int imageWidth2 = this.Size.Width;
            int imageHeight2 = (int)(this.Size.Width * imageRatio);
            int finalOutlineWidth;
            int finalOutlineHeight;
            if (imageWidth1 <= this.Size.Width)
            {
                finalOutlineWidth = imageWidth1;
                finalOutlineHeight = imageHeight1;
            }
            else
            {
                finalOutlineWidth = imageWidth2;
                finalOutlineHeight = imageHeight2;
            }

            System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Black);
            Font drawFont = new Font("Arial", finalOutlineHeight/40);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            g.DrawImage(podOutlineImage, new Rectangle(new Point(this.Width / 2 - finalOutlineWidth / 2, 0), new Size(finalOutlineWidth, finalOutlineHeight)));

            double firstRow = .11;
            double secondRow = .23;
            double thirdRow = .66;
            double fourthRow = .76;
            double Column1Height = ((this.Width / 2) - (finalOutlineWidth / 2)) / 4;
            double Column2Height = ((this.Width / 2) - (finalOutlineWidth / 2)) / 4 + this.Width / 2 + (finalOutlineWidth / 2);
            double Column1RPM = 2 * ((this.Width / 2) - (finalOutlineWidth / 2)) / 4;
            double Column2RPM = 2 * ((this.Width / 2) - (finalOutlineWidth / 2)) / 4 + this.Width / 2 + (finalOutlineWidth / 2);
            double Column1Power = 3 * ((this.Width / 2) - (finalOutlineWidth / 2)) / 4;
            double Column2Power = 3 * ((this.Width / 2) - (finalOutlineWidth / 2)) / 4 + this.Width / 2 + (finalOutlineWidth / 2);

            int HECirclesSize = (int)((double)finalOutlineWidth / 4.5);

            int HE1CenterX = (int)((double)finalOutlineWidth * .250) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE2CenterX = (int)((double)finalOutlineWidth * .252) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE3CenterX = (int)((double)finalOutlineWidth * .255) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE4CenterX = (int)((double)finalOutlineWidth * .255) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE5CenterX = (int)((double)finalOutlineWidth * .757) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE6CenterX = (int)((double)finalOutlineWidth * .754) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE7CenterX = (int)((double)finalOutlineWidth * .754) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE8CenterX = (int)((double)finalOutlineWidth * .754) + (this.Width / 2 - finalOutlineWidth / 2);

            int HE1CenterY = (int)((double)finalOutlineHeight * .155);
            int HE2CenterY = (int)((double)finalOutlineHeight * .273);
            int HE3CenterY = (int)((double)finalOutlineHeight * .695);
            int HE4CenterY = (int)((double)finalOutlineHeight * .81);
            int HE5CenterY = (int)((double)finalOutlineHeight * .81);
            int HE6CenterY = (int)((double)finalOutlineHeight * .695);
            int HE7CenterY = (int)((double)finalOutlineHeight * .273);
            int HE8CenterY = (int)((double)finalOutlineHeight * .157);

            int lineSpaceing = drawFont.Height + 2;

            //HE 1 Text
            g.DrawString("HEIGHT", drawFont, drawBrush, new Point((int)(Column1Height - (g.MeasureString("HEIGHT", drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow)));
            g.DrawString("RPM", drawFont, drawBrush, new Point((int)(Column1RPM - (g.MeasureString("RPM", drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow)));
            g.DrawString("Power", drawFont, drawBrush, new Point((int)(Column1Power - (g.MeasureString("Power", drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow)));

            //HE 2 Text
            g.DrawString("HEIGHT", drawFont, drawBrush, new Point((int)(Column1Height - (g.MeasureString("HEIGHT", drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow)));
            g.DrawString("RPM", drawFont, drawBrush, new Point((int)(Column1RPM - (g.MeasureString("RPM", drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow)));
            g.DrawString("Power", drawFont, drawBrush, new Point((int)(Column1Power - (g.MeasureString("Power", drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow)));

            //HE 3 Text
            g.DrawString("HEIGHT", drawFont, drawBrush, new Point((int)(Column1Height - (g.MeasureString("HEIGHT", drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow)));
            g.DrawString("RPM", drawFont, drawBrush, new Point((int)(Column1RPM - (g.MeasureString("RPM", drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow)));
            g.DrawString("Power", drawFont, drawBrush, new Point((int)(Column1Power - (g.MeasureString("Power", drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow)));

            //HE 4 Text
            g.DrawString("HEIGHT", drawFont, drawBrush, new Point((int)(Column1Height - (g.MeasureString("HEIGHT", drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow)));
            g.DrawString("RPM", drawFont, drawBrush, new Point((int)(Column1RPM - (g.MeasureString("RPM", drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow)));
            g.DrawString("Power", drawFont, drawBrush, new Point((int)(Column1Power - (g.MeasureString("Power", drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow)));

            //HE 5 Text
            g.DrawString("HEIGHT", drawFont, drawBrush, new Point((int)(Column2Height - (g.MeasureString("HEIGHT", drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow)));
            g.DrawString("RPM", drawFont, drawBrush, new Point((int)(Column2RPM - (g.MeasureString("RPM", drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow)));
            g.DrawString("Power", drawFont, drawBrush, new Point((int)(Column2Power - (g.MeasureString("Power", drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow)));

            //HE 6 Text
            g.DrawString("HEIGHT", drawFont, drawBrush, new Point((int)(Column2Height - (g.MeasureString("HEIGHT", drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow)));
            g.DrawString("RPM", drawFont, drawBrush, new Point((int)(Column2RPM - (g.MeasureString("RPM", drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow)));
            g.DrawString("Power", drawFont, drawBrush, new Point((int)(Column2Power - (g.MeasureString("Power", drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow)));

            //HE 7 Text
            g.DrawString("HEIGHT", drawFont, drawBrush, new Point((int)(Column2Height - (g.MeasureString("HEIGHT", drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow)));
            g.DrawString("RPM", drawFont, drawBrush, new Point((int)(Column2RPM - (g.MeasureString("RPM", drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow)));
            g.DrawString("Power", drawFont, drawBrush, new Point((int)(Column2Power - (g.MeasureString("Power", drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow)));

            //HE 8 Text
            g.DrawString("HEIGHT", drawFont, drawBrush, new Point((int)(Column2Height - (g.MeasureString("HEIGHT", drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow)));
            g.DrawString("RPM", drawFont, drawBrush, new Point((int)(Column2RPM - (g.MeasureString("RPM", drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow)));
            g.DrawString("Power", drawFont, drawBrush, new Point((int)(Column2Power - (g.MeasureString("Power", drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow)));
        }

        protected override void OnPaint(PaintEventArgs e)
        {

           if (_isNewSize())
                redrawBackground();
           if (backgroundBuffer != null)
                e.Graphics.DrawImageUnscaled(backgroundBuffer, 0, 0);

            //Draw the pod outline in the middle of the control

            double imageRatio = (double)podOutlineImage.Height / podOutlineImage.Width;
            int imageWidth1 = (int)(this.Size.Height / imageRatio);
            int imageHeight1 = this.Size.Height;
            int imageWidth2 = this.Size.Width;
            int imageHeight2 = (int)(this.Size.Width * imageRatio);
            int finalOutlineWidth;
            int finalOutlineHeight;
            if (imageWidth1 <= this.Size.Width)
            {
                finalOutlineWidth = imageWidth1;
                finalOutlineHeight = imageHeight1;
            }
            else
            {
                finalOutlineWidth = imageWidth2;
                finalOutlineHeight = imageHeight2;
            }

            System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Black);
            Font drawFont = new Font("Arial", finalOutlineHeight / 40);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            double firstRow = .11;
            double secondRow = .23;
            double thirdRow = .66;
            double fourthRow = .76;
            double Column1Height = ((this.Width / 2) - (finalOutlineWidth / 2)) / 4;
            double Column2Height = ((this.Width / 2) - (finalOutlineWidth / 2)) / 4 + this.Width / 2 + (finalOutlineWidth / 2);
            double Column1RPM = 2 * ((this.Width / 2) - (finalOutlineWidth / 2)) / 4;
            double Column2RPM = 2 * ((this.Width / 2) - (finalOutlineWidth / 2)) / 4 + this.Width / 2 + (finalOutlineWidth / 2);
            double Column1Power = 3 * ((this.Width / 2) - (finalOutlineWidth / 2)) / 4;
            double Column2Power = 3 * ((this.Width / 2) - (finalOutlineWidth / 2)) / 4 + this.Width / 2 + (finalOutlineWidth / 2);

            int HECirclesSize = (int)((double)finalOutlineWidth / 4.5);

            int HE1CenterX = (int)((double)finalOutlineWidth * .250) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE2CenterX = (int)((double)finalOutlineWidth * .252) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE3CenterX = (int)((double)finalOutlineWidth * .255) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE4CenterX = (int)((double)finalOutlineWidth * .255) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE5CenterX = (int)((double)finalOutlineWidth * .757) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE6CenterX = (int)((double)finalOutlineWidth * .754) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE7CenterX = (int)((double)finalOutlineWidth * .754) + (this.Width / 2 - finalOutlineWidth / 2);
            int HE8CenterX = (int)((double)finalOutlineWidth * .754) + (this.Width / 2 - finalOutlineWidth / 2);

            int HE1CenterY = (int)((double)finalOutlineHeight * .155);
            int HE2CenterY = (int)((double)finalOutlineHeight * .273);
            int HE3CenterY = (int)((double)finalOutlineHeight * .695);
            int HE4CenterY = (int)((double)finalOutlineHeight * .81);
            int HE5CenterY = (int)((double)finalOutlineHeight * .81);
            int HE6CenterY = (int)((double)finalOutlineHeight * .695);
            int HE7CenterY = (int)((double)finalOutlineHeight * .273);
            int HE8CenterY = (int)((double)finalOutlineHeight * .157);

            int lineSpaceing = drawFont.Height + 2;

            //HE 1 Text
            e.Graphics.DrawString(string.Format("{0:0.0} mm", _HE1Height), drawFont, drawBrush, new Point((int)(Column1Height - (e.Graphics.MeasureString(string.Format("{0:0.0} mm", _HE1Height), drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0}", _HE1RPM), drawFont, drawBrush, new Point((int)(Column1RPM - (e.Graphics.MeasureString(string.Format("{0:0}", _HE1RPM), drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0} W", _HE1Power), drawFont, drawBrush, new Point((int)(Column1Power - (e.Graphics.MeasureString(string.Format("{0:0} W", _HE1Power), drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow) + lineSpaceing));
            e.Graphics.DrawArc(new System.Drawing.Pen(Color.Blue, 6), new Rectangle(HE1CenterX - HECirclesSize / 2, HE1CenterY - HECirclesSize / 2, HECirclesSize, HECirclesSize), -90, (int)(_HE1Percent * 360));


            //HE 2 Text
            e.Graphics.DrawString(string.Format("{0:0.0} mm", _HE2Height), drawFont, drawBrush, new Point((int)(Column1Height - (e.Graphics.MeasureString(string.Format("{0:0.0} mm", _HE2Height), drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0}", _HE2RPM), drawFont, drawBrush, new Point((int)(Column1RPM - (e.Graphics.MeasureString(string.Format("{0:0}", _HE2RPM), drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0} W", _HE2Power), drawFont, drawBrush, new Point((int)(Column1Power - (e.Graphics.MeasureString(string.Format("{0:0} W", _HE2Power), drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow) + lineSpaceing));
            e.Graphics.DrawArc(new System.Drawing.Pen(Color.Blue, 6), new Rectangle(HE2CenterX - HECirclesSize / 2, HE2CenterY - HECirclesSize / 2, HECirclesSize, HECirclesSize), -90, (int)(_HE2Percent * 360));

            //HE 3 Text
            e.Graphics.DrawString(string.Format("{0:0.0} mm", _HE3Height), drawFont, drawBrush, new Point((int)(Column1Height - (e.Graphics.MeasureString(string.Format("{0:0.0} mm", _HE3Height), drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0}", _HE3RPM), drawFont, drawBrush, new Point((int)(Column1RPM - (e.Graphics.MeasureString(string.Format("{0:0}", _HE3RPM), drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0} W", _HE3Power), drawFont, drawBrush, new Point((int)(Column1Power - (e.Graphics.MeasureString(string.Format("{0:0} W", _HE3Power), drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow) + lineSpaceing));
            e.Graphics.DrawArc(new System.Drawing.Pen(Color.Blue, 6), new Rectangle(HE3CenterX - HECirclesSize / 2, HE3CenterY - HECirclesSize / 2, HECirclesSize, HECirclesSize), -90, (int)(_HE3Percent * 360));

            //HE 4 Text
            e.Graphics.DrawString(string.Format("{0:0.0} mm", _HE4Height), drawFont, drawBrush, new Point((int)(Column1Height - (e.Graphics.MeasureString(string.Format("{0:0.0} mm", _HE4Height), drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0}", _HE4RPM), drawFont, drawBrush, new Point((int)(Column1RPM - (e.Graphics.MeasureString(string.Format("{0:0}", _HE4RPM), drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0} W", _HE4Power), drawFont, drawBrush, new Point((int)(Column1Power - (e.Graphics.MeasureString(string.Format("{0:0} W", _HE4Power), drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow) + lineSpaceing));
            e.Graphics.DrawArc(new System.Drawing.Pen(Color.Blue, 6), new Rectangle(HE4CenterX - HECirclesSize / 2, HE4CenterY - HECirclesSize / 2, HECirclesSize, HECirclesSize), -90, (int)(_HE4Percent * 360));

            //HE 5 Text
            e.Graphics.DrawString(string.Format("{0:0.0} mm", _HE5Height), drawFont, drawBrush, new Point((int)(Column2Height - (e.Graphics.MeasureString(string.Format("{0:0.0} mm", _HE5Height), drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0}", _HE5RPM), drawFont, drawBrush, new Point((int)(Column2RPM - (e.Graphics.MeasureString(string.Format("{0:0}", _HE5RPM), drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0} W", _HE5Power), drawFont, drawBrush, new Point((int)(Column2Power - (e.Graphics.MeasureString(string.Format("{0:0} W", _HE5Power), drawFont).ToSize().Width) / 2), (int)(this.Height * fourthRow) + lineSpaceing));
            e.Graphics.DrawArc(new System.Drawing.Pen(Color.Blue, 6), new Rectangle(HE5CenterX - HECirclesSize / 2, HE5CenterY - HECirclesSize / 2, HECirclesSize, HECirclesSize), -90, (int)(_HE5Percent * 360));

            //HE 6 Text
            e.Graphics.DrawString(string.Format("{0:0.0} mm", _HE6Height), drawFont, drawBrush, new Point((int)(Column2Height - (e.Graphics.MeasureString(string.Format("{0:0.0} mm", _HE6Height), drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0}", _HE6RPM), drawFont, drawBrush, new Point((int)(Column2RPM - (e.Graphics.MeasureString(string.Format("{0:0}", _HE6RPM), drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0} W", _HE6Power), drawFont, drawBrush, new Point((int)(Column2Power - (e.Graphics.MeasureString(string.Format("{0:0} W", _HE6Power), drawFont).ToSize().Width) / 2), (int)(this.Height * thirdRow) + lineSpaceing));
            e.Graphics.DrawArc(new System.Drawing.Pen(Color.Blue, 6), new Rectangle(HE6CenterX - HECirclesSize / 2, HE6CenterY - HECirclesSize / 2, HECirclesSize, HECirclesSize), -90, (int)(_HE6Percent * 360));

            //HE 7 Text
            e.Graphics.DrawString(string.Format("{0:0.0} mm", _HE7Height), drawFont, drawBrush, new Point((int)(Column2Height - (e.Graphics.MeasureString(string.Format("{0:0.0} mm", _HE7Height), drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0}", _HE7RPM), drawFont, drawBrush, new Point((int)(Column2RPM - (e.Graphics.MeasureString(string.Format("{0:0}", _HE7RPM), drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0} W", _HE7Power), drawFont, drawBrush, new Point((int)(Column2Power - (e.Graphics.MeasureString(string.Format("{0:0} W", _HE7Power), drawFont).ToSize().Width) / 2), (int)(this.Height * secondRow) + lineSpaceing));
            e.Graphics.DrawArc(new System.Drawing.Pen(Color.Blue, 6), new Rectangle(HE7CenterX - HECirclesSize / 2, HE7CenterY - HECirclesSize / 2, HECirclesSize, HECirclesSize), -90, (int)(_HE7Percent * 360));

            //HE 8 Text
            e.Graphics.DrawString(string.Format("{0:0.0} mm", _HE8Height), drawFont, drawBrush, new Point((int)(Column2Height - (e.Graphics.MeasureString(string.Format("{0:0.0} mm", _HE8Height), drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0}", _HE8RPM), drawFont, drawBrush, new Point((int)(Column2RPM - (e.Graphics.MeasureString(string.Format("{0:0}", _HE8RPM), drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow) + lineSpaceing));
            e.Graphics.DrawString(string.Format("{0:0} W", _HE8Power), drawFont, drawBrush, new Point((int)(Column2Power - (e.Graphics.MeasureString(string.Format("{0:0} W", _HE8Power), drawFont).ToSize().Width) / 2), (int)(this.Height * firstRow) + lineSpaceing));
            e.Graphics.DrawArc(new System.Drawing.Pen(Color.Blue, 6), new Rectangle(HE8CenterX - HECirclesSize / 2, HE8CenterY - HECirclesSize / 2, HECirclesSize, HECirclesSize), -90, (int)(_HE8Percent * 360));
        }


    }
}

