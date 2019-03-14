namespace EVCS.小云
{
    partial class Network
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
            this.cblnet = new System.Windows.Forms.ComboBox();
            this.change = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnetname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.configbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelvolumetext = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCurrentPercent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBarPercent = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCarNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cblnet
            // 
            this.cblnet.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cblnet.FormattingEnabled = true;
            this.cblnet.Location = new System.Drawing.Point(50, 12);
            this.cblnet.Name = "cblnet";
            this.cblnet.Size = new System.Drawing.Size(237, 29);
            this.cblnet.TabIndex = 0;
            this.cblnet.SelectedIndexChanged += new System.EventHandler(this.cblnet_SelectedIndexChanged);
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.change.Location = new System.Drawing.Point(293, 9);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(92, 35);
            this.change.TabIndex = 1;
            this.change.Text = "更新";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // link
            // 
            this.link.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.link.Location = new System.Drawing.Point(391, 9);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(89, 35);
            this.link.TabIndex = 2;
            this.link.Text = "链接";
            this.link.UseVisualStyleBackColor = true;
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(511, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "子端号：";
            // 
            // labelnetname
            // 
            this.labelnetname.AutoSize = true;
            this.labelnetname.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelnetname.Location = new System.Drawing.Point(591, 17);
            this.labelnetname.Name = "labelnetname";
            this.labelnetname.Size = new System.Drawing.Size(32, 21);
            this.labelnetname.TabIndex = 4;
            this.labelnetname.Text = "无";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.configbutton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(50, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本控制";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // configbutton
            // 
            this.configbutton.Location = new System.Drawing.Point(397, 30);
            this.configbutton.Name = "configbutton";
            this.configbutton.Size = new System.Drawing.Size(150, 42);
            this.configbutton.TabIndex = 4;
            this.configbutton.Text = "更改信息";
            this.configbutton.UseVisualStyleBackColor = true;
            this.configbutton.Click += new System.EventHandler(this.configbutton_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(216, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "结束";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "开始";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listen);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelCarNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelVolume);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(50, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(903, 226);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "状态";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(179, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "停止监听";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listen
            // 
            this.listen.Enabled = false;
            this.listen.Location = new System.Drawing.Point(5, 171);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(135, 37);
            this.listen.TabIndex = 19;
            this.listen.Text = "监听";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelvolumetext);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.labelcount);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.labelCurrentPercent);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.progressBarPercent);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(437, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 202);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "装载信息展示";
            // 
            // labelvolumetext
            // 
            this.labelvolumetext.AutoSize = true;
            this.labelvolumetext.Location = new System.Drawing.Point(128, 164);
            this.labelvolumetext.Name = "labelvolumetext";
            this.labelvolumetext.Size = new System.Drawing.Size(21, 21);
            this.labelvolumetext.TabIndex = 12;
            this.labelvolumetext.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "体积（m³）：";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(240, 131);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(21, 21);
            this.labelcount.TabIndex = 8;
            this.labelcount.Text = "0";
            this.labelcount.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "个数：";
            this.label8.Visible = false;
            // 
            // labelCurrentPercent
            // 
            this.labelCurrentPercent.AutoSize = true;
            this.labelCurrentPercent.Location = new System.Drawing.Point(124, 131);
            this.labelCurrentPercent.Name = "labelCurrentPercent";
            this.labelCurrentPercent.Size = new System.Drawing.Size(21, 21);
            this.labelCurrentPercent.TabIndex = 6;
            this.labelCurrentPercent.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "百分比(%)：";
            // 
            // progressBarPercent
            // 
            this.progressBarPercent.Location = new System.Drawing.Point(6, 30);
            this.progressBarPercent.Name = "progressBarPercent";
            this.progressBarPercent.Size = new System.Drawing.Size(341, 93);
            this.progressBarPercent.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "无";
            // 
            // labelCarNumber
            // 
            this.labelCarNumber.AutoSize = true;
            this.labelCarNumber.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCarNumber.Location = new System.Drawing.Point(110, 114);
            this.labelCarNumber.Name = "labelCarNumber";
            this.labelCarNumber.Size = new System.Drawing.Size(28, 19);
            this.labelCarNumber.TabIndex = 16;
            this.labelCarNumber.Text = "无";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(26, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "车牌号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(5, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "货运单号：";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVolume.Location = new System.Drawing.Point(110, 78);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(31, 21);
            this.labelVolume.TabIndex = 14;
            this.labelVolume.Text = "无";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(47, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "体积：";
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 700;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelnetname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.change);
            this.Controls.Add(this.cblnet);
            this.Name = "Network";
            this.Text = "客户端状况";
            this.Load += new System.EventHandler(this.Net_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cblnet;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnetname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCarNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelvolumetext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCurrentPercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBarPercent;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button listen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button configbutton;
        private System.Windows.Forms.Timer timer2;
    }
}