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

namespace SpatialDBMS.Forms
{
    public partial class FormSurfaceFeatureCheck : Form
    {
        private IMap currentMap;//当前MapControl控件中的Map对象
        private IFeatureLayer currentFeatureLayer;//临时变量，存储IFeatureLayer接口中的当前图层对象
        //设置哈希表类型的类变量来存储图层名称和所对应矢量图层的IFeatureLayer接口对象
        private Hashtable layersHashtable;
        private int countLyrSelected;//当前选中的图层数
        public int type;//表征质量检查的类型
        public FormSurfaceFeatureCheck()
        {
            countLyrSelected = 0;
            layersHashtable = new Hashtable();
            InitializeComponent();
        }

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

        //窗体加载时执行本函数
        private void FormSurfaceFeatureCheck_Load(object sender, EventArgs e)
        {
            IFeatureLayer featureLayer; //设置临时变量存储矢量图层对象

            //将当前图层列表清空
            comLyr.Items.Clear();
            layersHashtable.Clear();
            //清空图层列表
            for (int i = 0; i < checkedListBoxLyr.Items.Count; i++)
            {
                checkedListBoxLyr.Items.Clear();
            }

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
                        //将图层的名称添加到comLyr控件中
                        layerName = compositeLayer.get_Layer(j).Name;
                        //对应的矢量要素
                        featureLayer = (IFeatureLayer)compositeLayer.get_Layer(j);
                        comLyr.Items.Add(layerName);

                        //在哈希表中添加一项，包括图层名称和图层对象
                        layersHashtable.Add(layerName, featureLayer);
                    }
                }
                //如果图层不是图层组类型，则直接添加名称
                else
                {
                    layerName = currentMap.get_Layer(i).Name;
                    featureLayer = (IFeatureLayer)currentMap.get_Layer(i);

                    comLyr.Items.Add(layerName);
                    layersHashtable.Add(layerName, featureLayer);
                }
            }

            //将comLyr控件的默认选项设置为第一个图层的名称
            comLyr.SelectedIndex = 0;


        }
        //在图层名称下拉框控件中所选择图层发生改变时触发事件，执行本函数
        private void comLyr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //将选择的图层加载在checkedListBoxLyr控件上，并默认选中

            //首选，获取选择的layer名称
            string lyrName = comLyr.SelectedItem.ToString();
            //判断该layer是否已经加载过
            Boolean ifExist = false;
            int i = 0;
            for (i = 0; i < checkedListBoxLyr.Items.Count; i++)
            {
                string lyrNameSelected = checkedListBoxLyr.GetItemText(checkedListBoxLyr.Items[i]);
                if (lyrNameSelected == lyrName)
                {
                    //置为选中状态
                    checkedListBoxLyr.SetItemCheckState(i, CheckState.Checked);
                    ifExist = true;
                    break;
                }

            }
            if (!ifExist)
            {
                //添加
                countLyrSelected += 1;
                checkedListBoxLyr.Items.Add(lyrName);
                checkedListBoxLyr.SetItemCheckState(i, CheckState.Checked);
            }
        }
        //全选所有加载的layer
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < countLyrSelected; i++)
            {
                if (checkedListBoxLyr.GetItemChecked(i))
                {
                    continue;
                }
                else
                {
                    checkedListBoxLyr.SetItemChecked(i, true);
                }

            }
        }
        //反选加载的layer
        private void btnSelectSwitch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < countLyrSelected; i++)
            {
                if (checkedListBoxLyr.GetItemChecked(i))
                {
                    checkedListBoxLyr.SetItemChecked(i, false);
                }
                else
                {
                    checkedListBoxLyr.SetItemChecked(i, true);
                }

            }
        }
        //点击确定按钮后执行
        private void btnOk_Click(object sender, EventArgs e)
        {
            //执行算法
            try
            {
                //看调用时执行的内容
                SurfaceFeatureCheck(type);
                this.Close();
            }
            catch { }
        }
        //点击取消后执行
        private void btnCancle_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }

        private void SurfaceFeatureCheck(int type)
        {
            switch (type)
            {
                case 0://线折刺检查
                    LineThornCheck();
                    break;
                case 1://面折刺检查
                    AreaThornCheck();
                    break;
                case 3://面空洞检查
                    AreaHollowCheck();
                    break;
                case 4://碎面检查
                    LittleAreaCheck();
                    break;
                case 5://碎线检查
                    LittleLineCheck();
                    break;

            }

        }
        //线折刺检查的算法
        private void LineThornCheck()
        {

        }
        //面折刺检查的算法
        private void AreaThornCheck()
        {

        }
        //面空洞检查的算法
        private void AreaHollowCheck()
        {

        }
        //碎面检查的算法
        private void LittleAreaCheck()
        {
            Hashtable result = new Hashtable();
            IFeatureClass currentFeatureClass;

            //获取各个线图层
            for (int i = 0; i < checkedListBoxLyr.Items.Count; i++)
            {
                //图层被选中
                if (checkedListBoxLyr.GetItemChecked(i))
                {

                    string lyrNameSelected = checkedListBoxLyr.GetItemText(checkedListBoxLyr.Items[i]);
                    //找到选中的图层名对应的图层
                    foreach (DictionaryEntry de in layersHashtable)
                    {
                        //如果Hash表中的某项key值是当前遍历的图层名
                        if (de.Key.ToString() == lyrNameSelected)
                        {
                            //将该项Value值付给当前矢量图层对象
                            currentFeatureLayer = de.Value as IFeatureLayer;

                            currentFeatureClass = currentFeatureLayer.FeatureClass;

                            IFeatureCursor pFeatureCursor = currentFeatureClass.Search(null, false);
                            IFeature pFeature = pFeatureCursor.NextFeature();
                            int count = 0;
                            while (pFeature != null)
                            {
                                if (pFeature.Shape.GeometryType == esriGeometryType.esriGeometryPolygon)
                                {
                                    IArea pArea = pFeature.Shape as IArea;
                                    double dArea = pArea.Area;

                                    if (dArea < 1)
                                    {
                                        count++;
                                    }
                                }
                                else
                                {
                                    //MessageBox.Show(lyrNameSelected + "图层不是面状图层!\n");
                                    count = -1;
                                    
                                }
                                pFeature = pFeatureCursor.NextFeature();
                            }
                            result.Add(lyrNameSelected, count);
                            Marshal.ReleaseComObject(pFeatureCursor);

                        }
                    }
                }
            }
         
            //展示检查结果
            string strResult = "";
            foreach (DictionaryEntry de in result)
            {
                //如果Hash表中的某项key值是当前遍历的图层名
                int count = Convert.ToInt32(de.Value);
                if(count>=0)
                {
                    strResult += de.Key.ToString() + ":" + count + "个碎面\n";
                }else
                {
                    strResult += de.Key.ToString() + ":该图层不是面图层\n";
                }
                

            }
            MessageBox.Show(strResult);
        }

        //碎线检查的算法
        private void LittleLineCheck()
        {
            Hashtable result = new Hashtable();     
            IFeatureClass currentFeatureClass;

            //获取各个线图层
            for (int i = 0; i < checkedListBoxLyr.Items.Count; i++)
            {
                //图层被选中
                if (checkedListBoxLyr.GetItemChecked(i))
                {
                    
                    string lyrNameSelected = checkedListBoxLyr.GetItemText(checkedListBoxLyr.Items[i]);
                    //找到选中的图层名对应的图层
                    foreach(DictionaryEntry de in layersHashtable)
                    {
                        //如果Hash表中的某项key值是当前遍历的图层名
                        if(de.Key.ToString()==lyrNameSelected)
                        {
                            //将该项Value值付给当前矢量图层对象
                            currentFeatureLayer = de.Value as IFeatureLayer;
                            
                            currentFeatureClass = currentFeatureLayer.FeatureClass;
                            IFields pfields = currentFeatureClass.Fields;
                            int fieldIndex = pfields.FindFieldByAliasName("Shape_Length");

                            IFeatureCursor pFeatureCursor = currentFeatureClass.Search(null, false);
                            IFeature pFeature = pFeatureCursor.NextFeature();
                            int count = 0;
                            while(pFeature!=null)
                            {
                                
                                double len = Convert.ToDouble(pFeature.get_Value(fieldIndex));
                                if (len < 1)
                                {
                                    count++;
                                }

                                pFeature = pFeatureCursor.NextFeature();
                            }
                            result.Add(lyrNameSelected, count);
                            Marshal.ReleaseComObject(pFeatureCursor);

                        }
                    }              
                }

            }
            //展示检查结果
            string strResult = "";
            foreach (DictionaryEntry de in result)
            {
                //如果Hash表中的某项key值是当前遍历的图层名
                strResult += de.Key.ToString() + ":" + de.Value + "条碎线\n";
                
            }
            MessageBox.Show(strResult);

        }
    }
}
