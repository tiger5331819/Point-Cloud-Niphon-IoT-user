using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVCS.杂项
{
    public partial class key : Form
    {
        public key()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "PointCloudNiphon")
            {
                Form door = new door();
                door.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("密码输入错误请重新输入！");
                textBox1.Text = "";
            }
               
        }
    }
}
