using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVCS
{
    public partial class Calc : Form
    {
        /// <summary>
        /// 获取体积计算数据文件路径
        /// </summary>
          string Filename = "flag.dat";
          string Filename2 = "flag2.dat";
          string Filename3 = "volume.txt";
          string CountFilename = "count.txt";
          string CountFilenameflag = "countflag.dat";
          string Fgood = "length.txt";
          string Fgood2 = "hight.txt";
          string Fgood3 = "width.txt";
        /// <summary>
        /// 开始时间与结束时间以及体积和计数标志
        /// </summary>
        //体积差计算
        public decimal lastVolume = 0;
        

        long Ff2=0;
        long Ffcount = 0;
        public Calc()
        {
            InitializeComponent();
            form1 = this;
            NewMain.Nform.cloud.getcalc(form1);
        }
        /// <summary>
        /// 设立窗体对外接口
        /// </summary>
         static Calc form1;

        private void Calc_Load(object sender, EventArgs e)
        {
             NewMain.Nform.logClass = new LogClass();
            // TODO: 这行代码将数据加载到表“eVCSDataSet.SerialNumberRecords”中。您可以根据需要移动或删除它。
            this.serialNumberRecordsTableAdapter.Fill(this.eVCSDataSet.SerialNumberRecords);
            // TODO: 这行代码将数据加载到表“eVCSDataSet.SerialNumberRecords”中。您可以根据需要移动或删除它。
            //this.serialNumberRecordsTableAdapter.Fill(this.eVCSDataSet.SerialNumberRecords);
            // TODO:  这行代码将数据加载到表“eVCSDataSet.CarInfos”中。您可以根据需要移动或删除它。
            this.carInfosTableAdapter.Fill(this.eVCSDataSet.CarInfos);
         
            SNID = Convert.ToInt32(comboBoxCarInfoLists.SelectedValue);   // 货运单号  主键
            using (EVCSEntities1 db = new EVCSEntities1())
            {
                var carinfo = db.CarInfos.Where(f => f.ID == SNID).First();
                var info = db.SerialNumberRecords.Where(f => f.CarNO == carinfo.ID).First();
                
                NewMain.Nform.cloud.volumeCalc.carSN = info.SN;
                NewMain.Nform.cloud.volumeCalc.carName = carinfo.CarNO;
                NewMain.Nform.cloud.volumeCalc.carNo = carinfo.ID;
                NewMain.Nform.cloud.volumeCalc.carVolume = carinfo.Volume;
                labelVolume.Text = NewMain.Nform.cloud.volumeCalc.carVolume.ToString();
                labelCarNumber.Text = NewMain.Nform.cloud.volumeCalc.carSN;

            }

            if(NewMain.Nform.time)
            buttonOperate_Click(form1, e);
             NewMain.Nform.logClass.write("自动计算事件触发");
        }

        
        public void buttonOperate_Click(object sender, EventArgs e)
        {
            

            string carvolume = labelVolume.Text;
            if (String.IsNullOrEmpty(carvolume))
            {
                MessageBox.Show("请先选择车辆信息！");
                return ;
            }
            if (buttonOperate.Text=="开始")
            {
                 NewMain.Nform.logClass.write("执行开始时代码");
                timer3.Enabled = true;
                buttonOperate.Text = "正在启动";

                //用于每两分钟记录一次间隔体积
                timer4.Enabled = true;
                
               
                buttonOperate.Enabled = false;

                //timer2控件整个程序已经不再使用
                timer2.Enabled = false;//timer2控件已被停用

                //各种信息获取并显示在窗口界面上
                timer1.Enabled = true;                 
               
                //？？？？？？？？？？？？？？？？？？？？？？？
                progressBarWait.Visible = true;

                //车辆选取禁用
                comboBoxCarInfoLists.Enabled = false;

                File.Delete(Filename2);
                if (!File.Exists(Filename2))
                {

                    Ff2++;
                    // Create a file to write to.
                    File.WriteAllText(Filename2, "" + Ff2);
                }
                File.Delete(Filename);
                if (!File.Exists(CountFilenameflag))
                {

                    Ffcount++;
                    // Create a file to write to.
                    File.WriteAllText(CountFilenameflag, "" + Ffcount);
                }

                //Process pr = new Process();//声明一个进程类对象

                //pr.StartInfo.FileName = "体积计算 " + NewMain.Nform.cloud.Volumev + ".exe";
                //pr.Start();
                NewMain.Nform.cloud.volumeCalc.Begintime= DateTime.Now.ToString();
                // TODO 
            }
            else
            {

                 NewMain.Nform.logClass.write("执行结束时代码");
                //关闭体积记录明细
                timer4.Enabled = false;

                timer1.Enabled = false;
                progressBarWait.Visible = false;
                buttonOperate.Text = "正在关闭";
                buttonOperate.Enabled = false;
                timer3.Enabled = true;
                timer2.Enabled = false;
                comboBoxCarInfoLists.Enabled = true;

                if (!datasave()) MessageBox.Show("数据保存出错！");

                // TODO
            }
        }



        //String carnamesave1;
        //decimal? volumesave1;
        //int caridsave1;
        //string SNsave1;

        
        int SNID;
        //private void comboBoxCarInfoLists_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //         SNID = Convert.ToInt32(comboBoxCarInfoLists.SelectedValue);   // 货运单号  主键
        //        using (EVCSEntities1 db = new EVCSEntities1())
        //        {

        //            var carinfo = db.CarInfos.Where(f => f.ID == SNID).First();
        //            var info = db.SerialNumberRecords.Where(f => f.CarNO == carinfo.ID).First();
        //            SN = info.SN;
        //            carname = carinfo.CarNO;
        //            carid = carinfo.ID;
        //             NewMain.Nform.test.volumeCalc.volume = carinfo.Volume;
        //            labelVolume.Text =  NewMain.Nform.test.volumeCalc.volume.ToString();
        //            labelCarNumber.Text = SN;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
            
        //}
        private void comboBoxCarInfoLists_timeupdate(object sender, EventArgs e)
        {

        }


        
        //string Volume;//获取当前体积数
        //string Volumeb="0";//暂停保存体积
        //Decimal Addvolume;//暂停后保存的总体积

        Decimal PL, PW, PH,PP=0,PV;
        
        

        private void progressBarWait_Click(object sender, EventArgs e)
        {

        }

        private void labelCurrentPercent_Click(object sender, EventArgs e)
        {

        }
    
        /// <summary>
        /// 数据保存
        /// 先将程序关闭文件删除后将数据上传至数据库中
        /// </summary>
        /// <returns></returns>
         bool datasave()
        {
             
            Process[] pProcess;
            pProcess = Process.GetProcesses();
            for (int i = 1; i <= pProcess.Length - 1; i++)
            {
                if (pProcess[i].ProcessName == "体积计算 "+NewMain.Nform.cloud.Volumev)   //任务管理器应用程序的名
                {
                    pProcess[i].Kill();
                     NewMain.Nform.logClass.write("杀死体积计算 "+ NewMain.Nform.cloud.Volumev + "程序");

                    Ff2 = 0;

                    File.WriteAllText(Filename2, "" + Ff2);
                    File.Delete(Filename3);
                    File.Delete(CountFilename);
                    File.Delete(Fgood);
                    File.Delete(Fgood2);
                    File.Delete(Fgood3);

                }

            }

            using (EVCSEntities1 db = new EVCSEntities1())
            {
                Records info = new Records();
                info.SN = NewMain.Nform.cloud.volumeCalc.carSN;
                info.CarNO = NewMain.Nform.cloud.volumeCalc.carNo;
                info.CreateDate = DateTime.Now;
                info.StartDate = Convert.ToDateTime( NewMain.Nform.cloud.volumeCalc.Begintime);
                info.EndDate = Convert.ToDateTime( NewMain.Nform.cloud.volumeCalc.EndTime);
                info.Volume = Convert.ToDecimal(NewMain.Nform.cloud.Volume);
                info.Loading_rate = progressBarPercent.Value;
                info.Count = Convert.ToInt32(NewMain.Nform.cloud.volumeCalc.count);
                if (NewMain.Nform.timeptr != 0)
                {
                    switch(NewMain.Nform.timeptr)
                    {
                        case 1:info.Remark = "一频（昨日"+NewMain.Nform.cloud.gethour(0,true,true)+":"+NewMain.Nform.cloud.getminute(0, true,true)+"-"+ NewMain.Nform.cloud.gethour(0, false,true)+":"+ NewMain.Nform.cloud.getminute(0, false,true)+"）"; break;
                        case 2:info.Remark = "二频（"+NewMain.Nform.cloud.gethour(1,true,true)+":"+ NewMain.Nform.cloud.getminute(1, true,true)+" - "+ NewMain.Nform.cloud.gethour(1, false,true)+":"+ NewMain.Nform.cloud.getminute(1, false,true)+"）"; break;
                        case 3:info.Remark = "三频（" + NewMain.Nform.cloud.gethour(2, true,true) + ":" + NewMain.Nform.cloud.getminute(2, true,true) + "-" + NewMain.Nform.cloud.gethour(2, false,true) + ":" + NewMain.Nform.cloud.getminute(2, false,true) +"）"; break;
                    }
                }
                db.Records.Add(info);
                db.SaveChanges();
            }
            //string number;
            //string own;
            //using (EVCSEntities1 db = new EVCSEntities1())
            //{
            //    var carman = db.CarInfos.Where(f => f.ID == carid).First();
            //    number = carman.Tel;
            //    own = carman.Contact;
            //}

            //    File.WriteAllText("test.txt", "time:" +  NewMain.Nform.test.volumeCalc.Endtime + "   Volume: " + Addvolume + "   Count :" + AddCount + "   Contact:"+own+"    Tel:"+ number);
            //Process pr = new Process();//声明一个进程类对象

            //pr.StartInfo.FileName = "chat.exe";
            //pr.Start();

            //this.Close();
            NewMain.Nform.cloud.receivevolume();
            NewMain.Nform.cloud.volumeCalc.count = "0";
            return true;
        }

        /// <summary>
        /// 暂停功能实现
        /// 先保存现场然后终止程序，当要继续时重新启用程序并恢复现场
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if(button1.Text=="暂停")
        //    {
        //         NewMain.Nform.logClass.write("响应暂停事件");
        //        button1.Text="继续";
        //        timer1.Enabled = false;
        //        progressBarWait.Visible = false;
        //        carnamesave1 = carname;
        //        volumesave1 =  NewMain.Nform.test.volumeCalc.volume;
        //        caridsave1 = carid;
        //        SNsave1 = SN;
        //        timer2.Enabled = false;
        //        buttonOperate.Enabled = false;
        //        //comboBoxCarInfoLists.Enabled = false;


        //        Process[] pProcess;
        //        pProcess = Process.GetProcesses();
        //        for (int i = 1; i <= pProcess.Length - 1; i++)
        //        {
        //            if (pProcess[i].ProcessName == "体积计算 v0.07")   //任务管理器应用程序的名
        //            {
        //                pProcess[i].Kill();


        //                Ff2 = 0;

        //                File.WriteAllText(Filename2, "" + Ff2);
        //                File.Delete(Filename3);
        //            }
        //        }

        //        Countb = Count;
        //        Volumeb = Volume;
        //    }
        //    else
        //    {
        //         NewMain.Nform.logClass.write("响应继续事件");
        //        button1.Text = "暂停";
        //        timer1.Enabled = true;
        //        progressBarWait.Visible = true;
        //        buttonOperate.Enabled = true;
        //        //comboBoxCarInfoLists.Enabled = false;

        //        string volumet = labelVolume.Text;
        //        if (String.IsNullOrEmpty(volumet))
        //        {
        //            MessageBox.Show("请先选择车辆信息！");
        //            return;
        //        }
        //        if(carnamesave1!=carname)
        //        {
        //            DialogResult result = MessageBox.Show("小云检测到车辆更替在此提醒！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //            if(result == DialogResult.OK)
        //            {
        //                Volumeb = "0";
        //                Countb = "0";
        //                 NewMain.Nform.test.volumeCalc.Endtime = DateTime.Now.ToString();
        //                using (EVCSEntities1 db = new EVCSEntities1())
        //                {
        //                    Records info = new Records();
        //                    info.SN = SNsave1;
        //                    info.CarNO = caridsave1;
        //                    info.CreateDate = DateTime.Now;
                          
        //                    info.StartDate = Convert.ToDateTime( NewMain.Nform.test.volumeCalc.Begintime); 
        //                    info.EndDate = Convert.ToDateTime( NewMain.Nform.test.volumeCalc.Endtime); 
        //                    info.Volume = Convert.ToDecimal(Addvolume);
        //                    info.Loading_rate = progressBarPercent.Value;
        //                    info.Count = Convert.ToInt32(AddCount);
        //                    db.Records.Add(info);
        //                    db.SaveChanges();
        //                }
        //            }


        //        }//MessageBox.Show("66666");

        //        File.Delete(Filename2);
        //        if (!File.Exists(Filename2))
        //        {

        //            Ff2++;
        //            // Create a file to write to.
        //            File.WriteAllText(Filename2, "" + Ff2);
        //        }
                
                
        //         NewMain.Nform.test.volumeCalc.Begintime = DateTime.Now.ToString();
        //        Process pr = new Process();//声明一个进程类对象
        //        pr.StartInfo.FileName = "体积计算 v0.07.exe";
        //        pr.Start();
                
        //        timer2.Enabled = false;
        //    }
            

        //}

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBarPercent_Click(object sender, EventArgs e)
        {

        }
        public int progressBarvalue;

        /// <summary>
        /// 定时像体积计算程序获得体积以及个数等信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                //TODO  GET Current Volumn
                //体积数据获取
                File.Delete(Filename2);//体积标志flag更新
                if (!File.Exists(Filename2))
                {

                    Ff2++;
                    // Create a file to write to.
                    File.WriteAllText(Filename2, "" + Ff2);
                }
                if (File.Exists(Filename3))//体积数据获取
                {


                    // Create a file to write to.
                    NewMain.Nform.cloud.receivevolume(Filename3);
                }

                //计数信号传输
               
                if (File.Exists(CountFilename))//计数数据获取
                {


                    // Create a file to write to.
                    NewMain.Nform.cloud.volumeCalc.count = File.ReadAllText(CountFilename);
                }

                if (File.Exists(Fgood)&& File.Exists(Fgood2) && File.Exists(Fgood3))//计数数据获取
                {


                    // Create a file to write to.
                    PL = Convert.ToDecimal(File.ReadAllText(Fgood));
                    PH = Convert.ToDecimal(File.ReadAllText(Fgood2));
                    PW = Convert.ToDecimal(File.ReadAllText(Fgood3));
                    PV = PL * PH * PW;
                }
                if (PP != PW)
                {
                    using (EVCSEntities1 db = new EVCSEntities1())
                    {
                        string time = DateTime.Now.ToString();
                        Count info = new Count();
                        info.length = PL;
                        info.wide = PW;
                        info.hight = PH;
                        info.volume = PV;
                        info.time = Convert.ToDateTime(time);
                        db.Count.Add(info);
                        db.SaveChanges();
                        PP = PW;
                    }
                }
                NewMain.Nform.cloud.volumeCalc.Loadingrate=(int)(NewMain.Nform.cloud.Volume * 100 /  NewMain.Nform.cloud.volumeCalc.carVolume);
                progressBarPercent.Value = NewMain.Nform.cloud.volumeCalc.Loadingrate;
                progressBarvalue = progressBarPercent.Value;
                labelCurrentPercent.Text = progressBarPercent.Value.ToString();
                labelcount.Text = NewMain.Nform.cloud.volumeCalc.count;
                labelvolumetext.Text = Convert.ToString(NewMain.Nform.cloud.Volume);

                if (NewMain.Nform.cloud.cloudnet.checksermessflag() == 2)
                {
                    NewMain.Nform.cloud.cloudnet.sendpackage(NewMain.Nform.cloud.cloudnet.checksermessflag(), NewMain.Nform.cloud.volumeCalc);
                }
            }
            catch (Exception)
            {
                //if(progressBarPercent.Value >= 100)
                //{
                //    datasave();
                //     NewMain.Nform.test.volumeCalc.Begintime = DateTime.Now.ToString();
                //    Process pr = new Process();//声明一个进程类对象
                //    pr.StartInfo.FileName = "体积计算 v0.07.exe";
                //    pr.Start();
                //}
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void serialNumberRecordsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 开始结束按钮点击事件发生后缓冲时间控件
        /// 并且根据时间锁 time控制相关控件的enabled属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (buttonOperate.Text == "正在启动")
            {
                buttonOperate.Text = "结束";
                if (NewMain.Nform.time == true) { buttonOperate.Enabled = false; button1.Enabled = false; }
                else buttonOperate.Enabled = true;
                  
                timer3.Enabled = false;
            }
            else if (buttonOperate.Text == "正在关闭")
            {
                buttonOperate.Text = "开始";
                buttonOperate.Enabled = true;
                timer3.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                string nowTime = DateTime.Now.ToString();

                decimal volumeInterval = 0;//体积差值
                decimal nowVolume = Convert.ToDecimal(this.labelvolumetext.Text);//现在的体积
                volumeInterval = nowVolume - lastVolume;//体积差计算
                lastVolume = nowVolume;
                if (volumeInterval != 0)
                {
                    using (EVCSEntities1 vodb = new EVCSEntities1())
                    {


                        VolumeDetail volumeDetail = new VolumeDetail();
                        volumeDetail.date = Convert.ToDateTime(nowTime);
                        volumeDetail.volume = volumeInterval;

                        vodb.VolumeDetail.Add(volumeDetail);
                        vodb.SaveChanges();
                    }
                }
            }
            catch(Exception )
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelCarNumber_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // int i = 0;
            try
            {
      

                ///传送带伸缩检测 现已经废弃
                ////传送带信号传输
                //if (File.Exists(Filename))
                //{


                //    // Create a file to write to.
                //    i = Convert.ToInt32(File.ReadAllText(Filename));

                //}
                //if (i == 1&&timej==0)
                //{


                //     NewMain.Nform.test.volumeCalc.Endtime = DateTime.Now.ToString();
                //    using (EVCSEntities1 db = new EVCSEntities1())
                //    {
                //        Records info = new Records();
                //        info.SN = SN;
                //        info.CarNO = carid;
                //        info.StartDate = Convert.ToDateTime( NewMain.Nform.test.volumeCalc.Begintime);
                //        info.EndDate = Convert.ToDateTime( NewMain.Nform.test.volumeCalc.Endtime);
                //        info.Volume = Addvolume;
                //        info.Loading_rate = progressBarPercent.Value;
                //        info.Count = Convert.ToInt32(AddCount);
                //        db.Records.Add(info);
                //        db.SaveChanges();
                //    }
                //    buttonOperate.Text = "开始";
                //    buttonOperate.Enabled = false;
                //    button1.Enabled = false;
                //    Volumeb = "0";
                //    timer1.Enabled = false;
                //    progressBarWait.Visible = false;
                //    labelCurrentPercent.Text = "0";
                //    progressBarPercent.Value = 0;

                //    labelcount.Text = "0";
                //    File.Delete(Filename3);
                //    File.Delete(CountFilename);
                //    timej = 1;

                //}
                //if (i == 2)
                //{
                //     NewMain.Nform.test.volumeCalc.Begintime= DateTime.Now.ToString();
                //    string  NewMain.Nform.test.volumeCalc.volume = labelVolume.Text;
                //    if (String.IsNullOrEmpty( NewMain.Nform.test.volumeCalc.volume))
                //    {
                //        MessageBox.Show("小云提醒您：请先选择车辆信息！并且点击开始重新激活程序。");
                //        timer2.Enabled = false;
                //        return;
                //    }
                //    timej = 0;
                //    if (buttonOperate.Text == "开始")
                //    {
                //        File.Delete(CountFilename);
                //        timer1.Enabled = true;
                //        progressBarWait.Visible = true;
                //        buttonOperate.Text = "结束";
                //        buttonOperate.Enabled = true;
                //        button1.Enabled = true;
                //        File.Delete(Filename2);
                //        if (!File.Exists(Filename2))
                //        {

                //            Ff2++;
                //            // Create a file to write to.
                //            File.WriteAllText(Filename2, "" + Ff2);
                //        }



                //        // TODO 
                //    }

                //}

            }
            catch (Exception)
            {

            }
        }

        private void labelcount_Click(object sender, EventArgs e)
        {

        }





    }
}
