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

namespace SpatialDBMS
{
    public partial class MainForm : Form
    {
        #region class private members
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

            // 取得 MapControl 和 PageLayoutControl 的引用   
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
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            // 显示当前比例尺
            this.StatusScale.Text = " 比例尺 1:" + ((long)this.axMapControl1.MapScale).ToString();
            // 显示当前坐标
            this.StatusCoordinate.Text = " 当前坐标 X = " + e.mapX.ToString() + " Y = " + e.mapY.ToString() + " " + this.axMapControl1.MapUnits;
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

        }

        private void menuScopeQuery_Click(object sender, EventArgs e)
        {

        }

        private void menuCombineQuery_Click(object sender, EventArgs e)
        {

        }

        private void menuAttributeQuery_Click(object sender, EventArgs e)
        {

        }

        private void menuSpatialQuery_Click(object sender, EventArgs e)
        {

        }

        private void menuPutInGdb_Click(object sender, EventArgs e)
        {

        }
        //现势性检查
        private void menuTimeCheck_Click(object sender, EventArgs e)
        {

        }
        //
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
    }
}
