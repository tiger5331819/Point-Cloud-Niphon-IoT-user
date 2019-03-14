using System;
using System.Windows.Forms;

namespace EVCS
{
    public partial class CarInfoEnter : Form
    {
        public CarInfoEnter()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string carno = textBoxCarNO.Text;
            string contract = textBoxContract.Text;
            string tel = textBoxTel.Text;
            string volume = textBoxVolume.Text;
            string remark = textBoxRemark.Text;
            if (String.IsNullOrEmpty(carno))
            {
                MessageBox.Show("车牌号不能为空！");
                return;
            }
            if (String.IsNullOrEmpty(contract))
            {
                MessageBox.Show("请填写联系人！");
                return;
            }
            if (String.IsNullOrEmpty(tel))
            {
                MessageBox.Show("请填写联系方式！");
                return;
            }
            if (String.IsNullOrEmpty(volume))
            {
                MessageBox.Show("请填写车辆体积！");
                return;
            }
            using (EVCSEntities1 db=new EVCSEntities1())
            {
                CarInfos info = new CarInfos();
                info.CarNO = carno;
                info.Contact= contract;
                info.Tel = tel;
                info.Volume =Convert.ToDecimal( volume);
                info.Remark = remark;
                db.CarInfos.Add(info);
                db.SaveChanges();
                MessageBox.Show("录入成功！");
                this.Close();
            }
        }

        private void textBoxCarNO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
