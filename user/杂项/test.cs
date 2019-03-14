using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVCS
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            label4.Text = "程序版本：" + NewMain.Nform.cloud.Volumev;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process pr = new Process();//声明一个进程类对象

            pr.StartInfo.FileName = "测试工具.exe";
            pr.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //设置开机自启动  
            {
                MessageBox.Show("设置开机自启动，需要修改注册表", "提示");
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.SetValue("JcShutdown", path);
                rk2.Close();
                rk.Close();
            }
            else //取消开机自启动  
            {
                MessageBox.Show("取消开机自启动，需要修改注册表", "提示");
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.DeleteValue("JcShutdown", false);
                rk2.Close();
                rk.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form key = new 杂项.key();
            key.ShowDialog();
            this.Close();
        }
    }
}
