namespace EVCS.查询
{
    partial class SingleVolume
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
            this.SNSearach = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生成时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.体积DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singlevolumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVCSDataSet = new EVCS.EVCSDataSet();
            this.carInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singlevolumeTableAdapter = new EVCS.EVCSDataSetTableAdapters.SinglevolumeTableAdapter();
            this.carInfosTableAdapter = new EVCS.EVCSDataSetTableAdapters.CarInfosTableAdapter();
            this.tabControl1.SuspendLayout();
            this.SNSearach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singlevolumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SNSearach);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 265);
            this.tabControl1.TabIndex = 1;
            // 
            // SNSearach
            // 
            this.SNSearach.Controls.Add(this.dataGridView3);
            this.SNSearach.Location = new System.Drawing.Point(4, 31);
            this.SNSearach.Name = "SNSearach";
            this.SNSearach.Size = new System.Drawing.Size(730, 230);
            this.SNSearach.TabIndex = 2;
            this.SNSearach.Text = "单体积查询";
            this.SNSearach.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.车牌号DataGridViewTextBoxColumn,
            this.生成时间DataGridViewTextBoxColumn,
            this.体积DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.singlevolumeBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(730, 230);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 车牌号DataGridViewTextBoxColumn
            // 
            this.车牌号DataGridViewTextBoxColumn.DataPropertyName = "车牌号";
            this.车牌号DataGridViewTextBoxColumn.HeaderText = "车牌号";
            this.车牌号DataGridViewTextBoxColumn.Name = "车牌号DataGridViewTextBoxColumn";
            this.车牌号DataGridViewTextBoxColumn.ReadOnly = true;
            this.车牌号DataGridViewTextBoxColumn.Width = 200;
            // 
            // 生成时间DataGridViewTextBoxColumn
            // 
            this.生成时间DataGridViewTextBoxColumn.DataPropertyName = "生成时间";
            this.生成时间DataGridViewTextBoxColumn.HeaderText = "生成时间";
            this.生成时间DataGridViewTextBoxColumn.Name = "生成时间DataGridViewTextBoxColumn";
            this.生成时间DataGridViewTextBoxColumn.ReadOnly = true;
            this.生成时间DataGridViewTextBoxColumn.Width = 200;
            // 
            // 体积DataGridViewTextBoxColumn
            // 
            this.体积DataGridViewTextBoxColumn.DataPropertyName = "体积";
            this.体积DataGridViewTextBoxColumn.HeaderText = "体积";
            this.体积DataGridViewTextBoxColumn.Name = "体积DataGridViewTextBoxColumn";
            this.体积DataGridViewTextBoxColumn.ReadOnly = true;
            this.体积DataGridViewTextBoxColumn.Width = 200;
            // 
            // singlevolumeBindingSource
            // 
            this.singlevolumeBindingSource.DataMember = "Singlevolume";
            this.singlevolumeBindingSource.DataSource = this.eVCSDataSet;
            // 
            // eVCSDataSet
            // 
            this.eVCSDataSet.DataSetName = "EVCSDataSet";
            this.eVCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carInfosBindingSource
            // 
            this.carInfosBindingSource.DataMember = "CarInfos";
            this.carInfosBindingSource.DataSource = this.eVCSDataSet;
            // 
            // singlevolumeTableAdapter
            // 
            this.singlevolumeTableAdapter.ClearBeforeFill = true;
            // 
            // carInfosTableAdapter
            // 
            this.carInfosTableAdapter.ClearBeforeFill = true;
            // 
            // SingleVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 265);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SingleVolume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单体积查询";
            this.Load += new System.EventHandler(this.SingleVolume_Load);
            this.tabControl1.ResumeLayout(false);
            this.SNSearach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singlevolumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SNSearach;
        private System.Windows.Forms.DataGridView dataGridView3;
        private EVCSDataSet eVCSDataSet;
        private EVCSDataSetTableAdapters.SinglevolumeTableAdapter singlevolumeTableAdapter;
        private System.Windows.Forms.BindingSource carInfosBindingSource;
        private EVCSDataSetTableAdapters.CarInfosTableAdapter carInfosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生成时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 体积DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource singlevolumeBindingSource;
    }
}