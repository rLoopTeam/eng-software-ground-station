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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datatype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ParametersDataSet = new System.Data.DataSet();
            this.DataTypesDataSet = new System.Data.DataSet();
            this.Types_Table = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParameterPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTypesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Types_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // UDPAnnounceTXT
            // 
            this.UDPAnnounceTXT.Location = new System.Drawing.Point(46, 79);
            this.UDPAnnounceTXT.Margin = new System.Windows.Forms.Padding(6);
            this.UDPAnnounceTXT.Name = "UDPAnnounceTXT";
            this.UDPAnnounceTXT.Size = new System.Drawing.Size(534, 31);
            this.UDPAnnounceTXT.TabIndex = 0;
            this.UDPAnnounceTXT.Text = "PowerA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "UDP Announce Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ZMQ Node Name";
            // 
            // ZMQNodeTXT
            // 
            this.ZMQNodeTXT.Location = new System.Drawing.Point(46, 179);
            this.ZMQNodeTXT.Margin = new System.Windows.Forms.Padding(6);
            this.ZMQNodeTXT.Name = "ZMQNodeTXT";
            this.ZMQNodeTXT.Size = new System.Drawing.Size(534, 31);
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
            this.testDataType.Location = new System.Drawing.Point(684, 260);
            this.testDataType.Margin = new System.Windows.Forms.Padding(6);
            this.testDataType.Name = "testDataType";
            this.testDataType.Size = new System.Drawing.Size(238, 33);
            this.testDataType.TabIndex = 18;
            this.testDataType.Text = "Data Type";
            this.testDataType.SelectedIndexChanged += new System.EventHandler(this.testDataType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(350, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(74, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Index";
            // 
            // testDataIndexTxt
            // 
            this.testDataIndexTxt.Location = new System.Drawing.Point(46, 263);
            this.testDataIndexTxt.Margin = new System.Windows.Forms.Padding(6);
            this.testDataIndexTxt.Name = "testDataIndexTxt";
            this.testDataIndexTxt.Size = new System.Drawing.Size(126, 31);
            this.testDataIndexTxt.TabIndex = 14;
            this.testDataIndexTxt.Text = "21";
            // 
            // testDataToSendTxt
            // 
            this.testDataToSendTxt.Location = new System.Drawing.Point(210, 263);
            this.testDataToSendTxt.Margin = new System.Windows.Forms.Padding(6);
            this.testDataToSendTxt.Name = "testDataToSendTxt";
            this.testDataToSendTxt.Size = new System.Drawing.Size(440, 31);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.value,
            this.datatype});
            this.dataGridView1.DataSource = this.ParametersDataSet;
            this.dataGridView1.Location = new System.Drawing.Point(12, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(790, 315);
            this.dataGridView1.TabIndex = 19;
            // 
            // index
            // 
            this.index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.index.DataPropertyName = "index";
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value.DataPropertyName = "value";
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // datatype
            // 
            this.datatype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datatype.DataPropertyName = "datatype";
            this.datatype.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.datatype.HeaderText = "Data type";
            this.datatype.Items.AddRange(new object[] {
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
            this.datatype.Name = "datatype";
            this.datatype.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.datatype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ParametersDataSet
            // 
            this.ParametersDataSet.DataSetName = "ParametersDataSet";
            // 
            // DataTypesDataSet
            // 
            this.DataTypesDataSet.DataSetName = "DataTypesDataSet";
            this.DataTypesDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.Types_Table});
            // 
            // Types_Table
            // 
            this.Types_Table.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.Types_Table.TableName = "Types";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "value";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(623, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Parameter File";
            // 
            // txtParameterPath
            // 
            this.txtParameterPath.Location = new System.Drawing.Point(623, 179);
            this.txtParameterPath.Margin = new System.Windows.Forms.Padding(6);
            this.txtParameterPath.Name = "txtParameterPath";
            this.txtParameterPath.Size = new System.Drawing.Size(300, 31);
            this.txtParameterPath.TabIndex = 20;
            this.txtParameterPath.Text = "PARAMETERS.xml";
            this.txtParameterPath.Leave += new System.EventHandler(this.txtParameterPath_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(974, 699);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParameterPath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.testDataType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.testDataIndexTxt);
            this.Controls.Add(this.testDataToSendTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZMQNodeTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UDPAnnounceTXT);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Test Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTypesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Types_Table)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet ParametersDataSet;
        private System.Data.DataSet DataTypesDataSet;
        private System.Data.DataTable Types_Table;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewComboBoxColumn datatype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParameterPath;
    }
}

