namespace EVCS
{
    partial class Enters_GenerateSN
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCarNO = new System.Windows.Forms.ComboBox();
            this.eVCSDataSet = new EVCS.EVCSDataSet();
            this.carInfosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carInfosTableAdapter = new EVCS.EVCSDataSetTableAdapters.CarInfosTableAdapter();
            this.labelSN = new System.Windows.Forms.Label();
            this.textBoxCreateUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "货运单号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "创建人：";
            // 
            // comboBoxCarNO
            // 
            this.comboBoxCarNO.DataSource = this.carInfosBindingSource;
            this.comboBoxCarNO.DisplayMember = "CarNO";
            this.comboBoxCarNO.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCarNO.FormattingEnabled = true;
            this.comboBoxCarNO.Location = new System.Drawing.Point(83, 23);
            this.comboBoxCarNO.Name = "comboBoxCarNO";
            this.comboBoxCarNO.Size = new System.Drawing.Size(197, 29);
            this.comboBoxCarNO.TabIndex = 3;
            this.comboBoxCarNO.ValueMember = "ID";
            this.comboBoxCarNO.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarInfoLists_SelectedIndexChanged);
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
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Location = new System.Drawing.Point(95, 85);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(29, 12);
            this.labelSN.TabIndex = 4;
            this.labelSN.Text = "0000";
            // 
            // textBoxCreateUser
            // 
            this.textBoxCreateUser.Location = new System.Drawing.Point(83, 132);
            this.textBoxCreateUser.Name = "textBoxCreateUser";
            this.textBoxCreateUser.Size = new System.Drawing.Size(197, 21);
            this.textBoxCreateUser.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Enters_GenerateSN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCreateUser);
            this.Controls.Add(this.labelSN);
            this.Controls.Add(this.comboBoxCarNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Enters_GenerateSN";
            this.Text = "生成货运单号";
            this.Load += new System.EventHandler(this.Enters_GenerateSN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eVCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carInfosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCarNO;
        private EVCSDataSet eVCSDataSet;
        private System.Windows.Forms.BindingSource carInfosBindingSource;
        private EVCSDataSetTableAdapters.CarInfosTableAdapter carInfosTableAdapter;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.TextBox textBoxCreateUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}