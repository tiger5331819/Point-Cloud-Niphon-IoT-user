using EVCS;
using EVCS.查询;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace EVCS
{
    public partial class InfoSearchmain : Form
    {
        public InfoSearchmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form infoSearch = new InfoSearch();
            infoSearch.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form carf = new carfind();
            carf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form analysis = new Analysis();
            analysis.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Singlevolume = new SingleVolume();
            Singlevolume.ShowDialog();
        }

        private void InfoSearchmain_Load(object sender, EventArgs e)
        {

        }
    }
}
