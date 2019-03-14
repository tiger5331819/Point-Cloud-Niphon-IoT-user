using EVCS.查询;
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
using EVCS.小云;

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
        ///// <summary>
        ///// 禁用关闭键
        ///// </summary>
        //private const int CP_NOCLOSE_BUTTON = 0x200;
        //protected override CreateParams CreateParams

        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}
        /// <summary>
        /// ToolStripMenuItem_Click事件
        /// 将窗体以tab页签的形式插入
        /// 1.获取菜单栏选项信息
        /// 2.创建新窗体
        /// 3.将窗体放入页签
        /// </summary>
        private void 车辆信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Form form = new CarInfoEnter();
            Add_TabPage(menu.Text, form);
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
            Form form = new MainFrame();

            Add_TabPage("首页", form,1);
            NewMain.Nform.logClass.write("加载首页");


            //远程控制的程序没有开启的作用了，弃用

            //Process[] pProcess;
            //pProcess = Process.GetProcesses();
            //int pflag = 0;
            //for (int i = 1; i <= pProcess.Length - 1; i++)
            //{
            //    if (pProcess[i].ProcessName == "TeamViewer")   //任务管理器应用程序的名
            //    {
            //        pflag = 1;
            //    }
            //}
            //if (pflag == 0)
            //{
            //    Process pr = new Process();
            //    pr.StartInfo.FileName = "teamviewopen.bat";
            //    pr.Start();
            //}
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
                       // NewMain.Nform.cloud.Calc.buttonOperate_Click(NewMain.Nform.cloud.Calc, e);

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

        private void 生成货运流水号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行生成货运单流水号函数");
            Form form = new Enters_GenerateSN();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);
        }

        private void 开始计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 但体积查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行体积查询函数");
            Form form = new SingleVolume();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);

        }

        private void 车辆查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行日期查询函数");
            Form form = new carfind();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);
        }

        private void 查询所有信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行查询所有信息函数");
            Form form = new InfoSearch();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);
        }

        private void 每日装载分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行每日装载分析函数");
            Form form = new Analysis();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);
        }
      

        private void 计划任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行计划任务函数");
            Form Timechange = new Timechange();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, Timechange);
        }


        private void 统计分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 调配预测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行调配预测函数");
            Form form = new EVCS.预测.Forecas();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);

        }

        private void 添加调配任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行添加调配任务函数");
            Form form = new EVCS.调配.车辆调配.AddCarTask();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);
        }

        private void 调配任务表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行调配任务表函数");
            Form form = new EVCS.调配.车辆调配.CarTasksLists();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);
        }

        private void 添加人员调配任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行添加人员调配任务函数");
            Form form = new EVCS.调配.人员调配.AddPersonTask();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);

        }

        private void 人员调配任务表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMain.Nform.logClass.write("执行人员调配任务表函数");
            Form form = new EVCS.调配.人员调配.PersonTaskLists();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);
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
        //private void calc_FormClosing(object sender, FormClosingEventArgs e)
        //{
            
        //    NewMain.Nform.logClass.write("执行calc_FormClosing函数");
        //    cloud.writexml();
        //    int clock = 0;
        //    //if (NewMain.Nform.cloud.Calc == null) return;
        //    if (NewMain.Nform.cloud.Calc.button1.Text == "继续" && NewMain.Nform.cloud.Calc.buttonOperate.Enabled == false && NewMain.Nform.cloud.Calc.buttonOperate.Text == "结束" && clock == 0)
        //    {
        //        clock = 2;
        //        DialogResult result = MessageBox.Show("小云发现程序已经暂停，请点击继续后结束程序", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //        if (result == DialogResult.OK)
        //        {
        //            e.Cancel = true;  //点击OK   
        //            return;
        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //            return;
        //        }
        //    }
        //    if (NewMain.Nform.cloud.Calc.buttonOperate.Text == "结束" && clock == 0)
        //    {
        //        DialogResult result = MessageBox.Show("小云检测到计算过程尚未结束，关闭请点击结束按钮！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //        if (result == DialogResult.OK)
        //        {
        //            e.Cancel = true;  //点击OK   
        //            return;
        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //            return;
        //        }
        //    }
        //    if (time == true)
        //    {
        //        DialogResult result = MessageBox.Show("小云正在控制程序请勿关闭！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //        if (result == DialogResult.OK)
        //        {
        //            e.Cancel = true;  //点击OK   
        //            return;
        //        }
        //        else
        //        {
        //            e.Cancel = true;
                    
        //            return;
        //        }
        //    }
           
        //}

        private void 车辆信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 生成表格ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 将数据库里的数据存入本地excel表格里
        /// </summary>
        /// <param name="ds">
        /// c#数据表
        /// </param>
        public void WriteExcel(DataSet ds)
        {
            NewMain.Nform.logClass.write("写数据到Excel表格");
            try
            {
                string path = "装载情况.xls";
                StreamWriter sw = new StreamWriter("D:\\" + path, false, Encoding.GetEncoding("gb2312"));
                StringBuilder sb = new StringBuilder();
                for (int k = 0; k < ds.Tables[0].Columns.Count; k++)
                {
                    sb.Append(ds.Tables[0].Columns[k].ColumnName.ToString() + "\t");
                }
                sb.Append(Environment.NewLine);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        sb.Append(ds.Tables[0].Rows[i][j].ToString() + "\t");
                    }
                    sb.Append(Environment.NewLine);//每写一行数据后换行
                }
                sw.Write(sb.ToString());
                sw.Flush();
                sw.Close();//释放资源
                MessageBox.Show("已经生成指定Excel文件!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                NewMain.Nform.logClass.write("出错："+ex.Message.ToString());
            }
        }
        /// <summary>
        /// 将数据库里的数据存入Dataset里并调用WriteExcel函数将数据保存至本地
        /// </summary>
        private void 全部数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //建立数据库链接
            string sql;
            string filename = DateTime.Now.ToString();
            string ConnectionStr = "Server=.;Initial Catalog=EVCS;User ID=sa;Password=sa;MultipleActiveResultSets=False;";
            //SqlConnection conn = new SqlConnection(ConnectionStr);  
            // sql = "EXEC master..xp_cmdshell 'bcp EVCS.dbo.Records out D:\\生成表格.xls -c -q -S\"POINTCLOUD\" -U\"sa\" -P\"sa\"\'";
            //SqlCommand cm = new SqlCommand(sql, conn);

            //cm.ExecuteNonQuery();

            NewMain.Nform.logClass.write("执行数据库链接函数");
            //创建DataSet表并且将数据存入表中
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(ConnectionStr);

            conn.Open();
            sql = "SELECT a.ID,b.CarNO, a.StartDate, a.EndDate, a.Volume, a.[Loading rate], a.Count, a.SN,a.CreateDate FROM Records AS a INNER JOIN CarInfos AS b ON a.CarNO = b.ID "; //查询表
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(ds);
            //this.dataGridView1.DataSource = ds.Tables[0];//表从起始行显示在dataGridView里
            WriteExcel(ds);
            conn.Close();
            NewMain.Nform.logClass.write("显示数据成功");
            // MessageBox.Show("生成成功");
        }

        private void 察看链接情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form net = new Network();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, net);
        }
    }

}
