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
            this.podStateControl2 = new rLoop_Ground_Station.PodStateControl();
            this.rPodSpeedometer1 = new rLoop_Ground_Station.rPodSpeedometer();
            this.rPodGyro1 = new rLoop_Ground_Station.rPodGyro();
            this.rPodCurrentGauge2 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodCurrentGauge();
            this.rPodBatteryIndicator1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodBatteryVoltage();
            this.rPodCurrentGauge1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodCurrentGauge();
            this.rPodBatteryVoltage1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodBatteryVoltage();
            this.testingTabPage1 = new rLoop_Ground_Station.TabPanels.TestingTabPage();
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
            this.customTabControl1.Size = new System.Drawing.Size(1413, 826);
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
            this.OverviewTab.Size = new System.Drawing.Size(1405, 795);
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
            this.panel1.Size = new System.Drawing.Size(1399, 429);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
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
            this.panel2.Location = new System.Drawing.Point(3, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1399, 360);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.PowerNodeATab.Size = new System.Drawing.Size(1405, 795);
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
            this.PowerNodeBTab.Size = new System.Drawing.Size(1405, 795);
            this.PowerNodeBTab.TabIndex = 4;
            this.PowerNodeBTab.Text = "Power B";
            // 
            // auxPropTab
            // 
            this.auxPropTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.auxPropTab.Location = new System.Drawing.Point(4, 27);
            this.auxPropTab.Margin = new System.Windows.Forms.Padding(2);
            this.auxPropTab.Name = "auxPropTab";
            this.auxPropTab.Size = new System.Drawing.Size(1405, 795);
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
            this.NodeUtilitiesTab.Size = new System.Drawing.Size(1405, 795);
            this.NodeUtilitiesTab.TabIndex = 1;
            this.NodeUtilitiesTab.Text = "Node Utilities";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 692);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1399, 100);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1399, 535);
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
            this.dataGridView1.Size = new System.Drawing.Size(1399, 535);
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
            this.panel3.Size = new System.Drawing.Size(1399, 254);
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
            this.SerialConsoleTab.Size = new System.Drawing.Size(1405, 795);
            this.SerialConsoleTab.TabIndex = 2;
            this.SerialConsoleTab.Text = "Console";
            // 
            // testTab
            // 
            this.testTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.testTab.Controls.Add(this.testingTabPage1);
            this.testTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.testTab.Location = new System.Drawing.Point(4, 27);
            this.testTab.Margin = new System.Windows.Forms.Padding(2);
            this.testTab.Name = "testTab";
            this.testTab.Size = new System.Drawing.Size(1405, 795);
            this.testTab.TabIndex = 6;
            this.testTab.Text = "TEST";
            this.testTab.Click += new System.EventHandler(this.testTab_Click);
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
            this.podStateControl2.Size = new System.Drawing.Size(449, 429);
            this.podStateControl2.TabIndex = 0;
            // 
            // rPodSpeedometer1
            // 
            this.rPodSpeedometer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rPodSpeedometer1.Location = new System.Drawing.Point(0, 0);
            this.rPodSpeedometer1.Margin = new System.Windows.Forms.Padding(12);
            this.rPodSpeedometer1.Name = "rPodSpeedometer1";
            this.rPodSpeedometer1.Size = new System.Drawing.Size(512, 429);
            this.rPodSpeedometer1.TabIndex = 9;
            // 
            // rPodGyro1
            // 
            this.rPodGyro1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rPodGyro1.Location = new System.Drawing.Point(961, 0);
            this.rPodGyro1.Margin = new System.Windows.Forms.Padding(12);
            this.rPodGyro1.Name = "rPodGyro1";
            this.rPodGyro1.Size = new System.Drawing.Size(438, 429);
            this.rPodGyro1.TabIndex = 11;
            // 
            // rPodCurrentGauge2
            // 
            this.rPodCurrentGauge2.Location = new System.Drawing.Point(246, 35);
            this.rPodCurrentGauge2.Margin = new System.Windows.Forms.Padding(12);
            this.rPodCurrentGauge2.Name = "rPodCurrentGauge2";
            this.rPodCurrentGauge2.Size = new System.Drawing.Size(184, 137);
            this.rPodCurrentGauge2.TabIndex = 13;
            // 
            // rPodBatteryIndicator1
            // 
            this.rPodBatteryIndicator1.Location = new System.Drawing.Point(391, 198);
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
            this.rPodCurrentGauge1.Size = new System.Drawing.Size(176, 167);
            this.rPodCurrentGauge1.TabIndex = 12;
            // 
            // rPodBatteryVoltage1
            // 
            this.rPodBatteryVoltage1.Location = new System.Drawing.Point(128, 213);
            this.rPodBatteryVoltage1.Margin = new System.Windows.Forms.Padding(12);
            this.rPodBatteryVoltage1.Name = "rPodBatteryVoltage1";
            this.rPodBatteryVoltage1.Size = new System.Drawing.Size(212, 91);
            this.rPodBatteryVoltage1.TabIndex = 11;
            this.rPodBatteryVoltage1.Load += new System.EventHandler(this.rPodBatteryIndicator1_Load);
            // 
            // testingTabPage1
            // 
            this.testingTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.testingTabPage1.Location = new System.Drawing.Point(14, 3);
            this.testingTabPage1.Name = "testingTabPage1";
            this.testingTabPage1.Size = new System.Drawing.Size(1350, 866);
            this.testingTabPage1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1452, 857);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrUpdateNodeUtilStats;
        private System.Windows.Forms.TextBox txtNewBaud;
        private System.Windows.Forms.Button btnNewBaudRate;
        private System.Windows.Forms.Label lblSelectedNodeTime;
        private System.Windows.Forms.Label lblSelectedNodeDataLogging;
        private System.Windows.Forms.Button btnStopDataLogging;
        private System.Windows.Forms.Button btnStartDataLogging;
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
        private TabPanels.TestingTabPage testingTabPage1;
    }
}

