namespace EVCS.查询
{
    partial class find
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eVCSDataSet = new EVCS.EVCSDataSet();
            this.vRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_RecordsTableAdapter = new EVCS.EVCSDataSetTableAdapters.V_RecordsTableAdapter();
            this.车牌DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.体积mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.装载率DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.车牌DataGridViewTextBoxColumn,
            this.开始时间DataGridViewTextBoxColumn,
            this.结束时间DataGridViewTextBoxColumn,
            this.体积mDataGridViewTextBoxColumn,
            this.装载率DataGridViewTextBoxColumn,
            this.备注DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vRecordsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // eVCSDataSet
            // 
            this.eVCSDataSet.DataSetName = "EVCSDataSet";
            this.eVCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vRecordsBindingSource
            // 
            this.vRecordsBindingSource.DataMember = "V_Records";
            this.vRecordsBindingSource.DataSource = this.eVCSDataSet;
            // 
            // v_RecordsTableAdapter
            // 
            this.v_RecordsTableAdapter.ClearBeforeFill = true;
            // 
            // 车牌DataGridViewTextBoxColumn
            // 
            this.车牌DataGridViewTextBoxColumn.DataPropertyName = "车牌";
            this.车牌DataGridViewTextBoxColumn.HeaderText = "车牌";
            this.车牌DataGridViewTextBoxColumn.Name = "车牌DataGridViewTextBoxColumn";
            this.车牌DataGridViewTextBoxColumn.ReadOnly = true;
            this.车牌DataGridViewTextBoxColumn.Width = 150;
            // 
            // 开始时间DataGridViewTextBoxColumn
            // 
            this.开始时间DataGridViewTextBoxColumn.DataPropertyName = "开始时间";
            this.开始时间DataGridViewTextBoxColumn.HeaderText = "开始时间";
            this.开始时间DataGridViewTextBoxColumn.Name = "开始时间DataGridViewTextBoxColumn";
            this.开始时间DataGridViewTextBoxColumn.ReadOnly = true;
            this.开始时间DataGridViewTextBoxColumn.Width = 200;
            // 
            // 结束时间DataGridViewTextBoxColumn
            // 
            this.结束时间DataGridViewTextBoxColumn.DataPropertyName = "结束时间";
            this.结束时间DataGridViewTextBoxColumn.HeaderText = "结束时间";
            this.结束时间DataGridViewTextBoxColumn.Name = "结束时间DataGridViewTextBoxColumn";
            this.结束时间DataGridViewTextBoxColumn.ReadOnly = true;
            this.结束时间DataGridViewTextBoxColumn.Width = 200;
            // 
            // 体积mDataGridViewTextBoxColumn
            // 
            this.体积mDataGridViewTextBoxColumn.DataPropertyName = "体积（m³）";
            this.体积mDataGridViewTextBoxColumn.HeaderText = "体积（m³）";
            this.体积mDataGridViewTextBoxColumn.Name = "体积mDataGridViewTextBoxColumn";
            this.体积mDataGridViewTextBoxColumn.ReadOnly = true;
            this.体积mDataGridViewTextBoxColumn.Width = 145;
            // 
            // 装载率DataGridViewTextBoxColumn
            // 
            this.装载率DataGridViewTextBoxColumn.DataPropertyName = "装载率";
            this.装载率DataGridViewTextBoxColumn.HeaderText = "装载率";
            this.装载率DataGridViewTextBoxColumn.Name = "装载率DataGridViewTextBoxColumn";
            this.装载率DataGridViewTextBoxColumn.ReadOnly = true;
            this.装载率DataGridViewTextBoxColumn.Width = 99;
            // 
            // 备注DataGridViewTextBoxColumn
            // 
            this.备注DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.备注DataGridViewTextBoxColumn.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn.Name = "备注DataGridViewTextBoxColumn";
            this.备注DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 432);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "find";
            this.Text = "find";
            this.Load += new System.EventHandler(this.find_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRecordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EVCSDataSet eVCSDataSet;
        private System.Windows.Forms.BindingSource vRecordsBindingSource;
        private EVCSDataSetTableAdapters.V_RecordsTableAdapter v_RecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 体积mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 装载率DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
    }
}