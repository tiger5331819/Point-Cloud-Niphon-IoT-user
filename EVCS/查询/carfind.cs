using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EVCS.查询
{
    public partial class carfind : Form
    {
        public carfind()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当查询事件发生时更新表单数据并且按照时间进行查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(carname))
            //{
            //    MessageBox.Show("请先选择车辆信息！");
            //    return;
            //}

            //DataSet ds = new DataSet();
            //string sql;


            ////string ConnectionStr = "Server=tcp:point-cloud.database.chinacloudapi.cn,1433;Initial Catalog=EVCS;Persist Security Info=False;User ID=suhuyuan;Password=PointCloud401;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //string ConnectionStr = "Server=10.193.255.203;Initial Catalog=EVCS;User ID=suhuyuan;Password=PointCloud401;MultipleActiveResultSets=False;";
            //SqlConnection conn = new SqlConnection(ConnectionStr);

            //conn.Open();
            //sql = "SELECT a.ID,b.CarNO, a.StartDate, a.EndDate, a.Volume, a.[Loading rate] FROM Records AS a INNER JOIN CarInfos AS b ON a.CarNO = b.ID where b.CarNO ='" + carname + "'"; //查询表
            //SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //sda.Fill(ds);
            //this.dataGridView1.DataSource = ds.Tables[0];//表从起始行显示在dataGridView里

            //conn.Close();

            //DateTime date = dateTimePicker1.Value.Date;
            //MessageBox.Show(Convert.ToString(date));

            this.records_Day_VolumeTableAdapter.Fill(this.eVCSDataSet.Records_Day_Volume);
            //获取选择的日期
            DateTime date = dateTimePicker1.Value.Date;

            BindingSource bs = new BindingSource();
            bs = dataGridView1.DataSource as BindingSource;
            //拼接查询条件
            string filter = "";

            filter += "(年='" + date.Year + "' and 月 = '" + date.Month + "'and 日 ='" + date.Day + "')";
            bs.Filter = filter;
            dataGridView1.DataSource = bs;

        }

        private void carfind_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eVCSDataSet.Records_Day_Volume”中。您可以根据需要移动或删除它。
           


            this.comboBoxCarInfoLists.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int carInfoID;
        String carname;
        private void comboBoxCarInfoLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                carInfoID = Convert.ToInt32(comboBoxCarInfoLists.SelectedValue);
                using (EVCSEntities1 db = new EVCSEntities1())
                {
                    var carinfo = db.CarInfos.Where(f => f.ID == carInfoID).First();
                    carname = carinfo.CarNO;
                    decimal? volume = carinfo.Volume;
                    //labelVolume.Text = volume.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dateTimePickerAnalysisDayly_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
