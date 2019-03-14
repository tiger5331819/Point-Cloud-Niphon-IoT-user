namespace EVCS.调配.车辆调配
{
    partial class CarTasksLists
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCarTasksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eVCSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVCSDataSet = new EVCS.EVCSDataSet();
            this.carTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTasksTableAdapter = new EVCS.EVCSDataSetTableAdapters.CarTasksTableAdapter();
            this.vCarTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_CarTasksTableAdapter = new EVCS.EVCSDataSetTableAdapters.V_CarTasksTableAdapter();
            this.vCarTasksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCarTasksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCarTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCarTasksBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.92337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.07663F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.taskDateDataGridViewTextBoxColumn,
            this.carNODataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vCarTasksBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(664, 204);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // taskDateDataGridViewTextBoxColumn
            // 
            this.taskDateDataGridViewTextBoxColumn.DataPropertyName = "TaskDate";
            this.taskDateDataGridViewTextBoxColumn.HeaderText = "TaskDate";
            this.taskDateDataGridViewTextBoxColumn.Name = "taskDateDataGridViewTextBoxColumn";
            this.taskDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carNODataGridViewTextBoxColumn
            // 
            this.carNODataGridViewTextBoxColumn.DataPropertyName = "CarNO";
            this.carNODataGridViewTextBoxColumn.HeaderText = "CarNO";
            this.carNODataGridViewTextBoxColumn.Name = "carNODataGridViewTextBoxColumn";
            this.carNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vCarTasksBindingSource2
            // 
            this.vCarTasksBindingSource2.DataMember = "V_CarTasks";
            this.vCarTasksBindingSource2.DataSource = this.eVCSDataSetBindingSource;
            // 
            // eVCSDataSetBindingSource
            // 
            this.eVCSDataSetBindingSource.DataSource = this.eVCSDataSet;
            this.eVCSDataSetBindingSource.Position = 0;
            // 
            // eVCSDataSet
            // 
            this.eVCSDataSet.DataSetName = "EVCSDataSet";
            this.eVCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTasksBindingSource
            // 
            this.carTasksBindingSource.DataMember = "CarTasks";
            this.carTasksBindingSource.DataSource = this.eVCSDataSetBindingSource;
            // 
            // carTasksTableAdapter
            // 
            this.carTasksTableAdapter.ClearBeforeFill = true;
            // 
            // vCarTasksBindingSource
            // 
            this.vCarTasksBindingSource.DataMember = "V_CarTasks";
            this.vCarTasksBindingSource.DataSource = this.eVCSDataSetBindingSource;
            // 
            // v_CarTasksTableAdapter
            // 
            this.v_CarTasksTableAdapter.ClearBeforeFill = true;
            // 
            // vCarTasksBindingSource1
            // 
            this.vCarTasksBindingSource1.DataMember = "V_CarTasks";
            this.vCarTasksBindingSource1.DataSource = this.eVCSDataSet;
            // 
            // CarTasksLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CarTasksLists";
            this.Text = "CarTasksLists";
            this.Load += new System.EventHandler(this.CarTasksLists_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCarTasksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCarTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCarTasksBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private EVCSDataSet eVCSDataSet;
        private System.Windows.Forms.BindingSource eVCSDataSetBindingSource;
        private System.Windows.Forms.BindingSource carTasksBindingSource;
        private EVCSDataSetTableAdapters.CarTasksTableAdapter carTasksTableAdapter;
        private System.Windows.Forms.BindingSource vCarTasksBindingSource;
        private EVCSDataSetTableAdapters.V_CarTasksTableAdapter v_CarTasksTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vCarTasksBindingSource2;
        private System.Windows.Forms.BindingSource vCarTasksBindingSource1;
    }
}