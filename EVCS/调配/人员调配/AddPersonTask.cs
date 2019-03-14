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
    public partial class AddPersonTask : Form
    {
        public AddPersonTask()
        {
            InitializeComponent();
        }

        private void PersonTaskLists_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“eVCSDataSet1.Users”中。您可以根据需要移动或删除它。
            this.usersTableAdapter1.Fill(this.eVCSDataSet1.Users);

            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePicker1.Value;
                int userID = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                using (EVCSEntities1 db = new EVCSEntities1())
                {
                    db.PersonTasks.Add(new PersonTasks() { UserID = userID, TaskDate = date });
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
            }
            MessageBox.Show("任务添加完成！");
            comboBox1.Text = "";
        }
    }
}
