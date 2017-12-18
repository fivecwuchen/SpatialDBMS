using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpatialDBMS.Classes;

namespace SpatialDBMS.Forms
{
    public partial class FormAddUser : Form
    {
        public static string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Data\\User.csv";
        DataTable User = CSVHelper.ReadCSV(path);
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            DataTable User_new = User.Copy();

            if (username.Text == null || username.Text.Equals(""))
            {
                MessageBox.Show("用户名不能为空!");
                return;
            }
            if (psw1.Text == null || psw1.Text.Equals(""))
            {
                MessageBox.Show("密码不能为空!");
                return;
            }
            if (psw1.Text != psw2.Text)
            {
                MessageBox.Show("两次密码不一致!");
                return;
            }
            DataRow newline = User.Rows[1];
            int r = User_new.Rows.Count + 1;

            newline[0] = r.ToString();
            newline[1] = username.Text;
            newline[2] = psw1.Text;
            newline[3] = "0";
            User_new.Rows.Add(newline.ItemArray);

            CSVHelper.SaveCSV(User_new, path);
            MessageBox.Show("新增用户" + username.Text + "成功!");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
