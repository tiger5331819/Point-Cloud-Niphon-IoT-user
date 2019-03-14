namespace EVCS.调配.车辆调配
{
    partial class AddCarTask
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCarno = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.eVCSDataSet = new EVCS.EVCSDataSet();
            this.carInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carInfosTableAdapter = new EVCS.EVCSDataSetTableAdapters.CarInfosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "添加任务";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carInfosBindingSource;
            this.comboBox1.DisplayMember = "CarNO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 20);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "ID";
            // 
            // labelCarno
            // 
            this.labelCarno.AutoSize = true;
            this.labelCarno.Location = new System.Drawing.Point(32, 74);
            this.labelCarno.Name = "labelCarno";
            this.labelCarno.Size = new System.Drawing.Size(53, 12);
            this.labelCarno.TabIndex = 7;
            this.labelCarno.Text = "车牌号：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 21);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "时间：";
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
            // carInfosTableAdapter
            // 
            this.carInfosTableAdapter.ClearBeforeFill = true;
            // 
            // AddCarTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelCarno);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "AddCarTask";
            this.Text = "AddCarTask";
            this.Load += new System.EventHandler(this.AddCarTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelCarno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private EVCSDataSet eVCSDataSet;
        private System.Windows.Forms.BindingSource carInfosBindingSource;
        private EVCSDataSetTableAdapters.CarInfosTableAdapter carInfosTableAdapter;
    }
}