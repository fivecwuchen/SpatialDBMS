using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.DataSourcesFile;
using SpatialDBMS.Classes;

namespace SpatialDBMS.Forms
{
    public partial class FormTopoSelect : Form
    {
        FormTopoCheck TopoCheckForm = new FormTopoCheck();
        SpatialDBMS.Classes.Topology first = new SpatialDBMS.Classes.Topology();

        private IWorkspace PWSp, FWSp;
        public IWorkspace WSp
        {
            get
            {
                if (PWSp != null)
                    return PWSp;
                if (FWSp != null)
                    return FWSp;
                else
                {
                    MessageBox.Show("your WorkSpace is NULL!");
                    return null;
                }
            }
        }

        private string[] myFCName;
        public string[] FCName
        {
            get { return myFCName; }
        }

        private static string[] mySelectedFCName;
        public static string[] SeletedFCName
        {
            get { return mySelectedFCName; }
        }

        private string[] SelectedfcIndex;
        public string[] Selected_FCIndex
        {
            get
            { return SelectedfcIndex; }
        }

        private void FormTopoSelect_Load(object sender, EventArgs e)
        {

        }
        //点击下一步按钮的响应操作
        private void btnNext_Click(object sender, EventArgs e)
        {
            StringBuilder mySb = new StringBuilder();
            foreach (int x in checkedListBoxFeatures.CheckedIndices)
            {
                mySb.Append(x + ",");
            }
            string tempstr = mySb.ToString().Remove(mySb.ToString().Length - 1);
            string[] tempArray = tempstr.Split(',');
            //动态数组的生成方法1：stringbuilder转string[]。
            //方法2：使用Array
            //上面两个语句用以去除""的数组元素

            TopoCheckForm.pass_FCIndex(tempArray);
            if (PWSp != null)
            {
                TopoCheckForm.get_WorkSpace(PWSp);
            }
            else
            {
                TopoCheckForm.get_WorkSpace(FWSp);
            }
            this.Hide();
            TopoCheckForm.Show();
            TopoCheckForm.Activate();
            TopoCheckForm.get_SelectForm(this);
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < checkedListBoxFeatures.Items.Count; j++)
            {
                checkedListBoxFeatures.SetItemChecked(j, true);
            }
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < checkedListBoxFeatures.Items.Count; j++)
            {
                checkedListBoxFeatures.SetItemChecked(j, false);
            }
        }
        //加载文件数据库操作（gdb）
        private void OpenGDB_Click(object sender, EventArgs e)
        {
            PWSp = first.get_FWorkSp();
            textBoxGdbPath.Text = first.File_Name;
            IFeatureClassContainer myFCContainer = first.get_FCName(PWSp);

            myFCName = first.get_FCName2(PWSp);
            TopoCheckForm.pass_FCName(myFCName);
            if (myFCName != null)
            {
                int j = 0;
                if (myFCContainer.ClassCount != 0 && myFCName != null)
                {
                    while (j < myFCContainer.ClassCount)
                    {//在IFeatureClass中有AliaName（别名）属性
                     //现在采用这个方法能够获得FC的原名，代码如下：
                     //myFCContainer.Class[j].AliaName

                        checkedListBoxFeatures.Items.Add(myFCName[j]);
                        j++;
                    }
                }
                else
                {
                    MessageBox.Show("There is no FeatureClass in your DataSet!");
                    return;
                }
            }
        }

        private void OpenMDB_Click(object sender, EventArgs e)
        {
            #region 用IFeatureClassContainer来读取Name属性失败~
            //openGDB first = new openGDB();
            //PWSp = first.get_PWorkSp();
            //textBox1.Text = first.File_Name;           
            //IFeatureClassContainer myFCContainer = first.get_FCName(PWSp);
            //if (myFCContainer != null)
            //{
            //    int j = 0;
            //    if (myFCContainer.ClassCount != 0)
            //    {
            //        while (j < myFCContainer.ClassCount)
            //        {
            //            checkedListBox1.Items.Add(myFCContainer.Class[j].AliasName);
            //            j++;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("There is no FeatureClass in your DataSet!");
            //        return;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("There is no DataSet in your DataBase!");
            //    return;
            //}
            #endregion

            FWSp = first.get_FWorkSp();
            textBoxGdbPath.Text = first.File_Name;
            IFeatureClassContainer myFCContainer = first.get_FCName(FWSp);
            string[] myFCName;
            myFCName = first.get_FCName2(FWSp);
            TopoCheckForm.pass_FCName(myFCName);
            if (myFCContainer.ClassCount != 0 && myFCName != null)
            {
                int j = 0;
                if (myFCContainer.ClassCount != 0)
                {
                    while (j < myFCContainer.ClassCount)
                    {//在IFeatureClass中有AliaName（别名）属性
                        //现在采用这个方法能够获得FC的原名，代码如下：
                        //myFCContainer.Class[j].AliaName

                        checkedListBoxFeatures.Items.Add(myFCName[j]);
                        j++;
                    }
                }
                else
                {
                    MessageBox.Show("There is no FeatureClass in your DataSet!");
                    return;
                }
            }
        }

        public FormTopoSelect()
        {
            InitializeComponent();
        }

        
    }
}
