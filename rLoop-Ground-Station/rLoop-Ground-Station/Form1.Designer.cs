﻿namespace rLoop_Ground_Station
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
            System.Windows.Forms.Timer HEguiDemo;
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UpdateNodeList = new System.Windows.Forms.Timer(this.components);
            this.UpdateDGVTimer = new System.Windows.Forms.Timer(this.components);
            this.BatteryPackAStatusTab = new System.Windows.Forms.Timer(this.components);
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
            this.MotorTab = new System.Windows.Forms.TabPage();
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
            this.ControlNodeTab = new System.Windows.Forms.TabPage();
            this.CommandNodeTab = new System.Windows.Forms.TabPage();
            this.BrakesNodeATab = new System.Windows.Forms.TabPage();
            this.BrakesNodeBTab = new System.Windows.Forms.TabPage();
            this.StepperNodeTab = new System.Windows.Forms.TabPage();
            this.NodeUtilitiesTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SerialConsoleTab = new System.Windows.Forms.TabPage();
            this.podStateControl2 = new rLoop_Ground_Station.PodStateControl();
            this.rPodSpeedometer1 = new rLoop_Ground_Station.rPodSpeedometer();
            this.rPodGyro1 = new rLoop_Ground_Station.rPodGyro();
            this.rPodCurrentGauge2 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodCurrentGauge();
            this.rPodBatteryIndicator1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodBatteryVoltage();
            this.rPodCurrentGauge1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodCurrentGauge();
            this.rPodBatteryVoltage1 = new rLoop_Ground_Station.rPod_GUI_Elements.rPodBatteryVoltage();
            HEguiDemo = new System.Windows.Forms.Timer(this.components);
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
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HEguiDemo
            // 
            HEguiDemo.Enabled = true;
            HEguiDemo.Interval = 50;
            HEguiDemo.Tick += new System.EventHandler(this.timer2_Tick);
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
            // customTabControl1
            // 
            this.customTabControl1.Controls.Add(this.OverviewTab);
            this.customTabControl1.Controls.Add(this.MotorTab);
            this.customTabControl1.Controls.Add(this.PowerNodeATab);
            this.customTabControl1.Controls.Add(this.PowerNodeBTab);
            this.customTabControl1.Controls.Add(this.ControlNodeTab);
            this.customTabControl1.Controls.Add(this.CommandNodeTab);
            this.customTabControl1.Controls.Add(this.BrakesNodeATab);
            this.customTabControl1.Controls.Add(this.BrakesNodeBTab);
            this.customTabControl1.Controls.Add(this.StepperNodeTab);
            this.customTabControl1.Controls.Add(this.NodeUtilitiesTab);
            this.customTabControl1.Controls.Add(this.SerialConsoleTab);
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
            this.customTabControl1.Location = new System.Drawing.Point(24, 23);
            this.customTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(2634, 1435);
            this.customTabControl1.TabIndex = 13;
            // 
            // OverviewTab
            // 
            this.OverviewTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.OverviewTab.Controls.Add(this.panel1);
            this.OverviewTab.Controls.Add(this.panel2);
            this.OverviewTab.Location = new System.Drawing.Point(4, 38);
            this.OverviewTab.Margin = new System.Windows.Forms.Padding(6);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Padding = new System.Windows.Forms.Padding(6);
            this.OverviewTab.Size = new System.Drawing.Size(2626, 1393);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2614, 689);
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
            this.panel2.Location = new System.Drawing.Point(6, 695);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2614, 692);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(1502, 33);
            this.trackBar5.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar5.Maximum = 400;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(350, 90);
            this.trackBar5.TabIndex = 10;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1090, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height";
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(1230, 381);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(596, 90);
            this.trackBar4.TabIndex = 4;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1090, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Power";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1230, 150);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(624, 90);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1230, 225);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar2.Maximum = 4000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(624, 90);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(1230, 306);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar3.Maximum = 5000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(596, 90);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1090, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "RPM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1090, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Percent";
            // 
            // MotorTab
            // 
            this.MotorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.MotorTab.Location = new System.Drawing.Point(4, 38);
            this.MotorTab.Margin = new System.Windows.Forms.Padding(6);
            this.MotorTab.Name = "MotorTab";
            this.MotorTab.Size = new System.Drawing.Size(2626, 1393);
            this.MotorTab.TabIndex = 10;
            this.MotorTab.Text = "HEs";
            // 
            // PowerNodeATab
            // 
            this.PowerNodeATab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.PowerNodeATab.Controls.Add(this.customTabControl2);
            this.PowerNodeATab.Location = new System.Drawing.Point(4, 38);
            this.PowerNodeATab.Margin = new System.Windows.Forms.Padding(6);
            this.PowerNodeATab.Name = "PowerNodeATab";
            this.PowerNodeATab.Padding = new System.Windows.Forms.Padding(6);
            this.PowerNodeATab.Size = new System.Drawing.Size(2626, 1393);
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
            this.customTabControl2.Margin = new System.Windows.Forms.Padding(6);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2421, 1065);
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
            this.tabPage5.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(2498, 1182);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Charger";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(2498, 1182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BMS 1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(2498, 1182);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BMS 2";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(2498, 1182);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "BMS 3";
            // 
            // PowerNodeBTab
            // 
            this.PowerNodeBTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.PowerNodeBTab.Location = new System.Drawing.Point(4, 38);
            this.PowerNodeBTab.Margin = new System.Windows.Forms.Padding(6);
            this.PowerNodeBTab.Name = "PowerNodeBTab";
            this.PowerNodeBTab.Size = new System.Drawing.Size(2626, 1393);
            this.PowerNodeBTab.TabIndex = 4;
            this.PowerNodeBTab.Text = "Power B";
            // 
            // ControlNodeTab
            // 
            this.ControlNodeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.ControlNodeTab.Location = new System.Drawing.Point(4, 38);
            this.ControlNodeTab.Margin = new System.Windows.Forms.Padding(6);
            this.ControlNodeTab.Name = "ControlNodeTab";
            this.ControlNodeTab.Size = new System.Drawing.Size(2626, 1393);
            this.ControlNodeTab.TabIndex = 5;
            this.ControlNodeTab.Text = "Control";
            // 
            // CommandNodeTab
            // 
            this.CommandNodeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.CommandNodeTab.Location = new System.Drawing.Point(4, 38);
            this.CommandNodeTab.Margin = new System.Windows.Forms.Padding(6);
            this.CommandNodeTab.Name = "CommandNodeTab";
            this.CommandNodeTab.Size = new System.Drawing.Size(2626, 1393);
            this.CommandNodeTab.TabIndex = 6;
            this.CommandNodeTab.Text = "Command";
            // 
            // BrakesNodeATab
            // 
            this.BrakesNodeATab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.BrakesNodeATab.Location = new System.Drawing.Point(4, 38);
            this.BrakesNodeATab.Margin = new System.Windows.Forms.Padding(6);
            this.BrakesNodeATab.Name = "BrakesNodeATab";
            this.BrakesNodeATab.Size = new System.Drawing.Size(2626, 1393);
            this.BrakesNodeATab.TabIndex = 7;
            this.BrakesNodeATab.Text = "Brakes A";
            // 
            // BrakesNodeBTab
            // 
            this.BrakesNodeBTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.BrakesNodeBTab.Location = new System.Drawing.Point(4, 38);
            this.BrakesNodeBTab.Margin = new System.Windows.Forms.Padding(6);
            this.BrakesNodeBTab.Name = "BrakesNodeBTab";
            this.BrakesNodeBTab.Size = new System.Drawing.Size(2626, 1393);
            this.BrakesNodeBTab.TabIndex = 8;
            this.BrakesNodeBTab.Text = "Brakes B";
            // 
            // StepperNodeTab
            // 
            this.StepperNodeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.StepperNodeTab.Location = new System.Drawing.Point(4, 38);
            this.StepperNodeTab.Margin = new System.Windows.Forms.Padding(6);
            this.StepperNodeTab.Name = "StepperNodeTab";
            this.StepperNodeTab.Size = new System.Drawing.Size(2626, 1393);
            this.StepperNodeTab.TabIndex = 9;
            this.StepperNodeTab.Text = "Stepper";
            // 
            // NodeUtilitiesTab
            // 
            this.NodeUtilitiesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.NodeUtilitiesTab.Controls.Add(this.panel5);
            this.NodeUtilitiesTab.Controls.Add(this.panel4);
            this.NodeUtilitiesTab.Controls.Add(this.panel3);
            this.NodeUtilitiesTab.Location = new System.Drawing.Point(4, 38);
            this.NodeUtilitiesTab.Margin = new System.Windows.Forms.Padding(6);
            this.NodeUtilitiesTab.Name = "NodeUtilitiesTab";
            this.NodeUtilitiesTab.Padding = new System.Windows.Forms.Padding(6);
            this.NodeUtilitiesTab.Size = new System.Drawing.Size(2626, 1393);
            this.NodeUtilitiesTab.TabIndex = 1;
            this.NodeUtilitiesTab.Text = "Node Utilities";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(6, 1195);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2614, 192);
            this.panel5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1426, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Program Teensy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1426, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(6, 494);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2614, 893);
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(2614, 893);
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
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2614, 488);
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
            this.testDataType.Location = new System.Drawing.Point(1686, 354);
            this.testDataType.Margin = new System.Windows.Forms.Padding(6);
            this.testDataType.Name = "testDataType";
            this.testDataType.Size = new System.Drawing.Size(238, 33);
            this.testDataType.TabIndex = 12;
            this.testDataType.Text = "Data Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1352, 402);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1076, 402);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Index";
            // 
            // sendTestData
            // 
            this.sendTestData.Location = new System.Drawing.Point(1530, 408);
            this.sendTestData.Margin = new System.Windows.Forms.Padding(6);
            this.sendTestData.Name = "sendTestData";
            this.sendTestData.Size = new System.Drawing.Size(398, 44);
            this.sendTestData.TabIndex = 9;
            this.sendTestData.Text = "Set Parameter";
            this.sendTestData.UseVisualStyleBackColor = true;
            this.sendTestData.Click += new System.EventHandler(this.sendTestData_Click);
            // 
            // testDataIndexTxt
            // 
            this.testDataIndexTxt.Location = new System.Drawing.Point(1048, 358);
            this.testDataIndexTxt.Margin = new System.Windows.Forms.Padding(6);
            this.testDataIndexTxt.Name = "testDataIndexTxt";
            this.testDataIndexTxt.Size = new System.Drawing.Size(126, 31);
            this.testDataIndexTxt.TabIndex = 8;
            this.testDataIndexTxt.Text = "5";
            // 
            // testDataToSendTxt
            // 
            this.testDataToSendTxt.Location = new System.Drawing.Point(1212, 358);
            this.testDataToSendTxt.Margin = new System.Windows.Forms.Padding(6);
            this.testDataToSendTxt.Name = "testDataToSendTxt";
            this.testDataToSendTxt.Size = new System.Drawing.Size(440, 31);
            this.testDataToSendTxt.TabIndex = 7;
            this.testDataToSendTxt.Text = "3.14159";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1212, 173);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "New Node Name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1212, 223);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(442, 60);
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
            this.label7.Location = new System.Drawing.Point(180, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360, 48);
            this.label7.TabIndex = 4;
            this.label7.Text = "Discovered Nodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(852, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(58, 96);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(648, 279);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SerialConsoleTab
            // 
            this.SerialConsoleTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.SerialConsoleTab.Location = new System.Drawing.Point(4, 38);
            this.SerialConsoleTab.Margin = new System.Windows.Forms.Padding(6);
            this.SerialConsoleTab.Name = "SerialConsoleTab";
            this.SerialConsoleTab.Padding = new System.Windows.Forms.Padding(6);
            this.SerialConsoleTab.Size = new System.Drawing.Size(2626, 1393);
            this.SerialConsoleTab.TabIndex = 2;
            this.SerialConsoleTab.Text = "Console";
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
            this.podStateControl2.Size = new System.Drawing.Size(1664, 689);
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
            this.rPodGyro1.Location = new System.Drawing.Point(2176, 0);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2568, 1481);
            this.Controls.Add(this.customTabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "rLoop Ground Station Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer UpdateNodeList;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TabPage ControlNodeTab;
        private System.Windows.Forms.TabPage CommandNodeTab;
        private System.Windows.Forms.TabPage BrakesNodeATab;
        private System.Windows.Forms.TabPage BrakesNodeBTab;
        private System.Windows.Forms.TabPage StepperNodeTab;
        private rPod_GUI_Elements.rPodBatteryVoltage rPodBatteryIndicator1;
        private rPod_GUI_Elements.rPodBatteryVoltage rPodBatteryVoltage1;
        private rPod_GUI_Elements.rPodCurrentGauge rPodCurrentGauge1;
        private System.Windows.Forms.CustomTabControl customTabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage MotorTab;
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
    }
}

