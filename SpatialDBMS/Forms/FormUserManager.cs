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
    public partial class FormUserManager : Form
    {
        public static string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Data\\User.csv";
        DataTable User = CSVHelper.ReadCSV(path);
        DataTable User1 = new DataTable();
        
        public FormUserManager()
        {
            InitializeComponent();
        }

        private void FormUserManager_Load(object sender, EventArgs e)
        {
            for (int r = 0; r < User.Rows.Count; r++)
            {
                listBox1.Items.Add(User.Rows[r][1].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddUser dialog = new FormAddUser();
            dialog.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User1.Columns.Add("ID", typeof(string));
            User1.Columns.Add("NAME", typeof(string));
            User1.Columns.Add("PASSWORD", typeof(string));
            User1.Columns.Add("ROLE", typeof(string));
            String name = listBox1.SelectedItem.ToString();
            for (int r = 0; r < User.Rows.Count; r++)
            {
                if (name != User.Rows[r][1].ToString())
                {
                    User1.Rows.Add(User.Rows[r].ItemArray);
                }
            }

            CSVHelper.SaveCSV(User1, path);
            MessageBox.Show("删除用户" + name + "成功!");
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            this.Close();
        }

        
    }
}
