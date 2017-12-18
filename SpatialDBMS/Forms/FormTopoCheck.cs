using System;
using System.Windows.Forms;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

namespace SpatialDBMS.Forms
{
    public partial class FormTopoCheck : Form
    {        
        public FormTopoCheck()
        {
            InitializeComponent();
        }

        #region 成员
        private IWorkspace myWorkSpace;
        private ITopology myTopology;
        private Form forminstance;
        private string[] CB_FCIndex;
        private string[] CB_FCName;
        private string[] SelectText = new string[3];
        private string[] TempRuleContainer = new string[47];
        private int[] FCIndex = new int[2];
        private string _CatchTpRule;
        private int lenth = 0;
        #endregion

        #region 方法
        public void pass_FCName(string[] FCName)
        {
            CB_FCName = FCName;
        }
        public void pass_FCIndex(string[] FCIndex)
        {
            CB_FCIndex = FCIndex;
        }
        public void get_WorkSpace(IWorkspace myTempWSp)
        {
            myWorkSpace = myTempWSp;
        }
        public void get_SelectForm(Form openform)
        {
            forminstance = openform;
        }
        #endregion

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            ListViewItem LVI = new ListViewItem();
            LVI.Text = SelectText[0];
            for (int i = 1; i <= 2; i++)
            {
                LVI.SubItems.Add(SelectText[i]);
            }
            listView1.Items.Add(LVI);
            listView1.EndUpdate();

            if (lenth == 0)
            {
                int index = 0;
                foreach (string x in TempRuleContainer)
                {
                    if (x.Equals(_CatchTpRule))
                    {
                        break;
                    }
                    else
                        index++;
                }
                SpatialDBMS.Classes.Topology second = new SpatialDBMS.Classes.Topology();
                string RuleName = TempRuleContainer[index].Remove(0, 7);
                IFeatureClass myTempFC = second.get_FCContainer(myWorkSpace).get_Class(FCIndex[0]);
                second.AddRuleToTopology1(myTopology, (esriTopologyRuleType)index, RuleName, myTempFC);
                MessageBox.Show("添加拓扑规则成功!");
            }
            else
            {
                int index = 0;
                foreach (string x in TempRuleContainer)
                {
                    if (x.Equals(_CatchTpRule))
                    {
                        break;
                    }
                    else
                        index++;
                }
                SpatialDBMS.Classes.Topology second = new SpatialDBMS.Classes.Topology();
                string RuleName = TempRuleContainer[index].Remove(0, 7);
                IFeatureClass myOriginFC = second.get_FCContainer(myWorkSpace).get_Class(FCIndex[0]);
                IFeatureClass myDestinationFC = second.get_FCContainer(myWorkSpace).get_Class(FCIndex[1]);
                second.AddRuleToTopology2(myTopology, (esriTopologyRuleType)index, RuleName, myOriginFC, 1, myDestinationFC, 1);
                MessageBox.Show("添加拓扑规则成功!");
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            IGeoDataset geoDataset = (IGeoDataset)myTopology;
            IEnvelope envelope = geoDataset.Extent;
            SpatialDBMS.Classes.Topology third = new SpatialDBMS.Classes.Topology();
            third.ValidateTopology(myTopology, envelope);
            MessageBox.Show("验证成功!");
        }

        private void btnCreateTopo_Click(object sender, EventArgs e)
        {
            SpatialDBMS.Classes.Topology second = new SpatialDBMS.Classes.Topology();
            ITopology myTempTopology = second.create_topology(myWorkSpace, CB_FCIndex, textBoxTopoName.Text);
            myTopology = myTempTopology;
            MessageBox.Show("创建拓扑成功 !");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormTopoSelect mySelectForm = new FormTopoSelect();
            mySelectForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //加载检查结果
        private void btnFinish_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void comboBoxFeaA_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectText[0] = comboBoxFeaA.SelectedItem.ToString();
            int index = 0;
            foreach (string x in CB_FCName)
            {
                if (x.Equals(comboBoxFeaA.SelectedItem.ToString()))
                    FCIndex[0] = index;
                else
                    index++;
            }

        }

        private void comboBoxTopoRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectText[1] = comboBoxTopoRule.SelectedItem.ToString();
            string temp1 = SelectText[1];
            string temp2;
            temp2 = "esriTRT" + temp1;
            _CatchTpRule = temp2;

        }

        private void comboBoxFeaB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectText[2] = comboBoxFeaB.SelectedItem.ToString();
            int index = 0;
            foreach (string x in CB_FCName)
            {
                if (x.Equals(comboBoxFeaB.SelectedItem.ToString()))
                    FCIndex[1] = index;
                else
                    index++;
            }
            if (comboBoxFeaB.SelectedItem != null)
            {
                lenth = 1;
            }
            else
                lenth = 0;

        }

        private void FormTopoCheck_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < CB_FCIndex.Length; i++)
            {
                comboBoxFeaA.Items.Add(CB_FCName[int.Parse(CB_FCIndex[i])]);
                comboBoxFeaB.Items.Add(CB_FCName[int.Parse(CB_FCIndex[i])]);
            }
            for (int i = 0; i <= 46; i++)
            {
                string temp = ((esriTopologyRuleType)i).ToString();
                TempRuleContainer[i] = temp;
                if (temp.Length < 3)
                {
                    continue;
                }
                else
                {
                    temp = temp.Remove(0, 7);
                    comboBoxTopoRule.Items.Add(temp);
                }

            }

        }

        private void FormTopoCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            forminstance.Dispose();
        }

        private void btnAddRule_Click_1(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            ListViewItem LVI = new ListViewItem();
            LVI.Text = SelectText[0];
            for (int i = 1; i <= 2; i++)
            {
                LVI.SubItems.Add(SelectText[i]);
            }
            listView1.Items.Add(LVI);
            listView1.EndUpdate();

            if (lenth == 0)
            {
                int index = 0;
                foreach (string x in TempRuleContainer)
                {
                    if (x.Equals(_CatchTpRule))
                    {
                        break;
                    }
                    else
                        index++;
                }
                SpatialDBMS.Classes.Topology second = new SpatialDBMS.Classes.Topology();
                string RuleName = TempRuleContainer[index].Remove(0, 7);
                IFeatureClass myTempFC = second.get_FCContainer(myWorkSpace).get_Class(FCIndex[0]);
                second.AddRuleToTopology1(myTopology, (esriTopologyRuleType)index, RuleName, myTempFC);
                MessageBox.Show("添加拓扑规则成功!");
            }
            else
            {
                int index = 0;
                foreach (string x in TempRuleContainer)
                {
                    if (x.Equals(_CatchTpRule))
                    {
                        break;
                    }
                    else
                        index++;
                }
                SpatialDBMS.Classes.Topology second = new SpatialDBMS.Classes.Topology();
                string RuleName = TempRuleContainer[index].Remove(0, 7);
                IFeatureClass myOriginFC = second.get_FCContainer(myWorkSpace).get_Class(FCIndex[0]);
                IFeatureClass myDestinationFC = second.get_FCContainer(myWorkSpace).get_Class(FCIndex[1]);
                second.AddRuleToTopology2(myTopology, (esriTopologyRuleType)index, RuleName, myOriginFC, 1, myDestinationFC, 1);
                MessageBox.Show("添加拓扑规则成功!");
            }
        }

        private void btnValidate_Click_1(object sender, EventArgs e)
        {
            IGeoDataset geoDataset = (IGeoDataset)myTopology;
            IEnvelope envelope = geoDataset.Extent;
            SpatialDBMS.Classes.Topology third = new SpatialDBMS.Classes.Topology();
            third.ValidateTopology(myTopology, envelope);
            MessageBox.Show("验证成功!");
        }
    }
}
