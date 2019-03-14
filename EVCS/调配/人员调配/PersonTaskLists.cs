using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVCS.调配.人员调配
{
    public partial class PersonTaskLists : Form
    {
        public PersonTaskLists()
        {
            InitializeComponent();
        }

        private void PersonTaskLists_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“eVCSDataSet.V_PersonTasks”中。您可以根据需要移动或删除它。
            this.v_PersonTasksTableAdapter.Fill(this.eVCSDataSet.V_PersonTasks);
            datebind();
        }
        private void datebind()
        {
            this.v_PersonTasksTableAdapter.Fill(this.eVCSDataSet.V_PersonTasks);
            DateTime date = dateTimePicker1.Value.Date;
            BindingSource bs = new BindingSource();
            bs = dataGridView1.DataSource as BindingSource;

            //拼接查询条件
            string filter = "";


            filter += "TaskDate ='" + date.ToShortDateString() + "'";
            bs.Filter = filter;
            dataGridView1.DataSource = bs;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datebind();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
