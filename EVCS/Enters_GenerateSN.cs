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
    public partial class Enters_GenerateSN : Form
    {
        public Enters_GenerateSN()
        {
            InitializeComponent();
        }

        private void comboBoxCarInfoLists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Enters_GenerateSN_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eVCSDataSet.CarInfos”中。您可以根据需要移动或删除它。
            this.carInfosTableAdapter.Fill(this.eVCSDataSet.CarInfos);
            string sn = new GenerateSerialNumber().Generate("HYDH","yyyyMMdd",1,1,6);
            labelSN.Text = sn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CarNO =Convert.ToInt32( comboBoxCarNO.SelectedValue);
            string sn = labelSN.Text;
            string createUser = textBoxCreateUser.Text;
            using (EVCSEntities1 db=new EVCSEntities1())
            {
                db.SerialNumberRecords.Add(new SerialNumberRecords() { CarNO = CarNO, SN = sn, CreateUser = createUser,Datetime=DateTime.Now });
                db.SaveChanges();
            }
            MessageBox.Show("添加单号成功！");
            this.Close();
        }
    }
}
