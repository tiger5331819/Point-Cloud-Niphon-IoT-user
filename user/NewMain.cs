using EVCS.体积测量;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace EVCS
{

    public partial class NewMain : Form
    {
        /// <summary>
        /// NewMain类对外接口
        /// 接口为 public static NewMain Nform
        /// 访问形式为：NewMain.Nform.xxx
        /// </summary>
        public NewMain()
        {
            InitializeComponent();
            Nform = this;
           cloud = new Special();
        }
        public Special cloud;
        public static NewMain Nform;
        /// <summary>
        /// 禁用关闭键
        /// </summary>
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
     
        /// <summary>
        /// NewMain窗体 加载事件
        /// 加载首页以及检测是否打开teamview，若没有打开则运行teamviewopen.bat运行teamview
        /// </summary>
        public LogClass logClass;
        private void NewMain_Load(object sender, EventArgs e)
        {
            logClass = new LogClass();            
            logClass.write("NewMain_Load开始执行");
            Form form = new MainFrame(timer1);

            Add_TabPage("首页", form,1);
            NewMain.Nform.logClass.write("加载首页");
            Process[] pProcess;
            pProcess = Process.GetProcesses();
            int pflag = 0;
            for (int i = 1; i <= pProcess.Length - 1; i++)
            {
                if (pProcess[i].ProcessName == "TeamViewer")   //任务管理器应用程序的名
                {
                    pflag = 1;
                }
            }
            if (pflag == 0)
            {
                Process pr = new Process();
                pr.StartInfo.FileName = "teamviewopen.bat";
                pr.Start();
            }
            NewMain.Nform.logClass.write("NewMain_Load执行完毕");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tabNane"></param>
        /// <param name="myForm"></param>
        /// 
        private void MainTabControl_DrawItem(object sender, DrawItemEventArgs e)

        {

            /*如果将 DrawMode 属性设置为 OwnerDrawFixed， 

            则每当 TabControl 需要绘制它的一个选项卡时，它就会引发 DrawItem 事件*/

            try

            {

                this.tabControlMain.TabPages[e.Index].BackColor = Color.LightBlue;

                Rectangle tabRect = this.tabControlMain.GetTabRect(e.Index);

                e.Graphics.DrawString(this.tabControlMain.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText, (float)(tabRect.X + 2), (float)(tabRect.Y + 2));

                using (Pen pen = new Pen(Color.White))

                {

                    tabRect.Offset(tabRect.Width - 15, 2);

                    tabRect.Width = 15;

                    tabRect.Height = 15;

                    e.Graphics.DrawRectangle(pen, tabRect);

                }

                Color color = (e.State == DrawItemState.Selected) ? Color.LightBlue : Color.White;

                using (Brush brush = new SolidBrush(color))

                {

                    e.Graphics.FillRectangle(brush, tabRect);

                }

                using (Pen pen2 = new Pen(Color.Red))

                {

                    Point point = new Point(tabRect.X + 3, tabRect.Y + 3);

                    Point point2 = new Point((tabRect.X + tabRect.Width) - 3, (tabRect.Y + tabRect.Height) - 3);

                    e.Graphics.DrawLine(pen2, point, point2);

                    Point point3 = new Point(tabRect.X + 3, (tabRect.Y + tabRect.Height) - 3);

                    Point point4 = new Point((tabRect.X + tabRect.Width) - 3, tabRect.Y + 3);

                    e.Graphics.DrawLine(pen2, point3, point4);

                }

                e.Graphics.Dispose();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

        }
        /// <summary>
        /// 检查是否是体积测量页面
        /// 如果是则关闭体积测量程序并保存数据
        /// </summary>
        /// <param name="tab">
        /// 当前页签
        /// </param>
        private void CheckCalc(System.Windows.Forms.TabPage tab, EventArgs e)
        {
            if (tab.Text == "体积测量 X")
            {
                Process[] pProcess;
                pProcess = Process.GetProcesses();
                for (int i = 1; i <= pProcess.Length - 1; i++)
                {
                    if (pProcess[i].ProcessName == "体积计算 "+ NewMain.Nform.cloud.Volumev)   //任务管理器应用程序的名
                    {
                        NewMain.Nform.cloud.Calc.buttonOperate_Click(NewMain.Nform.cloud.Calc, e);

                    }
                }
            }

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
                    if (this.tabControlMain.SelectedTab.Text == "体积测量 X" && time == true || this.tabControlMain.SelectedTab.Text == "首页") return;
                    CheckCalc(this.tabControlMain.SelectedTab, e);
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

        

        private void 开始计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        Form Calcfrom;

        private void 计划任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行计划任务函数");
            Form Timechange = new Timechange();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, Timechange);
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool time = false;//时间锁
        public int timeptr = 0;//时间标记：数字则代表频号
        /// <summary>
        /// 程序关闭响应事件
        /// 1.clock用于检测相对应的异常退出操作
        /// 2.程序暂停、程序正在运行、程序自动运行过程中不允许关闭程序
        /// 3.程序自动运行关闭条件和时间锁有关，若时间锁锁上则意味着程序正在自动运行
        /// </summary>
        private void calc_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            NewMain.Nform.logClass.write("执行calc_FormClosing函数");
            cloud.writexml();
            int clock = 0;
            if (NewMain.Nform.cloud.Calc == null) return;
            if (NewMain.Nform.cloud.Calc.button1.Text == "继续" && NewMain.Nform.cloud.Calc.buttonOperate.Enabled == false && NewMain.Nform.cloud.Calc.buttonOperate.Text == "结束" && clock == 0)
            {
                clock = 2;
                DialogResult result = MessageBox.Show("小云发现程序已经暂停，请点击继续后结束程序", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    e.Cancel = true;  //点击OK   
                    return;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            if (NewMain.Nform.cloud.Calc.buttonOperate.Text == "结束" && clock == 0)
            {
                DialogResult result = MessageBox.Show("小云检测到计算过程尚未结束，关闭请点击结束按钮！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    e.Cancel = true;  //点击OK   
                    return;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            if (time == true)
            {
                DialogResult result = MessageBox.Show("小云正在控制程序请勿关闭！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    e.Cancel = true;  //点击OK   
                    return;
                }
                else
                {
                    e.Cancel = true;
                    
                    return;
                }
            }
           
        }
        /// <summary>
        /// 程序自动运行时间触发器
        /// 定时自动开始结束
        /// </summary>

        public int autoFlag = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            //自动计算时的正常开启时间
            if ((DateTime.Now.Hour ==cloud.gethour(1,true) && DateTime.Now.Minute == cloud.getminute(1,true) && time == false) || autoFlag == 1)  //如果当前时间是7点30分
            {
                NewMain.Nform.logClass.write("执行频段二时间段的自动体积计算功能");
                time = true;
                Calcfrom = new Calc();
                Add_TabPage("体积测量", Calcfrom);
                
                timeptr = 2;
                autoFlag = 0;
            }

            if ((DateTime.Now.Hour == cloud.gethour(1,false) && DateTime.Now.Minute == cloud.getminute(1,false) && time == true) || autoFlag == 2)  //如果当前时间是13点00分
            {
                
                NewMain.Nform.logClass.write("关闭频段二时间段的自动体积计算功能");
                tabControlCheckHave(this.tabControlMain, "体积测量 X");
                CheckCalc(this.tabControlMain.SelectedTab, e);

                this.tabControlMain.TabPages.Remove(this.tabControlMain.SelectedTab);
                NewMain.Nform.cloud.Calc.Close();
                time = false;
                timeptr = 0;
                autoFlag = 0;
            }
            if ((DateTime.Now.Hour == cloud.gethour(2,true) && DateTime.Now.Minute == cloud.getminute(2,true) && time == false) || autoFlag == 3)  //如果当前时间是13点01分
            {
                NewMain.Nform.logClass.write("执行频段三时间段的自动体积计算功能");
                time = true;
                Calcfrom = new Calc();
                
                Add_TabPage("体积测量", Calcfrom);
                timeptr = 3;
                autoFlag = 0;
            }
            if ((DateTime.Now.Hour == cloud.gethour(2,false) && DateTime.Now.Minute ==cloud.getminute(2,false) && time == true) || autoFlag == 4)  //如果当前时间是16点59分
            {
                time = false;
                NewMain.Nform.logClass.write("关闭频段三时间段的自动体积计算功能");
                tabControlCheckHave(this.tabControlMain, "体积测量 X");
                CheckCalc(this.tabControlMain.SelectedTab, e);

                this.tabControlMain.TabPages.Remove(this.tabControlMain.SelectedTab);
                NewMain.Nform.cloud.Calc.Close();
                
                timeptr = 0;
                autoFlag = 0;
            }
            if ((DateTime.Now.Hour == cloud.gethour(0,true) && DateTime.Now.Minute == cloud.getminute(0,true) && time == false) || autoFlag == 5)  //如果当前时间是17点00分
            {
                NewMain.Nform.logClass.write("执行频段一时间段的自动体积计算功能");
                time = true;
                Calcfrom = new Calc();
                
                Add_TabPage("体积测量", Calcfrom);
                timeptr = 1;
                autoFlag = 0;

            }
            if ((DateTime.Now.Hour == cloud.gethour(0,false) && DateTime.Now.Minute == cloud.getminute(0,false) && time == true) || autoFlag == 6)  //如果当前时间是7点00分
            {
                NewMain.Nform.logClass.write("关闭频段一时间段的自动体积计算功能");
                tabControlCheckHave(this.tabControlMain, "体积测量 X");
                CheckCalc(this.tabControlMain.SelectedTab, e);

                this.tabControlMain.TabPages.Remove(this.tabControlMain.SelectedTab);
                NewMain.Nform.cloud.Calc.Close();
                time = false;
                timeptr = 0;
                autoFlag = 0;
            }

            this.checkBox1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //获取当前时间
            DateTime judgeDateTime = new DateTime();
            judgeDateTime = DateTime.Now;
            //checked属性先改变，事件再发生
            //开启自动管理
            if (checkBox1.Checked == true)
            {
                this.checkBox1.Enabled = false;
                timer1.Enabled = true;
                NewMain.Nform.logClass.write("手动点击打开自动计算功能");
                //频段二
                if ((judgeDateTime.Hour > cloud.gethour(1,true) && judgeDateTime.Hour < cloud.gethour(1,false)) || (judgeDateTime.Hour == cloud.gethour(1,true) && judgeDateTime.Minute > cloud.getminute(1,true)))
                {
                    autoFlag = 1;
                }
                //频段三
                else if (judgeDateTime.Hour >= cloud.gethour(2,true) && judgeDateTime.Hour <= cloud.gethour(2,false))
                {
                    autoFlag = 3;
                }
                //频段一
                else if (judgeDateTime.Hour >= cloud.gethour(0,true) || judgeDateTime.Hour <cloud.gethour(0,false))
                {
                    autoFlag = 5;
                }
                else
                {
                    this.timer1.Enabled = true;
                }

            }

            //关闭自动管理
            if (checkBox1.Checked == false)
            {
                this.checkBox1.Enabled = false;
                NewMain.Nform.logClass.write("手动点击关闭自动计算功能");
                //频段二
                if ((judgeDateTime.Hour > cloud.gethour(1,true) && judgeDateTime.Hour < cloud.gethour(1,false)) || (judgeDateTime.Hour == cloud.gethour(1,true) && judgeDateTime.Minute > cloud.getminute(1,true)))
                {
                    autoFlag = 2;
                }
                //频段三
                else if (judgeDateTime.Hour >= cloud.gethour(2,true) && judgeDateTime.Hour <= cloud.gethour(2,false))
                {
                    //MessageBox.Show("点击关闭");
                    autoFlag = 4;
                }
                //频段一
                else if (judgeDateTime.Hour >= cloud.gethour(0,true) || judgeDateTime.Hour < cloud.gethour(0,false))
                {
                    autoFlag = 6;
                }
                else
                {
                    this.timer1.Enabled = false;
                }
            }
        }


        bool linkflag=false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (linkflag == false) if (cloud.cloudnet.linkserver()) linkflag = true;
            if (cloud.cloudnet.checksermessflag() != -1&&cloud.cloudnet.checksermessflag()==1)
            {
                cloud.cloudnet.sendmessage(cloud.cloudnet.checksermessflag(),cloud.volumeCalc);
            }
        }
    }

}
