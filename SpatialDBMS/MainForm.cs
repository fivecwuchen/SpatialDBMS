using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using SpatialDBMS.Classes;
using SpatialDBMS.Forms;
using System.Collections.Generic;

namespace SpatialDBMS
{
    public partial class MainForm : Form
    {
        #region


        //treeview2父节点
        TreeNode Vecnode = new TreeNode();
        TreeNode Rasnode = new TreeNode();

        public IMapControl3 m_mapControl = null;
        private string m_mapDocumentName = string.Empty;
        private ISelectionEnvironment selectionEnvironment;

        //右键菜单
        private ITOCControl2 pTocControl;
        private IMapControl3 pMapControl;
        private IToolbarMenu pToolMenuMap;
        private IToolbarMenu pToolMenuLayer;
        //标记当前选中的工具类型
        private string mTool;

        //代码图层名可编辑功能变量
        private ITOCControl m_TOCControl;

        public ILayer pMoveLayer;//需要被调整的图层；
        public int toIndex;//将要调整到的目标图层的索引；

        //文件路径名称,包含文件名称和路径名称
        string strName = null;
        bool isExit = false;


        public string rasterPath = System.Environment.CurrentDirectory + "\\data\\栅格数据设计\\YGYX.gdb";
        public string vectorPath = System.Environment.CurrentDirectory + "\\data\\JCDL.gdb";

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //get the MapControl
            m_mapControl = (IMapControl3)axMapControl1.Object;
            //disable the Save menu (since there is no file yet)
            menuSaveFile.Enabled = false;

            // 取得 MapControl 和 PageLayoutimeCheckontrol 的引用   
            pTocControl = (ITOCControl2)axTOCControl1.Object;
            pMapControl = (IMapControl3)axMapControl1.Object;
            // 创建菜单   
            pToolMenuMap = new ToolbarMenu();
            pToolMenuLayer = new ToolbarMenu();
            //添加菜单项
            pToolMenuLayer.AddItem(new ZoomToLayer(), -1, 0, true, esriCommandStyles.esriCommandStyleTextOnly);
            pToolMenuLayer.AddItem(new RemoveLayer(), -1, 0, true, esriCommandStyles.esriCommandStyleTextOnly);


            //设置菜单的hook
            pToolMenuLayer.SetHook(pMapControl);

            m_TOCControl = this.axTOCControl1.Object as ITOCControl;

            //Set buddy control
            axToolbarControl1.SetBuddyControl(axMapControl1);
            axToolbarControl2.SetBuddyControl(axMapControl1);

            this.skinEngine1.SkinFile = "Page.ssk";
        }
        

        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            esriTOCControlItem item = new esriTOCControlItem();
            IBasicMap pMap = null;
            ILayer pLayer = new FeatureLayer();
            object pOther = new object();
            object pIndex = new object();
            //获取鼠标点击信息   
            axTOCControl1.HitTest(e.x, e.y, ref item, ref pMap, ref pLayer, ref pOther, ref pIndex);
            if (e.button == 2)
            {
                if (item == esriTOCControlItem.esriTOCControlItemMap)
                {
                    pTocControl.SelectItem(pMap, null);
                }
                else
                {
                    pTocControl.SelectItem(pLayer, null);
                }
                //设置CustomProperty为layer (用于自定义的Layer命令)   
                pMapControl.CustomProperty = pLayer;
                //弹出右键菜单   
                if (item == esriTOCControlItem.esriTOCControlItemLayer)
                {
                    //动态添加OpenAttributeTable菜单项
                    pToolMenuLayer.AddItem(new OpenAttribute(pLayer, pMapControl, axMapControl1), -1, 2, true, esriCommandStyles.esriCommandStyleTextOnly);
                    pToolMenuLayer.PopupMenu(e.x, e.y, pTocControl.hWnd);
                    //移除OpenAttributeTable菜单项，以防止重复添加
                    pToolMenuLayer.Remove(2);
                }
                if (item == esriTOCControlItem.esriTOCControlItemMap)
                {
                    pToolMenuMap.PopupMenu(e.x, e.y, pTocControl.hWnd);
                }

                else
                {
                    pToolMenuLayer.PopupMenu(e.x, e.y, pTocControl.hWnd);
                }
            }

            esriTOCControlItem item1 = esriTOCControlItem.esriTOCControlItemNone;
            if (e.button == 1)
            {
                IBasicMap map = null;
                ILayer layer = null;
                object other = null;
                object index = null;

                m_TOCControl.HitTest(e.x, e.y, ref item1, ref map, ref layer, ref other, ref index);
                if (item1 == esriTOCControlItem.esriTOCControlItemLayer)
                {
                    if (layer is IAnnotationSublayer)
                    {
                        return;
                    }
                    else
                    {
                        pMoveLayer = layer;
                    }
                }
            }
        }

        private void axTOCControl1_OnMouseUp(object sender, ITOCControlEvents_OnMouseUpEvent e)
        {
            if (e.button == 1)
            {
                esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
                IBasicMap map = null;
                ILayer layer = null;
                object other = null;
                object index = null;

                m_TOCControl.HitTest(e.x, e.y, ref item, ref map, ref layer, ref other, ref index);
                IMap pMap = this.axMapControl1.ActiveView.FocusMap;
                if (item == esriTOCControlItem.esriTOCControlItemLayer || layer != null)
                {
                    if (pMoveLayer != null)
                    {
                        ILayer pTempLayer;
                        for (int i = 0; i < pMap.LayerCount; i++)
                        {
                            pTempLayer = pMap.get_Layer(i);
                            if (pTempLayer == layer)
                            {
                                toIndex = i;
                            }
                        }
                        pMap.MoveLayer(pMoveLayer, toIndex);
                        axMapControl1.ActiveView.Refresh();
                        m_TOCControl.Update();
                    }
                }
            }
        }

        private void menuOpenFile_Click(object sender, EventArgs e)
        {            
            //定义OpenFileDialog，获取并打开地图文档
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开MXD";
            openFileDialog.Filter = "MXD文件（*.mxd）|*.mxd";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strName = openFileDialog.FileName;
                if (strName != "")
                {
                    this.axMapControl1.LoadMxFile(strName);
                }
            }
            //地图文档全图显示
            this.axMapControl1.Extent = this.axMapControl1.FullExtent;
        }

        private void menuSaveFile_Click(object sender, EventArgs e)
        {
            //保存文件对话框
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存mxd";
            saveFileDialog.Filter = "mxd文件(*.mxd)|*.mxd";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strName = saveFileDialog.FileName;
                if (strName != "")
                {
                    IMxdContents pMxdC;
                    pMxdC = this.axMapControl1.Map as IMxdContents;
                    IMapDocument pMapDocument = new MapDocument();
                    pMapDocument.New(strName);
                    IActiveView pActiveView = this.axMapControl1.Map as IActiveView;
                    pMapDocument.ReplaceContents(pMxdC);
                    pMapDocument.Save(true, true);
                }
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            isExit = true;
            this.Close();
            Environment.Exit(0);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isExit = true;
            this.Close();
            Environment.Exit(0);
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {        
            FormLogin dialog = new FormLogin();
            dialog.ShowDialog();
            if (dialog.ifLogin)
            {
                MessageBox.Show("登录成功\n身份：" + dialog.role);
                menuQuery.Visible = true;
                menuAddData.Visible = true;
                menuPutInGdb.Visible = true;
                menuCheck.Visible = true;
                menuStatistic.Visible = true;
                menuLogout.Visible = true;
                if (dialog.ifManager)
                {
                    menuUserManager.Visible = true;
                }
                menuLogin.Visible = false;
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            menuLogin.Visible = true;

            menuQuery.Visible = false;
            menuAddData.Visible = false;
            menuPutInGdb.Visible = false;
            menuCheck.Visible = false;
            menuStatistic.Visible = false;
            menuLogout.Visible = false;
            menuUserManager.Visible = false;
        }

        private void menuAddShp_Click(object sender, EventArgs e)
        {
            //文件路径名称，包含文件名称和路径名称
            string strName = null;
            //文件路径
            string strFilePath = null;
            //文件名称
            string strFileName = null;

            //定义OpenFileDialog，获取并打开地图文档
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "添加Shp";
            openFileDialog.Filter = "shp文件（*.shp）|*.shp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strName = openFileDialog.FileName;
                if (strName != "")
                {
                    strFilePath = System.IO.Path.GetDirectoryName(strName);
                    strFileName = System.IO.Path.GetFileNameWithoutExtension(strName);
                    this.axMapControl1.AddShapeFile(strFilePath, strFileName);
                }
            }
            //地图文档全图显示
            this.axMapControl1.Extent = this.axMapControl1.FullExtent;
        }

        private void menuAddImg_Click(object sender, EventArgs e)
        {
            ESRI.ArcGIS.SystemUI.ICommand cmd = new ControlsAddDataCommand();
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
        }

        private void menuAddGdb_Click(object sender, EventArgs e)
        {
            ESRI.ArcGIS.SystemUI.ICommand cmd = new ControlsAddDataCommand();
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
        }

        private void menuTimeQuery_Click(object sender, EventArgs e)
        {
            FormQueryByTime dialog = new FormQueryByTime();
            dialog.ShowDialog();            
        }

        private void menuScopeQuery_Click(object sender, EventArgs e)
        {
            FormQueryByMapSheet dialog = new FormQueryByMapSheet();
            dialog.ShowDialog();
        }

        private void menuAttributeQuery_Click(object sender, EventArgs e)
        {
            FormQueryByAttribute dialog = new FormQueryByAttribute();
            dialog.CurrentMap = axMapControl1.Map;
            dialog.ShowDialog();
        }

        private void menuSpatialQuery_Click(object sender, EventArgs e)
        {
            FormQueryBySpatial dialog = new FormQueryBySpatial();
            dialog.CurrentMap = axMapControl1.Map;
            dialog.ShowDialog();
        }

        private void menuPutInGdb_Click(object sender, EventArgs e)
        {
            FormPutInGDB dialog = new FormPutInGDB();
            dialog.CurrentMap = axMapControl1.Map;
            dialog.ShowDialog();
        }

        //现势性检查
        private void menuTimeCheck_Click(object sender, EventArgs e)
        {
            IWorkspaceFactory pFileGDBWorkspaceFactory;
            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactory();
            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(rasterPath, 0);
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            IDataset pDataset = pEnumDataset.Next();
            DataTable SpatialRefTable = new DataTable();

            SpatialRefTable.Columns.Add(new DataColumn("影像名称", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("影像拍摄时间", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("时间现势性检查", typeof(string)));

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
                    if (int.Parse(strArray[1].Substring(0, 8)) < 20170000 && int.Parse(strArray[1].Substring(0, 8)) > 20120000)
                    {
                        dr["时间现势性检查"] = "√";
                    }
                    else
                    {
                        dr["时间现势性检查"] = "×";
                    }
                    SpatialRefTable.Rows.Add(dr);

                }
                pDataset = pEnumDataset.Next();
            }
            // ExportExcel(SpatialRefTable);
            //弹出显示框
            FormCheckResult timeCheck = new FormCheckResult();
            timeCheck.Text = "现势性检查";
            timeCheck.dgvCheckResult.DataSource = SpatialRefTable;
            timeCheck.dgvCheckResult.Columns[1].Width = 200;
            timeCheck.dgvCheckResult.Columns[2].Width = 300;
            timeCheck.Show();
        }
        
        private void menuCoordinateCheck_Click(object sender, EventArgs e)
        {
            IWorkspaceFactory pFileGDBWorkspaceFactory;
            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactory();
            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(rasterPath, 0);

            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            IDataset pDataset = pEnumDataset.Next();
            DataTable SpatialRefTable = new DataTable();

            SpatialRefTable.Columns.Add(new DataColumn("影像名称", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("影像坐标参考系", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("坐标参考系检查", typeof(string)));

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
                    dr["影像名称"] = rastername;
                    dr["影像坐标参考系"] = spatialref;
                    IRasterLayer pRasterLayer = new RasterLayer();
                    pRasterLayer.CreateFromDataset(pRasterDataset);
                    if (spatialref == null)
                    {
                        dr["坐标参考系检查"] = "×";
                    }
                    else
                    {
                        dr["坐标参考系检查"] = "√";
                    }
                    SpatialRefTable.Rows.Add(dr);

                }
                pDataset = pEnumDataset.Next();
            }
            // ExportExcel(SpatialRefTable);
            //弹出显示框
            FormCheckResult coordCheck = new FormCheckResult();
            coordCheck.Text = "空间参考系检查";
            coordCheck.dgvCheckResult.DataSource = SpatialRefTable;
            coordCheck.dgvCheckResult.Columns[1].Width = 200;
            coordCheck.dgvCheckResult.Columns[2].Width = 300;
            coordCheck.Show();
        }

        private void menuLittleLineCheck_Click(object sender, EventArgs e)
        {
            FormSurfaceFeatureCheck surfaceFeatureCheck = new FormSurfaceFeatureCheck();
            surfaceFeatureCheck.Text = "碎线检查";
            surfaceFeatureCheck.CurrentMap = axMapControl1.Map;
            surfaceFeatureCheck.type = 5;
            surfaceFeatureCheck.Show();
        }

        private void menuLittleAreaCheck_Click(object sender, EventArgs e)
        {
            FormSurfaceFeatureCheck surfaceFeatureCheck = new FormSurfaceFeatureCheck();
            surfaceFeatureCheck.Text = "碎面检查";
            surfaceFeatureCheck.type = 4;
            surfaceFeatureCheck.CurrentMap = axMapControl1.Map;
            surfaceFeatureCheck.Show();
        }

        private void menuAreaHollowCheck_Click(object sender, EventArgs e)
        {
            FormSurfaceFeatureCheck surfaceFeatureCheck = new FormSurfaceFeatureCheck();
            surfaceFeatureCheck.Text = "面空洞检查";
            surfaceFeatureCheck.type = 3;
            surfaceFeatureCheck.CurrentMap = axMapControl1.Map;
            surfaceFeatureCheck.Show();
        }

        private void menuAreaThornCheck_Click(object sender, EventArgs e)
        {
            FormSurfaceFeatureCheck surfaceFeatureCheck = new FormSurfaceFeatureCheck();
            surfaceFeatureCheck.Text = "面折刺检查";
            surfaceFeatureCheck.CurrentMap = axMapControl1.Map;
            surfaceFeatureCheck.type = 2;
            surfaceFeatureCheck.Show();
        }

        private void menuLineThornCheck_Click(object sender, EventArgs e)
        {
            FormSurfaceFeatureCheck surfaceFeatureCheck = new FormSurfaceFeatureCheck();
            surfaceFeatureCheck.Text = "线折刺检查";
            surfaceFeatureCheck.CurrentMap = axMapControl1.Map;
            surfaceFeatureCheck.type = 1;
            surfaceFeatureCheck.Show();
        }

        private void menuFormatCheck_Click(object sender, EventArgs e)
        {
            IWorkspaceFactory pFileGDBWorkspaceFactory;
            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactory(); //using ESRI.ArcGIS.DataSourcesGDB;

            //获取工作空间
            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(rasterPath, 0);
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();

            DataTable SpatialRefTable = new DataTable();

            SpatialRefTable.Columns.Add(new DataColumn("影像名称", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("数据类型", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("所在数据库", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("名称格式检查", typeof(string)));

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

                    DataRow dr = SpatialRefTable.NewRow();
                    dr["影像名称"] = pDataset.Name.ToString();
                    dr["数据类型"] = "File GeoDatabase Raster Dataset";
                    dr["所在数据库"] = rasterPath;
                    string rastername = pDataset.Name.ToString();
                    string[] strArray = rastername.Split('_');
                    if (strArray[0] == "GF1" && strArray[1].Length == 10)
                    {
                        dr["名称格式检查"] = "√";

                    }
                    else
                    {
                        dr["名称格式检查"] = "×";
                    }
                    SpatialRefTable.Rows.Add(dr);
                    //IRasterPyramid3 pRasPyrmid;
                    //pRasPyrmid = pRasterDataset as IRasterPyramid3;
                    //if (pRasPyrmid != null)
                    //{
                    //    if (!(pRasPyrmid.Present))
                    //    {
                    //        pRasPyrmid.Create(); //创建金字塔
                    //    }
                    //}
                    IRasterLayer pRasterLayer = new RasterLayer();
                    pRasterLayer.CreateFromDataset(pRasterDataset);
                    ILayer pLayer = pRasterLayer as ILayer;


                    //axMapControl1.AddLayer(pLayer, 0);
                }
                pDataset = pEnumDataset.Next();
            }
            // ExportExcel(SpatialRefTable);
            //弹出显示框
            FormCheckResult formatCheck = new FormCheckResult();
            formatCheck.Text = "格式一致性";
            formatCheck.dgvCheckResult.DataSource = SpatialRefTable;
            formatCheck.dgvCheckResult.Columns[1].Width = 200;
            formatCheck.dgvCheckResult.Columns[2].Width = 300;
            formatCheck.Show();
        }
                
        private void menuMapunitWholeCheck_Click(object sender, EventArgs e)
        {
            IWorkspaceFactory pFileGDBWorkspaceFactory;
            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactory(); //using ESRI.ArcGIS.DataSourcesGDB;

            //获取工作空间
            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(rasterPath, 0);
            //  AddAllDataset(pWorkspace, axMapControl1);

            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();


            DataTable SpatialRefTable = new DataTable();
            SpatialRefTable.Columns.Add(new DataColumn("未分幅影像名称", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("分幅数量", typeof(int)));
            SpatialRefTable.Columns.Add(new DataColumn("分幅影像完备性检查", typeof(string)));
            int rastercount = 0;
            string rastername = "a";
            List<string> testList = new List<string>();
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


                    testList.Add(pDataset.Name.ToString());

                }
                pDataset = pEnumDataset.Next();
            }
            testList.Sort();

            for (int i = 0; i < testList.Count; i++)
            {
                DataRow dr = SpatialRefTable.NewRow();
                if (rastername != testList[i].Substring(0, testList[i].Length - 1))
                {
                    rastername = testList[i].Substring(0, testList[i].Length - 1);
                    dr["未分幅影像名称"] = rastername;
                    dr["分幅数量"] = rastercount;
                    if (rastercount == 4)
                    {
                        dr["分幅影像完备性检查"] = "√";
                        SpatialRefTable.Rows.Add(dr);
                    }
                    else if (rastercount == 3)
                    {
                        dr["分幅影像完备性检查"] = "×";
                        SpatialRefTable.Rows.Add(dr);
                    }


                    rastercount = 1;
                }
                else
                {
                    rastercount = rastercount + 1;
                }
            }

            // ExportExcel(SpatialRefTable);
            //弹出显示框
            FormCheckResult imgIntegrityCheck = new FormCheckResult();
            imgIntegrityCheck.Text = "影像完备性检查";
            imgIntegrityCheck.dgvCheckResult.DataSource = SpatialRefTable;
            imgIntegrityCheck.dgvCheckResult.Columns[1].Width = 200;
            imgIntegrityCheck.dgvCheckResult.Columns[2].Width = 300;
            imgIntegrityCheck.Show();
        }

        private void menuFeatureWholeCheck_Click(object sender, EventArgs e)
        {
            FormFeatureWholeCheck wholeFeatureCheck = new FormFeatureWholeCheck();
            wholeFeatureCheck.CurrentMap = axMapControl1.Map;
            wholeFeatureCheck.Show();
        }

        //边界范围检查
        private void menuExtentCheck_Click(object sender, EventArgs e)
        {
            FormExtentCheck extentCheck = new FormExtentCheck();
            extentCheck.CurrentMap = axMapControl1.Map;
            extentCheck.Show();
        }

        private void menuRasterQuaCheck_Click(object sender, EventArgs e)
        {
            IWorkspaceFactory pFileGDBWorkspaceFactory;
            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactory(); //using ESRI.ArcGIS.DataSourcesGDB;


            //获取工作空间
            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(rasterPath, 0);
            //  AddAllDataset(pWorkspace, axMapControl1);

            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();

            DataTable SpatialRefTable = new DataTable();

            SpatialRefTable.Columns.Add(new DataColumn("影像名称", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("影像分辨率", typeof(string)));
            SpatialRefTable.Columns.Add(new DataColumn("影像分辨率检查", typeof(string)));

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

                    DataRow dr = SpatialRefTable.NewRow();
                    dr["影像名称"] = pDataset.Name.ToString();
                    IRasterLayer pRasterLayer = new RasterLayer();
                    pRasterLayer.CreateFromDataset(pRasterDataset);


                    IRasterProps rasterProps = (IRasterProps)pRasterLayer.Raster;
                    double dX = rasterProps.MeanCellSize().X;
                    double dY = rasterProps.MeanCellSize().Y;
                    dr["影像分辨率"] = "(" + dX.ToString() + "*" + dX.ToString() + ")";
                    //string rasterformat = pRasterDataset.Format.ToString();
                    if (dX == 20 && dY == 20)
                    {
                        dr["影像分辨率检查"] = "√";

                    }
                    else
                    {
                        dr["影像分辨率检查"] = "×";
                    }

                    SpatialRefTable.Rows.Add(dr);


                }
                pDataset = pEnumDataset.Next();
            }
            // ExportExcel(SpatialRefTable);
            //弹出显示框
            FormCheckResult quaCheck = new FormCheckResult();
            quaCheck.Text = "影像质量检查";
            quaCheck.dgvCheckResult.DataSource = SpatialRefTable;
            quaCheck.dgvCheckResult.Columns[1].Width = 200;
            quaCheck.dgvCheckResult.Columns[2].Width = 300;
            quaCheck.Show();
        }

        private void menuTopologyCheck_Click(object sender, EventArgs e)
        {
            FormTopoSelect fm1 = new FormTopoSelect();
            fm1.ShowDialog();
            txtMessage.Text = "\r\n" + "\r\n" + "   拓扑建立好后，存放在该数据集中。" + "\r\n" + "\r\n" + "\r\n" + "若已有拓扑，请先删除";

        }

        #region no use
        public ITopology Create_Topology(IFeatureWorkspace featureWorkspace, string featuredatasetName, string featureClassName, string topologyName)
        {
            try
            {
                //1.---打开拓朴所在的要素数据集，并创建拓朴
                IFeatureDataset featureDataset = featureWorkspace.OpenFeatureDataset(featuredatasetName);
                if (featureDataset != null)
                {
                    ITopologyContainer topologyContainer = (ITopologyContainer)featureDataset;
                    ITopology topology = topologyContainer.CreateTopology("topo", topologyContainer.DefaultClusterTolerance, -1, ""); //在这个地方报错
                    //2.---给拓朴加入要素集

                    IFeatureClassContainer featureclassContainer = (IFeatureClassContainer)featureDataset;
                    IFeatureClass featureClass = featureclassContainer.get_ClassByName(featureClassName);
                    topology.AddClass(featureClass, 5, 1, 1, false);
                    //3.---返回拓朴
                    return topology;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            return null;
        }

        //private void CreateTopButton_Click(object sender, EventArgs e)
        //{
        //    //打开目标数据库
        //    IWorkspace fWorkspace = open_pGDB_Workspace("e:\\Topo.mdb");
        //    IFeatureWorkspace fW = fWorkspace as IFeatureWorkspace;
        //    //启动编辑
        //    IWorkspaceEdit workspaceEdit = (IWorkspaceEdit)fWorkspace;
        //    workspaceEdit.StartEditing(true);
        //    workspaceEdit.StartEditOperation();
        //    //调用创建拓朴的方法
        //    ITopology topology = Create_Topology(fW, "HN_DS", "HN", "Polygon_Topo");
        //    //停止编辑
        //    workspaceEdit.StopEditOperation();
        //    workspaceEdit.StopEditing(true);
        //    if (topology != null)
        //    {
        //        MessageBox.Show("创建拓朴成功！");
        //    }
        //}


        //public ITopology OpenTopologyFromFeatureWorkspace(IFeatureWorkspace featureWorkspace,String featureDatasetName, String topologyName)
        //{
        //    // Open the feature dataset and cast it to ITopologyContainer.
        //    IFeatureDataset featureDataset = featureWorkspace.OpenFeatureDataset(featureDatasetName);
        //    ITopologyContainer topologyContainer = (ITopologyContainer)featureDataset;

        //    // Open the topology and return it.
        //    ITopology topology = topologyContainer.get_TopologyByName(topologyName);
        //    return topology;

        //}



        public void DisplayErrorFeaturesForRule(ITopology topology, ITopologyRule topologyRule)
        { // Given the topology and specific topology rule, return the error features for that rule.

            //// Cast to required interfaces and get the spatial reference.
            //IErrorFeatureContainer errorFeatureContainer = (IErrorFeatureContainer)topology;
            //IGeoDataset geoDataset = (IGeoDataset)topology;
            //ISpatialReference spatialReference = geoDataset.SpatialReference;

            //// Get an enumerator for the error features.
            //IEnumTopologyErrorFeature enumTopologyErrorFeature =
            //    errorFeatureContainer.get_ErrorFeatures(spatialReference, topologyRule, geoDataset.Extent, true, false);

            //// Display the origin IDs for each of the error features.
            //ITopologyErrorFeature topologyErrorFeature = null;
            //while ((topologyErrorFeature = enumTopologyErrorFeature.Next()) != null)
            //{
            //    Console.WriteLine("Origin feature OID: {0}", topologyErrorFeature.OriginOID);
            //}
        }



        public void CreateTopology()
        {

            // Open the workspace and the required datasets.
            Type factoryType = Type.GetTypeFromProgID("esriDataSourcesGDB.FileGDBWorkspaceFactory");
            IWorkspaceFactory workspaceFactory = (IWorkspaceFactory)Activator.CreateInstance(factoryType);
            IWorkspace workspace = workspaceFactory.OpenFromFile(@"C:\arcgis\ArcTutor\BuildingaGeodatabase\Montgomery.gdb", 0);
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;
            IFeatureDataset featureDataset = featureWorkspace.OpenFeatureDataset("Landbase");
            IFeatureClass blocksFC = featureWorkspace.OpenFeatureClass("Blocks");
            IFeatureClass parcelsFC = featureWorkspace.OpenFeatureClass("Parcels");


            ISchemaLock schemaLock = (ISchemaLock)featureDataset;
            // 将featureDataset设置为模式锁对象

            try
            {

                schemaLock.ChangeSchemaLock(esriSchemaLock.esriExclusiveSchemaLock);
                //模式锁设置为 独占 的打开方式


                ITopologyContainer2 topologyContainer = (ITopologyContainer2)featureDataset;
                ITopology topology = topologyContainer.CreateTopology("Landbase_Topology", topologyContainer.DefaultClusterTolerance, -1, "");
                // Create the topology.

                topology.AddClass(blocksFC, 5, 1, 1, false);
                //topology.AddClass(parcelsFC, 5, 1, 1, false);
                //添加要素集中要素到topologycontainer

                AddRuleToTopology(topology, esriTopologyRuleType.esriTRTAreaContainOnePoint, "NO point containned!", blocksFC);
                //添加拓扑规则


                // Get an envelope with the topology's extents and validate the topology.
                IGeoDataset geoDataset = (IGeoDataset)topology;
                IEnvelope envelope = geoDataset.Extent;
                //ValidateTopology(topology, envelope);    

            }
            catch (Exception comExc)
            {

                throw new Exception(String.Format("Error creating topology: ~~ Message: {1}", comExc.Message), comExc);
            }
            finally
            {
                schemaLock.ChangeSchemaLock(esriSchemaLock.esriSharedSchemaLock);
            }

        }

        public void AddRuleToTopology(ITopology topology, esriTopologyRuleType ruleType, String ruleName, IFeatureClass featureClass)
        {
            // Create a topology rule.
            ITopologyRule topologyRule = new TopologyRuleClass();
            topologyRule.TopologyRuleType = ruleType;
            topologyRule.Name = ruleName;
            topologyRule.OriginClassID = featureClass.FeatureClassID;
            topologyRule.AllOriginSubtypes = true;

            // Cast the topology to the ITopologyRuleContainer interface and add the rule.
            ITopologyRuleContainer topologyRuleContainer = (ITopologyRuleContainer)topology;
            if (topologyRuleContainer.get_CanAddRule(topologyRule))
            {
                topologyRuleContainer.AddRule(topologyRule);
            }
            else
            {
                throw new ArgumentException("Could not add specified rule to the topology.");
            }
        }


        public void DisplayTypesForEachRule(ITopology topology)
        {
            // Cast the topology to ITopologyRuleContainer and get the rule enumerator.
            ITopologyRuleContainer topologyRuleContainer = (ITopologyRuleContainer)topology;
            IEnumRule enumRule = topologyRuleContainer.Rules;

            // Iterate through each rule.
            enumRule.Reset();
            IRule rule = null;
            while ((rule = enumRule.Next()) != null)
            {
                // Cast to ITopology and display the rule type.
                ITopologyRule topologyRule = (ITopologyRule)rule;
                Console.WriteLine("Rule type: {0}", topologyRule.TopologyRuleType);
            }
        }

        public ITopologyErrorFeature GetErrorFeatureForNoOverlapRule(ITopology topology, IFeatureClass featureClass, int originFeatureOID, int destFeatureOID)
        {//获取拓扑错误的要素类

            // Cast to required interfaces and get the spatial reference.
            IErrorFeatureContainer errorFeatureContainer = (IErrorFeatureContainer)topology;
            IGeoDataset geoDataset = (IGeoDataset)topology;
            ISpatialReference spatialReference = geoDataset.SpatialReference;

            // Find the error feature and return it.
            ITopologyErrorFeature topologyErrorFeature = errorFeatureContainer.get_ErrorFeature(spatialReference, esriTopologyRuleType.esriTRTAreaNoOverlap, esriGeometryType.esriGeometryPolygon, featureClass.FeatureClassID,
                originFeatureOID, featureClass.FeatureClassID, destFeatureOID);
            //OriginFeatureOID：起始要素对象ID；destFeatureOID：目标要素对象ID
            return topologyErrorFeature;

        }
        #endregion

        #region useful

        public void DisplayErrorFeaturesForRule2(ITopology topology)
        {

            //IErrorFeatureContainer errorFeatureContainer = (IErrorFeatureContainer)topology;
            //IGeoDataset geoDataset = (IGeoDataset)topology;
            //ISpatialReference spatialReference = geoDataset.SpatialReference;
            //// 强制转换传入接口，并获取其空间参考系

            //IEnumTopologyErrorFeature enumTopologyErrorFeature = errorFeatureContainer.get_ErrorFeatures(spatialReference, topologyRule, geoDataset.Extent, true, false);
            //// 获得错误feature的枚举数


            //ITopologyErrorFeature topologyErrorFeature = null;
            //while ((topologyErrorFeature = enumTopologyErrorFeature.Next()) != null)
            //{
            //    Console.WriteLine("Origin feature OID: {0}", topologyErrorFeature.OriginOID);
            //}
            // 显示每一个错误要素的起始ID（originID）


            IGeoDataset geoDS = topology as IGeoDataset;
            IErrorFeatureContainer errorContainer = topology as IErrorFeatureContainer;
            IEnumTopologyErrorFeature eErrorFeat;
            eErrorFeat = errorContainer.get_ErrorFeaturesByRuleType(geoDS.SpatialReference, esriTopologyRuleType.esriTRTAreaContainOnePoint, null, true, false);
            ITopologyErrorFeature topoError;
            //topoError = eErrorFeat.Next();
            while ((topoError = eErrorFeat.Next()) != null)
            {
                Console.WriteLine("Origin feature OID: {0}", topoError.OriginOID);
            }
            // 显示每一个错误要素的起始ID（originID） 

        }



        public ITopology Create_Topology1()
        {
            Type factoryType = Type.GetTypeFromProgID("esriDataSourcesGDB.FileGDBWorkspaceFactory");
            IWorkspaceFactory workspaceFactory = (IWorkspaceFactory)Activator.CreateInstance(factoryType);
            IWorkspace workspace = workspaceFactory.OpenFromFile(@"F:\temp\Nautical & FME 论文\New Folder\New File Geodatabase.gdb", 0);
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;
            IFeatureDataset featureDataset = featureWorkspace.OpenFeatureDataset("q");

            //ISchemaLock schemaLock = (ISchemaLock)featureDataset;
            //schemaLock.ChangeSchemaLock(esriSchemaLock.esriSharedSchemaLock);

            IFeatureClass blocksFC = featureWorkspace.OpenFeatureClass("f11");
            IFeatureClass blocksFC2 = featureWorkspace.OpenFeatureClass("pt1");

            //IFeatureClass parcelsFC = featureWorkspace.OpenFeatureClass("Parcels");

            //IEnumDataset pEDataset;           

            //ISchemaLock schemaLock = (ISchemaLock)featureDataset;
            // 将featureDataset设置为模式锁对象



            //schemaLock.ChangeSchemaLock(esriSchemaLock.esriExclusiveSchemaLock);
            //模式锁设置为 独占 的打开方式


            ITopologyContainer topologyContainer = (ITopologyContainer)featureDataset;
            ITopology topology = topologyContainer.CreateTopology("Topology1", topologyContainer.DefaultClusterTolerance, -1, "");
            // Create the topology.

            topology.AddClass(blocksFC, 5, 1, 1, false);
            topology.AddClass(blocksFC2, 5, 1, 1, false);
            //schemaLock.ChangeSchemaLock(esriSchemaLock.esriSharedSchemaLock);
            return topology;

        }


        #endregion

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void MenuAddAllGDB_Click(object sender, EventArgs e)
        {
            IWorkspaceFactory pFileGDBWorkspaceFactory;

            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactoryClass(); //using ESRI.ArcGIS.DataSourcesGDB;

            string pFullPath1 = System.Environment.CurrentDirectory + "\\data\\JCDL.gdb";
            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(pFullPath1, 0);
            VecAddAllDataset(pWorkspace);
            Vecnode.Name = "JCDL";
            Vecnode.Text = "JCDL";
            Vecnode.Tag = "gdb";
            treeView2.Nodes.Add(Vecnode);

            string pFullPath2 = System.Environment.CurrentDirectory + "\\data\\YGYX.gdb";
            IWorkspace pWorkspace2 = pFileGDBWorkspaceFactory.OpenFromFile(pFullPath2, 0);
            RasAddAllDataset(pWorkspace2);
            Rasnode.Name = "YGYX";
            Rasnode.Text = "YGYX";
            Rasnode.Tag = "gdb";
            treeView2.Nodes.Add(Rasnode);
        }

        private void ClearAllData()
        {
            if (axMapControl1.Map != null && axMapControl1.Map.LayerCount > 0)
            {
                //新建mainMapControl中Map
                IMap dataMap = new MapClass();
                dataMap.Name = "Map";
                axMapControl1.DocumentFilename = string.Empty;
                axMapControl1.Map = dataMap;
            }
        }

        private void VecAddAllDataset(IWorkspace pWorkspace)
        {
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();

            //判断数据集是否有数据
            while (pDataset != null)
            {
                TreeNode node = new TreeNode();
                node.Name = pDataset.Name;
                node.Text = pDataset.Name;
                node.Tag = "VECdataset";
                Vecnode.Nodes.Add(node);
                if (pDataset is IFeatureDataset)  //要素数据集
                {
                    IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                    IFeatureDataset pFeatureDataset = pFeatureWorkspace.OpenFeatureDataset(pDataset.Name);
                    IEnumDataset pEnumDataset1 = pFeatureDataset.Subsets;
                    pEnumDataset1.Reset();
                    IGroupLayer pGroupLayer = new GroupLayerClass();
                    pGroupLayer.Name = pFeatureDataset.Name;
                    IDataset pDataset1 = pEnumDataset1.Next();
                    while (pDataset1 != null)
                    {
                        if (pDataset1 is IFeatureClass)  //要素类
                        {
                            IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                            pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset1.Name);

                            if (pFeatureLayer.FeatureClass != null)
                            {
                                pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;

                                CheckBox checkbox = new CheckBox();
                                checkbox.Text = pFeatureLayer.Name;
                                checkbox.Name = pFeatureLayer.Name;
                                node.Nodes.Add(checkbox.Name);
                                checkbox.Tag = "feature";

                                //pGroupLayer.Add(pFeatureLayer);
                                //mapControl.Map.AddLayer(pFeatureLayer);
                            }
                        }
                        pDataset1 = pEnumDataset1.Next();
                    }
                }
                else if (pDataset is IFeatureClass) //要素类
                {
                    IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                    IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                    pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset.Name);

                    pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;
                    CheckBox checkbox = new CheckBox();
                    checkbox.Text = pFeatureLayer.Name;
                    checkbox.Name = pFeatureLayer.Name;
                    node.Nodes.Add(checkbox.Name);
                    checkbox.Tag = "feature";
                    //mapControl.Map.AddLayer(pFeatureLayer);
                }
                pDataset = pEnumDataset.Next();
            }

            //mapControl.ActiveView.Refresh();

        }

        private void RasAddAllDataset(IWorkspace pWorkspace)
        {
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();

            //判断数据集是否有数据
            while (pDataset != null)
            {
                TreeNode node = new TreeNode();
                node.Name = pDataset.Name;
                node.Text = pDataset.Name;

                Rasnode.Nodes.Add(node);
                pDataset = pEnumDataset.Next();
                node.Tag = "raster";
            }

            //mapControl.ActiveView.Refresh();

        }

        private void treeView2_AfterCheck(object sender, TreeViewEventArgs e)
        {
            IWorkspaceFactory pFileGDBWorkspaceFactory;

            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactoryClass(); //using ESRI.ArcGIS.DataSourcesGDB;
            if (e.Node.Checked)
            {
                switch (e.Node.Tag.ToString())
                {
                    case "gdb":
                        {
                            string pFullPath1 = System.Environment.CurrentDirectory + "\\data\\" + e.Node.Name.ToString() + ".gdb";
                            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(pFullPath1, 0);
                            AddAllDataset(pWorkspace, axMapControl1);
                        }
                        break;
                    case "VECdataset":
                        {
                            string pFullPath1 = System.Environment.CurrentDirectory + "\\data\\" + e.Node.Parent.Name.ToString() + ".gdb";
                            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(pFullPath1, 0);
                            VecAddSpeDataset(pWorkspace, e.Node.Name);
                        }
                        break;
                    case "raster":
                        {
                            string pFullPath1 = System.Environment.CurrentDirectory + "\\data\\" + e.Node.Parent.Name.ToString() + ".gdb";
                            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(pFullPath1, 0);
                            RasAddSpeDataset(pWorkspace, e.Node.Name);
                        }
                        break;

                }
            }
        }

        private void AddAllDataset(IWorkspace pWorkspace, AxMapControl mapControl)
        {
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();

            //判断数据集是否有数据
            while (pDataset != null)
            {
                TreeNode node = new TreeNode();
                node.Name = pDataset.Name;
                node.Text = pDataset.Name;
                treeView1.Nodes.Add(node);
                if (pDataset is IFeatureDataset)  //要素数据集
                {
                    IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                    IFeatureDataset pFeatureDataset = pFeatureWorkspace.OpenFeatureDataset(pDataset.Name);
                    IEnumDataset pEnumDataset1 = pFeatureDataset.Subsets;
                    pEnumDataset1.Reset();
                    IGroupLayer pGroupLayer = new GroupLayerClass();
                    pGroupLayer.Name = pFeatureDataset.Name;
                    IDataset pDataset1 = pEnumDataset1.Next();
                    while (pDataset1 != null)
                    {
                        if (pDataset1 is IFeatureClass)  //要素类
                        {
                            IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                            pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset1.Name);

                            if (pFeatureLayer.FeatureClass != null)
                            {
                                pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;

                                CheckBox checkbox = new CheckBox();
                                checkbox.Text = pFeatureLayer.Name;
                                checkbox.Name = pFeatureLayer.Name;
                                node.Nodes.Add(checkbox.Name);

                                pGroupLayer.Add(pFeatureLayer);
                                mapControl.Map.AddLayer(pFeatureLayer);
                            }
                        }
                        pDataset1 = pEnumDataset1.Next();
                    }
                }
                else if (pDataset is IFeatureClass) //要素类
                {
                    IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                    IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                    pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset.Name);

                    pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;
                    mapControl.Map.AddLayer(pFeatureLayer);
                }
                else if (pDataset is IRasterDataset) //栅格数据集
                {
                    IRasterWorkspaceEx pRasterWorkspace = (IRasterWorkspaceEx)pWorkspace;
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pDataset.Name);
                    //影像金字塔判断与创建
                    IRasterPyramid3 pRasPyrmid;
                    pRasPyrmid = pRasterDataset as IRasterPyramid3;
                    if (pRasPyrmid != null)
                    {
                        if (!(pRasPyrmid.Present))
                        {
                            pRasPyrmid.Create(); //创建金字塔
                        }
                    }
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromDataset(pRasterDataset);
                    ILayer pLayer = pRasterLayer as ILayer;
                    mapControl.AddLayer(pLayer, 0);
                }
                pDataset = pEnumDataset.Next();
            }

            mapControl.ActiveView.Refresh();

        }

        private void VecAddSpeDataset(IWorkspace pWorkspace, string datasetName)
        {
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();

            //判断数据集是否有数据
            while (pDataset != null)
            {
                if (pDataset.Name == datasetName)
                {
                    if (pDataset is IFeatureDataset)  //要素数据集
                    {
                        IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                        IFeatureDataset pFeatureDataset = pFeatureWorkspace.OpenFeatureDataset(pDataset.Name);
                        IEnumDataset pEnumDataset1 = pFeatureDataset.Subsets;
                        pEnumDataset1.Reset();
                        IGroupLayer pGroupLayer = new GroupLayerClass();
                        pGroupLayer.Name = pFeatureDataset.Name;
                        IDataset pDataset1 = pEnumDataset1.Next();
                        while (pDataset1 != null)
                        {
                            if (pDataset1 is IFeatureClass)  //要素类
                            {
                                IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                                pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset1.Name);

                                if (pFeatureLayer.FeatureClass != null)
                                {
                                    pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;

                                    pGroupLayer.Add(pFeatureLayer);
                                    axMapControl1.Map.AddLayer(pFeatureLayer);
                                }
                            }
                            pDataset1 = pEnumDataset1.Next();
                        }
                    }
                    else if (pDataset is IFeatureClass) //要素类
                    {
                        IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                        IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                        pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset.Name);

                        pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;

                        axMapControl1.Map.AddLayer(pFeatureLayer);
                    }
                    axMapControl1.ActiveView.Refresh();
                    break;
                }
                else
                    pDataset = pEnumDataset.Next();
            }



        }

        private void RasAddSpeDataset(IWorkspace pWorkspace, string datasetName)
        {
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();

            //判断数据集是否有数据
            while (pDataset.Name != null)
            {
                if (pDataset.Name == datasetName)
                {
                    IRasterWorkspaceEx pRasterWorkspace = (IRasterWorkspaceEx)pWorkspace;
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(datasetName);
                    //影像金字塔判断与创建
                    IRasterPyramid3 pRasPyrmid;
                    pRasPyrmid = pRasterDataset as IRasterPyramid3;
                    if (pRasPyrmid != null)
                    {
                        if (!(pRasPyrmid.Present))
                        {
                            pRasPyrmid.Create(); //创建金字塔
                        }
                    }
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromDataset(pRasterDataset);
                    ILayer pLayer = pRasterLayer as ILayer;
                    axMapControl1.AddLayer(pLayer, 0);

                    axMapControl1.ActiveView.Refresh();
                    break;
                }


                pDataset = pEnumDataset.Next();
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            // 显示当前比例尺
            this.StatusScale.Text = " 比例尺 1:" + ((long)this.axMapControl1.MapScale).ToString();
            // 显示当前坐标
            this.StatusCoordinate.Text = " 当前坐标 X = " + e.mapX.ToString() + " Y = " + e.mapY.ToString() + " " + this.axMapControl1.MapUnits;
        }

        private void menuUserManager_Click(object sender, EventArgs e)
        {
            FormUserManager dialog = new FormUserManager();
            dialog.ShowDialog();
        }

        private void menuStatistic_Click(object sender, EventArgs e)
        {

        }
    }
}
