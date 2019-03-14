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
    public partial class InfoSearch : Form
    {
        public InfoSearch()
        {
            InitializeComponent();
        }

        private void InfoSearch_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eVCSDataSet1.Records_Day_Volume”中。您可以根据需要移动或删除它。
            this.records_Day_VolumeTableAdapter.Fill(this.eVCSDataSet1.Records_Day_Volume);

            // TODO: 这行代码将数据加载到表“eVCSDataSet.SerialNumberRecordsDetails”中。您可以根据需要移动或删除它。
            this.serialNumberRecordsDetailsTableAdapter.Fill(this.eVCSDataSet.SerialNumberRecordsDetails);

            // TODO:  这行代码将数据加载到表“eVCSDataSet.CarInfos”中。您可以根据需要移动或删除它。
            this.carInfosTableAdapter.Fill(this.eVCSDataSet.CarInfos);

            //货运单号查询 添加默认值
            comboBoxSN_CarNubmer.Text = " ";
            dateTimePickerSNEnd.Value = DateTime.Now;
            dateTimePickerSNStart.Value = DateTime.Now.AddMonths(-1);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSN_Search_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSN_Search_Click_1(object sender, EventArgs e)
        {
            string carnumber = comboBoxSN_CarNubmer.Text;
            DateTime start = dateTimePickerSNStart.Value;
            DateTime end = dateTimePickerSNEnd.Value;
            BindingSource bs = new BindingSource();
            bs = dataGridView3.DataSource as BindingSource;
            
            //拼接查询条件
            string filter = "";
            

            filter += "(Datetime >='"+ start.ToShortDateString() + "' and Datetime <= '"+ end.ToShortDateString() + "')";
            if (!String.IsNullOrEmpty(carnumber))
            {
                filter += " and CarNumber like '%" + carnumber + "%'";
            }
            bs.Filter = filter;
            dataGridView3.DataSource = bs;

        }

        private void buttonSN_Reset_Click(object sender, EventArgs e)
        {
            comboBoxSN_CarNubmer.Text="";
            dateTimePickerSNStart.Value=DateTime.Now.AddMonths(-1);
            dateTimePickerSNEnd.Value = DateTime.Now;
            BindingSource bs = new BindingSource();
            bs = dataGridView3.DataSource as BindingSource;
            bs.Filter = "";
            dataGridView3.DataSource = bs;
        }

        private void dateTimePickerSNStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSN_CarNubmer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.v_RecordsTableAdapter.FillBy(this.eVCSDataSet.V_Records);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
