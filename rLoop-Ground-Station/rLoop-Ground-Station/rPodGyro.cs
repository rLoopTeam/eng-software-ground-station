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

            Stream imageStream = assembly
                .GetManifestResourceStream("rLoop_Ground_Station.g6034.png");

            podOutlineImage = Image.FromStream(imageStream);
            this.DoubleBuffered = true;
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

        private void redrawBackground()
        {
            backgroundBuffer = new Bitmap(this.Size.Width, this.Size.Height);
            Graphics g = Graphics.FromImage(backgroundBuffer);

            System.Drawing.Pen myPen = new System.Drawing.Pen(Color.Black);
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.White);


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

            g.DrawImage(podOutlineImage, new Rectangle(new Point(this.Width / 2 - finalOutlineWidth / 2, 0), new Size(finalOutlineWidth, finalOutlineHeight)));
        }

        private void rPodGyro_Paint(object sender, PaintEventArgs e)
        {
            if (_isNewSize())
                redrawBackground();

            e.Graphics.DrawImageUnscaled(backgroundBuffer, 0, 0);
        }
    }
}
