namespace EVCS
{
    partial class NewMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计划任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.自动管理设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启自动管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始计算ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1132, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始计算ToolStripMenuItem
            // 
            this.开始计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计划任务ToolStripMenuItem});
            this.开始计算ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.开始计算ToolStripMenuItem.Name = "开始计算ToolStripMenuItem";
            this.开始计算ToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.开始计算ToolStripMenuItem.Text = "开始计算";
            this.开始计算ToolStripMenuItem.Click += new System.EventHandler(this.开始计算ToolStripMenuItem_Click);
            // 
            // 计划任务ToolStripMenuItem
            // 
            this.计划任务ToolStripMenuItem.Name = "计划任务ToolStripMenuItem";
            this.计划任务ToolStripMenuItem.Size = new System.Drawing.Size(168, 32);
            this.计划任务ToolStripMenuItem.Text = "计划任务";
            this.计划任务ToolStripMenuItem.Click += new System.EventHandler(this.计划任务ToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 38);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1132, 515);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            this.tabControlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainTabControl_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 自动管理设置ToolStripMenuItem
            // 
            this.自动管理设置ToolStripMenuItem.Name = "自动管理设置ToolStripMenuItem";
            this.自动管理设置ToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.自动管理设置ToolStripMenuItem.Text = "自动管理设置";
            // 
            // 开启自动管理ToolStripMenuItem
            // 
            this.开启自动管理ToolStripMenuItem.Name = "开启自动管理ToolStripMenuItem";
            this.开启自动管理ToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.开启自动管理ToolStripMenuItem.Text = "开启自动管理";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(978, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 30);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "开启自动管理";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 600;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 553);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "青岛中心局车辆装载率管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.calc_FormClosing);
            this.Load += new System.EventHandler(this.NewMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem 开始计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计划任务ToolStripMenuItem;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 自动管理设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启自动管理ToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}