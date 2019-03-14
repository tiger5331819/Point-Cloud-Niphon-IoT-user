using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVCS.体积测量
{
    public partial class Timechange : Form
    {
        public Timechange()
        {
            InitializeComponent();
            comboBoxTimeList.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void comboBoxTimeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ID;
                int flag=0;
                ID = comboBoxTimeList.Text;  
                switch(ID)
                {
                    case "一频":flag = 0;break;
                    case "二频":flag = 1;break;
                    case "三频":flag = 2;break;
                }
                comboBox1.Text = Convert.ToString(NewMain.Nform.cloud.gethour(flag, true));
                comboBox1.SelectedIndex = NewMain.Nform.cloud.gethour(flag,true);
                comboBox2.Text= Convert.ToString(NewMain.Nform.cloud.getminute(flag, true));
                comboBox2.SelectedIndex = NewMain.Nform.cloud.getminute(flag, true);

                comboBox4.Text = Convert.ToString(NewMain.Nform.cloud.gethour(flag, false));
                comboBox4.SelectedIndex = NewMain.Nform.cloud.gethour(flag, false);
                comboBox3.Text = Convert.ToString(NewMain.Nform.cloud.getminute(flag, false));
                comboBox3.SelectedIndex = NewMain.Nform.cloud.getminute(flag, false);

            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID;
            int flag = 0;
            ID = comboBoxTimeList.Text;
            switch (ID)
            {
                case "一频": flag = 0; break;
                case "二频": flag = 1; break;
                case "三频": flag = 2; break;
                default:MessageBox.Show("小云检测到不正确的频段，请选择正确的频段！");break;
            }
            NewMain.Nform.cloud.sethour(flag, true, comboBox1.Text);
            NewMain.Nform.cloud.setminute(flag, true, comboBox2.Text);
            NewMain.Nform.cloud.sethour(flag, false, comboBox4.Text);
            NewMain.Nform.cloud.setminute(flag, false, comboBox3.Text);
            MessageBox.Show("计划任务时间更改");
            this.Close();
        }

        private void Timechange_FormClosing(object sender, FormClosingEventArgs e)
        {
            NewMain.Nform.tabControlMain.TabPages.Remove(NewMain.Nform.tabControlMain.SelectedTab);
        }
    }
}
