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
    public partial class level : Form
    {
        public level()
        {
            InitializeComponent();
        }

        private void level_Load(object sender, EventArgs e)
        {
            textBoxEVCSversion.Text = NewMain.Nform.cloud.EVCSv;
            textBoxvolumeversion.Text = NewMain.Nform.cloud.Volumev;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMain.Nform.cloud.EVCSv=textBoxEVCSversion.Text;
            NewMain.Nform.cloud.Volumev=textBoxvolumeversion.Text;
            MessageBox.Show("版本信息更新成功");
        }

        private void level_FormClosing(object sender, FormClosingEventArgs e)
        {
            NewMain.Nform.tabControlMain.TabPages.Remove(NewMain.Nform.tabControlMain.SelectedTab);
        }
    }
}
