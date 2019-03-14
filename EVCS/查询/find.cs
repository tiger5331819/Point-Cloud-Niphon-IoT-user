using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVCS.查询
{
    public partial class find : Form
    {
        public find()
        {
            InitializeComponent();
        }

        private void find_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eVCSDataSet.V_Records”中。您可以根据需要移动或删除它。
            this.v_RecordsTableAdapter.Fill(this.eVCSDataSet.V_Records);
            // TODO: 这行代码将数据加载到表“eVCSDataSet.Records”中。您可以根据需要移动或删除它。


        }
    }
}
