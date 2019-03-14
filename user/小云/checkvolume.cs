using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVCS.小云
{
    public partial class checkvolume : Form
    {
        public checkvolume()
        {
            InitializeComponent();
            volumeshow[0] = volumeshow[1] = volumeshow[2] = volumeshow[3]=volumeshow[4]= "0";
        }
        string[] volumeshow = new string[5];
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = NewMain.Nform.cloud.volumeCalc.Loadingrate.ToString();
            textBoxvolume.Text = Convert.ToString(NewMain.Nform.cloud.Volume);
            for(int i=4;i>0;i--)
            {
                volumeshow[i] = volumeshow[i - 1];
            }
            volumeshow[0] = textBoxvolume.Text;
            label1.Text = volumeshow[0];
            label5.Text = volumeshow[1];
            label7.Text = volumeshow[2];
            label11.Text = volumeshow[3];
            label9.Text = volumeshow[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="暂停")
            {
                timer1.Enabled = false;
                button2.Enabled = true;
                button1.Text = "恢复";
            }
            else
            {
                timer1.Enabled = true;
                button2.Enabled = false;
                button1.Text = "暂停";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal nowvolume = Convert.ToDecimal(label1.Text);
            decimal changevolume = Convert.ToDecimal(textBoxvolume.Text);
            decimal middlevolume = nowvolume - changevolume;
            if (NewMain.Nform.cloud.changevolume(middlevolume))
            {
                MessageBox.Show("体积修改成功！");
                NewMain.Nform.logClass.write("修改体积");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            textBoxcarinfoenable.Text = NewMain.Nform.cloud.Calc.comboBoxCarInfoLists.Enabled.ToString();
            textBoxcarinfovisible.Text = NewMain.Nform.cloud.Calc.comboBoxCarInfoLists.Visible.ToString();
            textBoxboenable.Text= NewMain.Nform.cloud.Calc.buttonOperate.Enabled.ToString();
            textBoxbovisible.Text = NewMain.Nform.cloud.Calc.buttonOperate.Visible.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewMain.Nform.cloud.Calc.comboBoxCarInfoLists.Enabled = Convert.ToBoolean(textBoxcarinfoenable.Text);
            NewMain.Nform.cloud.Calc.comboBoxCarInfoLists.Visible = Convert.ToBoolean(textBoxcarinfovisible.Text);
            NewMain.Nform.cloud.Calc.buttonOperate.Enabled = Convert.ToBoolean(textBoxboenable.Text);
            NewMain.Nform.cloud.Calc.buttonOperate.Visible = Convert.ToBoolean(textBoxbovisible.Text);
        }
    }
}
