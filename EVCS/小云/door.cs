using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVCS.体积测量;
using EVCS.小云;
using EVCS.查询;

namespace EVCS.杂项
{
    public partial class door : Form
    {
        public door()
        {
            InitializeComponent();
        }

        private void MainTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;
                Rectangle tabRect = this.tabControlMain.GetTabRect(this.tabControlMain.SelectedIndex);
                tabRect.Offset(tabRect.Width - 0x12, 2);
                tabRect.Width = 15;
                tabRect.Height = 15;
                if ((((x > tabRect.X) && (x < tabRect.Right)) && (y > tabRect.Y)) && (y < tabRect.Bottom))
                {
                    if (this.tabControlMain.SelectedTab.Text == "首页") return;
                    this.tabControlMain.TabPages.Remove(this.tabControlMain.SelectedTab);
                }
            }
        }
        /// <summary>
        /// 添加窗体至页签
        /// </summary>
        /// <param name="tabNane">
        /// 从菜单栏获取的窗口名
        /// </param>
        /// <param name="myForm">
        /// 所要添加的具体窗体
        /// </param>
        private void Add_TabPage(string tabNane, Form myForm, int flag = 0)
        {
            if (flag == 0)
                tabNane += " X";
            if (tabControlCheckHave(this.tabControlMain, tabNane))
            {
                myForm.Close();
                NewMain.Nform.logClass.write("选中选项卡");
                return;
            }
            else
            {
                //添加一个选项卡并且显示最近添加的选项卡
                tabControlMain.TabPages.Add(tabNane);
                tabControlMain.SelectTab(tabControlMain.TabPages.Count - 1);

                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Dock = DockStyle.Fill;
                myForm.TopLevel = false;
                myForm.Show();

                //设置控件的父容器
                myForm.Parent = tabControlMain.SelectedTab;

                NewMain.Nform.logClass.write("添加新选项卡");
            }


        }
        /// <summary>
        /// 检查是否已经存在窗体所对应的页签
        /// </summary>
        /// <param name="tab">
        /// 相关选项卡页集
        /// </param>
        /// <param name="tabName">
        /// tab页签的名字
        /// </param>
        /// <returns>
        /// 返回检查状态，如果存在则返回true，不存在返回false
        /// </returns>
        private bool tabControlCheckHave(System.Windows.Forms.TabControl tab, String tabName)
        {
            for (int i = 0; i < tab.TabCount; i++)
            {
                if (tab.TabPages[i].Text == tabName)
                {
                    tab.SelectedIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void 计划任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行计划任务函数");
            Form Timechange = new Timechange();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, Timechange);
        }

        private void 版本升级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form level = new 小云.level();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, level);
        }

        private void door_Load(object sender, EventArgs e)
        {
            Form form = new CloudMain();
            Add_TabPage("首页", form, 1);
            NewMain.Nform.logClass.write("进入小云控制终端");
            
        }

        private void 体积计算状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form checkv = new checkvolume();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, checkv);
        }

        private void 全体积记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form findvolume = new find();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, findvolume);
        }

        private void 察看链接情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Net = new Network();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, Net);
        }
    }
}
