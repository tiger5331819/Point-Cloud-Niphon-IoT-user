using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVCS.查询
{
    public partial class SingleVolume : Form
    {
        public SingleVolume()
        {
            InitializeComponent();
        }
        private void InfoSearch_Load(object sender, EventArgs e)
        {

        }



        private void comboBoxSN_CarNubmer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SingleVolume_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eVCSDataSet.CarInfos”中。您可以根据需要移动或删除它。
            this.carInfosTableAdapter.Fill(this.eVCSDataSet.CarInfos);
            // TODO: 这行代码将数据加载到表“eVCSDataSet.Singlevolume”中。您可以根据需要移动或删除它。
            this.singlevolumeTableAdapter.Fill(this.eVCSDataSet.Singlevolume);

        }
    }
}

        