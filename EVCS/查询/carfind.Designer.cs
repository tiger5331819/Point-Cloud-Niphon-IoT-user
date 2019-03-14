namespace EVCS.查询
{
    partial class carfind
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
            this.textBoxCarNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordsDayVolumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVCSDataSet = new EVCS.EVCSDataSet();
            this.comboBoxCarInfoLists = new System.Windows.Forms.ComboBox();
            this.carInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.carInfosTableAdapter = new EVCS.EVCSDataSetTableAdapters.CarInfosTableAdapter();
            this.records_Day_VolumeTableAdapter = new EVCS.EVCSDataSetTableAdapters.Records_Day_VolumeTableAdapter();
            this.车牌号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.体积mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.装载率DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDayVolumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCarNO
            // 
            this.textBoxCarNO.Location = new System.Drawing.Point(13, -88);
            this.textBoxCarNO.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxCarNO.Name = "textBoxCarNO";
            this.textBoxCarNO.Size = new System.Drawing.Size(222, 21);
            this.textBoxCarNO.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-128, -94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "车牌号：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(-252, -108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(73, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "车牌号：";
            this.label2.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(660, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.车牌号DataGridViewTextBoxColumn,
            this.体积mDataGridViewTextBoxColumn,
            this.装载率DataGridViewTextBoxColumn,
            this.备注DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recordsDayVolumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(998, 418);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // recordsDayVolumeBindingSource
            // 
            this.recordsDayVolumeBindingSource.DataMember = "Records_Day_Volume";
            this.recordsDayVolumeBindingSource.DataSource = this.eVCSDataSet;
            // 
            // eVCSDataSet
            // 
            this.eVCSDataSet.DataSetName = "EVCSDataSet";
            this.eVCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxCarInfoLists
            // 
            this.comboBoxCarInfoLists.DataSource = this.carInfosBindingSource;
            this.comboBoxCarInfoLists.DisplayMember = "ID";
            this.comboBoxCarInfoLists.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCarInfoLists.FormattingEnabled = true;
            this.comboBoxCarInfoLists.Location = new System.Drawing.Point(202, 20);
            this.comboBoxCarInfoLists.Name = "comboBoxCarInfoLists";
            this.comboBoxCarInfoLists.Size = new System.Drawing.Size(194, 29);
            this.comboBoxCarInfoLists.TabIndex = 19;
            this.comboBoxCarInfoLists.ValueMember = "ID";
            this.comboBoxCarInfoLists.Visible = false;
            this.comboBoxCarInfoLists.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarInfoLists_SelectedIndexChanged);
            // 
            // carInfosBindingSource
            // 
            this.carInfosBindingSource.DataMember = "CarInfos";
            this.carInfosBindingSource.DataSource = this.eVCSDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxCarInfoLists);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 63);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.28226F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 496);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // carInfosTableAdapter
            // 
            this.carInfosTableAdapter.ClearBeforeFill = true;
            // 
            // records_Day_VolumeTableAdapter
            // 
            this.records_Day_VolumeTableAdapter.ClearBeforeFill = true;
            // 
            // 车牌号DataGridViewTextBoxColumn
            // 
            this.车牌号DataGridViewTextBoxColumn.DataPropertyName = "车牌号";
            this.车牌号DataGridViewTextBoxColumn.HeaderText = "车牌号";
            this.车牌号DataGridViewTextBoxColumn.Name = "车牌号DataGridViewTextBoxColumn";
            this.车牌号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 体积mDataGridViewTextBoxColumn
            // 
            this.体积mDataGridViewTextBoxColumn.DataPropertyName = "体积（m³）";
            this.体积mDataGridViewTextBoxColumn.HeaderText = "体积（m³）";
            this.体积mDataGridViewTextBoxColumn.Name = "体积mDataGridViewTextBoxColumn";
            this.体积mDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 装载率DataGridViewTextBoxColumn
            // 
            this.装载率DataGridViewTextBoxColumn.DataPropertyName = "装载率";
            this.装载率DataGridViewTextBoxColumn.HeaderText = "装载率";
            this.装载率DataGridViewTextBoxColumn.Name = "装载率DataGridViewTextBoxColumn";
            this.装载率DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 备注DataGridViewTextBoxColumn
            // 
            this.备注DataGridViewTextBoxColumn.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn.Name = "备注DataGridViewTextBoxColumn";
            this.备注DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxCarNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "carfind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日期查询";
            this.Load += new System.EventHandler(this.carfind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDayVolumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCarNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EVCSDataSet eVCSDataSet;
        protected System.Windows.Forms.ComboBox comboBoxCarInfoLists;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource carInfosBindingSource;
        private EVCSDataSetTableAdapters.CarInfosTableAdapter carInfosTableAdapter;
        private System.Windows.Forms.BindingSource recordsDayVolumeBindingSource;
        private EVCSDataSetTableAdapters.Records_Day_VolumeTableAdapter records_Day_VolumeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 体积mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 装载率DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
    }
}