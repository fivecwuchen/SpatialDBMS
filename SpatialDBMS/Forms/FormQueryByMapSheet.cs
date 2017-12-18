using System;
using System.Windows.Forms;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using System.Data;

namespace SpatialDBMS.Forms
{
    public partial class FormQueryByMapSheet : Form
    {
        public string rasterPath = System.Environment.CurrentDirectory + "\\data\\YGYX.gdb";
        public string id = "0";
        public FormQueryByMapSheet()
        {
            InitializeComponent();
        }


        private void checkLeftUpper_Click(object sender, EventArgs e)
        {
            id = "0";
        }

        private void checkRightUpper_Click(object sender, EventArgs e)
        {
            id = "1";
        }

        private void checkLeftDown_Click(object sender, EventArgs e)
        {
            id = "2";
        }

        private void checkRightDown_Click(object sender, EventArgs e)
        {
            id = "3";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string[] image = comboBox1.SelectedItem.ToString().Split('_');

            IWorkspaceFactory pFileGDBWorkspaceFactory;
            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactory();
            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(rasterPath, 0);
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            IDataset pDataset = pEnumDataset.Next();
            DataTable SpatialRefTable = new DataTable();

            SpatialRefTable.Columns.Add(new DataColumn("影像名称", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("图幅号", typeof(string)));

            //判断数据集是否有数据
            while (pDataset != null)
            {

                if (pDataset is IRasterDataset) //栅格数据集
                {
                    IRasterWorkspaceEx pRasterWorkspace = (IRasterWorkspaceEx)pWorkspace;
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pDataset.Name);
                    //影像金字塔判断与创建
                    ISpatialReference pSpatialRef = (pRasterDataset as IGeoDataset).SpatialReference;
                    string spatialref = pSpatialRef.Name.ToString();
                    string rastername = pDataset.Name.ToString();
                    string[] strArray = rastername.Split('_');

                    DataRow dr = SpatialRefTable.NewRow();
                    dr["影像名称"] = pDataset.Name.ToString();
                    dr["图幅号"] = strArray[1].Substring(strArray[1].Length-1, 1);
                    IRasterLayer pRasterLayer = new RasterLayer();
                    pRasterLayer.CreateFromDataset(pRasterDataset);
                    if (strArray[1].Substring(0, 8) == image[1] && strArray[1].Substring(strArray[1].Length - 1, 1) == id)
                    {
                        SpatialRefTable.Rows.Add(dr);
                    }


                }
                pDataset = pEnumDataset.Next();
            }
            // ExportExcel(SpatialRefTable);
            //弹出显示框
            FormQueryShowResult timeQuery = new FormQueryShowResult();
            timeQuery.Text = "图幅查询";
            timeQuery.dgvQueryResult.DataSource = SpatialRefTable;
            timeQuery.dgvQueryResult.Columns[1].Width = 200;
            timeQuery.Show();
        }

    }
}
