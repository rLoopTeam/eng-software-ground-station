namespace rLoop_Ground_Station.TabPanels
{
    partial class TestingTabPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPodStop = new System.Windows.Forms.Button();
            this.btnPodSafe = new System.Windows.Forms.Button();
            this.TESTTabTimer = new System.Windows.Forms.Timer(this.components);
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPodStop
            // 
            this.btnPodStop.BackColor = System.Drawing.Color.Red;
            this.btnPodStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPodStop.Location = new System.Drawing.Point(625, 233);
            this.btnPodStop.Name = "btnPodStop";
            this.btnPodStop.Size = new System.Drawing.Size(481, 288);
            this.btnPodStop.TabIndex = 210;
            this.btnPodStop.Text = "LCU Stop";
            this.btnPodStop.UseVisualStyleBackColor = false;
            this.btnPodStop.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnPodSafe
            // 
            this.btnPodSafe.Location = new System.Drawing.Point(137, 233);
            this.btnPodSafe.Name = "btnPodSafe";
            this.btnPodSafe.Size = new System.Drawing.Size(465, 288);
            this.btnPodSafe.TabIndex = 209;
            this.btnPodSafe.Text = "Power Safe";
            this.btnPodSafe.UseVisualStyleBackColor = true;
            this.btnPodSafe.Click += new System.EventHandler(this.button11_Click);
            // 
            // TESTTabTimer
            // 
            this.TESTTabTimer.Enabled = true;
            this.TESTTabTimer.Interval = 200;
            this.TESTTabTimer.Tick += new System.EventHandler(this.TESTTabTimer_Tick);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(266, 1128);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(389, 45);
            this.trackBar2.TabIndex = 242;
            // 
            // TestingTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.btnPodStop);
            this.Controls.Add(this.btnPodSafe);
            this.Name = "TestingTabPage";
            this.Size = new System.Drawing.Size(1350, 747);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPodStop;
        private System.Windows.Forms.Button btnPodSafe;
        private System.Windows.Forms.Timer TESTTabTimer;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}
