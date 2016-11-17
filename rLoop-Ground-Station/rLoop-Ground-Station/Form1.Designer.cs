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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UpdateNodeList = new System.Windows.Forms.Timer(this.components);
            this.UpdateDGVTimer = new System.Windows.Forms.Timer(this.components);
            this.BatteryPackAStatusTab = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateNodeUtilStats = new System.Windows.Forms.Timer(this.components);
            this.customTabControl1 = new System.Windows.Forms.CustomTabControl();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.podStateControl2 = new rLoop_Ground_Station.PodStateControl();
            this.rPodSpeedometer1 = new rLoop_Ground_Station.rPodSpeedometer();
            this.rPodGyro1 = new rLoop_Ground_Station.rPodGyro();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rPodCurrentGauge2 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodCurrentGauge();
            this.rPodBatteryIndicator1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodBatteryVoltage();
            this.rPodCurrentGauge1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodCurrentGauge();
            this.rPodBatteryVoltage1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodBatteryVoltage();
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
            this.AuxPropTab = new System.Windows.Forms.TabPage();
            this.NodeUtilitiesTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectedNodeIp = new System.Windows.Forms.Label();
            this.lblSelectedNodeDataLogging = new System.Windows.Forms.Label();
            this.lblSelectedNodeTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartDataLogging = new System.Windows.Forms.Button();
            this.btnStopDataLogging = new System.Windows.Forms.Button();
            this.txtNewBaud = new System.Windows.Forms.TextBox();
            this.btnNewBaudRate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.testDataType = new System.Windows.Forms.ComboBox();
            this.sendTestData = new System.Windows.Forms.Button();
            this.testDataIndexTxt = new System.Windows.Forms.TextBox();
            this.testDataToSendTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SerialConsoleTab = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.testTab = new System.Windows.Forms.TabPage();
            this.testingTabPage1 = new rLoop_Ground_Station.TabPanels.TestingTabPage();
            this.brakesTab = new System.Windows.Forms.TabPage();
            this.brakesTabPage1 = new rLoop_Ground_Station.TabPanels.BrakesTabPage();
            this.LGUTab = new System.Windows.Forms.TabPage();
            this.lguTabPage1 = new rLoop_Ground_Station.TabPanels.LGUTabPage();
            this.FCUTab = new System.Windows.Forms.TabPage();
            this.fcu1 = new rLoop_Ground_Station.TabPanels.FCU();
            this.powerTab = new System.Windows.Forms.TabPage();
            this.powerTabPage1 = new rLoop_Ground_Station.TabPanels.PowerTabPage();
            this.customTabControl1.SuspendLayout();
            this.OverviewTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PowerNodeATab.SuspendLayout();
            this.customTabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.NodeUtilitiesTab.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SerialConsoleTab.SuspendLayout();
            this.testTab.SuspendLayout();
            this.brakesTab.SuspendLayout();
            this.LGUTab.SuspendLayout();
            this.FCUTab.SuspendLayout();
            this.powerTab.SuspendLayout();
            this.SuspendLayout();
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
            this.customTabControl1.Controls.Add(this.AuxPropTab);
            this.customTabControl1.Controls.Add(this.NodeUtilitiesTab);
            this.customTabControl1.Controls.Add(this.SerialConsoleTab);
            this.customTabControl1.Controls.Add(this.testTab);
            this.customTabControl1.Controls.Add(this.brakesTab);
            this.customTabControl1.Controls.Add(this.LGUTab);
            this.customTabControl1.Controls.Add(this.FCUTab);
            this.customTabControl1.Controls.Add(this.powerTab);
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
            this.customTabControl1.DisplayStyleProvider.Padding = new System.Drawing.Point(8, 4);
            this.customTabControl1.DisplayStyleProvider.Radius = 3;
            this.customTabControl1.DisplayStyleProvider.ShowTabCloser = false;
            this.customTabControl1.DisplayStyleProvider.TextColor = System.Drawing.Color.White;
            this.customTabControl1.DisplayStyleProvider.TextColorDisabled = System.Drawing.Color.WhiteSmoke;
            this.customTabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.customTabControl1.HotTrack = true;
            this.customTabControl1.Location = new System.Drawing.Point(42, 23);
            this.customTabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(3126, 1715);
            this.customTabControl1.TabIndex = 13;
            // 
            // OverviewTab
            // 
            this.OverviewTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.OverviewTab.Controls.Add(this.panel1);
            this.OverviewTab.Controls.Add(this.panel2);
            this.OverviewTab.Location = new System.Drawing.Point(4, 36);
            this.OverviewTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OverviewTab.Size = new System.Drawing.Size(3118, 1675);
            this.OverviewTab.TabIndex = 0;
            this.OverviewTab.Text = "Overview";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.podStateControl2);
            this.panel1.Controls.Add(this.rPodSpeedometer1);
            this.panel1.Controls.Add(this.rPodGyro1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3106, 836);
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
            this.podStateControl2.Location = new System.Drawing.Point(1024, 0);
            this.podStateControl2.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.podStateControl2.Name = "podStateControl2";
            this.podStateControl2.Size = new System.Drawing.Size(1206, 836);
            this.podStateControl2.TabIndex = 0;
            // 
            // rPodSpeedometer1
            // 
            this.rPodSpeedometer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rPodSpeedometer1.Location = new System.Drawing.Point(0, 0);
            this.rPodSpeedometer1.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.rPodSpeedometer1.Name = "rPodSpeedometer1";
            this.rPodSpeedometer1.Size = new System.Drawing.Size(1024, 836);
            this.rPodSpeedometer1.TabIndex = 9;
            // 
            // rPodGyro1
            // 
            this.rPodGyro1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rPodGyro1.Location = new System.Drawing.Point(2230, 0);
            this.rPodGyro1.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.rPodGyro1.Name = "rPodGyro1";
            this.rPodGyro1.Size = new System.Drawing.Size(876, 836);
            this.rPodGyro1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rPodCurrentGauge2);
            this.panel2.Controls.Add(this.rPodBatteryIndicator1);
            this.panel2.Controls.Add(this.rPodCurrentGauge1);
            this.panel2.Controls.Add(this.rPodBatteryVoltage1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(6, 842);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3106, 827);
            this.panel2.TabIndex = 13;
            // 
            // rPodCurrentGauge2
            // 
            this.rPodCurrentGauge2.Location = new System.Drawing.Point(760, 21);
            this.rPodCurrentGauge2.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.rPodCurrentGauge2.Name = "rPodCurrentGauge2";
            this.rPodCurrentGauge2.Size = new System.Drawing.Size(500, 440);
            this.rPodCurrentGauge2.TabIndex = 13;
            // 
            // rPodBatteryIndicator1
            // 
            this.rPodBatteryIndicator1.Location = new System.Drawing.Point(72, 515);
            this.rPodBatteryIndicator1.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.rPodBatteryIndicator1.Name = "rPodBatteryIndicator1";
            this.rPodBatteryIndicator1.Size = new System.Drawing.Size(466, 217);
            this.rPodBatteryIndicator1.TabIndex = 11;
            // 
            // rPodCurrentGauge1
            // 
            this.rPodCurrentGauge1.Location = new System.Drawing.Point(62, 0);
            this.rPodCurrentGauge1.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.rPodCurrentGauge1.Name = "rPodCurrentGauge1";
            this.rPodCurrentGauge1.Size = new System.Drawing.Size(476, 462);
            this.rPodCurrentGauge1.TabIndex = 12;
            // 
            // rPodBatteryVoltage1
            // 
            this.rPodBatteryVoltage1.Location = new System.Drawing.Point(800, 515);
            this.rPodBatteryVoltage1.Margin = new System.Windows.Forms.Padding(24, 23, 24, 23);
            this.rPodBatteryVoltage1.Name = "rPodBatteryVoltage1";
            this.rPodBatteryVoltage1.Size = new System.Drawing.Size(500, 217);
            this.rPodBatteryVoltage1.TabIndex = 11;
            // 
            // PowerNodeATab
            // 
            this.PowerNodeATab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.PowerNodeATab.Controls.Add(this.customTabControl2);
            this.PowerNodeATab.Location = new System.Drawing.Point(4, 36);
            this.PowerNodeATab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PowerNodeATab.Name = "PowerNodeATab";
            this.PowerNodeATab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PowerNodeATab.Size = new System.Drawing.Size(3118, 1675);
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
            this.customTabControl2.Location = new System.Drawing.Point(12, 12);
            this.customTabControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customTabControl2.Name = "customTabControl2";
            this.customTabControl2.SelectedIndex = 0;
            this.customTabControl2.Size = new System.Drawing.Size(2506, 1213);
            this.customTabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.BrakesAPackTemperature);
            this.tabPage1.Controls.Add(this.BrakesAPackVoltage);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(2498, 1182);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 108);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2420, 1065);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // BrakesAPackTemperature
            // 
            this.BrakesAPackTemperature.AutoSize = true;
            this.BrakesAPackTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrakesAPackTemperature.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BrakesAPackTemperature.Location = new System.Drawing.Point(736, 23);
            this.BrakesAPackTemperature.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BrakesAPackTemperature.Name = "BrakesAPackTemperature";
            this.BrakesAPackTemperature.Size = new System.Drawing.Size(768, 73);
            this.BrakesAPackTemperature.TabIndex = 2;
            this.BrakesAPackTemperature.Text = "Temperature: 0.000 degC";
            // 
            // BrakesAPackVoltage
            // 
            this.BrakesAPackVoltage.AutoSize = true;
            this.BrakesAPackVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrakesAPackVoltage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BrakesAPackVoltage.Location = new System.Drawing.Point(34, 23);
            this.BrakesAPackVoltage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BrakesAPackVoltage.Name = "BrakesAPackVoltage";
            this.BrakesAPackVoltage.Size = new System.Drawing.Size(608, 73);
            this.BrakesAPackVoltage.TabIndex = 1;
            this.BrakesAPackVoltage.Text = "Voltage: 0.000 Volts";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(2498, 1182);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Charger";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(2498, 1182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BMS 1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(2498, 1182);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BMS 2";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(2498, 1182);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "BMS 3";
            // 
            // PowerNodeBTab
            // 
            this.PowerNodeBTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.PowerNodeBTab.Location = new System.Drawing.Point(4, 36);
            this.PowerNodeBTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PowerNodeBTab.Name = "PowerNodeBTab";
            this.PowerNodeBTab.Size = new System.Drawing.Size(3118, 1675);
            this.PowerNodeBTab.TabIndex = 4;
            this.PowerNodeBTab.Text = "Power B";
            // 
            // AuxPropTab
            // 
            this.AuxPropTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.AuxPropTab.Location = new System.Drawing.Point(4, 36);
            this.AuxPropTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuxPropTab.Name = "AuxPropTab";
            this.AuxPropTab.Size = new System.Drawing.Size(3118, 1675);
            this.AuxPropTab.TabIndex = 5;
            this.AuxPropTab.Text = "Aux Prop";
            // 
            // NodeUtilitiesTab
            // 
            this.NodeUtilitiesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.NodeUtilitiesTab.Controls.Add(this.panel5);
            this.NodeUtilitiesTab.Controls.Add(this.panel4);
            this.NodeUtilitiesTab.Controls.Add(this.panel3);
            this.NodeUtilitiesTab.Location = new System.Drawing.Point(4, 36);
            this.NodeUtilitiesTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NodeUtilitiesTab.Name = "NodeUtilitiesTab";
            this.NodeUtilitiesTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NodeUtilitiesTab.Size = new System.Drawing.Size(3118, 1675);
            this.NodeUtilitiesTab.TabIndex = 1;
            this.NodeUtilitiesTab.Text = "Node Utilities";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(6, 1477);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3106, 192);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(6, 494);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3106, 1175);
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(3106, 1175);
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
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3106, 488);
            this.panel3.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedNodeIp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedNodeDataLogging, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedNodeTime, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(556, 98);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 333);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // lblSelectedNodeIp
            // 
            this.lblSelectedNodeIp.AutoSize = true;
            this.lblSelectedNodeIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedNodeIp.ForeColor = System.Drawing.Color.White;
            this.lblSelectedNodeIp.Location = new System.Drawing.Point(6, 0);
            this.lblSelectedNodeIp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedNodeIp.Name = "lblSelectedNodeIp";
            this.lblSelectedNodeIp.Padding = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.lblSelectedNodeIp.Size = new System.Drawing.Size(60, 67);
            this.lblSelectedNodeIp.TabIndex = 4;
            this.lblSelectedNodeIp.Text = "IP";
            // 
            // lblSelectedNodeDataLogging
            // 
            this.lblSelectedNodeDataLogging.AutoSize = true;
            this.lblSelectedNodeDataLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedNodeDataLogging.ForeColor = System.Drawing.Color.White;
            this.lblSelectedNodeDataLogging.Location = new System.Drawing.Point(6, 67);
            this.lblSelectedNodeDataLogging.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedNodeDataLogging.Name = "lblSelectedNodeDataLogging";
            this.lblSelectedNodeDataLogging.Padding = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.lblSelectedNodeDataLogging.Size = new System.Drawing.Size(247, 67);
            this.lblSelectedNodeDataLogging.TabIndex = 4;
            this.lblSelectedNodeDataLogging.Text = "data logging";
            // 
            // lblSelectedNodeTime
            // 
            this.lblSelectedNodeTime.AutoSize = true;
            this.lblSelectedNodeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedNodeTime.ForeColor = System.Drawing.Color.White;
            this.lblSelectedNodeTime.Location = new System.Drawing.Point(6, 134);
            this.lblSelectedNodeTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedNodeTime.Name = "lblSelectedNodeTime";
            this.lblSelectedNodeTime.Padding = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.lblSelectedNodeTime.Size = new System.Drawing.Size(114, 67);
            this.lblSelectedNodeTime.TabIndex = 4;
            this.lblSelectedNodeTime.Text = "Time";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnStartDataLogging, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStopDataLogging, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewBaud, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNewBaudRate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.testDataType, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.sendTestData, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.testDataIndexTxt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.testDataToSendTxt, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1096, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.07207F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.22523F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.16216F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1908, 427);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnStartDataLogging
            // 
            this.btnStartDataLogging.AutoSize = true;
            this.btnStartDataLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDataLogging.Location = new System.Drawing.Point(1692, 6);
            this.btnStartDataLogging.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStartDataLogging.Name = "btnStartDataLogging";
            this.btnStartDataLogging.Size = new System.Drawing.Size(972, 82);
            this.btnStartDataLogging.TabIndex = 5;
            this.btnStartDataLogging.Text = "Start Data Logging";
            this.btnStartDataLogging.UseVisualStyleBackColor = true;
            this.btnStartDataLogging.Click += new System.EventHandler(this.btnStartDataLogging_Click);
            // 
            // btnStopDataLogging
            // 
            this.btnStopDataLogging.AutoSize = true;
            this.btnStopDataLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopDataLogging.Location = new System.Drawing.Point(1692, 100);
            this.btnStopDataLogging.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStopDataLogging.Name = "btnStopDataLogging";
            this.btnStopDataLogging.Size = new System.Drawing.Size(966, 96);
            this.btnStopDataLogging.TabIndex = 5;
            this.btnStopDataLogging.Text = "Stop Data Logging";
            this.btnStopDataLogging.UseVisualStyleBackColor = true;
            this.btnStopDataLogging.Click += new System.EventHandler(this.btnStopDataLogging_Click);
            // 
            // txtNewBaud
            // 
            this.txtNewBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewBaud.Location = new System.Drawing.Point(1072, 6);
            this.txtNewBaud.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNewBaud.Name = "txtNewBaud";
            this.txtNewBaud.Size = new System.Drawing.Size(282, 69);
            this.txtNewBaud.TabIndex = 6;
            this.txtNewBaud.Text = "57600";
            // 
            // btnNewBaudRate
            // 
            this.btnNewBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBaudRate.Location = new System.Drawing.Point(1072, 100);
            this.btnNewBaudRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNewBaudRate.Name = "btnNewBaudRate";
            this.btnNewBaudRate.Size = new System.Drawing.Size(608, 87);
            this.btnNewBaudRate.TabIndex = 5;
            this.btnNewBaudRate.Text = "Change UART Baud";
            this.btnNewBaudRate.UseVisualStyleBackColor = true;
            this.btnNewBaudRate.Click += new System.EventHandler(this.btnNewBaudRate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 69);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "New Node Name";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 100);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1054, 96);
            this.button3.TabIndex = 5;
            this.button3.Text = "Change Node Name";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // testDataType
            // 
            this.testDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.testDataType.Location = new System.Drawing.Point(1692, 260);
            this.testDataType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.testDataType.Name = "testDataType";
            this.testDataType.Size = new System.Drawing.Size(392, 71);
            this.testDataType.TabIndex = 12;
            this.testDataType.Text = "Data Type";
            // 
            // sendTestData
            // 
            this.sendTestData.AutoSize = true;
            this.sendTestData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendTestData.Location = new System.Drawing.Point(1692, 345);
            this.sendTestData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sendTestData.Name = "sendTestData";
            this.sendTestData.Size = new System.Drawing.Size(768, 76);
            this.sendTestData.TabIndex = 9;
            this.sendTestData.Text = "Set Parameter";
            this.sendTestData.UseVisualStyleBackColor = true;
            this.sendTestData.Click += new System.EventHandler(this.sendTestData_Click);
            // 
            // testDataIndexTxt
            // 
            this.testDataIndexTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testDataIndexTxt.Location = new System.Drawing.Point(1072, 260);
            this.testDataIndexTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.testDataIndexTxt.Name = "testDataIndexTxt";
            this.testDataIndexTxt.Size = new System.Drawing.Size(420, 69);
            this.testDataIndexTxt.TabIndex = 8;
            this.testDataIndexTxt.Text = "5";
            // 
            // testDataToSendTxt
            // 
            this.testDataToSendTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testDataToSendTxt.Location = new System.Drawing.Point(1072, 345);
            this.testDataToSendTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.testDataToSendTxt.Name = "testDataToSendTxt";
            this.testDataToSendTxt.Size = new System.Drawing.Size(420, 69);
            this.testDataToSendTxt.TabIndex = 7;
            this.testDataToSendTxt.Text = "3.14159";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(894, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 63);
            this.label1.TabIndex = 11;
            this.label1.Text = "Value";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(901, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 63);
            this.label8.TabIndex = 10;
            this.label8.Text = "Index";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(102, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360, 48);
            this.label7.TabIndex = 4;
            this.label7.Text = "Discovered Nodes";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 48;
            this.listBox1.Location = new System.Drawing.Point(58, 98);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(440, 340);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SerialConsoleTab
            // 
            this.SerialConsoleTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.SerialConsoleTab.Controls.Add(this.txtConsole);
            this.SerialConsoleTab.Location = new System.Drawing.Point(4, 36);
            this.SerialConsoleTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SerialConsoleTab.Name = "SerialConsoleTab";
            this.SerialConsoleTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SerialConsoleTab.Size = new System.Drawing.Size(3118, 1675);
            this.SerialConsoleTab.TabIndex = 2;
            this.SerialConsoleTab.Text = "Console";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.SystemColors.Info;
            this.txtConsole.Location = new System.Drawing.Point(6, 6);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(3106, 1663);
            this.txtConsole.TabIndex = 0;
            // 
            // testTab
            // 
            this.testTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.testTab.Controls.Add(this.testingTabPage1);
            this.testTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.testTab.Location = new System.Drawing.Point(4, 36);
            this.testTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testTab.Name = "testTab";
            this.testTab.Size = new System.Drawing.Size(3118, 1675);
            this.testTab.TabIndex = 6;
            this.testTab.Text = "STOPS";
            // 
            // testingTabPage1
            // 
            this.testingTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.testingTabPage1.Location = new System.Drawing.Point(28, 6);
            this.testingTabPage1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.testingTabPage1.Name = "testingTabPage1";
            this.testingTabPage1.Size = new System.Drawing.Size(2700, 1665);
            this.testingTabPage1.TabIndex = 0;
            // 
            // brakesTab
            // 
            this.brakesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.brakesTab.Controls.Add(this.brakesTabPage1);
            this.brakesTab.Location = new System.Drawing.Point(4, 36);
            this.brakesTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.brakesTab.Name = "brakesTab";
            this.brakesTab.Size = new System.Drawing.Size(3118, 1675);
            this.brakesTab.TabIndex = 7;
            this.brakesTab.Text = "Brakes";
            // 
            // brakesTabPage1
            // 
            this.brakesTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.brakesTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brakesTabPage1.Location = new System.Drawing.Point(0, 0);
            this.brakesTabPage1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.brakesTabPage1.Name = "brakesTabPage1";
            this.brakesTabPage1.Size = new System.Drawing.Size(3118, 1675);
            this.brakesTabPage1.TabIndex = 0;
            // 
            // LGUTab
            // 
            this.LGUTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.LGUTab.Controls.Add(this.lguTabPage1);
            this.LGUTab.Location = new System.Drawing.Point(4, 36);
            this.LGUTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LGUTab.Name = "LGUTab";
            this.LGUTab.Size = new System.Drawing.Size(3118, 1675);
            this.LGUTab.TabIndex = 8;
            this.LGUTab.Text = "LGU";
            // 
            // lguTabPage1
            // 
            this.lguTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lguTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lguTabPage1.Location = new System.Drawing.Point(0, 0);
            this.lguTabPage1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.lguTabPage1.Name = "lguTabPage1";
            this.lguTabPage1.Size = new System.Drawing.Size(3118, 1675);
            this.lguTabPage1.TabIndex = 0;
            // 
            // FCUTab
            // 
            this.FCUTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.FCUTab.Controls.Add(this.fcu1);
            this.FCUTab.Location = new System.Drawing.Point(4, 36);
            this.FCUTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FCUTab.Name = "FCUTab";
            this.FCUTab.Size = new System.Drawing.Size(3118, 1675);
            this.FCUTab.TabIndex = 9;
            this.FCUTab.Text = "FCU";
            // 
            // fcu1
            // 
            this.fcu1.AutoSize = true;
            this.fcu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.fcu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcu1.ForeColor = System.Drawing.Color.Silver;
            this.fcu1.Location = new System.Drawing.Point(0, 0);
            this.fcu1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.fcu1.Name = "fcu1";
            this.fcu1.Size = new System.Drawing.Size(3118, 1675);
            this.fcu1.TabIndex = 0;
            // 
            // powerTab
            // 
            this.powerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.powerTab.Controls.Add(this.powerTabPage1);
            this.powerTab.Location = new System.Drawing.Point(4, 36);
            this.powerTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.powerTab.Name = "powerTab";
            this.powerTab.Size = new System.Drawing.Size(3118, 1675);
            this.powerTab.TabIndex = 10;
            this.powerTab.Text = "Power";
            // 
            // powerTabPage1
            // 
            this.powerTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.powerTabPage1.Location = new System.Drawing.Point(48, 8);
            this.powerTabPage1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.powerTabPage1.Name = "powerTabPage1";
            this.powerTabPage1.Size = new System.Drawing.Size(2362, 1535);
            this.powerTabPage1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2988, 1762);
            this.Controls.Add(this.customTabControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "rLoop Ground Station Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.customTabControl1.ResumeLayout(false);
            this.OverviewTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PowerNodeATab.ResumeLayout(false);
            this.customTabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.NodeUtilitiesTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.SerialConsoleTab.ResumeLayout(false);
            this.SerialConsoleTab.PerformLayout();
            this.testTab.ResumeLayout(false);
            this.brakesTab.ResumeLayout(false);
            this.LGUTab.ResumeLayout(false);
            this.FCUTab.ResumeLayout(false);
            this.FCUTab.PerformLayout();
            this.powerTab.ResumeLayout(false);
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
        private rPodSpeedometer rPodSpeedometer1;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sendTestData;
        private System.Windows.Forms.TextBox testDataIndexTxt;
        private System.Windows.Forms.TextBox testDataToSendTxt;
        private System.Windows.Forms.ComboBox testDataType;
        private System.Windows.Forms.Timer BatteryPackAStatusTab;
        private System.Windows.Forms.Label BrakesAPackVoltage;
        private System.Windows.Forms.Label BrakesAPackTemperature;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage AuxPropTab;
        private System.Windows.Forms.TabPage testTab;
        private TabPanels.TestingTabPage testingTabPage1;
        private System.Windows.Forms.TabPage brakesTab;
        private System.Windows.Forms.TabPage LGUTab;
        private System.Windows.Forms.TabPage FCUTab;
        private TabPanels.LGUTabPage lguTabPage1;
        private TabPanels.BrakesTabPage brakesTabPage1;
        private TabPanels.FCU fcu1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage powerTab;
        private TabPanels.PowerTabPage powerTabPage1;
        private System.Windows.Forms.TextBox txtConsole;
    }
}

