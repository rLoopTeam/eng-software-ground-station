namespace rLoop_Ground_Station
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
            this.HEguiDemo = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UpdateNodeList = new System.Windows.Forms.Timer(this.components);
            this.UpdateDGVTimer = new System.Windows.Forms.Timer(this.components);
            this.BatteryPackAStatusTab = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateNodeUtilStats = new System.Windows.Forms.Timer(this.components);
            this.customTabControl1 = new System.Windows.Forms.CustomTabControl();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PowerNodeATab = new System.Windows.Forms.TabPage();
            this.customTabControl2 = new System.Windows.Forms.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BrakesAPackTemperature = new System.Windows.Forms.Label();
            this.BrakesAPackVoltage = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PowerNodeBTab = new System.Windows.Forms.TabPage();
            this.auxPropTab = new System.Windows.Forms.TabPage();
            this.NodeUtilitiesTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.testDataType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sendTestData = new System.Windows.Forms.Button();
            this.testDataIndexTxt = new System.Windows.Forms.TextBox();
            this.testDataToSendTxt = new System.Windows.Forms.TextBox();
            this.txtNewBaud = new System.Windows.Forms.TextBox();
            this.btnStopDataLogging = new System.Windows.Forms.Button();
            this.btnStartDataLogging = new System.Windows.Forms.Button();
            this.btnNewBaudRate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSelectedNodeTime = new System.Windows.Forms.Label();
            this.lblSelectedNodeDataLogging = new System.Windows.Forms.Label();
            this.lblSelectedNodeIp = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SerialConsoleTab = new System.Windows.Forms.TabPage();
            this.testTab = new System.Windows.Forms.TabPage();
            this.label51 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.txtEBRightSpeedCommand = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.txtEBLeftSpeedCommand = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.txtEBRightDirCommand = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.txtEBLeftDirCommand = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.lblEBRightDistanceBeam = new System.Windows.Forms.Label();
            this.lblEBLeftDistanceBeam = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.lblEBRightMLP = new System.Windows.Forms.Label();
            this.lblEBLeftMLP = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblOperatingMode = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtFt2DirectionCommand = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.txtFt1DirectionCommand = new System.Windows.Forms.TextBox();
            this.lblAcceleration = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblYaw = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lblYCG = new System.Windows.Forms.Label();
            this.lblXCG = new System.Windows.Forms.Label();
            this.lblCGHeight = new System.Windows.Forms.Label();
            this.lblRightMLP = new System.Windows.Forms.Label();
            this.lblLeftMLP = new System.Windows.Forms.Label();
            this.lblEBRightLimitSwitch = new System.Windows.Forms.Label();
            this.lblEBLeftLimitSwitch = new System.Windows.Forms.Label();
            this.lblIBDS2Value = new System.Windows.Forms.Label();
            this.lblIBDS1Value = new System.Windows.Forms.Label();
            this.lblS4Value = new System.Windows.Forms.Label();
            this.lblS3Value = new System.Windows.Forms.Label();
            this.lblS2Value = new System.Windows.Forms.Label();
            this.lblS1Value = new System.Windows.Forms.Label();
            this.lblHDS4Value = new System.Windows.Forms.Label();
            this.lblHDS3Value = new System.Windows.Forms.Label();
            this.lblHDS2Value = new System.Windows.Forms.Label();
            this.lblHDS1Value = new System.Windows.Forms.Label();
            this.lblAuxPropEnabled = new System.Windows.Forms.Label();
            this.lblLMForward2MLP = new System.Windows.Forms.Label();
            this.lblLMForward1MLP = new System.Windows.Forms.Label();
            this.lblLMFT2MLP = new System.Windows.Forms.Label();
            this.lblFT1MLP = new System.Windows.Forms.Label();
            this.lblLMForwardLimitSwitch2 = new System.Windows.Forms.Label();
            this.lblLMForwardLimitSwitch1 = new System.Windows.Forms.Label();
            this.lblLMLimitSwitch2 = new System.Windows.Forms.Label();
            this.lblLMLimitSwitch1 = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAllPodStop = new System.Windows.Forms.Button();
            this.TESTTabTimer = new System.Windows.Forms.Timer(this.components);
            this.podStateControl2 = new rLoop_Ground_Station.PodStateControl();
            this.rPodSpeedometer1 = new rLoop_Ground_Station.rPodSpeedometer();
            this.rPodGyro1 = new rLoop_Ground_Station.rPodGyro();
            this.rPodCurrentGauge2 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodCurrentGauge();
            this.rPodBatteryIndicator1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodBatteryVoltage();
            this.rPodCurrentGauge1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodCurrentGauge();
            this.rPodBatteryVoltage1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodBatteryVoltage();
            this.customTabControl1.SuspendLayout();
            this.OverviewTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.PowerNodeATab.SuspendLayout();
            this.customTabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.NodeUtilitiesTab.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.testTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // HEguiDemo
            // 
            this.HEguiDemo.Enabled = true;
            this.HEguiDemo.Interval = 50;
            this.HEguiDemo.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // UpdateNodeList
            // 
            this.UpdateNodeList.Enabled = true;
            this.UpdateNodeList.Interval = 2000;
            this.UpdateNodeList.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UpdateDGVTimer
            // 
            this.UpdateDGVTimer.Enabled = true;
            this.UpdateDGVTimer.Interval = 50;
            this.UpdateDGVTimer.Tick += new System.EventHandler(this.UpdateDGVTimer_Tick);
            // 
            // BatteryPackAStatusTab
            // 
            this.BatteryPackAStatusTab.Enabled = true;
            this.BatteryPackAStatusTab.Interval = 200;
            this.BatteryPackAStatusTab.Tick += new System.EventHandler(this.BatteryPackAStatusTab_Tick);
            // 
            // tmrUpdateNodeUtilStats
            // 
            this.tmrUpdateNodeUtilStats.Enabled = true;
            this.tmrUpdateNodeUtilStats.Interval = 1000;
            this.tmrUpdateNodeUtilStats.Tick += new System.EventHandler(this.tmrUpdateNodeUtilStats_Tick);
            // 
            // customTabControl1
            // 
            this.customTabControl1.Controls.Add(this.OverviewTab);
            this.customTabControl1.Controls.Add(this.PowerNodeATab);
            this.customTabControl1.Controls.Add(this.PowerNodeBTab);
            this.customTabControl1.Controls.Add(this.auxPropTab);
            this.customTabControl1.Controls.Add(this.NodeUtilitiesTab);
            this.customTabControl1.Controls.Add(this.SerialConsoleTab);
            this.customTabControl1.Controls.Add(this.testTab);
            this.customTabControl1.DisplayStyle = System.Windows.Forms.TabStyle.VS2010;
            // 
            // 
            // 
            this.customTabControl1.DisplayStyleProvider.BorderColor = System.Drawing.Color.Transparent;
            this.customTabControl1.DisplayStyleProvider.BorderColorHot = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.customTabControl1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.customTabControl1.DisplayStyleProvider.CloserColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.customTabControl1.DisplayStyleProvider.FocusTrack = false;
            this.customTabControl1.DisplayStyleProvider.HotTrack = true;
            this.customTabControl1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customTabControl1.DisplayStyleProvider.Opacity = 1F;
            this.customTabControl1.DisplayStyleProvider.Overlap = 0;
            this.customTabControl1.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 5);
            this.customTabControl1.DisplayStyleProvider.Radius = 3;
            this.customTabControl1.DisplayStyleProvider.ShowTabCloser = false;
            this.customTabControl1.DisplayStyleProvider.TextColor = System.Drawing.Color.White;
            this.customTabControl1.DisplayStyleProvider.TextColorDisabled = System.Drawing.Color.WhiteSmoke;
            this.customTabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.customTabControl1.HotTrack = true;
            this.customTabControl1.Location = new System.Drawing.Point(12, 12);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(1262, 695);
            this.customTabControl1.TabIndex = 13;
            // 
            // OverviewTab
            // 
            this.OverviewTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.OverviewTab.Controls.Add(this.panel1);
            this.OverviewTab.Controls.Add(this.panel2);
            this.OverviewTab.Location = new System.Drawing.Point(4, 27);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.OverviewTab.Size = new System.Drawing.Size(1254, 664);
            this.OverviewTab.TabIndex = 0;
            this.OverviewTab.Text = "Overview";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.podStateControl2);
            this.panel1.Controls.Add(this.rPodSpeedometer1);
            this.panel1.Controls.Add(this.rPodGyro1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 298);
            this.panel1.TabIndex = 12;
            // 
            // podStateControl2
            // 
            this.podStateControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podStateControl2.HE1Height = 12.23D;
            this.podStateControl2.HE1Percent = 0.8D;
            this.podStateControl2.HE1Power = 3000D;
            this.podStateControl2.HE1RPM = 3000D;
            this.podStateControl2.HE2Height = 12.2D;
            this.podStateControl2.HE2Percent = 0.8D;
            this.podStateControl2.HE2Power = 3000D;
            this.podStateControl2.HE2RPM = 3000D;
            this.podStateControl2.HE3Height = 12.2D;
            this.podStateControl2.HE3Percent = 0.8D;
            this.podStateControl2.HE3Power = 3000D;
            this.podStateControl2.HE3RPM = 3000D;
            this.podStateControl2.HE4Height = 12.2D;
            this.podStateControl2.HE4Percent = 0.8D;
            this.podStateControl2.HE4Power = 3000D;
            this.podStateControl2.HE4RPM = 3000D;
            this.podStateControl2.HE5Height = 12.2D;
            this.podStateControl2.HE5Percent = 0.8D;
            this.podStateControl2.HE5Power = 3000D;
            this.podStateControl2.HE5RPM = 3000D;
            this.podStateControl2.HE6Height = 12.2D;
            this.podStateControl2.HE6Percent = 0.8D;
            this.podStateControl2.HE6Power = 3000D;
            this.podStateControl2.HE6RPM = 3000D;
            this.podStateControl2.HE7Height = 12.2D;
            this.podStateControl2.HE7Percent = 0.8D;
            this.podStateControl2.HE7Power = 3000D;
            this.podStateControl2.HE7RPM = 3000D;
            this.podStateControl2.HE8Height = 12.2D;
            this.podStateControl2.HE8Percent = 0.8D;
            this.podStateControl2.HE8Power = 3000D;
            this.podStateControl2.HE8RPM = 3000D;
            this.podStateControl2.Location = new System.Drawing.Point(484, 0);
            this.podStateControl2.Margin = new System.Windows.Forms.Padding(6);
            this.podStateControl2.Name = "podStateControl2";
            this.podStateControl2.Size = new System.Drawing.Size(545, 298);
            this.podStateControl2.TabIndex = 0;
            // 
            // rPodSpeedometer1
            // 
            this.rPodSpeedometer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rPodSpeedometer1.Location = new System.Drawing.Point(0, 0);
            this.rPodSpeedometer1.Margin = new System.Windows.Forms.Padding(6);
            this.rPodSpeedometer1.Name = "rPodSpeedometer1";
            this.rPodSpeedometer1.Size = new System.Drawing.Size(484, 298);
            this.rPodSpeedometer1.TabIndex = 9;
            // 
            // rPodGyro1
            // 
            this.rPodGyro1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rPodGyro1.Location = new System.Drawing.Point(1029, 0);
            this.rPodGyro1.Margin = new System.Windows.Forms.Padding(6);
            this.rPodGyro1.Name = "rPodGyro1";
            this.rPodGyro1.Size = new System.Drawing.Size(219, 298);
            this.rPodGyro1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAllPodStop);
            this.panel2.Controls.Add(this.rPodCurrentGauge2);
            this.panel2.Controls.Add(this.rPodBatteryIndicator1);
            this.panel2.Controls.Add(this.rPodCurrentGauge1);
            this.panel2.Controls.Add(this.rPodBatteryVoltage1);
            this.panel2.Controls.Add(this.trackBar5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.trackBar4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.trackBar3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 360);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rPodCurrentGauge2
            // 
            this.rPodCurrentGauge2.Location = new System.Drawing.Point(208, 18);
            this.rPodCurrentGauge2.Margin = new System.Windows.Forms.Padding(6);
            this.rPodCurrentGauge2.Name = "rPodCurrentGauge2";
            this.rPodCurrentGauge2.Size = new System.Drawing.Size(142, 140);
            this.rPodCurrentGauge2.TabIndex = 13;
            // 
            // rPodBatteryIndicator1
            // 
            this.rPodBatteryIndicator1.Location = new System.Drawing.Point(208, 184);
            this.rPodBatteryIndicator1.Margin = new System.Windows.Forms.Padding(6);
            this.rPodBatteryIndicator1.Name = "rPodBatteryIndicator1";
            this.rPodBatteryIndicator1.Size = new System.Drawing.Size(142, 70);
            this.rPodBatteryIndicator1.TabIndex = 11;
            this.rPodBatteryIndicator1.Load += new System.EventHandler(this.rPodBatteryIndicator1_Load);
            // 
            // rPodCurrentGauge1
            // 
            this.rPodCurrentGauge1.Location = new System.Drawing.Point(23, 18);
            this.rPodCurrentGauge1.Margin = new System.Windows.Forms.Padding(6);
            this.rPodCurrentGauge1.Name = "rPodCurrentGauge1";
            this.rPodCurrentGauge1.Size = new System.Drawing.Size(142, 140);
            this.rPodCurrentGauge1.TabIndex = 12;
            // 
            // rPodBatteryVoltage1
            // 
            this.rPodBatteryVoltage1.Location = new System.Drawing.Point(23, 184);
            this.rPodBatteryVoltage1.Margin = new System.Windows.Forms.Padding(6);
            this.rPodBatteryVoltage1.Name = "rPodBatteryVoltage1";
            this.rPodBatteryVoltage1.Size = new System.Drawing.Size(142, 70);
            this.rPodBatteryVoltage1.TabIndex = 11;
            this.rPodBatteryVoltage1.Load += new System.EventHandler(this.rPodBatteryIndicator1_Load);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(751, 17);
            this.trackBar5.Maximum = 400;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(175, 45);
            this.trackBar5.TabIndex = 10;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(545, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height";
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(615, 198);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(298, 45);
            this.trackBar4.TabIndex = 4;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(545, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Power";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(615, 78);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(312, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(615, 117);
            this.trackBar2.Maximum = 4000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(312, 45);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(615, 159);
            this.trackBar3.Maximum = 5000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(298, 45);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(545, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RPM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(545, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Percent";
            // 
            // PowerNodeATab
            // 
            this.PowerNodeATab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.PowerNodeATab.Controls.Add(this.customTabControl2);
            this.PowerNodeATab.Location = new System.Drawing.Point(4, 27);
            this.PowerNodeATab.Name = "PowerNodeATab";
            this.PowerNodeATab.Padding = new System.Windows.Forms.Padding(3);
            this.PowerNodeATab.Size = new System.Drawing.Size(1254, 664);
            this.PowerNodeATab.TabIndex = 3;
            this.PowerNodeATab.Text = "Power A";
            // 
            // customTabControl2
            // 
            this.customTabControl2.Controls.Add(this.tabPage1);
            this.customTabControl2.Controls.Add(this.tabPage5);
            this.customTabControl2.Controls.Add(this.tabPage2);
            this.customTabControl2.Controls.Add(this.tabPage3);
            this.customTabControl2.Controls.Add(this.tabPage4);
            this.customTabControl2.DisplayStyle = System.Windows.Forms.TabStyle.VS2010;
            // 
            // 
            // 
            this.customTabControl2.DisplayStyleProvider.BorderColor = System.Drawing.Color.Transparent;
            this.customTabControl2.DisplayStyleProvider.BorderColorHot = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.customTabControl2.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.customTabControl2.DisplayStyleProvider.CloserColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.customTabControl2.DisplayStyleProvider.FocusTrack = false;
            this.customTabControl2.DisplayStyleProvider.HotTrack = true;
            this.customTabControl2.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customTabControl2.DisplayStyleProvider.Opacity = 1F;
            this.customTabControl2.DisplayStyleProvider.Overlap = 0;
            this.customTabControl2.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 5);
            this.customTabControl2.DisplayStyleProvider.Radius = 3;
            this.customTabControl2.DisplayStyleProvider.ShowTabCloser = false;
            this.customTabControl2.DisplayStyleProvider.TextColor = System.Drawing.Color.White;
            this.customTabControl2.DisplayStyleProvider.TextColorDisabled = System.Drawing.Color.WhiteSmoke;
            this.customTabControl2.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.customTabControl2.HotTrack = true;
            this.customTabControl2.ItemSize = new System.Drawing.Size(95, 22);
            this.customTabControl2.Location = new System.Drawing.Point(6, 6);
            this.customTabControl2.Name = "customTabControl2";
            this.customTabControl2.SelectedIndex = 0;
            this.customTabControl2.Size = new System.Drawing.Size(1253, 631);
            this.customTabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.BrakesAPackTemperature);
            this.tabPage1.Controls.Add(this.BrakesAPackVoltage);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Voltages";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(30, 30);
            this.flowLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(0, 50);
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 56);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1210, 554);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // BrakesAPackTemperature
            // 
            this.BrakesAPackTemperature.AutoSize = true;
            this.BrakesAPackTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrakesAPackTemperature.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BrakesAPackTemperature.Location = new System.Drawing.Point(368, 12);
            this.BrakesAPackTemperature.Name = "BrakesAPackTemperature";
            this.BrakesAPackTemperature.Size = new System.Drawing.Size(384, 37);
            this.BrakesAPackTemperature.TabIndex = 2;
            this.BrakesAPackTemperature.Text = "Temperature: 0.000 degC";
            // 
            // BrakesAPackVoltage
            // 
            this.BrakesAPackVoltage.AutoSize = true;
            this.BrakesAPackVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrakesAPackVoltage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BrakesAPackVoltage.Location = new System.Drawing.Point(17, 12);
            this.BrakesAPackVoltage.Name = "BrakesAPackVoltage";
            this.BrakesAPackVoltage.Size = new System.Drawing.Size(306, 37);
            this.BrakesAPackVoltage.TabIndex = 1;
            this.BrakesAPackVoltage.Text = "Voltage: 0.000 Volts";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1245, 600);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Charger";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1245, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BMS 1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1245, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BMS 2";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1245, 600);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "BMS 3";
            // 
            // PowerNodeBTab
            // 
            this.PowerNodeBTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.PowerNodeBTab.Location = new System.Drawing.Point(4, 27);
            this.PowerNodeBTab.Name = "PowerNodeBTab";
            this.PowerNodeBTab.Size = new System.Drawing.Size(1254, 664);
            this.PowerNodeBTab.TabIndex = 4;
            this.PowerNodeBTab.Text = "Power B";
            // 
            // auxPropTab
            // 
            this.auxPropTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.auxPropTab.Location = new System.Drawing.Point(4, 27);
            this.auxPropTab.Margin = new System.Windows.Forms.Padding(2);
            this.auxPropTab.Name = "auxPropTab";
            this.auxPropTab.Size = new System.Drawing.Size(1254, 664);
            this.auxPropTab.TabIndex = 5;
            this.auxPropTab.Text = "Aux propulsion";
            // 
            // NodeUtilitiesTab
            // 
            this.NodeUtilitiesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.NodeUtilitiesTab.Controls.Add(this.panel5);
            this.NodeUtilitiesTab.Controls.Add(this.panel4);
            this.NodeUtilitiesTab.Controls.Add(this.panel3);
            this.NodeUtilitiesTab.Location = new System.Drawing.Point(4, 27);
            this.NodeUtilitiesTab.Name = "NodeUtilitiesTab";
            this.NodeUtilitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.NodeUtilitiesTab.Size = new System.Drawing.Size(1254, 664);
            this.NodeUtilitiesTab.TabIndex = 1;
            this.NodeUtilitiesTab.Text = "Node Utilities";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 561);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1248, 100);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1248, 404);
            this.panel4.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.value,
            this.units,
            this.description});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 404);
            this.dataGridView1.TabIndex = 5;
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // units
            // 
            this.units.HeaderText = "Units";
            this.units.Name = "units";
            this.units.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.testDataType);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.sendTestData);
            this.panel3.Controls.Add(this.testDataIndexTxt);
            this.panel3.Controls.Add(this.testDataToSendTxt);
            this.panel3.Controls.Add(this.txtNewBaud);
            this.panel3.Controls.Add(this.btnStopDataLogging);
            this.panel3.Controls.Add(this.btnStartDataLogging);
            this.panel3.Controls.Add(this.btnNewBaudRate);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblSelectedNodeTime);
            this.panel3.Controls.Add(this.lblSelectedNodeDataLogging);
            this.panel3.Controls.Add(this.lblSelectedNodeIp);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1248, 254);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.testDataType.Location = new System.Drawing.Point(818, 144);
            this.testDataType.Name = "testDataType";
            this.testDataType.Size = new System.Drawing.Size(121, 21);
            this.testDataType.TabIndex = 12;
            this.testDataType.Text = "Data Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(651, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(513, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Index";
            // 
            // sendTestData
            // 
            this.sendTestData.Location = new System.Drawing.Point(740, 172);
            this.sendTestData.Name = "sendTestData";
            this.sendTestData.Size = new System.Drawing.Size(199, 23);
            this.sendTestData.TabIndex = 9;
            this.sendTestData.Text = "Set Parameter";
            this.sendTestData.UseVisualStyleBackColor = true;
            this.sendTestData.Click += new System.EventHandler(this.sendTestData_Click);
            // 
            // testDataIndexTxt
            // 
            this.testDataIndexTxt.Location = new System.Drawing.Point(499, 146);
            this.testDataIndexTxt.Name = "testDataIndexTxt";
            this.testDataIndexTxt.Size = new System.Drawing.Size(65, 20);
            this.testDataIndexTxt.TabIndex = 8;
            this.testDataIndexTxt.Text = "5";
            // 
            // testDataToSendTxt
            // 
            this.testDataToSendTxt.Location = new System.Drawing.Point(581, 146);
            this.testDataToSendTxt.Name = "testDataToSendTxt";
            this.testDataToSendTxt.Size = new System.Drawing.Size(222, 20);
            this.testDataToSendTxt.TabIndex = 7;
            this.testDataToSendTxt.Text = "3.14159";
            // 
            // txtNewBaud
            // 
            this.txtNewBaud.Location = new System.Drawing.Point(696, 50);
            this.txtNewBaud.Name = "txtNewBaud";
            this.txtNewBaud.Size = new System.Drawing.Size(143, 20);
            this.txtNewBaud.TabIndex = 6;
            this.txtNewBaud.Text = "57600";
            // 
            // btnStopDataLogging
            // 
            this.btnStopDataLogging.Location = new System.Drawing.Point(860, 87);
            this.btnStopDataLogging.Name = "btnStopDataLogging";
            this.btnStopDataLogging.Size = new System.Drawing.Size(143, 31);
            this.btnStopDataLogging.TabIndex = 5;
            this.btnStopDataLogging.Text = "Stop Data Logging";
            this.btnStopDataLogging.UseVisualStyleBackColor = true;
            this.btnStopDataLogging.Click += new System.EventHandler(this.btnStopDataLogging_Click);
            // 
            // btnStartDataLogging
            // 
            this.btnStartDataLogging.Location = new System.Drawing.Point(860, 50);
            this.btnStartDataLogging.Name = "btnStartDataLogging";
            this.btnStartDataLogging.Size = new System.Drawing.Size(143, 31);
            this.btnStartDataLogging.TabIndex = 5;
            this.btnStartDataLogging.Text = "Start Data Logging";
            this.btnStartDataLogging.UseVisualStyleBackColor = true;
            this.btnStartDataLogging.Click += new System.EventHandler(this.btnStartDataLogging_Click);
            // 
            // btnNewBaudRate
            // 
            this.btnNewBaudRate.Location = new System.Drawing.Point(696, 76);
            this.btnNewBaudRate.Name = "btnNewBaudRate";
            this.btnNewBaudRate.Size = new System.Drawing.Size(143, 31);
            this.btnNewBaudRate.TabIndex = 5;
            this.btnNewBaudRate.Text = "Change UART Baud";
            this.btnNewBaudRate.UseVisualStyleBackColor = true;
            this.btnNewBaudRate.Click += new System.EventHandler(this.btnNewBaudRate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(537, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "New Node Name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Change Node Name";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(90, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Discovered Nodes";
            // 
            // lblSelectedNodeTime
            // 
            this.lblSelectedNodeTime.AutoSize = true;
            this.lblSelectedNodeTime.ForeColor = System.Drawing.Color.White;
            this.lblSelectedNodeTime.Location = new System.Drawing.Point(380, 106);
            this.lblSelectedNodeTime.Name = "lblSelectedNodeTime";
            this.lblSelectedNodeTime.Size = new System.Drawing.Size(30, 13);
            this.lblSelectedNodeTime.TabIndex = 4;
            this.lblSelectedNodeTime.Text = "Time";
            // 
            // lblSelectedNodeDataLogging
            // 
            this.lblSelectedNodeDataLogging.AutoSize = true;
            this.lblSelectedNodeDataLogging.ForeColor = System.Drawing.Color.White;
            this.lblSelectedNodeDataLogging.Location = new System.Drawing.Point(380, 76);
            this.lblSelectedNodeDataLogging.Name = "lblSelectedNodeDataLogging";
            this.lblSelectedNodeDataLogging.Size = new System.Drawing.Size(65, 13);
            this.lblSelectedNodeDataLogging.TabIndex = 4;
            this.lblSelectedNodeDataLogging.Text = "data logging";
            // 
            // lblSelectedNodeIp
            // 
            this.lblSelectedNodeIp.AutoSize = true;
            this.lblSelectedNodeIp.ForeColor = System.Drawing.Color.White;
            this.lblSelectedNodeIp.Location = new System.Drawing.Point(380, 50);
            this.lblSelectedNodeIp.Name = "lblSelectedNodeIp";
            this.lblSelectedNodeIp.Size = new System.Drawing.Size(17, 13);
            this.lblSelectedNodeIp.TabIndex = 4;
            this.lblSelectedNodeIp.Text = "IP";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 147);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SerialConsoleTab
            // 
            this.SerialConsoleTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.SerialConsoleTab.Location = new System.Drawing.Point(4, 27);
            this.SerialConsoleTab.Name = "SerialConsoleTab";
            this.SerialConsoleTab.Padding = new System.Windows.Forms.Padding(3);
            this.SerialConsoleTab.Size = new System.Drawing.Size(1254, 664);
            this.SerialConsoleTab.TabIndex = 2;
            this.SerialConsoleTab.Text = "Console";
            // 
            // testTab
            // 
            this.testTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.testTab.Controls.Add(this.label51);
            this.testTab.Controls.Add(this.button13);
            this.testTab.Controls.Add(this.txtEBRightSpeedCommand);
            this.testTab.Controls.Add(this.label52);
            this.testTab.Controls.Add(this.button14);
            this.testTab.Controls.Add(this.txtEBLeftSpeedCommand);
            this.testTab.Controls.Add(this.label53);
            this.testTab.Controls.Add(this.button15);
            this.testTab.Controls.Add(this.txtEBRightDirCommand);
            this.testTab.Controls.Add(this.label54);
            this.testTab.Controls.Add(this.button16);
            this.testTab.Controls.Add(this.txtEBLeftDirCommand);
            this.testTab.Controls.Add(this.label69);
            this.testTab.Controls.Add(this.label68);
            this.testTab.Controls.Add(this.lblEBRightDistanceBeam);
            this.testTab.Controls.Add(this.lblEBLeftDistanceBeam);
            this.testTab.Controls.Add(this.label74);
            this.testTab.Controls.Add(this.label75);
            this.testTab.Controls.Add(this.lblEBRightMLP);
            this.testTab.Controls.Add(this.lblEBLeftMLP);
            this.testTab.Controls.Add(this.label63);
            this.testTab.Controls.Add(this.label64);
            this.testTab.Controls.Add(this.button12);
            this.testTab.Controls.Add(this.button11);
            this.testTab.Controls.Add(this.label49);
            this.testTab.Controls.Add(this.button9);
            this.testTab.Controls.Add(this.textBox6);
            this.testTab.Controls.Add(this.label50);
            this.testTab.Controls.Add(this.button10);
            this.testTab.Controls.Add(this.textBox7);
            this.testTab.Controls.Add(this.lblOperatingMode);
            this.testTab.Controls.Add(this.label47);
            this.testTab.Controls.Add(this.button7);
            this.testTab.Controls.Add(this.textBox4);
            this.testTab.Controls.Add(this.label48);
            this.testTab.Controls.Add(this.button8);
            this.testTab.Controls.Add(this.textBox5);
            this.testTab.Controls.Add(this.label45);
            this.testTab.Controls.Add(this.button5);
            this.testTab.Controls.Add(this.textBox2);
            this.testTab.Controls.Add(this.label46);
            this.testTab.Controls.Add(this.button6);
            this.testTab.Controls.Add(this.textBox3);
            this.testTab.Controls.Add(this.label37);
            this.testTab.Controls.Add(this.button4);
            this.testTab.Controls.Add(this.txtFt2DirectionCommand);
            this.testTab.Controls.Add(this.label29);
            this.testTab.Controls.Add(this.sendButton);
            this.testTab.Controls.Add(this.txtFt1DirectionCommand);
            this.testTab.Controls.Add(this.lblAcceleration);
            this.testTab.Controls.Add(this.lblSpeed);
            this.testTab.Controls.Add(this.lblYaw);
            this.testTab.Controls.Add(this.lblRoll);
            this.testTab.Controls.Add(this.lblPitch);
            this.testTab.Controls.Add(this.lblYCG);
            this.testTab.Controls.Add(this.lblXCG);
            this.testTab.Controls.Add(this.lblCGHeight);
            this.testTab.Controls.Add(this.lblEBRightLimitSwitch);
            this.testTab.Controls.Add(this.lblEBLeftLimitSwitch);
            this.testTab.Controls.Add(this.lblIBDS2Value);
            this.testTab.Controls.Add(this.lblIBDS1Value);
            this.testTab.Controls.Add(this.lblHDS4Value);
            this.testTab.Controls.Add(this.lblHDS3Value);
            this.testTab.Controls.Add(this.lblHDS2Value);
            this.testTab.Controls.Add(this.lblHDS1Value);
            this.testTab.Controls.Add(this.lblAuxPropEnabled);
            this.testTab.Controls.Add(this.lblLMForward2MLP);
            this.testTab.Controls.Add(this.lblLMForward1MLP);
            this.testTab.Controls.Add(this.lblLMFT2MLP);
            this.testTab.Controls.Add(this.lblFT1MLP);
            this.testTab.Controls.Add(this.lblLMForwardLimitSwitch2);
            this.testTab.Controls.Add(this.lblLMForwardLimitSwitch1);
            this.testTab.Controls.Add(this.lblLMLimitSwitch2);
            this.testTab.Controls.Add(this.lblLMLimitSwitch1);
            this.testTab.Controls.Add(this.acc);
            this.testTab.Controls.Add(this.label38);
            this.testTab.Controls.Add(this.label39);
            this.testTab.Controls.Add(this.label40);
            this.testTab.Controls.Add(this.label41);
            this.testTab.Controls.Add(this.label42);
            this.testTab.Controls.Add(this.label43);
            this.testTab.Controls.Add(this.label44);
            this.testTab.Controls.Add(this.label36);
            this.testTab.Controls.Add(this.label35);
            this.testTab.Controls.Add(this.label34);
            this.testTab.Controls.Add(this.label33);
            this.testTab.Controls.Add(this.label32);
            this.testTab.Controls.Add(this.label31);
            this.testTab.Controls.Add(this.label30);
            this.testTab.Controls.Add(this.label26);
            this.testTab.Controls.Add(this.label25);
            this.testTab.Controls.Add(this.label24);
            this.testTab.Controls.Add(this.label23);
            this.testTab.Controls.Add(this.label22);
            this.testTab.Controls.Add(this.label21);
            this.testTab.Controls.Add(this.label20);
            this.testTab.Controls.Add(this.label19);
            this.testTab.Controls.Add(this.label18);
            this.testTab.Controls.Add(this.label17);
            this.testTab.Controls.Add(this.label16);
            this.testTab.Controls.Add(this.label15);
            this.testTab.Controls.Add(this.label14);
            this.testTab.Controls.Add(this.label13);
            this.testTab.Controls.Add(this.label12);
            this.testTab.Controls.Add(this.label11);
            this.testTab.Controls.Add(this.label10);
            this.testTab.Location = new System.Drawing.Point(4, 27);
            this.testTab.Margin = new System.Windows.Forms.Padding(2);
            this.testTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.testTab.Location = new System.Drawing.Point(4, 38);
            this.testTab.Name = "testTab";
            this.testTab.Size = new System.Drawing.Size(1254, 664);
            this.testTab.TabIndex = 6;
            this.testTab.Text = "TEST";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(1079, 733);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(258, 26);
            this.label51.TabIndex = 126;
            this.label51.Text = "EB right speed command";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1713, 723);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(133, 44);
            this.button13.TabIndex = 125;
            this.button13.Text = "Send";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // txtEBRightSpeedCommand
            // 
            this.txtEBRightSpeedCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEBRightSpeedCommand.Location = new System.Drawing.Point(1396, 721);
            this.txtEBRightSpeedCommand.Name = "txtEBRightSpeedCommand";
            this.txtEBRightSpeedCommand.Size = new System.Drawing.Size(290, 44);
            this.txtEBRightSpeedCommand.TabIndex = 124;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(1078, 678);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(245, 26);
            this.label52.TabIndex = 123;
            this.label52.Text = "EB left speed command";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(1712, 668);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(133, 44);
            this.button14.TabIndex = 122;
            this.button14.Text = "Send";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // txtEBLeftSpeedCommand
            // 
            this.txtEBLeftSpeedCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEBLeftSpeedCommand.Location = new System.Drawing.Point(1395, 666);
            this.txtEBLeftSpeedCommand.Name = "txtEBLeftSpeedCommand";
            this.txtEBLeftSpeedCommand.Size = new System.Drawing.Size(290, 44);
            this.txtEBLeftSpeedCommand.TabIndex = 121;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(1079, 604);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(281, 26);
            this.label53.TabIndex = 120;
            this.label53.Text = "EB right direction command";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1713, 594);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(133, 44);
            this.button15.TabIndex = 119;
            this.button15.Text = "Send";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // txtEBRightDirCommand
            // 
            this.txtEBRightDirCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEBRightDirCommand.Location = new System.Drawing.Point(1396, 592);
            this.txtEBRightDirCommand.Name = "txtEBRightDirCommand";
            this.txtEBRightDirCommand.Size = new System.Drawing.Size(290, 44);
            this.txtEBRightDirCommand.TabIndex = 118;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(1078, 549);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(268, 26);
            this.label54.TabIndex = 117;
            this.label54.Text = "EB left direction command";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(1712, 539);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(133, 44);
            this.button16.TabIndex = 116;
            this.button16.Text = "Send";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // txtEBLeftDirCommand
            // 
            this.txtEBLeftDirCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEBLeftDirCommand.Location = new System.Drawing.Point(1395, 537);
            this.txtEBLeftDirCommand.Name = "txtEBLeftDirCommand";
            this.txtEBLeftDirCommand.Size = new System.Drawing.Size(290, 44);
            this.txtEBLeftDirCommand.TabIndex = 115;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(1461, 28);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(366, 51);
            this.label69.TabIndex = 114;
            this.label69.Text = "Flight Control Unit";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(277, 28);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(370, 51);
            this.label68.TabIndex = 113;
            this.label68.Text = "Landing Gear Unit";
            // 
            // lblEBRightDistanceBeam
            // 
            this.lblEBRightDistanceBeam.AutoSize = true;
            this.lblEBRightDistanceBeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEBRightDistanceBeam.ForeColor = System.Drawing.Color.White;
            this.lblEBRightDistanceBeam.Location = new System.Drawing.Point(1387, 443);
            this.lblEBRightDistanceBeam.Name = "lblEBRightDistanceBeam";
            this.lblEBRightDistanceBeam.Size = new System.Drawing.Size(24, 26);
            this.lblEBRightDistanceBeam.TabIndex = 112;
            this.lblEBRightDistanceBeam.Text = "0";
            // 
            // lblEBLeftDistanceBeam
            // 
            this.lblEBLeftDistanceBeam.AutoSize = true;
            this.lblEBLeftDistanceBeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEBLeftDistanceBeam.ForeColor = System.Drawing.Color.White;
            this.lblEBLeftDistanceBeam.Location = new System.Drawing.Point(1387, 405);
            this.lblEBLeftDistanceBeam.Name = "lblEBLeftDistanceBeam";
            this.lblEBLeftDistanceBeam.Size = new System.Drawing.Size(24, 26);
            this.lblEBLeftDistanceBeam.TabIndex = 111;
            this.lblEBLeftDistanceBeam.Text = "0";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(1086, 443);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(238, 26);
            this.label74.TabIndex = 108;
            this.label74.Text = "EB right distance beam";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.ForeColor = System.Drawing.Color.White;
            this.label75.Location = new System.Drawing.Point(1086, 405);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(225, 26);
            this.label75.TabIndex = 107;
            this.label75.Text = "EB left distance beam";
            // 
            // lblEBRightMLP
            // 
            this.lblEBRightMLP.AutoSize = true;
            this.lblEBRightMLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEBRightMLP.ForeColor = System.Drawing.Color.White;
            this.lblEBRightMLP.Location = new System.Drawing.Point(1387, 359);
            this.lblEBRightMLP.Name = "lblEBRightMLP";
            this.lblEBRightMLP.Size = new System.Drawing.Size(24, 26);
            this.lblEBRightMLP.TabIndex = 102;
            this.lblEBRightMLP.Text = "0";
            // 
            // lblEBLeftMLP
            // 
            this.lblEBLeftMLP.AutoSize = true;
            this.lblEBLeftMLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEBLeftMLP.ForeColor = System.Drawing.Color.White;
            this.lblEBLeftMLP.Location = new System.Drawing.Point(1387, 324);
            this.lblEBLeftMLP.Name = "lblEBLeftMLP";
            this.lblEBLeftMLP.Size = new System.Drawing.Size(24, 26);
            this.lblEBLeftMLP.TabIndex = 101;
            this.lblEBLeftMLP.Text = "0";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(1086, 359);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(141, 26);
            this.label63.TabIndex = 94;
            this.label63.Text = "EB right MLP";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(1086, 324);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(128, 26);
            this.label64.TabIndex = 93;
            this.label64.Text = "EB left MLP";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button12.Location = new System.Drawing.Point(2162, 621);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 80);
            this.button12.TabIndex = 89;
            this.button12.Text = "Pod stop";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1918, 597);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 112);
            this.button11.TabIndex = 88;
            this.button11.Text = "Safe";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(27, 480);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(94, 13);
            this.label49.TabIndex = 87;
            this.label49.Text = "LM forward 2 MLP";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(344, 475);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 23);
            this.label49.Location = new System.Drawing.Point(52, 925);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(306, 26);
            this.label49.TabIndex = 87;
            this.label49.Text = "LM forward 2 speed command";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(727, 915);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 44);
            this.button9.TabIndex = 86;
            this.button9.Text = "Send";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(186, 474);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(147, 26);
            this.textBox6.Location = new System.Drawing.Point(410, 913);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(290, 44);
            this.textBox6.TabIndex = 85;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(26, 452);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(94, 13);
            this.label50.TabIndex = 84;
            this.label50.Text = "LM forward 1 MLP";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(344, 447);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 23);
            this.label50.Location = new System.Drawing.Point(51, 870);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(306, 26);
            this.label50.TabIndex = 84;
            this.label50.Text = "LM forward 1 speed command";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(726, 860);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 44);
            this.button10.TabIndex = 83;
            this.button10.Text = "Send";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(185, 446);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(147, 26);
            this.textBox7.Location = new System.Drawing.Point(409, 858);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(290, 44);
            this.textBox7.TabIndex = 82;
            // 
            // lblOperatingMode
            // 
            this.lblOperatingMode.AutoSize = true;
            this.lblOperatingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatingMode.ForeColor = System.Drawing.Color.White;
            this.lblOperatingMode.Location = new System.Drawing.Point(183, 38);
            this.lblOperatingMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperatingMode.Name = "lblOperatingMode";
            this.lblOperatingMode.Size = new System.Drawing.Size(13, 13);
            this.lblOperatingMode.Location = new System.Drawing.Point(1391, 153);
            this.lblOperatingMode.Name = "lblOperatingMode";
            this.lblOperatingMode.Size = new System.Drawing.Size(24, 26);
            this.lblOperatingMode.TabIndex = 81;
            this.lblOperatingMode.Text = "0";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.White;
			this.button7.Size = new System.Drawing.Size(66, 23);
            this.label47.Location = new System.Drawing.Point(52, 796);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(255, 26);
            this.label47.TabIndex = 80;
            this.label47.Text = "LMA ft2 speed command";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(727, 786);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 44);
            this.button7.TabIndex = 79;
            this.button7.Text = "Send";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(410, 784);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(290, 44);
            this.textBox4.TabIndex = 78;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(51, 741);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(255, 26);
            this.label48.TabIndex = 77;
            this.label48.Text = "LMA ft1 speed command";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(726, 731);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 44);
            this.button8.TabIndex = 76;
            this.button8.Text = "Send";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(409, 729);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(290, 44);
            this.textBox5.TabIndex = 75;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(51, 675);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(344, 26);
            this.label45.TabIndex = 74;
            this.label45.Text = "LMA forward 2 direction command";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(726, 665);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 44);
            this.button5.TabIndex = 73;
            this.button5.Text = "Send";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(409, 663);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 44);
            this.textBox2.TabIndex = 72;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(50, 620);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(344, 26);
            this.label46.TabIndex = 71;
            this.label46.Text = "LMA forward 1 direction command";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(725, 610);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 44);
            this.button6.TabIndex = 70;
            this.button6.Text = "Send";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(408, 608);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(290, 44);
            this.textBox3.TabIndex = 69;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(50, 552);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(287, 26);
            this.label37.TabIndex = 68;
            this.label37.Text = "LMA ft2 Direction Command";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(725, 542);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 44);
            this.button4.TabIndex = 67;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtFt2DirectionCommand
            // 
            this.txtFt2DirectionCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFt2DirectionCommand.Location = new System.Drawing.Point(408, 540);
            this.txtFt2DirectionCommand.Name = "txtFt2DirectionCommand";
            this.txtFt2DirectionCommand.Size = new System.Drawing.Size(290, 44);
            this.txtFt2DirectionCommand.TabIndex = 66;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(49, 497);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(287, 26);
            this.label29.TabIndex = 65;
            this.label29.Text = "LMA ft1 Direction Command";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(724, 487);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(133, 44);
            this.sendButton.TabIndex = 64;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // txtFt1DirectionCommand
            // 
            this.txtFt1DirectionCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFt1DirectionCommand.Location = new System.Drawing.Point(407, 485);
            this.txtFt1DirectionCommand.Name = "txtFt1DirectionCommand";
            this.txtFt1DirectionCommand.Size = new System.Drawing.Size(290, 44);
            this.txtFt1DirectionCommand.TabIndex = 63;
            // 
            // lblAcceleration
            // 
            this.lblAcceleration.AutoSize = true;
            this.lblAcceleration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceleration.ForeColor = System.Drawing.Color.White;
            this.lblAcceleration.Location = new System.Drawing.Point(1811, 436);
            this.lblAcceleration.Name = "lblAcceleration";
            this.lblAcceleration.Size = new System.Drawing.Size(24, 26);
            this.lblAcceleration.TabIndex = 62;
            this.lblAcceleration.Text = "0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(1811, 398);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(24, 26);
            this.lblSpeed.TabIndex = 61;
            this.lblSpeed.Text = "0";
            // 
            // lblYaw
            // 
            this.lblYaw.AutoSize = true;
            this.lblYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaw.ForeColor = System.Drawing.Color.White;
            this.lblYaw.Location = new System.Drawing.Point(1811, 355);
            this.lblYaw.Name = "lblYaw";
            this.lblYaw.Size = new System.Drawing.Size(24, 26);
            this.lblYaw.TabIndex = 60;
            this.lblYaw.Text = "0";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.ForeColor = System.Drawing.Color.White;
            this.lblRoll.Location = new System.Drawing.Point(1811, 317);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(24, 26);
            this.lblRoll.TabIndex = 59;
            this.lblRoll.Text = "0";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitch.ForeColor = System.Drawing.Color.White;
            this.lblPitch.Location = new System.Drawing.Point(1811, 280);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(24, 26);
            this.lblPitch.TabIndex = 58;
            this.lblPitch.Text = "0";
            // 
            // lblYCG
            // 
            this.lblYCG.AutoSize = true;
            this.lblYCG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYCG.ForeColor = System.Drawing.Color.White;
            this.lblYCG.Location = new System.Drawing.Point(1811, 245);
            this.lblYCG.Name = "lblYCG";
            this.lblYCG.Size = new System.Drawing.Size(24, 26);
            this.lblYCG.TabIndex = 57;
            this.lblYCG.Text = "0";
            // 
            // lblXCG
            // 
            this.lblXCG.AutoSize = true;
            this.lblXCG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXCG.ForeColor = System.Drawing.Color.White;
            this.lblXCG.Location = new System.Drawing.Point(1812, 206);
            this.lblXCG.Name = "lblXCG";
            this.lblXCG.Size = new System.Drawing.Size(24, 26);
            this.lblXCG.TabIndex = 56;
            this.lblXCG.Text = "0";
            // 
            // lblCGHeight
            // 
            this.lblCGHeight.AutoSize = true;
            this.lblCGHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGHeight.ForeColor = System.Drawing.Color.White;
            this.lblCGHeight.Location = new System.Drawing.Point(1812, 165);
            this.lblCGHeight.Name = "lblCGHeight";
            this.lblCGHeight.Size = new System.Drawing.Size(24, 26);
            this.lblCGHeight.TabIndex = 55;
            this.lblCGHeight.Text = "0";
            // 
            // lblEBRightLimitSwitch
            // 
            this.lblEBRightLimitSwitch.AutoSize = true;
            this.lblEBRightLimitSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEBRightLimitSwitch.ForeColor = System.Drawing.Color.White;
            this.lblEBRightLimitSwitch.Location = new System.Drawing.Point(1387, 295);
            this.lblEBRightLimitSwitch.Name = "lblEBRightLimitSwitch";
            this.lblEBRightLimitSwitch.Size = new System.Drawing.Size(24, 26);
            this.lblEBRightLimitSwitch.TabIndex = 51;
            this.lblEBRightLimitSwitch.Text = "0";
            // 
            // lblEBLeftLimitSwitch
            // 
            this.lblEBLeftLimitSwitch.AutoSize = true;
            this.lblEBLeftLimitSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEBLeftLimitSwitch.ForeColor = System.Drawing.Color.White;
            this.lblEBLeftLimitSwitch.Location = new System.Drawing.Point(1387, 254);
            this.lblEBLeftLimitSwitch.Name = "lblEBLeftLimitSwitch";
            this.lblEBLeftLimitSwitch.Size = new System.Drawing.Size(24, 26);
            this.lblEBLeftLimitSwitch.TabIndex = 50;
            this.lblEBLeftLimitSwitch.Text = "0";
            // 
            // lblIBDS2Value
            // 
            this.lblIBDS2Value.AutoSize = true;
            this.lblIBDS2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIBDS2Value.ForeColor = System.Drawing.Color.White;
            this.lblIBDS2Value.Location = new System.Drawing.Point(2224, 493);
            this.lblIBDS2Value.Name = "lblIBDS2Value";
            this.lblIBDS2Value.Size = new System.Drawing.Size(24, 26);
            this.lblIBDS2Value.TabIndex = 49;
            this.lblIBDS2Value.Text = "0";
            // 
            // lblIBDS1Value
            // 
            this.lblIBDS1Value.AutoSize = true;
            this.lblIBDS1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIBDS1Value.ForeColor = System.Drawing.Color.White;
            this.lblIBDS1Value.Location = new System.Drawing.Point(2224, 455);
            this.lblIBDS1Value.Name = "lblIBDS1Value";
            this.lblIBDS1Value.Size = new System.Drawing.Size(24, 26);
            this.lblIBDS1Value.TabIndex = 48;
            this.lblIBDS1Value.Text = "0";
            // 
            // lblHDS4Value
            // 
            this.lblHDS4Value.AutoSize = true;
            this.lblHDS4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDS4Value.ForeColor = System.Drawing.Color.White;
            this.lblHDS4Value.Location = new System.Drawing.Point(2224, 418);
            this.lblHDS4Value.Name = "lblHDS4Value";
            this.lblHDS4Value.Size = new System.Drawing.Size(24, 26);
            this.lblHDS4Value.TabIndex = 47;
            this.lblHDS4Value.Text = "0";
            // 
            // lblHDS3Value
            // 
            this.lblHDS3Value.AutoSize = true;
            this.lblHDS3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDS3Value.ForeColor = System.Drawing.Color.White;
            this.lblHDS3Value.Location = new System.Drawing.Point(2224, 383);
            this.lblHDS3Value.Name = "lblHDS3Value";
            this.lblHDS3Value.Size = new System.Drawing.Size(24, 26);
            this.lblHDS3Value.TabIndex = 46;
            this.lblHDS3Value.Text = "0";
            // 
            // lblHDS2Value
            // 
            this.lblHDS2Value.AutoSize = true;
            this.lblHDS2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDS2Value.ForeColor = System.Drawing.Color.White;
            this.lblHDS2Value.Location = new System.Drawing.Point(2225, 344);
            this.lblHDS2Value.Name = "lblHDS2Value";
            this.lblHDS2Value.Size = new System.Drawing.Size(24, 26);
            this.lblHDS2Value.TabIndex = 45;
            this.lblHDS2Value.Text = "0";
            // 
            // lblHDS1Value
            // 
            this.lblHDS1Value.AutoSize = true;
            this.lblHDS1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDS1Value.ForeColor = System.Drawing.Color.White;
            this.lblHDS1Value.Location = new System.Drawing.Point(2225, 303);
            this.lblHDS1Value.Name = "lblHDS1Value";
            this.lblHDS1Value.Size = new System.Drawing.Size(24, 26);
            this.lblHDS1Value.TabIndex = 44;
            this.lblHDS1Value.Text = "0";
            // 
            // lblAuxPropEnabled
            // 
            this.lblAuxPropEnabled.AutoSize = true;
            this.lblAuxPropEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuxPropEnabled.ForeColor = System.Drawing.Color.White;
            this.lblAuxPropEnabled.Location = new System.Drawing.Point(2230, 162);
            this.lblAuxPropEnabled.Name = "lblAuxPropEnabled";
            this.lblAuxPropEnabled.Size = new System.Drawing.Size(24, 26);
            this.lblAuxPropEnabled.TabIndex = 43;
            this.lblAuxPropEnabled.Text = "0";
            // 
            // lblLMForward2MLP
            // 
            this.lblLMForward2MLP.AutoSize = true;
            this.lblLMForward2MLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMForward2MLP.ForeColor = System.Drawing.Color.White;
            this.lblLMForward2MLP.Location = new System.Drawing.Point(361, 434);
            this.lblLMForward2MLP.Name = "lblLMForward2MLP";
            this.lblLMForward2MLP.Size = new System.Drawing.Size(13, 13);
            this.lblLMForward2MLP.TabIndex = 42;
            this.lblLMForward2MLP.Text = "0";
            // 
            // lblLMForward1MLP
            // 
            this.lblLMForward1MLP.AutoSize = true;
            this.lblLMForward1MLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMForward1MLP.ForeColor = System.Drawing.Color.White;
            this.lblLMForward1MLP.Location = new System.Drawing.Point(361, 396);
            this.lblLMForward1MLP.Name = "lblLMForward1MLP";
            this.lblLMForward1MLP.Size = new System.Drawing.Size(13, 13);
            this.lblLMForward1MLP.TabIndex = 41;
            this.lblLMForward1MLP.Text = "0";
            // 
            // lblLMFT2MLP
            // 
            this.lblLMFT2MLP.AutoSize = true;
            this.lblLMFT2MLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMFT2MLP.ForeColor = System.Drawing.Color.White;
            this.lblLMFT2MLP.Location = new System.Drawing.Point(361, 353);
            this.lblLMFT2MLP.Name = "lblLMFT2MLP";
            this.lblLMFT2MLP.Size = new System.Drawing.Size(13, 13);
            this.lblLMFT2MLP.TabIndex = 40;
            this.lblLMFT2MLP.Text = "0";
            // 
            // lblFT1MLP
            // 
            this.lblFT1MLP.AutoSize = true;
            this.lblFT1MLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFT1MLP.ForeColor = System.Drawing.Color.White;
            this.lblFT1MLP.Location = new System.Drawing.Point(361, 315);
            this.lblFT1MLP.Name = "lblFT1MLP";
            this.lblFT1MLP.Size = new System.Drawing.Size(13, 13);
            this.lblFT1MLP.TabIndex = 39;
            this.lblFT1MLP.Text = "0";
            // 
            // lblLMForwardLimitSwitch2
            // 
            this.lblLMForwardLimitSwitch2.AutoSize = true;
            this.lblLMForwardLimitSwitch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMForwardLimitSwitch2.ForeColor = System.Drawing.Color.White;
            this.lblLMForwardLimitSwitch2.Location = new System.Drawing.Point(361, 278);
            this.lblLMForwardLimitSwitch2.Name = "lblLMForwardLimitSwitch2";
            this.lblLMForwardLimitSwitch2.Size = new System.Drawing.Size(13, 13);
            this.lblLMForwardLimitSwitch2.TabIndex = 38;
            this.lblLMForwardLimitSwitch2.Text = "0";
            // 
            // lblLMForwardLimitSwitch1
            // 
            this.lblLMForwardLimitSwitch1.AutoSize = true;
            this.lblLMForwardLimitSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMForwardLimitSwitch1.ForeColor = System.Drawing.Color.White;
            this.lblLMForwardLimitSwitch1.Location = new System.Drawing.Point(361, 243);
            this.lblLMForwardLimitSwitch1.Name = "lblLMForwardLimitSwitch1";
            this.lblLMForwardLimitSwitch1.Size = new System.Drawing.Size(13, 13);
            this.lblLMForwardLimitSwitch1.TabIndex = 37;
            this.lblLMForwardLimitSwitch1.Text = "0";
            // 
            // lblLMLimitSwitch2
            // 
            this.lblLMLimitSwitch2.AutoSize = true;
            this.lblLMLimitSwitch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMLimitSwitch2.ForeColor = System.Drawing.Color.White;
            this.lblLMLimitSwitch2.Location = new System.Drawing.Point(362, 204);
            this.lblLMLimitSwitch2.Name = "lblLMLimitSwitch2";
            this.lblLMLimitSwitch2.Size = new System.Drawing.Size(13, 13);
            this.lblLMLimitSwitch2.TabIndex = 36;
            this.lblLMLimitSwitch2.Text = "0";
            // 
            // lblLMLimitSwitch1
            // 
            this.lblLMLimitSwitch1.AutoSize = true;
            this.lblLMLimitSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMLimitSwitch1.ForeColor = System.Drawing.Color.White;
            this.lblLMLimitSwitch1.Location = new System.Drawing.Point(362, 163);
            this.lblLMLimitSwitch1.Name = "lblLMLimitSwitch1";
            this.lblLMLimitSwitch1.Size = new System.Drawing.Size(13, 13);
            this.lblLMLimitSwitch1.TabIndex = 35;
            this.lblLMLimitSwitch1.Text = "0";
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc.ForeColor = System.Drawing.Color.White;
            this.acc.Location = new System.Drawing.Point(1594, 436);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(132, 26);
            this.acc.TabIndex = 34;
            this.acc.Text = "Acceleration";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(1594, 398);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(75, 26);
            this.label38.TabIndex = 33;
            this.label38.Text = "Speed";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(1594, 355);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(56, 26);
            this.label39.TabIndex = 32;
            this.label39.Text = "Yaw";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(1594, 317);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(50, 26);
            this.label40.TabIndex = 31;
            this.label40.Text = "Roll";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(1594, 280);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(61, 26);
            this.label41.TabIndex = 30;
            this.label41.Text = "Pitch";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(1594, 245);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(67, 26);
            this.label42.TabIndex = 29;
            this.label42.Text = "Y CG";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(1595, 206);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(66, 26);
            this.label43.TabIndex = 28;
            this.label43.Text = "X CG";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(1595, 165);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(110, 26);
            this.label44.TabIndex = 27;
            this.label44.Text = "CG height";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(1083, 153);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(168, 26);
            this.label36.TabIndex = 26;
            this.label36.Text = "Operating mode";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(1913, 491);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(140, 26);
            this.label35.TabIndex = 25;
            this.label35.Text = "IBDS 2 value";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(1913, 457);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(140, 26);
            this.label34.TabIndex = 24;
            this.label34.Text = "IBDS 1 value";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(1913, 420);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(131, 26);
            this.label33.TabIndex = 23;
            this.label33.Text = "HD s4 value";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(1913, 381);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(131, 26);
            this.label32.TabIndex = 22;
            this.label32.Text = "HD s3 value";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(1913, 341);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 26);
            this.label31.TabIndex = 21;
            this.label31.Text = "HD s2 value";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(1913, 302);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(131, 26);
            this.label30.TabIndex = 20;
            this.label30.Text = "HD s1 value";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(1085, 289);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(203, 26);
            this.label26.TabIndex = 16;
            this.label26.Text = "EB right limit switch";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(1085, 254);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(190, 26);
            this.label25.TabIndex = 15;
            this.label25.Text = "EB left limit switch";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(1913, 162);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(284, 26);
            this.label24.TabIndex = 14;
            this.label24.Text = "Auxiliary propulsion enabled";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(44, 433);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(189, 26);
            this.label23.TabIndex = 13;
            this.label23.Text = "LM forward 2 MLP";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(44, 395);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(189, 26);
            this.label22.TabIndex = 12;
            this.label22.Text = "LM forward 1 MLP";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(44, 352);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 26);
            this.label21.TabIndex = 11;
            this.label21.Text = "LM ft2 MLP";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(44, 314);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 26);
            this.label20.TabIndex = 10;
            this.label20.Text = "LM ft1 MLP";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(44, 277);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(251, 26);
            this.label19.TabIndex = 9;
            this.label19.Text = "LM forward 2 limit switch";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(44, 242);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(251, 26);
            this.label18.TabIndex = 8;
            this.label18.Text = "LM forward 1 limit switch";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(45, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 26);
            this.label17.TabIndex = 7;
            this.label17.Text = "LM 2 Limit switch";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(45, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 26);
            this.label16.TabIndex = 6;
            this.label16.Text = "LM 1 Limit switch";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1593, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(234, 37);
            this.label15.TabIndex = 5;
            this.label15.Text = "Pod kinematics";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1911, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 37);
            this.label14.TabIndex = 4;
            this.label14.Text = "Distance sensors";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1081, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 37);
            this.label13.TabIndex = 3;
            this.label13.Text = "Eddy brakes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1914, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 37);
            this.label12.TabIndex = 2;
            this.label12.Text = "Aux propulsion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(42, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 37);
            this.label11.TabIndex = 1;
            this.label11.Text = "Lift mechanism";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1077, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 37);
            this.label10.TabIndex = 0;
            this.label10.Text = "Operating mode";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TESTTabTimer
            // 
            this.TESTTabTimer.Enabled = true;
            this.TESTTabTimer.Interval = 200;
            this.TESTTabTimer.Tick += new System.EventHandler(this.TESTTabTimer_Tick);
            // 
            // podStateControl2
            // 
            this.podStateControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podStateControl2.HE1Height = 12.23D;
            this.podStateControl2.HE1Percent = 0.8D;
            this.podStateControl2.HE1Power = 3000D;
            this.podStateControl2.HE1RPM = 3000D;
            this.podStateControl2.HE2Height = 12.2D;
            this.podStateControl2.HE2Percent = 0.8D;
            this.podStateControl2.HE2Power = 3000D;
            this.podStateControl2.HE2RPM = 3000D;
            this.podStateControl2.HE3Height = 12.2D;
            this.podStateControl2.HE3Percent = 0.8D;
            this.podStateControl2.HE3Power = 3000D;
            this.podStateControl2.HE3RPM = 3000D;
            this.podStateControl2.HE4Height = 12.2D;
            this.podStateControl2.HE4Percent = 0.8D;
            this.podStateControl2.HE4Power = 3000D;
            this.podStateControl2.HE4RPM = 3000D;
            this.podStateControl2.HE5Height = 12.2D;
            this.podStateControl2.HE5Percent = 0.8D;
            this.podStateControl2.HE5Power = 3000D;
            this.podStateControl2.HE5RPM = 3000D;
            this.podStateControl2.HE6Height = 12.2D;
            this.podStateControl2.HE6Percent = 0.8D;
            this.podStateControl2.HE6Power = 3000D;
            this.podStateControl2.HE6RPM = 3000D;
            this.podStateControl2.HE7Height = 12.2D;
            this.podStateControl2.HE7Percent = 0.8D;
            this.podStateControl2.HE7Power = 3000D;
            this.podStateControl2.HE7RPM = 3000D;
            this.podStateControl2.HE8Height = 12.2D;
            this.podStateControl2.HE8Percent = 0.8D;
            this.podStateControl2.HE8Power = 3000D;
            this.podStateControl2.HE8RPM = 3000D;
            this.podStateControl2.Location = new System.Drawing.Point(512, 0);
            this.podStateControl2.Margin = new System.Windows.Forms.Padding(12);
            this.podStateControl2.Name = "podStateControl2";
            this.podStateControl2.Size = new System.Drawing.Size(1656, 689);
            this.podStateControl2.TabIndex = 0;
            // 
            // rPodSpeedometer1
            // 
            this.rPodSpeedometer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rPodSpeedometer1.Location = new System.Drawing.Point(0, 0);
            this.rPodSpeedometer1.Margin = new System.Windows.Forms.Padding(12);
            this.rPodSpeedometer1.Name = "rPodSpeedometer1";
            this.rPodSpeedometer1.Size = new System.Drawing.Size(512, 689);
            this.rPodSpeedometer1.TabIndex = 9;
            // 
            // rPodGyro1
            // 
            this.rPodGyro1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rPodGyro1.Location = new System.Drawing.Point(2168, 0);
            this.rPodGyro1.Margin = new System.Windows.Forms.Padding(12);
            this.rPodGyro1.Name = "rPodGyro1";
            this.rPodGyro1.Size = new System.Drawing.Size(438, 689);
            this.rPodGyro1.TabIndex = 11;
            // 
            // rPodCurrentGauge2
            // 
            this.rPodCurrentGauge2.Location = new System.Drawing.Point(416, 35);
            this.rPodCurrentGauge2.Margin = new System.Windows.Forms.Padding(12);
            this.rPodCurrentGauge2.Name = "rPodCurrentGauge2";
            this.rPodCurrentGauge2.Size = new System.Drawing.Size(284, 269);
            this.rPodCurrentGauge2.TabIndex = 13;
            // 
            // rPodBatteryIndicator1
            // 
            this.rPodBatteryIndicator1.Location = new System.Drawing.Point(416, 354);
            this.rPodBatteryIndicator1.Margin = new System.Windows.Forms.Padding(12);
            this.rPodBatteryIndicator1.Name = "rPodBatteryIndicator1";
            this.rPodBatteryIndicator1.Size = new System.Drawing.Size(284, 135);
            this.rPodBatteryIndicator1.TabIndex = 11;
            this.rPodBatteryIndicator1.Load += new System.EventHandler(this.rPodBatteryIndicator1_Load);
            // 
            // rPodCurrentGauge1
            // 
            this.rPodCurrentGauge1.Location = new System.Drawing.Point(46, 35);
            this.rPodCurrentGauge1.Margin = new System.Windows.Forms.Padding(12);
            this.rPodCurrentGauge1.Name = "rPodCurrentGauge1";
            this.rPodCurrentGauge1.Size = new System.Drawing.Size(284, 269);
            this.rPodCurrentGauge1.TabIndex = 12;
            // 
            // rPodBatteryVoltage1
            // 
            this.rPodBatteryVoltage1.Location = new System.Drawing.Point(46, 354);
            this.rPodBatteryVoltage1.Margin = new System.Windows.Forms.Padding(12);
            this.rPodBatteryVoltage1.Name = "rPodBatteryVoltage1";
            this.rPodBatteryVoltage1.Size = new System.Drawing.Size(284, 135);
            this.rPodBatteryVoltage1.TabIndex = 11;
            this.rPodBatteryVoltage1.Load += new System.EventHandler(this.rPodBatteryIndicator1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1292, 734);
            this.Controls.Add(this.customTabControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "rLoop Ground Station Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.customTabControl1.ResumeLayout(false);
            this.OverviewTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.PowerNodeATab.ResumeLayout(false);
            this.customTabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.NodeUtilitiesTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.testTab.ResumeLayout(false);
            this.testTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer UpdateNodeList;
        private System.Windows.Forms.Label lblSelectedNodeIp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Timer UpdateDGVTimer;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private rPodSpeedometer rPodSpeedometer1;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.CustomTabControl customTabControl1;
        private System.Windows.Forms.TabPage OverviewTab;
        private System.Windows.Forms.TabPage NodeUtilitiesTab;
        private rPodGyro rPodGyro1;
        private System.Windows.Forms.Panel panel1;
        private PodStateControl podStateControl2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage SerialConsoleTab;
        private System.Windows.Forms.TabPage PowerNodeATab;
        private System.Windows.Forms.TabPage PowerNodeBTab;
        private rPod_GUI_Elements.rPodBatteryVoltage rPodBatteryIndicator1;
        private rPod_GUI_Elements.rPodBatteryVoltage rPodBatteryVoltage1;
        private rPod_GUI_Elements.rPodCurrentGauge rPodCurrentGauge1;
        private System.Windows.Forms.CustomTabControl customTabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private rPod_GUI_Elements.rPodCurrentGauge rPodCurrentGauge2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sendTestData;
        private System.Windows.Forms.TextBox testDataIndexTxt;
        private System.Windows.Forms.TextBox testDataToSendTxt;
        private System.Windows.Forms.ComboBox testDataType;
        private System.Windows.Forms.Timer BatteryPackAStatusTab;
        private System.Windows.Forms.Label BrakesAPackVoltage;
        private System.Windows.Forms.Label BrakesAPackTemperature;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer HEguiDemo;
        private System.Windows.Forms.TabPage auxPropTab;
        private System.Windows.Forms.TabPage testTab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAcceleration;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblYaw;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label lblYCG;
        private System.Windows.Forms.Label lblXCG;
        private System.Windows.Forms.Label lblCGHeight;
        private System.Windows.Forms.Label lblEBRightLimitSwitch;
        private System.Windows.Forms.Label lblEBLeftLimitSwitch;
        private System.Windows.Forms.Label lblIBDS2Value;
        private System.Windows.Forms.Label lblIBDS1Value;
        private System.Windows.Forms.Label lblHDS4Value;
        private System.Windows.Forms.Label lblHDS3Value;
        private System.Windows.Forms.Label lblHDS2Value;
        private System.Windows.Forms.Label lblHDS1Value;
        private System.Windows.Forms.Label lblAuxPropEnabled;
        private System.Windows.Forms.Label lblLMForward2MLP;
        private System.Windows.Forms.Label lblLMForward1MLP;
        private System.Windows.Forms.Label lblLMFT2MLP;
        private System.Windows.Forms.Label lblFT1MLP;
        private System.Windows.Forms.Label lblLMForwardLimitSwitch2;
        private System.Windows.Forms.Label lblLMForwardLimitSwitch1;
        private System.Windows.Forms.Label lblLMLimitSwitch2;
        private System.Windows.Forms.Label lblLMLimitSwitch1;
        private System.Windows.Forms.Label acc;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox txtFt1DirectionCommand;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtFt2DirectionCommand;
        private System.Windows.Forms.Label lblOperatingMode;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Timer TESTTabTimer;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label lblEBRightDistanceBeam;
        private System.Windows.Forms.Label lblEBLeftDistanceBeam;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label lblEBRightMLP;
        private System.Windows.Forms.Label lblEBLeftMLP;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox txtEBRightSpeedCommand;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txtEBLeftSpeedCommand;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox txtEBRightDirCommand;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox txtEBLeftDirCommand;
    }
}

