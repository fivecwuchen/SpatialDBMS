using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Geometry;
using System.Runtime.InteropServices;
using System.IO;

namespace SpatialDBMS.Forms
{
    public partial class FormPutInGDB : Form
    {
        private IMap currentMap;    //当前MapControl控件中的Map对象
        private IFeatureLayer currentFeatureLayer;  //设置临时类变量来使用IFeatureLayer接口的当前图层对象
        private string currentFieldName;    //设置临时类变量来存储字段名称

        /// <summary>
        /// 获得当前MapControl控件中的Map对象。
        /// </summary>
        public IMap CurrentMap
        {
            set
            {
                currentMap = value;
            }
        }
        public FormPutInGDB()
        {
            InitializeComponent();
        }

        

        private void FormPutInGDB_Load(object sender, EventArgs e)
        {
            try
            {
                //将当前图层列表清空
                comboBoxLayerName.Items.Clear();

                string layerName;   //设置临时变量存储图层名称

                //对Map中的每个图层进行判断并加载名称
                for (int i = 0; i < currentMap.LayerCount; i++)
                {
                    //如果该图层为图层组类型，则分别对所包含的每个图层进行操作
                    if (currentMap.get_Layer(i) is GroupLayer)
                    {
                        //使用ICompositeLayer接口进行遍历操作
                        ICompositeLayer compositeLayer = currentMap.get_Layer(i) as ICompositeLayer;
                        for (int j = 0; j < compositeLayer.Count; j++)
                        {
                            //将图层的名称添加到comboBoxLayerName控件中
                            layerName = compositeLayer.get_Layer(j).Name;
                            comboBoxLayerName.Items.Add(layerName);
                        }
                    }
                    //如果图层不是图层组类型，则直接添加名称
                    else
                    {
                        layerName = currentMap.get_Layer(i).Name;
                        comboBoxLayerName.Items.Add(layerName);
                    }
                }

                //将comboBoxLayerName控件的默认选项设置为第一个图层的名称
                comboBoxLayerName.SelectedIndex = 0;
            }
            catch { }
        }

        private void comboBoxLayerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            for (int i = 0; i < currentMap.LayerCount; i++)
            {
                if (currentMap.get_Layer(i) is GroupLayer)
                {
                    ICompositeLayer compositeLayer = currentMap.get_Layer(i) as ICompositeLayer;
                    for (int j = 0; j < compositeLayer.Count; j++)
                    {
                        //判断图层的名称是否与comboBoxLayerName控件中选择的图层名称相同
                        if (compositeLayer.get_Layer(j).Name == comboBoxLayerName.SelectedItem.ToString())
                        {
                            //如果相同则设置为整个窗体所使用的IFeatureLayer接口对象
                            currentFeatureLayer = compositeLayer.get_Layer(j) as IFeatureLayer;
                            break;
                        }
                    }
                }
                else
                {
                    //判断图层的名称是否与comboBoxLayerName中选择的图层名称相同
                    if (currentMap.get_Layer(i).Name == comboBoxLayerName.SelectedItem.ToString())
                    {
                        //如果相同则设置为整个窗体所使用的IFeatureLayer接口对象
                        currentFeatureLayer = currentMap.get_Layer(i) as IFeatureLayer;
                        break;
                    }
                }
            }

        }

        /// <summary>  
        /// 创建数据库  
        /// </summary>  
        /// <param name="mdbFolder"></param>  
        /// <param name="mdbName"></param>  
        /// <returns></returns>  
        public IWorkspace CreateMdb(string mdbFolder, string mdbName)
        {
            
            IWorkspaceFactory pFtWsFct = new AccessWorkspaceFactory();
            IWorkspaceName workspaceName = pFtWsFct.Create(mdbFolder, mdbName, null, 0);
            IFeatureWorkspace pFeatureWorkSpace = (workspaceName as IName).Open() as IFeatureWorkspace;
            IWorkspace pWorkspace = (workspaceName as IName).Open() as IWorkspace;
            return pWorkspace;
        }

        /// <summary>  
        // 创建要素数据集  
        /// </summary>  
        /// <param name="workspace"></param>  
        /// <param name="code"></param>  
        /// <param name="datasetName"></param>  
        /// <returns></returns>  
        public IFeatureDataset CreateFeatureClass(IWorkspace workspace, int code, string datasetName)
        {
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;
            //创建一个要素集创建一个投影  
            ISpatialReferenceFactory spatialRefFactory = new SpatialReferenceEnvironmentClass();
            ISpatialReference spatialReference = spatialRefFactory.CreateProjectedCoordinateSystem(code);
            //确定是否支持高精度存储空间  
            Boolean supportsHighPrecision = false;
            IWorkspaceProperties workspaceProperties = (IWorkspaceProperties)workspace;
            IWorkspaceProperty workspaceProperty = workspaceProperties.get_Property
                (esriWorkspacePropertyGroupType.esriWorkspacePropertyGroup,
                (int)esriWorkspacePropertyType.esriWorkspacePropSupportsHighPrecisionStorage);
            if (workspaceProperty.IsSupported)
            {
                supportsHighPrecision = Convert.ToBoolean(workspaceProperty.PropertyValue);
            }
            //设置投影精度  
            IControlPrecision2 controlPrecision = (IControlPrecision2)spatialReference;
            controlPrecision.IsHighPrecision = supportsHighPrecision;
            //设置容差  
            ISpatialReferenceResolution spatialRefResolution = (ISpatialReferenceResolution)spatialReference;
            spatialRefResolution.ConstructFromHorizon();
            spatialRefResolution.SetDefaultXYResolution();
            ISpatialReferenceTolerance spatialRefTolerance = (ISpatialReferenceTolerance)spatialReference;
            spatialRefTolerance.SetDefaultXYTolerance();
            //创建要素集  
            IFeatureDataset featureDataset = featureWorkspace.CreateFeatureDataset(datasetName, spatialReference);
            return featureDataset;
        }

        /// <summary>  
        /// 获得参照投影的编码  
        /// </summary>  
        /// <param name="tFeatureLayer"></param>  
        /// <returns></returns>  
        public int getSpatialReferenceCode(IFeatureClass tFeatureClass)
        {
            IDataset dataset = tFeatureClass as IDataset;
            IGeoDataset geoDataset = (IGeoDataset)dataset;
            int code = geoDataset.SpatialReference.FactoryCode;
            return code;
        }

        /// <summary>  
        /// 将Shapefile导入到数据库  
        /// </summary>  
        /// <param name="pFeaClass"></param>  
        /// <param name="pWorkspace"></param>  
        /// <param name="tFeatureClass"></param>  
        private void importToDB(IFeatureClass pFeaClass, IWorkspace pWorkspace, IFeatureDataset tFeatureClass, string SHPName)
        {

            IFeatureClassDescription featureClassDescription = new FeatureClassDescriptionClass();
            IObjectClassDescription objectClassDescription = featureClassDescription as IObjectClassDescription;

            IFields pFields = pFeaClass.Fields;
            IFieldChecker pFieldChecker = new FieldCheckerClass();
            IEnumFieldError pEnumFieldError = null;
            IFields vFields = null;
            pFieldChecker.ValidateWorkspace = pWorkspace as IWorkspace;
            pFieldChecker.Validate(pFields, out pEnumFieldError, out vFields);
            IFeatureWorkspace featureWorkspace = pWorkspace as IFeatureWorkspace;
            IFeatureClass sdeFeatureClass = null;
            if (sdeFeatureClass == null)
            {
                sdeFeatureClass = tFeatureClass.CreateFeatureClass(SHPName, vFields,
                    objectClassDescription.InstanceCLSID, objectClassDescription.ClassExtensionCLSID,
                    pFeaClass.FeatureType, pFeaClass.ShapeFieldName, "");
                IFeatureCursor featureCursor = pFeaClass.Search(null, true);
                IFeature feature = featureCursor.NextFeature();
                IFeatureCursor sdeFeatureCursor = sdeFeatureClass.Insert(true);
                IFeatureBuffer sdeFeatureBuffer;
                while (feature != null)
                {
                    sdeFeatureBuffer = sdeFeatureClass.CreateFeatureBuffer();
                    IField shpField = new FieldClass();
                    IFields shpFields = feature.Fields;
                    for (int i = 0; i < shpFields.FieldCount; i++)
                    {
                        shpField = shpFields.get_Field(i);
                        if (shpField.Name.Contains("Area") || shpField.Name.Contains("Leng") || shpField.Name.Contains("FID")) continue;
                        int index = sdeFeatureBuffer.Fields.FindField(shpField.Name);
                        if (index != -1)
                        {
                            sdeFeatureBuffer.set_Value(index, feature.get_Value(i));
                        }
                    }
                    sdeFeatureCursor.InsertFeature(sdeFeatureBuffer);
                    sdeFeatureCursor.Flush();
                    feature = featureCursor.NextFeature();
                }
                featureCursor.Flush();
                Marshal.ReleaseComObject(feature);
                Marshal.ReleaseComObject(featureCursor);
            }
        }

        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            
            FileInfo file = new FileInfo(txtOutputPath.Text);
            string name = file.Name; // text.txt
            string path = txtOutputPath.Text.Substring(0, txtOutputPath.Text.LastIndexOf("\\") + 1);
            IWorkspace pWorkspace = CreateMdb(path, name);//参数为mdb的目录路径和数据库名  
                                                                //2.创建要素数据集  
            IFeatureClass pCphFeatureClass = currentFeatureLayer.FeatureClass;
            int code = getSpatialReferenceCode(pCphFeatureClass);//参照投影的代号  
            string datasetName = pCphFeatureClass.AliasName;//要素数据集的名称  
            IFeatureDataset pCphDataset = CreateFeatureClass(pWorkspace, code, datasetName);
            //3.导入SHP到要素数据集(  
            importToDB(pCphFeatureClass, pWorkspace, pCphDataset, pCphFeatureClass.AliasName);

            this.Close();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOutputLayer_Click(object sender, EventArgs e)
        {
            //定义输出文件路径
            SaveFileDialog saveDlg = new SaveFileDialog();
            //检查路径是否存在
            saveDlg.CheckPathExists = true;
            saveDlg.Filter = "Shapefile (*.mdb)|*.mdb";

            //读取文件输出路径到txtOutputPath
            DialogResult dr = saveDlg.ShowDialog();
            if (dr == DialogResult.OK)
                txtOutputPath.Text = saveDlg.FileName;
        }
    }
}
