namespace EVCS
{
    partial class Calc
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCarInfoLists = new System.Windows.Forms.ComboBox();
            this.carInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVCSDataSet = new EVCS.EVCSDataSet();
            this.serialNumberRecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carInfosTableAdapter = new EVCS.EVCSDataSetTableAdapters.CarInfosTableAdapter();
            this.buttonOperate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelvolumetext = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCurrentPercent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarPercent = new System.Windows.Forms.ProgressBar();
            this.progressBarWait = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.labelCarNumber = new System.Windows.Forms.Label();
            this.serialNumberRecordsTableAdapter = new EVCS.EVCSDataSetTableAdapters.SerialNumberRecordsTableAdapter();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumberRecordsBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "货运单号：";
            // 
            // comboBoxCarInfoLists
            // 
            this.comboBoxCarInfoLists.DataSource = this.carInfosBindingSource;
            this.comboBoxCarInfoLists.DisplayMember = "CarNO";
            this.comboBoxCarInfoLists.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCarInfoLists.FormattingEnabled = true;
            this.comboBoxCarInfoLists.Location = new System.Drawing.Point(119, 12);
            this.comboBoxCarInfoLists.Name = "comboBoxCarInfoLists";
            this.comboBoxCarInfoLists.Size = new System.Drawing.Size(264, 29);
            this.comboBoxCarInfoLists.TabIndex = 2;
            this.comboBoxCarInfoLists.ValueMember = "ID";
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
            // serialNumberRecordsBindingSource1
            // 
            this.serialNumberRecordsBindingSource1.DataMember = "SerialNumberRecords";
            this.serialNumberRecordsBindingSource1.DataSource = this.eVCSDataSet;
            // 
            // carInfosTableAdapter
            // 
            this.carInfosTableAdapter.ClearBeforeFill = true;
            // 
            // buttonOperate
            // 
            this.buttonOperate.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOperate.Location = new System.Drawing.Point(27, 140);
            this.buttonOperate.Name = "buttonOperate";
            this.buttonOperate.Size = new System.Drawing.Size(208, 114);
            this.buttonOperate.TabIndex = 3;
            this.buttonOperate.Text = "开始";
            this.buttonOperate.UseVisualStyleBackColor = true;
            this.buttonOperate.Click += new System.EventHandler(this.buttonOperate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(44, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "体积：";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVolume.Location = new System.Drawing.Point(107, 54);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(0, 21);
            this.labelVolume.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelvolumetext);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelcount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelCurrentPercent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.progressBarPercent);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(423, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 278);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "装载信息展示";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelvolumetext
            // 
            this.labelvolumetext.AutoSize = true;
            this.labelvolumetext.Location = new System.Drawing.Point(134, 236);
            this.labelvolumetext.Name = "labelvolumetext";
            this.labelvolumetext.Size = new System.Drawing.Size(0, 21);
            this.labelvolumetext.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "体积（m³）：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(240, 181);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(21, 21);
            this.labelcount.TabIndex = 8;
            this.labelcount.Text = "0";
            this.labelcount.Visible = false;
            this.labelcount.Click += new System.EventHandler(this.labelcount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "个数：";
            this.label4.Visible = false;
            // 
            // labelCurrentPercent
            // 
            this.labelCurrentPercent.AutoSize = true;
            this.labelCurrentPercent.Location = new System.Drawing.Point(124, 181);
            this.labelCurrentPercent.Name = "labelCurrentPercent";
            this.labelCurrentPercent.Size = new System.Drawing.Size(21, 21);
            this.labelCurrentPercent.TabIndex = 6;
            this.labelCurrentPercent.Text = "0";
            this.labelCurrentPercent.Click += new System.EventHandler(this.labelCurrentPercent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "百分比(%)：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // progressBarPercent
            // 
            this.progressBarPercent.Location = new System.Drawing.Point(6, 40);
            this.progressBarPercent.Name = "progressBarPercent";
            this.progressBarPercent.Size = new System.Drawing.Size(341, 131);
            this.progressBarPercent.TabIndex = 0;
            this.progressBarPercent.Click += new System.EventHandler(this.progressBarPercent_Click);
            // 
            // progressBarWait
            // 
            this.progressBarWait.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBarWait.Location = new System.Drawing.Point(27, 287);
            this.progressBarWait.Name = "progressBarWait";
            this.progressBarWait.Size = new System.Drawing.Size(351, 26);
            this.progressBarWait.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarWait.TabIndex = 7;
            this.progressBarWait.Visible = false;
            this.progressBarWait.Click += new System.EventHandler(this.progressBarWait_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(259, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "暂停";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(23, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "车牌号：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelCarNumber
            // 
            this.labelCarNumber.AutoSize = true;
            this.labelCarNumber.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCarNumber.Location = new System.Drawing.Point(115, 90);
            this.labelCarNumber.Name = "labelCarNumber";
            this.labelCarNumber.Size = new System.Drawing.Size(0, 19);
            this.labelCarNumber.TabIndex = 10;
            this.labelCarNumber.Click += new System.EventHandler(this.labelCarNumber_Click);
            // 
            // serialNumberRecordsTableAdapter
            // 
            this.serialNumberRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 349);
            this.Controls.Add(this.labelCarNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBarWait);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOperate);
            this.Controls.Add(this.comboBoxCarInfoLists);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "体积测量";
            this.Load += new System.EventHandler(this.Calc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumberRecordsBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private EVCSDataSet eVCSDataSet;
        private System.Windows.Forms.BindingSource carInfosBindingSource;
        private EVCSDataSetTableAdapters.CarInfosTableAdapter carInfosTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarPercent;
        private System.Windows.Forms.ProgressBar progressBarWait;
        private System.Windows.Forms.Label labelCurrentPercent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCarNumber;
        private System.Windows.Forms.BindingSource serialNumberRecordsBindingSource1;
        private EVCSDataSetTableAdapters.SerialNumberRecordsTableAdapter serialNumberRecordsTableAdapter;
        public System.Windows.Forms.Button buttonOperate;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelvolumetext;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Timer timer4;
        public System.Windows.Forms.ComboBox comboBoxCarInfoLists;
    }
}