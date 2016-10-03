namespace DummyDataTX
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UDPAnnounceTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ZMQNodeTXT = new System.Windows.Forms.TextBox();
            this.testDataType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.testDataIndexTxt = new System.Windows.Forms.TextBox();
            this.testDataToSendTxt = new System.Windows.Forms.TextBox();
            this.UDPTimer = new System.Windows.Forms.Timer(this.components);
            this.ZMQTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UDPAnnounceTXT
            // 
            this.UDPAnnounceTXT.Location = new System.Drawing.Point(23, 41);
            this.UDPAnnounceTXT.Name = "UDPAnnounceTXT";
            this.UDPAnnounceTXT.Size = new System.Drawing.Size(269, 20);
            this.UDPAnnounceTXT.TabIndex = 0;
            this.UDPAnnounceTXT.Text = "PowerA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UDP Announce Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ZMQ Node Name";
            // 
            // ZMQNodeTXT
            // 
            this.ZMQNodeTXT.Location = new System.Drawing.Point(23, 93);
            this.ZMQNodeTXT.Name = "ZMQNodeTXT";
            this.ZMQNodeTXT.Size = new System.Drawing.Size(269, 20);
            this.ZMQNodeTXT.TabIndex = 2;
            this.ZMQNodeTXT.Text = "PowerA";
            // 
            // testDataType
            // 
            this.testDataType.FormattingEnabled = true;
            this.testDataType.Items.AddRange(new object[] {
            "Int 8",
            "UInt 8",
            "Int 16",
            "UInt 16",
            "Int 32",
            "UInt 32",
            "Int 64",
            "UInt 64",
            "Float",
            "Double"});
            this.testDataType.Location = new System.Drawing.Point(342, 135);
            this.testDataType.Name = "testDataType";
            this.testDataType.Size = new System.Drawing.Size(121, 21);
            this.testDataType.TabIndex = 18;
            this.testDataType.Text = "Data Type";
            this.testDataType.SelectedIndexChanged += new System.EventHandler(this.testDataType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(175, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Index";
            // 
            // testDataIndexTxt
            // 
            this.testDataIndexTxt.Location = new System.Drawing.Point(23, 137);
            this.testDataIndexTxt.Name = "testDataIndexTxt";
            this.testDataIndexTxt.Size = new System.Drawing.Size(65, 20);
            this.testDataIndexTxt.TabIndex = 14;
            this.testDataIndexTxt.Text = "21";
            // 
            // testDataToSendTxt
            // 
            this.testDataToSendTxt.Location = new System.Drawing.Point(105, 137);
            this.testDataToSendTxt.Name = "testDataToSendTxt";
            this.testDataToSendTxt.Size = new System.Drawing.Size(222, 20);
            this.testDataToSendTxt.TabIndex = 13;
            this.testDataToSendTxt.Text = "3.14159";
            // 
            // UDPTimer
            // 
            this.UDPTimer.Enabled = true;
            this.UDPTimer.Interval = 1000;
            this.UDPTimer.Tick += new System.EventHandler(this.UDPTimer_Tick);
            // 
            // ZMQTimer
            // 
            this.ZMQTimer.Enabled = true;
            this.ZMQTimer.Tick += new System.EventHandler(this.ZMQTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(487, 198);
            this.Controls.Add(this.testDataType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.testDataIndexTxt);
            this.Controls.Add(this.testDataToSendTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZMQNodeTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UDPAnnounceTXT);
            this.Name = "Form1";
            this.Text = "Test Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UDPAnnounceTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ZMQNodeTXT;
        private System.Windows.Forms.ComboBox testDataType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox testDataIndexTxt;
        private System.Windows.Forms.TextBox testDataToSendTxt;
        private System.Windows.Forms.Timer UDPTimer;
        private System.Windows.Forms.Timer ZMQTimer;
    }
}

