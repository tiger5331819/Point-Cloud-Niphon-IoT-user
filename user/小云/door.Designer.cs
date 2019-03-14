namespace EVCS.杂项
{
    partial class door
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(door));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计划任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本升级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.体积管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.体积计算状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全体积记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 38);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(799, 502);
            this.tabControlMain.TabIndex = 3;
            this.tabControlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainTabControl_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始计算ToolStripMenuItem,
            this.体积管理ToolStripMenuItem,
            this.数据查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(799, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始计算ToolStripMenuItem
            // 
            this.开始计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计划任务ToolStripMenuItem,
            this.版本升级ToolStripMenuItem});
            this.开始计算ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.开始计算ToolStripMenuItem.Name = "开始计算ToolStripMenuItem";
            this.开始计算ToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.开始计算ToolStripMenuItem.Text = "配置管理";
            // 
            // 计划任务ToolStripMenuItem
            // 
            this.计划任务ToolStripMenuItem.Name = "计划任务ToolStripMenuItem";
            this.计划任务ToolStripMenuItem.Size = new System.Drawing.Size(168, 32);
            this.计划任务ToolStripMenuItem.Text = "计划任务";
            this.计划任务ToolStripMenuItem.Click += new System.EventHandler(this.计划任务ToolStripMenuItem_Click);
            // 
            // 版本升级ToolStripMenuItem
            // 
            this.版本升级ToolStripMenuItem.Name = "版本升级ToolStripMenuItem";
            this.版本升级ToolStripMenuItem.Size = new System.Drawing.Size(168, 32);
            this.版本升级ToolStripMenuItem.Text = "版本升级";
            this.版本升级ToolStripMenuItem.Click += new System.EventHandler(this.版本升级ToolStripMenuItem_Click);
            // 
            // 体积管理ToolStripMenuItem
            // 
            this.体积管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.体积计算状态ToolStripMenuItem});
            this.体积管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.体积管理ToolStripMenuItem.Name = "体积管理ToolStripMenuItem";
            this.体积管理ToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.体积管理ToolStripMenuItem.Text = "体积管理";
            // 
            // 体积计算状态ToolStripMenuItem
            // 
            this.体积计算状态ToolStripMenuItem.Name = "体积计算状态ToolStripMenuItem";
            this.体积计算状态ToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.体积计算状态ToolStripMenuItem.Text = "体积计算状态";
            this.体积计算状态ToolStripMenuItem.Click += new System.EventHandler(this.体积计算状态ToolStripMenuItem_Click);
            // 
            // 数据查询ToolStripMenuItem
            // 
            this.数据查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全体积记录ToolStripMenuItem});
            this.数据查询ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据查询ToolStripMenuItem.Name = "数据查询ToolStripMenuItem";
            this.数据查询ToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.数据查询ToolStripMenuItem.Text = "数据查询";
            // 
            // 全体积记录ToolStripMenuItem
            // 
            this.全体积记录ToolStripMenuItem.Name = "全体积记录ToolStripMenuItem";
            this.全体积记录ToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.全体积记录ToolStripMenuItem.Text = "全体积记录";
            // 
            // door
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 540);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "door";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "小云控制终端";
            this.Load += new System.EventHandler(this.door_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计划任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本升级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 体积管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 体积计算状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全体积记录ToolStripMenuItem;
    }
}