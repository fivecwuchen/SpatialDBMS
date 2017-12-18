using System;
using System.Windows.Forms;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using System.Data;

namespace SpatialDBMS.Forms
{
    public partial class FormQueryByTime : Form
    {
        public string rasterPath = System.Environment.CurrentDirectory + "\\data\\YGYX.gdb";
        public FormQueryByTime()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string year = cbxYear.SelectedItem.ToString();
            string month = cbxMonth.SelectedItem.ToString();

            IWorkspaceFactory pFileGDBWorkspaceFactory;
            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactory();
            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(rasterPath, 0);
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            IDataset pDataset = pEnumDataset.Next();
            DataTable SpatialRefTable = new DataTable();

            SpatialRefTable.Columns.Add(new DataColumn("影像名称", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("影像拍摄时间", typeof(string)));

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
                    dr["影像拍摄时间"] = strArray[1].Substring(0, 8);
                    IRasterLayer pRasterLayer = new RasterLayer();
                    pRasterLayer.CreateFromDataset(pRasterDataset);
                    if (strArray[1].Substring(0, 6) == year + month)
                    {
                        SpatialRefTable.Rows.Add(dr);
                    }


                }
                pDataset = pEnumDataset.Next();
            }
            // ExportExcel(SpatialRefTable);
            //弹出显示框
            FormQueryShowResult timeQuery = new FormQueryShowResult();
            timeQuery.Text = "时间查询";
            timeQuery.dgvQueryResult.DataSource = SpatialRefTable;
            timeQuery.dgvQueryResult.Columns[1].Width = 200;
            timeQuery.Show();
        }
    }
}
