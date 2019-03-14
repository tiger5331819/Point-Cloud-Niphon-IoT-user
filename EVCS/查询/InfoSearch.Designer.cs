namespace EVCS
{
    partial class InfoSearch
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RecordSearch = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.年 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.体积mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.装载率DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsDayVolumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVCSDataSet1 = new EVCS.EVCSDataSet();
            this.CarInfoSearch = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVCSDataSet = new EVCS.EVCSDataSet();
            this.SNSearach = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberRecordsDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eVCSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSN_Reset = new System.Windows.Forms.Button();
            this.buttonSN_Search = new System.Windows.Forms.Button();
            this.dateTimePickerSNEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSNStart = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSN_CarNubmer = new System.Windows.Forms.ComboBox();
            this.carInfosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialNumberRecordsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carInfosTableAdapter = new EVCS.EVCSDataSetTableAdapters.CarInfosTableAdapter();
            this.serialNumberRecordsDetailsTableAdapter = new EVCS.EVCSDataSetTableAdapters.SerialNumberRecordsDetailsTableAdapter();
            this.records_Day_VolumeTableAdapter = new EVCS.EVCSDataSetTableAdapters.Records_Day_VolumeTableAdapter();
            this.tabControl1.SuspendLayout();
            this.RecordSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDayVolumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet1)).BeginInit();
            this.CarInfoSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).BeginInit();
            this.SNSearach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumberRecordsDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumberRecordsDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RecordSearch);
            this.tabControl1.Controls.Add(this.CarInfoSearch);
            this.tabControl1.Controls.Add(this.SNSearach);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1328, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // RecordSearch
            // 
            this.RecordSearch.Controls.Add(this.dataGridView2);
            this.RecordSearch.Location = new System.Drawing.Point(4, 31);
            this.RecordSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RecordSearch.Name = "RecordSearch";
            this.RecordSearch.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RecordSearch.Size = new System.Drawing.Size(1320, 410);
            this.RecordSearch.TabIndex = 0;
            this.RecordSearch.Text = "录入信息查询";
            this.RecordSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.年,
            this.月,
            this.日,
            this.车牌号,
            this.体积mDataGridViewTextBoxColumn,
            this.装载率DataGridViewTextBoxColumn,
            this.备注DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.recordsDayVolumeBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(6, 5);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1308, 400);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // 年
            // 
            this.年.DataPropertyName = "年";
            this.年.FillWeight = 69.91459F;
            this.年.HeaderText = "年";
            this.年.Name = "年";
            this.年.ReadOnly = true;
            // 
            // 月
            // 
            this.月.DataPropertyName = "月";
            this.月.FillWeight = 61.19954F;
            this.月.HeaderText = "月";
            this.月.Name = "月";
            this.月.ReadOnly = true;
            // 
            // 日
            // 
            this.日.DataPropertyName = "日";
            this.日.FillWeight = 52.01844F;
            this.日.HeaderText = "日";
            this.日.Name = "日";
            this.日.ReadOnly = true;
            // 
            // 车牌号
            // 
            this.车牌号.DataPropertyName = "车牌号";
            this.车牌号.FillWeight = 89.47765F;
            this.车牌号.HeaderText = "车牌号";
            this.车牌号.Name = "车牌号";
            this.车牌号.ReadOnly = true;
            // 
            // 体积mDataGridViewTextBoxColumn
            // 
            this.体积mDataGridViewTextBoxColumn.DataPropertyName = "体积（m³）";
            this.体积mDataGridViewTextBoxColumn.FillWeight = 117.348F;
            this.体积mDataGridViewTextBoxColumn.HeaderText = "体积（m³）";
            this.体积mDataGridViewTextBoxColumn.Name = "体积mDataGridViewTextBoxColumn";
            this.体积mDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 装载率DataGridViewTextBoxColumn
            // 
            this.装载率DataGridViewTextBoxColumn.DataPropertyName = "装载率";
            this.装载率DataGridViewTextBoxColumn.FillWeight = 67.14635F;
            this.装载率DataGridViewTextBoxColumn.HeaderText = "装载率";
            this.装载率DataGridViewTextBoxColumn.Name = "装载率DataGridViewTextBoxColumn";
            this.装载率DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 备注DataGridViewTextBoxColumn
            // 
            this.备注DataGridViewTextBoxColumn.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn.FillWeight = 204.287F;
            this.备注DataGridViewTextBoxColumn.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn.Name = "备注DataGridViewTextBoxColumn";
            this.备注DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recordsDayVolumeBindingSource
            // 
            this.recordsDayVolumeBindingSource.DataMember = "Records_Day_Volume";
            this.recordsDayVolumeBindingSource.DataSource = this.eVCSDataSet1;
            // 
            // eVCSDataSet1
            // 
            this.eVCSDataSet1.DataSetName = "EVCSDataSet";
            this.eVCSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CarInfoSearch
            // 
            this.CarInfoSearch.Controls.Add(this.dataGridView1);
            this.CarInfoSearch.Location = new System.Drawing.Point(4, 31);
            this.CarInfoSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CarInfoSearch.Name = "CarInfoSearch";
            this.CarInfoSearch.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CarInfoSearch.Size = new System.Drawing.Size(1320, 410);
            this.CarInfoSearch.TabIndex = 1;
            this.CarInfoSearch.Text = "车辆信息查询";
            this.CarInfoSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.carNODataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carInfosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // carNODataGridViewTextBoxColumn
            // 
            this.carNODataGridViewTextBoxColumn.DataPropertyName = "CarNO";
            this.carNODataGridViewTextBoxColumn.HeaderText = "车牌号";
            this.carNODataGridViewTextBoxColumn.Name = "carNODataGridViewTextBoxColumn";
            this.carNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "车辆体积";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "联系人";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carInfosBindingSource
            // 
            this.carInfosBindingSource.DataMember = "CarInfos";
            this.carInfosBindingSource.DataSource = this.eVCSDataSet;
            // 
            // eVCSDataSet
            // 
            this.eVCSDataSet.DataSetName = "EVCSDataSet";
            this.eVCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SNSearach
            // 
            this.SNSearach.Controls.Add(this.dataGridView3);
            this.SNSearach.Controls.Add(this.groupBox1);
            this.SNSearach.Location = new System.Drawing.Point(4, 31);
            this.SNSearach.Name = "SNSearach";
            this.SNSearach.Size = new System.Drawing.Size(1320, 410);
            this.SNSearach.TabIndex = 2;
            this.SNSearach.Text = "货运单号查询";
            this.SNSearach.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.carNODataGridViewTextBoxColumn1,
            this.sNDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn,
            this.createUserDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn1,
            this.carNumberDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.serialNumberRecordsDetailsBindingSource1;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView3.Location = new System.Drawing.Point(0, 82);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(1320, 328);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // carNODataGridViewTextBoxColumn1
            // 
            this.carNODataGridViewTextBoxColumn1.DataPropertyName = "CarNO";
            this.carNODataGridViewTextBoxColumn1.HeaderText = "CarNO";
            this.carNODataGridViewTextBoxColumn1.Name = "carNODataGridViewTextBoxColumn1";
            this.carNODataGridViewTextBoxColumn1.ReadOnly = true;
            this.carNODataGridViewTextBoxColumn1.Width = 150;
            // 
            // sNDataGridViewTextBoxColumn
            // 
            this.sNDataGridViewTextBoxColumn.DataPropertyName = "SN";
            this.sNDataGridViewTextBoxColumn.HeaderText = "SN";
            this.sNDataGridViewTextBoxColumn.Name = "sNDataGridViewTextBoxColumn";
            this.sNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNDataGridViewTextBoxColumn.Width = 300;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "Datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Datetime";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // createUserDataGridViewTextBoxColumn
            // 
            this.createUserDataGridViewTextBoxColumn.DataPropertyName = "CreateUser";
            this.createUserDataGridViewTextBoxColumn.HeaderText = "CreateUser";
            this.createUserDataGridViewTextBoxColumn.Name = "createUserDataGridViewTextBoxColumn";
            this.createUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn1
            // 
            this.remarkDataGridViewTextBoxColumn1.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn1.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn1.Name = "remarkDataGridViewTextBoxColumn1";
            this.remarkDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.carNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // serialNumberRecordsDetailsBindingSource1
            // 
            this.serialNumberRecordsDetailsBindingSource1.DataMember = "SerialNumberRecordsDetails";
            this.serialNumberRecordsDetailsBindingSource1.DataSource = this.eVCSDataSetBindingSource;
            // 
            // eVCSDataSetBindingSource
            // 
            this.eVCSDataSetBindingSource.DataSource = this.eVCSDataSet;
            this.eVCSDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSN_Reset);
            this.groupBox1.Controls.Add(this.buttonSN_Search);
            this.groupBox1.Controls.Add(this.dateTimePickerSNEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerSNStart);
            this.groupBox1.Controls.Add(this.comboBoxSN_CarNubmer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1320, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonSN_Reset
            // 
            this.buttonSN_Reset.Location = new System.Drawing.Point(1035, 20);
            this.buttonSN_Reset.Name = "buttonSN_Reset";
            this.buttonSN_Reset.Size = new System.Drawing.Size(75, 31);
            this.buttonSN_Reset.TabIndex = 7;
            this.buttonSN_Reset.Text = "重置";
            this.buttonSN_Reset.UseVisualStyleBackColor = true;
            this.buttonSN_Reset.Click += new System.EventHandler(this.buttonSN_Reset_Click);
            // 
            // buttonSN_Search
            // 
            this.buttonSN_Search.Location = new System.Drawing.Point(940, 22);
            this.buttonSN_Search.Name = "buttonSN_Search";
            this.buttonSN_Search.Size = new System.Drawing.Size(75, 31);
            this.buttonSN_Search.TabIndex = 6;
            this.buttonSN_Search.Text = "查询";
            this.buttonSN_Search.UseVisualStyleBackColor = true;
            this.buttonSN_Search.Click += new System.EventHandler(this.buttonSN_Search_Click_1);
            // 
            // dateTimePickerSNEnd
            // 
            this.dateTimePickerSNEnd.Location = new System.Drawing.Point(681, 22);
            this.dateTimePickerSNEnd.Name = "dateTimePickerSNEnd";
            this.dateTimePickerSNEnd.Size = new System.Drawing.Size(186, 31);
            this.dateTimePickerSNEnd.TabIndex = 5;
            // 
            // dateTimePickerSNStart
            // 
            this.dateTimePickerSNStart.Location = new System.Drawing.Point(360, 23);
            this.dateTimePickerSNStart.Name = "dateTimePickerSNStart";
            this.dateTimePickerSNStart.Size = new System.Drawing.Size(186, 31);
            this.dateTimePickerSNStart.TabIndex = 4;
            this.dateTimePickerSNStart.ValueChanged += new System.EventHandler(this.dateTimePickerSNStart_ValueChanged);
            // 
            // comboBoxSN_CarNubmer
            // 
            this.comboBoxSN_CarNubmer.DataSource = this.carInfosBindingSource1;
            this.comboBoxSN_CarNubmer.DisplayMember = "CarNO";
            this.comboBoxSN_CarNubmer.FormattingEnabled = true;
            this.comboBoxSN_CarNubmer.Location = new System.Drawing.Point(104, 23);
            this.comboBoxSN_CarNubmer.Name = "comboBoxSN_CarNubmer";
            this.comboBoxSN_CarNubmer.Size = new System.Drawing.Size(144, 29);
            this.comboBoxSN_CarNubmer.TabIndex = 3;
            this.comboBoxSN_CarNubmer.ValueMember = "CarNO";
            this.comboBoxSN_CarNubmer.SelectedIndexChanged += new System.EventHandler(this.comboBoxSN_CarNubmer_SelectedIndexChanged);
            // 
            // carInfosBindingSource1
            // 
            this.carInfosBindingSource1.DataMember = "CarInfos";
            this.carInfosBindingSource1.DataSource = this.eVCSDataSetBindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "开始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "结束时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号：";
            // 
            // serialNumberRecordsDetailsBindingSource
            // 
            this.serialNumberRecordsDetailsBindingSource.DataMember = "SerialNumberRecordsDetails";
            this.serialNumberRecordsDetailsBindingSource.DataSource = this.eVCSDataSetBindingSource;
            // 
            // carInfosTableAdapter
            // 
            this.carInfosTableAdapter.ClearBeforeFill = true;
            // 
            // serialNumberRecordsDetailsTableAdapter
            // 
            this.serialNumberRecordsDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // records_Day_VolumeTableAdapter
            // 
            this.records_Day_VolumeTableAdapter.ClearBeforeFill = true;
            // 
            // InfoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 445);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "InfoSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息查询";
            this.Load += new System.EventHandler(this.InfoSearch_Load);
            this.tabControl1.ResumeLayout(false);
            this.RecordSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDayVolumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet1)).EndInit();
            this.CarInfoSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).EndInit();
            this.SNSearach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumberRecordsDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumberRecordsDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RecordSearch;
        private System.Windows.Forms.TabPage CarInfoSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EVCSDataSet eVCSDataSet;
        private System.Windows.Forms.BindingSource carInfosBindingSource;
        private EVCSDataSetTableAdapters.CarInfosTableAdapter carInfosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource eVCSDataSetBindingSource;
        private EVCSDataSet eVCSDataSet1;
        private System.Windows.Forms.TabPage SNSearach;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource serialNumberRecordsDetailsBindingSource;
        private EVCSDataSetTableAdapters.SerialNumberRecordsDetailsTableAdapter serialNumberRecordsDetailsTableAdapter;
        private System.Windows.Forms.BindingSource serialNumberRecordsDetailsBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSNEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerSNStart;
        private System.Windows.Forms.ComboBox comboBoxSN_CarNubmer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSN_Reset;
        private System.Windows.Forms.Button buttonSN_Search;
        private System.Windows.Forms.BindingSource carInfosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recordsDayVolumeBindingSource;
        private EVCSDataSetTableAdapters.Records_Day_VolumeTableAdapter records_Day_VolumeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 体积mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 装载率DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
    }
}