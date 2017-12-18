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
using System.IO;
using ESRI.ArcGIS.Geodatabase;

namespace SpatialDBMS.Forms
{
    public partial class FormFeatureWholeCheck : Form
    {
        //定义类变量
        private IMap currentMap;//当前MapControl控件中的Map对象
        private IFeatureLayer currentFeatureLayer;//临时变量，存储IFeatureLayer接口中的当前图层对象
        public IMap CurrentMap
        {
            set
            {
                currentMap = value;
            }
        }
        public FormFeatureWholeCheck()
        {
            InitializeComponent();
        }

        private void FormFeatureWholeCheck_Load(object sender, EventArgs e)
        {
            if (currentMap == null)
            {
                MessageBox.Show("请加载图层或打开MXD文档");
            }
            //将当前图层列表清空
            comLyr.Items.Clear();

            string layerName;   //设置临时变量存储图层名称
            IFeatureLayer featureLayer; //设置临时变量存储矢量图层对象
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


                    }
                }
                //如果图层不是图层组类型，则直接添加名称
                else
                {
                    layerName = currentMap.get_Layer(i).Name;
                    featureLayer = (IFeatureLayer)currentMap.get_Layer(i);

                    comLyr.Items.Add(layerName);

                }
            }
            //将comLyr控件的默认选项设置为第一个图层的名称
            comLyr.SelectedIndex = 0;
        }
        //点击加载元数据
        private void btnLoadMetaData_Click(object sender, EventArgs e)
        {

        }
        //点击确定，计算要素个数
        private void btnOk_Click(object sender, EventArgs e)
        {

        }
        //提交检查信息
        private void btnCommit_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            string lyrName = comLyr.SelectedItem.ToString();

            //遍历找图层对象
            for (int i = 0; i < currentMap.LayerCount; i++)
            {
                if (currentMap.get_Layer(i) is GroupLayer)
                {
                    ICompositeLayer compositeLayer = currentMap.get_Layer(i) as ICompositeLayer;
                    for (int j = 0; j < compositeLayer.Count; j++)
                    {
                        //判断图层的名称是否与comboBoxLayerName控件中选择的图层名称相同
                        if (compositeLayer.get_Layer(j).Name == lyrName)
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
                    if (currentMap.get_Layer(i).Name == lyrName)
                    {
                        //如果相同则设置为整个窗体所使用的IFeatureLayer接口对象
                        currentFeatureLayer = currentMap.get_Layer(i) as IFeatureLayer;
                        break;
                    }
                }
            }

            IFeatureClass pFeatureClass = currentFeatureLayer.FeatureClass;
            int feaCount = pFeatureClass.FeatureCount(null);
            textFeatureNum.Text = feaCount + "";
        }

        private void btnLoadMetaData_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";//对话框的初始目录
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件|*.*";//要在对话框中显示的文件筛选器
            openFileDialog.RestoreDirectory = true;//控制对话框在关闭之前是否恢复当前目录
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName.ToString();//文件完整路径
                string metaInfo = File.ReadAllText(path);

                textMeta.Text = metaInfo;
            }
        }

        private void btnCommit_Click_1(object sender, EventArgs e)
        {
            string result = "";
            if (radioFit.Checked)
            {
                result = "您检查的结果为：\n\t相符，不存在要素多余或缺失";
            }
            if (radioExcess.Checked)
            {
                result = "您检查的结果为：\n\t要素多余！";
            }
            if (radioLack.Checked)
            {
                result = "您检查的结果为：\n\t要素缺失！";
            }

            MessageBox.Show(result);
        }

        private void FormFeatureWholeCheck_Load_1(object sender, EventArgs e)
        {
            if (currentMap == null)
            {
                MessageBox.Show("请加载图层或打开MXD文档");
            }
            //将当前图层列表清空
            comLyr.Items.Clear();

            string layerName;   //设置临时变量存储图层名称
            IFeatureLayer featureLayer; //设置临时变量存储矢量图层对象
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


                    }
                }
                //如果图层不是图层组类型，则直接添加名称
                else
                {
                    layerName = currentMap.get_Layer(i).Name;
                    featureLayer = (IFeatureLayer)currentMap.get_Layer(i);

                    comLyr.Items.Add(layerName);

                }
            }
            //将comLyr控件的默认选项设置为第一个图层的名称
            comLyr.SelectedIndex = 0;
        }
    }
}
