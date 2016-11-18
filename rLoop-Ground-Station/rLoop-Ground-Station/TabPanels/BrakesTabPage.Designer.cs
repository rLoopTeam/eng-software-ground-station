namespace rLoop_Ground_Station.TabPanels
{
    partial class BrakesTabPage
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
            this.lblBrakesHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLeftScrewPosition = new System.Windows.Forms.Label();
            this.lblRightScrewPosition = new System.Windows.Forms.Label();
            this.lblRightIBeamDistVal = new System.Windows.Forms.Label();
            this.lblRightScrewPositionVal = new System.Windows.Forms.Label();
            this.lblRightIBeamDist = new System.Windows.Forms.Label();
            this.lblLeftIBeamDistVal = new System.Windows.Forms.Label();
            this.lblLeftExtendLimit = new System.Windows.Forms.Label();
            this.lblRightRetractLimitVal = new System.Windows.Forms.Label();
            this.lblLeftIBeamDist = new System.Windows.Forms.Label();
            this.lblLeftExtendLimitVal = new System.Windows.Forms.Label();
            this.lblLeftRetractLimitVal = new System.Windows.Forms.Label();
            this.lblRightExtendLimit = new System.Windows.Forms.Label();
            this.lblRightRetractLimit = new System.Windows.Forms.Label();
            this.lblRightExtendLimitVal = new System.Windows.Forms.Label();
            this.lblLeftRetractLimit = new System.Windows.Forms.Label();
            this.lblLeftScrewPositionVal = new System.Windows.Forms.Label();
            this.lblLeftMLPADCRaw = new System.Windows.Forms.Label();
            this.lblRightMLPADCRaw = new System.Windows.Forms.Label();
            this.lblLeftMLPScaled = new System.Windows.Forms.Label();
            this.lblRightMLPScaled = new System.Windows.Forms.Label();
            this.lblLeftMLPADCRawVal = new System.Windows.Forms.Label();
            this.lblRightMLPADCRawVal = new System.Windows.Forms.Label();
            this.lblLeftMLPScaledVal = new System.Windows.Forms.Label();
            this.lblRightMLPScaledVal = new System.Windows.Forms.Label();
            this.comboBrakeParameters = new System.Windows.Forms.ComboBox();
            this.txtBrakeParameter = new System.Windows.Forms.TextBox();
            this.btnBrakeParameter = new System.Windows.Forms.Button();
            this.lblSetIBeamDist = new System.Windows.Forms.Label();
            this.txtIBeamDist = new System.Windows.Forms.TextBox();
            this.lblmmunits = new System.Windows.Forms.Label();
            this.btnSetIBeamDist = new System.Windows.Forms.Button();
            this.updateTmr = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrakesHeading
            // 
            this.lblBrakesHeading.AutoSize = true;
            this.lblBrakesHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrakesHeading.ForeColor = System.Drawing.Color.White;
            this.lblBrakesHeading.Location = new System.Drawing.Point(242, 42);
            this.lblBrakesHeading.Name = "lblBrakesHeading";
            this.lblBrakesHeading.Size = new System.Drawing.Size(174, 55);
            this.lblBrakesHeading.TabIndex = 278;
            this.lblBrakesHeading.Text = "Brakes";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.38283F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.61717F));
            this.tableLayoutPanel2.Controls.Add(this.lblLeftScrewPosition, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblRightScrewPosition, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblRightIBeamDistVal, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblRightScrewPositionVal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblRightIBeamDist, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftIBeamDistVal, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftExtendLimit, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblRightRetractLimitVal, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftIBeamDist, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftExtendLimitVal, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftRetractLimitVal, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblRightExtendLimit, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblRightRetractLimit, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblRightExtendLimitVal, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftRetractLimit, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftScrewPositionVal, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftMLPADCRaw, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.lblRightMLPADCRaw, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftMLPScaled, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.lblRightMLPScaled, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftMLPADCRawVal, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.lblRightMLPADCRawVal, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftMLPScaledVal, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.lblRightMLPScaledVal, 1, 13);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(86, 120);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 16;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(559, 713);
            this.tableLayoutPanel2.TabIndex = 279;
            // 
            // lblLeftScrewPosition
            // 
            this.lblLeftScrewPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftScrewPosition.AutoSize = true;
            this.lblLeftScrewPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftScrewPosition.ForeColor = System.Drawing.Color.White;
            this.lblLeftScrewPosition.Location = new System.Drawing.Point(3, 25);
            this.lblLeftScrewPosition.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblLeftScrewPosition.Name = "lblLeftScrewPosition";
            this.lblLeftScrewPosition.Size = new System.Drawing.Size(264, 33);
            this.lblLeftScrewPosition.TabIndex = 243;
            this.lblLeftScrewPosition.Text = "Left Screw Position";
            // 
            // lblRightScrewPosition
            // 
            this.lblRightScrewPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightScrewPosition.AutoSize = true;
            this.lblRightScrewPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightScrewPosition.ForeColor = System.Drawing.Color.White;
            this.lblRightScrewPosition.Location = new System.Drawing.Point(3, 68);
            this.lblRightScrewPosition.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblRightScrewPosition.Name = "lblRightScrewPosition";
            this.lblRightScrewPosition.Size = new System.Drawing.Size(284, 33);
            this.lblRightScrewPosition.TabIndex = 244;
            this.lblRightScrewPosition.Text = "Right Screw Position";
            // 
            // lblRightIBeamDistVal
            // 
            this.lblRightIBeamDistVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightIBeamDistVal.AutoSize = true;
            this.lblRightIBeamDistVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightIBeamDistVal.ForeColor = System.Drawing.Color.White;
            this.lblRightIBeamDistVal.Location = new System.Drawing.Point(314, 326);
            this.lblRightIBeamDistVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblRightIBeamDistVal.Name = "lblRightIBeamDistVal";
            this.lblRightIBeamDistVal.Size = new System.Drawing.Size(145, 33);
            this.lblRightIBeamDistVal.TabIndex = 258;
            this.lblRightIBeamDistVal.Text = "20.23 mm";
            // 
            // lblRightScrewPositionVal
            // 
            this.lblRightScrewPositionVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightScrewPositionVal.AutoSize = true;
            this.lblRightScrewPositionVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightScrewPositionVal.ForeColor = System.Drawing.Color.White;
            this.lblRightScrewPositionVal.Location = new System.Drawing.Point(314, 68);
            this.lblRightScrewPositionVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblRightScrewPositionVal.Name = "lblRightScrewPositionVal";
            this.lblRightScrewPositionVal.Size = new System.Drawing.Size(145, 33);
            this.lblRightScrewPositionVal.TabIndex = 252;
            this.lblRightScrewPositionVal.Text = "20.33 mm";
            // 
            // lblRightIBeamDist
            // 
            this.lblRightIBeamDist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightIBeamDist.AutoSize = true;
            this.lblRightIBeamDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightIBeamDist.ForeColor = System.Drawing.Color.White;
            this.lblRightIBeamDist.Location = new System.Drawing.Point(3, 326);
            this.lblRightIBeamDist.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblRightIBeamDist.Name = "lblRightIBeamDist";
            this.lblRightIBeamDist.Size = new System.Drawing.Size(244, 33);
            this.lblRightIBeamDist.TabIndex = 250;
            this.lblRightIBeamDist.Text = "Right I-Beam Dist";
            // 
            // lblLeftIBeamDistVal
            // 
            this.lblLeftIBeamDistVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftIBeamDistVal.AutoSize = true;
            this.lblLeftIBeamDistVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftIBeamDistVal.ForeColor = System.Drawing.Color.White;
            this.lblLeftIBeamDistVal.Location = new System.Drawing.Point(314, 283);
            this.lblLeftIBeamDistVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblLeftIBeamDistVal.Name = "lblLeftIBeamDistVal";
            this.lblLeftIBeamDistVal.Size = new System.Drawing.Size(145, 33);
            this.lblLeftIBeamDistVal.TabIndex = 257;
            this.lblLeftIBeamDistVal.Text = "20.23 mm";
            // 
            // lblLeftExtendLimit
            // 
            this.lblLeftExtendLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftExtendLimit.AutoSize = true;
            this.lblLeftExtendLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftExtendLimit.ForeColor = System.Drawing.Color.White;
            this.lblLeftExtendLimit.Location = new System.Drawing.Point(3, 111);
            this.lblLeftExtendLimit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblLeftExtendLimit.Name = "lblLeftExtendLimit";
            this.lblLeftExtendLimit.Size = new System.Drawing.Size(232, 33);
            this.lblLeftExtendLimit.TabIndex = 245;
            this.lblLeftExtendLimit.Text = "Left Extend Limit";
            // 
            // lblRightRetractLimitVal
            // 
            this.lblRightRetractLimitVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightRetractLimitVal.AutoSize = true;
            this.lblRightRetractLimitVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightRetractLimitVal.ForeColor = System.Drawing.Color.White;
            this.lblRightRetractLimitVal.Location = new System.Drawing.Point(314, 240);
            this.lblRightRetractLimitVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblRightRetractLimitVal.Name = "lblRightRetractLimitVal";
            this.lblRightRetractLimitVal.Size = new System.Drawing.Size(86, 33);
            this.lblRightRetractLimitVal.TabIndex = 256;
            this.lblRightRetractLimitVal.Text = "Open";
            // 
            // lblLeftIBeamDist
            // 
            this.lblLeftIBeamDist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftIBeamDist.AutoSize = true;
            this.lblLeftIBeamDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftIBeamDist.ForeColor = System.Drawing.Color.White;
            this.lblLeftIBeamDist.Location = new System.Drawing.Point(3, 283);
            this.lblLeftIBeamDist.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblLeftIBeamDist.Name = "lblLeftIBeamDist";
            this.lblLeftIBeamDist.Size = new System.Drawing.Size(224, 33);
            this.lblLeftIBeamDist.TabIndex = 249;
            this.lblLeftIBeamDist.Text = "Left I-Beam Dist";
            // 
            // lblLeftExtendLimitVal
            // 
            this.lblLeftExtendLimitVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftExtendLimitVal.AutoSize = true;
            this.lblLeftExtendLimitVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftExtendLimitVal.ForeColor = System.Drawing.Color.White;
            this.lblLeftExtendLimitVal.Location = new System.Drawing.Point(314, 111);
            this.lblLeftExtendLimitVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblLeftExtendLimitVal.Name = "lblLeftExtendLimitVal";
            this.lblLeftExtendLimitVal.Size = new System.Drawing.Size(106, 33);
            this.lblLeftExtendLimitVal.TabIndex = 253;
            this.lblLeftExtendLimitVal.Text = "Closed";
            // 
            // lblLeftRetractLimitVal
            // 
            this.lblLeftRetractLimitVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftRetractLimitVal.AutoSize = true;
            this.lblLeftRetractLimitVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftRetractLimitVal.ForeColor = System.Drawing.Color.White;
            this.lblLeftRetractLimitVal.Location = new System.Drawing.Point(314, 197);
            this.lblLeftRetractLimitVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblLeftRetractLimitVal.Name = "lblLeftRetractLimitVal";
            this.lblLeftRetractLimitVal.Size = new System.Drawing.Size(86, 33);
            this.lblLeftRetractLimitVal.TabIndex = 255;
            this.lblLeftRetractLimitVal.Text = "Open";
            // 
            // lblRightExtendLimit
            // 
            this.lblRightExtendLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightExtendLimit.AutoSize = true;
            this.lblRightExtendLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightExtendLimit.ForeColor = System.Drawing.Color.White;
            this.lblRightExtendLimit.Location = new System.Drawing.Point(3, 154);
            this.lblRightExtendLimit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblRightExtendLimit.Name = "lblRightExtendLimit";
            this.lblRightExtendLimit.Size = new System.Drawing.Size(252, 33);
            this.lblRightExtendLimit.TabIndex = 246;
            this.lblRightExtendLimit.Text = "Right Extend Limit";
            // 
            // lblRightRetractLimit
            // 
            this.lblRightRetractLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightRetractLimit.AutoSize = true;
            this.lblRightRetractLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightRetractLimit.ForeColor = System.Drawing.Color.White;
            this.lblRightRetractLimit.Location = new System.Drawing.Point(3, 240);
            this.lblRightRetractLimit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblRightRetractLimit.Name = "lblRightRetractLimit";
            this.lblRightRetractLimit.Size = new System.Drawing.Size(256, 33);
            this.lblRightRetractLimit.TabIndex = 248;
            this.lblRightRetractLimit.Text = "Right Retract Limit";
            // 
            // lblRightExtendLimitVal
            // 
            this.lblRightExtendLimitVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightExtendLimitVal.AutoSize = true;
            this.lblRightExtendLimitVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightExtendLimitVal.ForeColor = System.Drawing.Color.White;
            this.lblRightExtendLimitVal.Location = new System.Drawing.Point(314, 154);
            this.lblRightExtendLimitVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblRightExtendLimitVal.Name = "lblRightExtendLimitVal";
            this.lblRightExtendLimitVal.Size = new System.Drawing.Size(106, 33);
            this.lblRightExtendLimitVal.TabIndex = 254;
            this.lblRightExtendLimitVal.Text = "Closed";
            // 
            // lblLeftRetractLimit
            // 
            this.lblLeftRetractLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftRetractLimit.AutoSize = true;
            this.lblLeftRetractLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftRetractLimit.ForeColor = System.Drawing.Color.White;
            this.lblLeftRetractLimit.Location = new System.Drawing.Point(3, 197);
            this.lblLeftRetractLimit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblLeftRetractLimit.Name = "lblLeftRetractLimit";
            this.lblLeftRetractLimit.Size = new System.Drawing.Size(236, 33);
            this.lblLeftRetractLimit.TabIndex = 247;
            this.lblLeftRetractLimit.Text = "Left Retract Limit";
            // 
            // lblLeftScrewPositionVal
            // 
            this.lblLeftScrewPositionVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftScrewPositionVal.AutoSize = true;
            this.lblLeftScrewPositionVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftScrewPositionVal.ForeColor = System.Drawing.Color.White;
            this.lblLeftScrewPositionVal.Location = new System.Drawing.Point(314, 25);
            this.lblLeftScrewPositionVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblLeftScrewPositionVal.Name = "lblLeftScrewPositionVal";
            this.lblLeftScrewPositionVal.Size = new System.Drawing.Size(145, 33);
            this.lblLeftScrewPositionVal.TabIndex = 251;
            this.lblLeftScrewPositionVal.Text = "20.33 mm";
            // 
            // lblLeftMLPADCRaw
            // 
            this.lblLeftMLPADCRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftMLPADCRaw.AutoSize = true;
            this.lblLeftMLPADCRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftMLPADCRaw.ForeColor = System.Drawing.Color.White;
            this.lblLeftMLPADCRaw.Location = new System.Drawing.Point(3, 369);
            this.lblLeftMLPADCRaw.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblLeftMLPADCRaw.Name = "lblLeftMLPADCRaw";
            this.lblLeftMLPADCRaw.Size = new System.Drawing.Size(265, 33);
            this.lblLeftMLPADCRaw.TabIndex = 250;
            this.lblLeftMLPADCRaw.Text = "Left MLP ADC Raw";
            // 
            // lblRightMLPADCRaw
            // 
            this.lblRightMLPADCRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightMLPADCRaw.AutoSize = true;
            this.lblRightMLPADCRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightMLPADCRaw.ForeColor = System.Drawing.Color.White;
            this.lblRightMLPADCRaw.Location = new System.Drawing.Point(3, 412);
            this.lblRightMLPADCRaw.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblRightMLPADCRaw.Name = "lblRightMLPADCRaw";
            this.lblRightMLPADCRaw.Size = new System.Drawing.Size(285, 33);
            this.lblRightMLPADCRaw.TabIndex = 250;
            this.lblRightMLPADCRaw.Text = "Right MLP ADC Raw";
            // 
            // lblLeftMLPScaled
            // 
            this.lblLeftMLPScaled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftMLPScaled.AutoSize = true;
            this.lblLeftMLPScaled.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftMLPScaled.ForeColor = System.Drawing.Color.White;
            this.lblLeftMLPScaled.Location = new System.Drawing.Point(3, 455);
            this.lblLeftMLPScaled.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblLeftMLPScaled.Name = "lblLeftMLPScaled";
            this.lblLeftMLPScaled.Size = new System.Drawing.Size(227, 33);
            this.lblLeftMLPScaled.TabIndex = 250;
            this.lblLeftMLPScaled.Text = "Left MLP Scaled";
            // 
            // lblRightMLPScaled
            // 
            this.lblRightMLPScaled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightMLPScaled.AutoSize = true;
            this.lblRightMLPScaled.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightMLPScaled.ForeColor = System.Drawing.Color.White;
            this.lblRightMLPScaled.Location = new System.Drawing.Point(3, 498);
            this.lblRightMLPScaled.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblRightMLPScaled.Name = "lblRightMLPScaled";
            this.lblRightMLPScaled.Size = new System.Drawing.Size(247, 33);
            this.lblRightMLPScaled.TabIndex = 250;
            this.lblRightMLPScaled.Text = "Right MLP Scaled";
            // 
            // lblLeftMLPADCRawVal
            // 
            this.lblLeftMLPADCRawVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftMLPADCRawVal.AutoSize = true;
            this.lblLeftMLPADCRawVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftMLPADCRawVal.ForeColor = System.Drawing.Color.White;
            this.lblLeftMLPADCRawVal.Location = new System.Drawing.Point(314, 369);
            this.lblLeftMLPADCRawVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblLeftMLPADCRawVal.Name = "lblLeftMLPADCRawVal";
            this.lblLeftMLPADCRawVal.Size = new System.Drawing.Size(95, 33);
            this.lblLeftMLPADCRawVal.TabIndex = 258;
            this.lblLeftMLPADCRawVal.Text = "25625";
            // 
            // lblRightMLPADCRawVal
            // 
            this.lblRightMLPADCRawVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightMLPADCRawVal.AutoSize = true;
            this.lblRightMLPADCRawVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightMLPADCRawVal.ForeColor = System.Drawing.Color.White;
            this.lblRightMLPADCRawVal.Location = new System.Drawing.Point(314, 412);
            this.lblRightMLPADCRawVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblRightMLPADCRawVal.Name = "lblRightMLPADCRawVal";
            this.lblRightMLPADCRawVal.Size = new System.Drawing.Size(95, 33);
            this.lblRightMLPADCRawVal.TabIndex = 258;
            this.lblRightMLPADCRawVal.Text = "25625";
            // 
            // lblLeftMLPScaledVal
            // 
            this.lblLeftMLPScaledVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeftMLPScaledVal.AutoSize = true;
            this.lblLeftMLPScaledVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftMLPScaledVal.ForeColor = System.Drawing.Color.White;
            this.lblLeftMLPScaledVal.Location = new System.Drawing.Point(314, 455);
            this.lblLeftMLPScaledVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblLeftMLPScaledVal.Name = "lblLeftMLPScaledVal";
            this.lblLeftMLPScaledVal.Size = new System.Drawing.Size(145, 33);
            this.lblLeftMLPScaledVal.TabIndex = 258;
            this.lblLeftMLPScaledVal.Text = "10.32 mm";
            // 
            // lblRightMLPScaledVal
            // 
            this.lblRightMLPScaledVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRightMLPScaledVal.AutoSize = true;
            this.lblRightMLPScaledVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightMLPScaledVal.ForeColor = System.Drawing.Color.White;
            this.lblRightMLPScaledVal.Location = new System.Drawing.Point(314, 498);
            this.lblRightMLPScaledVal.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblRightMLPScaledVal.Name = "lblRightMLPScaledVal";
            this.lblRightMLPScaledVal.Size = new System.Drawing.Size(145, 33);
            this.lblRightMLPScaledVal.TabIndex = 258;
            this.lblRightMLPScaledVal.Text = "10.32 mm";
            // 
            // comboBrakeParameters
            // 
            this.comboBrakeParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBrakeParameters.FormattingEnabled = true;
            this.comboBrakeParameters.Items.AddRange(new object[] {
            "Left - micro-steps per revolution",
            "Left - max acceleration, microns / sec^2",
            "Left - Linear Microns per revolution",
            "Left - Steps per revolution",
            "Left - Max Angluar Velocity",
            "Right - micro-steps per revolution",
            "Right - max acceleration, microns / sec^2",
            "Right - Linear Microns per revolution",
            "Right - Steps per revolution",
            "Right - Max Angluar Velocity"});
            this.comboBrakeParameters.Location = new System.Drawing.Point(770, 137);
            this.comboBrakeParameters.Name = "comboBrakeParameters";
            this.comboBrakeParameters.Size = new System.Drawing.Size(626, 41);
            this.comboBrakeParameters.TabIndex = 280;
            this.comboBrakeParameters.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBrakeParameter
            // 
            this.txtBrakeParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrakeParameter.Location = new System.Drawing.Point(770, 200);
            this.txtBrakeParameter.Name = "txtBrakeParameter";
            this.txtBrakeParameter.Size = new System.Drawing.Size(626, 40);
            this.txtBrakeParameter.TabIndex = 281;
            this.txtBrakeParameter.Text = "random value";
            // 
            // btnBrakeParameter
            // 
            this.btnBrakeParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrakeParameter.Location = new System.Drawing.Point(949, 258);
            this.btnBrakeParameter.Name = "btnBrakeParameter";
            this.btnBrakeParameter.Size = new System.Drawing.Size(303, 76);
            this.btnBrakeParameter.TabIndex = 282;
            this.btnBrakeParameter.Text = "Set Parameter";
            this.btnBrakeParameter.UseVisualStyleBackColor = true;
            this.btnBrakeParameter.Click += new System.EventHandler(this.btnBrakeParameter_Click);
            // 
            // lblSetIBeamDist
            // 
            this.lblSetIBeamDist.AutoSize = true;
            this.lblSetIBeamDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetIBeamDist.ForeColor = System.Drawing.Color.White;
            this.lblSetIBeamDist.Location = new System.Drawing.Point(962, 446);
            this.lblSetIBeamDist.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblSetIBeamDist.Name = "lblSetIBeamDist";
            this.lblSetIBeamDist.Size = new System.Drawing.Size(282, 33);
            this.lblSetIBeamDist.TabIndex = 244;
            this.lblSetIBeamDist.Text = "Set I-Beam Distance";
            // 
            // txtIBeamDist
            // 
            this.txtIBeamDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIBeamDist.Location = new System.Drawing.Point(963, 498);
            this.txtIBeamDist.Name = "txtIBeamDist";
            this.txtIBeamDist.Size = new System.Drawing.Size(223, 40);
            this.txtIBeamDist.TabIndex = 283;
            this.txtIBeamDist.Text = "0 ... 25";
            // 
            // lblmmunits
            // 
            this.lblmmunits.AutoSize = true;
            this.lblmmunits.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmmunits.ForeColor = System.Drawing.Color.White;
            this.lblmmunits.Location = new System.Drawing.Point(1196, 503);
            this.lblmmunits.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblmmunits.Name = "lblmmunits";
            this.lblmmunits.Size = new System.Drawing.Size(65, 33);
            this.lblmmunits.TabIndex = 244;
            this.lblmmunits.Text = "mm";
            // 
            // btnSetIBeamDist
            // 
            this.btnSetIBeamDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetIBeamDist.Location = new System.Drawing.Point(958, 567);
            this.btnSetIBeamDist.Name = "btnSetIBeamDist";
            this.btnSetIBeamDist.Size = new System.Drawing.Size(303, 76);
            this.btnSetIBeamDist.TabIndex = 282;
            this.btnSetIBeamDist.Text = "Set Parameter";
            this.btnSetIBeamDist.UseVisualStyleBackColor = true;
            this.btnSetIBeamDist.Click += new System.EventHandler(this.btnSetIBeamDist_Click);
            // 
            // updateTmr
            // 
            this.updateTmr.Enabled = true;
            this.updateTmr.Tick += new System.EventHandler(this.updateTmr_Tick);
            // 
            // BrakesTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.txtIBeamDist);
            this.Controls.Add(this.lblmmunits);
            this.Controls.Add(this.btnSetIBeamDist);
            this.Controls.Add(this.btnBrakeParameter);
            this.Controls.Add(this.lblSetIBeamDist);
            this.Controls.Add(this.txtBrakeParameter);
            this.Controls.Add(this.comboBrakeParameters);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblBrakesHeading);
            this.Name = "BrakesTabPage";
            this.Size = new System.Drawing.Size(1480, 928);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBrakesHeading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblLeftScrewPosition;
        private System.Windows.Forms.Label lblRightScrewPosition;
        private System.Windows.Forms.Label lblRightIBeamDistVal;
        private System.Windows.Forms.Label lblRightScrewPositionVal;
        private System.Windows.Forms.Label lblRightIBeamDist;
        private System.Windows.Forms.Label lblLeftIBeamDistVal;
        private System.Windows.Forms.Label lblLeftExtendLimit;
        private System.Windows.Forms.Label lblRightRetractLimitVal;
        private System.Windows.Forms.Label lblLeftIBeamDist;
        private System.Windows.Forms.Label lblLeftExtendLimitVal;
        private System.Windows.Forms.Label lblLeftRetractLimitVal;
        private System.Windows.Forms.Label lblRightExtendLimit;
        private System.Windows.Forms.Label lblRightRetractLimit;
        private System.Windows.Forms.Label lblLeftRetractLimit;
        private System.Windows.Forms.Label lblLeftScrewPositionVal;
        private System.Windows.Forms.Label lblLeftMLPADCRaw;
        private System.Windows.Forms.Label lblRightMLPADCRaw;
        private System.Windows.Forms.Label lblLeftMLPScaled;
        private System.Windows.Forms.Label lblRightMLPScaled;
        private System.Windows.Forms.Label lblLeftMLPADCRawVal;
        private System.Windows.Forms.Label lblRightMLPADCRawVal;
        private System.Windows.Forms.Label lblLeftMLPScaledVal;
        private System.Windows.Forms.Label lblRightMLPScaledVal;
        private System.Windows.Forms.ComboBox comboBrakeParameters;
        private System.Windows.Forms.TextBox txtBrakeParameter;
        private System.Windows.Forms.Button btnBrakeParameter;
        private System.Windows.Forms.Label lblSetIBeamDist;
        private System.Windows.Forms.TextBox txtIBeamDist;
        private System.Windows.Forms.Label lblmmunits;
        private System.Windows.Forms.Button btnSetIBeamDist;
        private System.Windows.Forms.Label lblRightExtendLimitVal;
        private System.Windows.Forms.Timer updateTmr;
    }
}
