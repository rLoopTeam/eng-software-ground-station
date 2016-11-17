using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace rLoop_Ground_Station
{
    public class ControlWriter : TextWriter
    {
        private TextBox textbox;

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (textbox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                textbox.Invoke(d, new object[] { text });
            }
            else
            {
                textbox.Text += text;
            }
        }

        public ControlWriter(TextBox textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            SetText(value.ToString());
        }

        public override void Write(string value)
        {
            SetText(value.ToString());
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}
