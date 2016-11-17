﻿namespace rLoop_Ground_Station.TabPanels
{
    partial class PowerTabPage
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
            System.Windows.Forms.Button btnStreamPressureOn;
            this.lblPowerHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblTemperatureVal = new System.Windows.Forms.Label();
            this.lblPressureVal = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStreamPressureOff = new System.Windows.Forms.Button();
            this.btnChargeRelayOn = new System.Windows.Forms.Button();
            this.btnChargeRelayOff = new System.Windows.Forms.Button();
            this.btnStreamTemperatureOn = new System.Windows.Forms.Button();
            this.btnStreamTemperatureOff = new System.Windows.Forms.Button();
            this.lblUpdateTimer = new System.Windows.Forms.Timer(this.components);
            btnStreamPressureOn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPowerHeading
            // 
            this.lblPowerHeading.AutoSize = true;
            this.lblPowerHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerHeading.ForeColor = System.Drawing.Color.White;
            this.lblPowerHeading.Location = new System.Drawing.Point(402, 24);
            this.lblPowerHeading.Name = "lblPowerHeading";
            this.lblPowerHeading.Size = new System.Drawing.Size(290, 55);
            this.lblPowerHeading.TabIndex = 279;
            this.lblPowerHeading.Text = "Power Node";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.50237F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.49763F));
            this.tableLayoutPanel1.Controls.Add(this.lblTemperature, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPressure, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPressureVal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTemperatureVal, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(371, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 107);
            this.tableLayoutPanel1.TabIndex = 280;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(3, 5);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(182, 33);
            this.lblTemperature.TabIndex = 244;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblPressure
            // 
            this.lblPressure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.ForeColor = System.Drawing.Color.White;
            this.lblPressure.Location = new System.Drawing.Point(3, 48);
            this.lblPressure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(132, 33);
            this.lblPressure.TabIndex = 244;
            this.lblPressure.Text = "Pressure";
            // 
            // lblTemperatureVal
            // 
            this.lblTemperatureVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTemperatureVal.AutoSize = true;
            this.lblTemperatureVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureVal.ForeColor = System.Drawing.Color.White;
            this.lblTemperatureVal.Location = new System.Drawing.Point(198, 5);
            this.lblTemperatureVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblTemperatureVal.Name = "lblTemperatureVal";
            this.lblTemperatureVal.Size = new System.Drawing.Size(92, 33);
            this.lblTemperatureVal.TabIndex = 244;
            this.lblTemperatureVal.Text = "100 C";
            // 
            // lblPressureVal
            // 
            this.lblPressureVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPressureVal.AutoSize = true;
            this.lblPressureVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressureVal.ForeColor = System.Drawing.Color.White;
            this.lblPressureVal.Location = new System.Drawing.Point(198, 48);
            this.lblPressureVal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblPressureVal.Name = "lblPressureVal";
            this.lblPressureVal.Size = new System.Drawing.Size(116, 33);
            this.lblPressureVal.TabIndex = 244;
            this.lblPressureVal.Text = "100 Bar";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(btnStreamPressureOn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnStreamPressureOff, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnChargeRelayOn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnChargeRelayOff, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnStreamTemperatureOn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnStreamTemperatureOff, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(206, 224);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 498);
            this.tableLayoutPanel2.TabIndex = 281;
            // 
            // btnStreamPressureOn
            // 
            btnStreamPressureOn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnStreamPressureOn.AutoSize = true;
            btnStreamPressureOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStreamPressureOn.Location = new System.Drawing.Point(3, 3);
            btnStreamPressureOn.Name = "btnStreamPressureOn";
            btnStreamPressureOn.Size = new System.Drawing.Size(341, 159);
            btnStreamPressureOn.TabIndex = 0;
            btnStreamPressureOn.Text = "Stream Pressure On";
            btnStreamPressureOn.UseVisualStyleBackColor = true;
            btnStreamPressureOn.Click += new System.EventHandler(this.btnStreamPressureOn_Click);
            // 
            // btnStreamPressureOff
            // 
            this.btnStreamPressureOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStreamPressureOff.AutoSize = true;
            this.btnStreamPressureOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStreamPressureOff.Location = new System.Drawing.Point(350, 3);
            this.btnStreamPressureOff.Name = "btnStreamPressureOff";
            this.btnStreamPressureOff.Size = new System.Drawing.Size(341, 159);
            this.btnStreamPressureOff.TabIndex = 0;
            this.btnStreamPressureOff.Text = "Stream Pressure Off";
            this.btnStreamPressureOff.UseVisualStyleBackColor = true;
            this.btnStreamPressureOff.Click += new System.EventHandler(this.btnStreamPressureOff_Click);
            // 
            // btnChargeRelayOn
            // 
            this.btnChargeRelayOn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChargeRelayOn.AutoSize = true;
            this.btnChargeRelayOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargeRelayOn.Location = new System.Drawing.Point(3, 334);
            this.btnChargeRelayOn.Name = "btnChargeRelayOn";
            this.btnChargeRelayOn.Size = new System.Drawing.Size(341, 161);
            this.btnChargeRelayOn.TabIndex = 0;
            this.btnChargeRelayOn.Text = "Charge Relay On";
            this.btnChargeRelayOn.UseVisualStyleBackColor = true;
            this.btnChargeRelayOn.Click += new System.EventHandler(this.btnChargeRelayOn_Click);
            // 
            // btnChargeRelayOff
            // 
            this.btnChargeRelayOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChargeRelayOff.AutoSize = true;
            this.btnChargeRelayOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargeRelayOff.Location = new System.Drawing.Point(350, 334);
            this.btnChargeRelayOff.Name = "btnChargeRelayOff";
            this.btnChargeRelayOff.Size = new System.Drawing.Size(341, 161);
            this.btnChargeRelayOff.TabIndex = 0;
            this.btnChargeRelayOff.Text = "Charge Relay Off";
            this.btnChargeRelayOff.UseVisualStyleBackColor = true;
            this.btnChargeRelayOff.Click += new System.EventHandler(this.btnChargeRelayOff_Click);
            // 
            // btnStreamTemperatureOn
            // 
            this.btnStreamTemperatureOn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStreamTemperatureOn.AutoSize = true;
            this.btnStreamTemperatureOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStreamTemperatureOn.Location = new System.Drawing.Point(3, 168);
            this.btnStreamTemperatureOn.Name = "btnStreamTemperatureOn";
            this.btnStreamTemperatureOn.Size = new System.Drawing.Size(341, 160);
            this.btnStreamTemperatureOn.TabIndex = 0;
            this.btnStreamTemperatureOn.Text = "Stream Temperature On";
            this.btnStreamTemperatureOn.UseVisualStyleBackColor = true;
            this.btnStreamTemperatureOn.Click += new System.EventHandler(this.btnStreamTemperatureOn_Click);
            // 
            // btnStreamTemperatureOff
            // 
            this.btnStreamTemperatureOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStreamTemperatureOff.AutoSize = true;
            this.btnStreamTemperatureOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStreamTemperatureOff.Location = new System.Drawing.Point(350, 168);
            this.btnStreamTemperatureOff.Name = "btnStreamTemperatureOff";
            this.btnStreamTemperatureOff.Size = new System.Drawing.Size(341, 160);
            this.btnStreamTemperatureOff.TabIndex = 0;
            this.btnStreamTemperatureOff.Text = "Stream Temperature Off";
            this.btnStreamTemperatureOff.UseVisualStyleBackColor = true;
            this.btnStreamTemperatureOff.Click += new System.EventHandler(this.btnStreamTemperatureOff_Click);
            // 
            // lblUpdateTimer
            // 
            this.lblUpdateTimer.Enabled = true;
            this.lblUpdateTimer.Tick += new System.EventHandler(this.lblUpdateTimer_Tick);
            // 
            // PowerTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblPowerHeading);
            this.Name = "PowerTabPage";
            this.Size = new System.Drawing.Size(1181, 798);
            this.Load += new System.EventHandler(this.PowerTabPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPowerHeading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblTemperatureVal;
        private System.Windows.Forms.Label lblPressureVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnStreamPressureOff;
        private System.Windows.Forms.Button btnChargeRelayOn;
        private System.Windows.Forms.Button btnChargeRelayOff;
        private System.Windows.Forms.Button btnStreamTemperatureOn;
        private System.Windows.Forms.Button btnStreamTemperatureOff;
        private System.Windows.Forms.Timer lblUpdateTimer;
    }
}
