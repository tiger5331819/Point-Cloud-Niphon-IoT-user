using EVCS.体积测量;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVCS.小云
{
    public partial class Network : Form
    {
        public Network()
        {
            InitializeComponent();
            net = this;
        }
        public static Network net;
        private void Net_Load(object sender, EventArgs e)
        {
            foreach(IPList a in NewMain.Nform.cloud.getiplist)
            {
                if (a.ID !=null)
                {
                    cblnet.Items.Add(a.IP);
                }
            }
           
        }

        private void cblnet_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (IPList a in NewMain.Nform.cloud.getiplist)
            {
                if (cblnet.Text==a.IP)
                {
                        labelnetname.Text = Convert.ToString(a.ID);
                }
            }
            
        }

        /// <summary>
        /// 更新当前的连接子端数据到复选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_Click(object sender, EventArgs e)
        {
            NewMain.Nform.cloud.cloudnet.Send(NewMain.Nform.cloud.cloudnet.UpdateIPList());
            cblnet.Items.Clear();
            cblnet.Text = "";
            Thread.Sleep(100);
            foreach (IPList a in NewMain.Nform.cloud.getiplist)
            {
                if (a.ID != null)
                {
                    cblnet.Items.Add(a.IP);
                }
            }
        }

        /// <summary>
        /// //1.我能看你么：当子端接收到数据时，会返回当前状态，接收线程会将数据保存到相应位置，
        ///     这里程序休眠一会，直接使用返回的状态数据，应该加异常处理机制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void link_Click(object sender, EventArgs e)
        {       
            if(link.Text=="链接")
            {
                NewMain.Nform.cloud.cloudnet.Send(DeviceID());
                NewMain.Nform.cloud.cloudnet.Send(NewMain.Nform.cloud.cloudnet.CreatCodeToPackage(Codemode.monitor));

                Thread.Sleep(1000);
                label6.Text = NewMain.Nform.cloud.Data.volume.carName;
                labelCarNumber.Text = NewMain.Nform.cloud.Data.volume.carSN;
                labelVolume.Text = Convert.ToString(NewMain.Nform.cloud.Data.volume.carVolume);


                link.Text = "断开";
                cblnet.Enabled = false;
                change.Enabled = false;
                listen.Enabled = true;
                timer2.Enabled = true;
            }else if(link.Text== "断开")
            {
                NewMain.Nform.cloud.cloudnet.Send(NewMain.Nform.cloud.cloudnet.CreatCodeToPackage(Codemode.release));
                label6.Text = "";
                labelCarNumber.Text = "";
                labelVolume.Text = "";
                link.Text = "链接";

                cblnet.Enabled = true;
                change.Enabled = true;
                listen.Enabled = false;
                button1.Enabled = false;
                timer2.Enabled = false;
            }
        }
        Package DeviceID()
        {
            Package package = new Package();
            package.message = Messagetype.codeus;
            package.data = Encoding.UTF8.GetBytes(cblnet.Text);
            return package;
        }

        /// <summary>
        /// //2.根据返回的状态数据，确定没有问题时，向子端发送确认状态参数，以表示控制端做好准备，可实时获取数据：
        ///     并将timer1启用，实时更新数据到界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listen_Click(object sender, EventArgs e)
        {
            
            NewMain.Nform.cloud.cloudnet.Send(NewMain.Nform.cloud.cloudnet.CreatCodeToPackage(Codemode.sendvolume));
            
            timer1.Enabled = true;
            listen.Enabled = false;
            button1.Enabled = true;
        }


        /// <summary>
        /// 实时显示数据到界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            try
            {
                
                labelCurrentPercent.Text = Convert.ToString(NewMain.Nform.cloud.Data.volume.Loadingrate);
                progressBarPercent.Value = NewMain.Nform.cloud.Data.volume.Loadingrate;

                //labelcount.Text = NewMain.Nform.cloud.volumeCalc.count;
                labelvolumetext.Text = Convert.ToString(NewMain.Nform.cloud.Data.volume.volume);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelflag1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewMain.Nform.cloud.cloudnet.Send(NewMain.Nform.cloud.cloudnet.CreatCodeToPackage(Codemode.play));
            button3.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMain.Nform.cloud.cloudnet.Send(NewMain.Nform.cloud.cloudnet.CreatCodeToPackage(Codemode.stopsendvolume));
            
            listen.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewMain.Nform.cloud.cloudnet.Send(NewMain.Nform.cloud.cloudnet.CreatCodeToPackage(Codemode.stop));
        }

        private void configbutton_Click(object sender, EventArgs e)
        {
            Form timechange = new Timechange();
            timechange.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.Text = NewMain.Nform.cloud.Data.volume.carName;
            labelCarNumber.Text = NewMain.Nform.cloud.Data.volume.carSN;
            labelVolume.Text = Convert.ToString(NewMain.Nform.cloud.Data.volume.carVolume);
        }
    }
}
