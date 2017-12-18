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
using System.IO;

namespace SpatialDBMS.Forms
{
    public partial class FormLogin : Form
    {
        public static string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Data\\User.csv";
        DataTable User = CSVHelper.ReadCSV(path);
        public bool ifLogin = false;
        public bool ifManager = false;
        public string role = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = name.Text.Trim();
            string psw = password.Text.Trim();
            string csv_psw = "";
            string csv_role = "";

            for (int r = 0; r < User.Rows.Count; r++)
            {
                if (username == User.Rows[r][1].ToString())
                {
                    csv_psw = User.Rows[r][2].ToString();
                    csv_role = User.Rows[r][3].ToString();
                }
            }

            if (csv_psw == psw)
            {
                ifLogin = true;
                if (csv_role == "1")
                {
                    ifManager = true;
                    role = "管理员";
                }
                else
                {
                    role = "操作员";
                }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
