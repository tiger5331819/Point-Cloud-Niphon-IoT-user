using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVCS
{
    public partial class MainFrame : Form
    {
        Timer timerr;
      
        public MainFrame(Timer timer)
        {
            InitializeComponent();
            timerr = timer;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "版本号：" + NewMain.Nform.cloud.EVCSv;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form test = new test();
            test.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form log = new log();
            log.ShowDialog();
        }

       
    }
}
