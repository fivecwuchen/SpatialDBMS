using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.DataSourcesGDB;
using System.Windows.Forms;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace SpatialDBMS.Classes
{
    public class Topology
    {

        private string DS_Name = null;
        private string[] fc_name;
        private string file_Name;
        private string[] selectedindex;

        public string[] SelectedIndex
        {
            set { selectedindex = value; }
            get { return selectedindex; }
        }
        public void get_SelectedIndex(string[] Indices)
        {
            selectedindex = Indices;
        }
        public string DS_FullName
        {
            set { DS_Name = value; }
            get { return DS_Name; }
        }
        public string[] FC_Name
        {
            set { fc_name = value; }
            get { return fc_name; }
        }
        public string File_Name
        {
            set { file_Name = value; }
            get { return file_Name; }

        }

        public string openPGDB()
        {
            OpenFileDialog opfd1 = new OpenFileDialog();
            opfd1.Filter = "AGDB(*.mdb)|*.mdb|AllFiles(*.*)|*.*";
            opfd1.Multiselect = false;
            opfd1.InitialDirectory = @"F:\\course\\SDBMS\\SpatialDBMS\\bin\\Debug\\Data";
            DialogResult DiaRes = opfd1.ShowDialog();
            file_Name = opfd1.FileName;
            if (DiaRes != DialogResult.OK)
                return null;
            else

                return opfd1.FileName;
        }
        public string openFGDB()
        {
            FolderBrowserDialog openfolder = new FolderBrowserDialog();
            DialogResult DiaRes = openfolder.ShowDialog();
            file_Name = openfolder.SelectedPath;
            if (DiaRes != DialogResult.OK)
                return null;
            else
                return openfolder.SelectedPath;

        }
        public IWorkspace get_FWorkSp()
        {
            IWorkspaceFactory pWorkSpaceFactory = new FileGDBWorkspaceFactory();
            string tempFP = openFGDB();
            if (tempFP != null)
            {
                IWorkspace pWorkSpace = pWorkSpaceFactory.OpenFromFile(tempFP, 0);
                //IEnumDataset pEDataset =pWorkSpace. get_Datasets(esriDatasetType.esriDTAny);
                //IDataset pDataset = pEDataset.Next();
                return pWorkSpace;
            }
            else
                return null;
        }
        public IWorkspace get_PWorkSp()
        {

            IWorkspaceFactory pWorkSpaceFactory = new AccessWorkspaceFactory();
            string tempfilePath;
            tempfilePath = openPGDB();
            if (tempfilePath != null)
            {
                IWorkspace pWorkSpace = pWorkSpaceFactory.OpenFromFile(tempfilePath, 0);
                //IEnumDataset pEDataset = pWorkSpace.get_Datasets(esriDatasetType.esriDTAny);
                //IDataset pDataset = pEDataset.Next();
                return pWorkSpace;
            }
            else
                return null;
        }
        public IFeatureClassContainer get_FCContainer(IWorkspace myWSp)
        {
            IEnumDataset myEDS = myWSp.get_Datasets(esriDatasetType.esriDTFeatureDataset);
            IDataset myDS = myEDS.Next();
            if (myDS != null)
            {
                DS_Name = myDS.Name;
                IFeatureDataset myFDS = myDS as IFeatureDataset;

                //IWorkspace myWSp = DS as IWorkspace;

                IFeatureClassContainer myFCContainer = myFDS as IFeatureClassContainer;
                return myFCContainer;
            }
            else
            {
                MessageBox.Show("null featuredataset in this GeoDB!");
                return null;
            }

        }

        //topology code
        public ITopology create_topology(IWorkspace myWSp, string[] FCIndex, string TopologyName)
        {
            IEnumDataset myEDS = myWSp.get_Datasets(esriDatasetType.esriDTFeatureDataset);
            IDataset myDS = myEDS.Next();
            if (myDS != null)
            {
                DS_Name = myDS.Name;
                IFeatureDataset myFDS = myDS as IFeatureDataset;

                //IWorkspace myWSp = DS as IWorkspace;

                IFeatureClassContainer myFCContainer = myFDS as IFeatureClassContainer;
                //要素类容器
                ITopologyContainer myTopologyContainer = myFDS as ITopologyContainer;
                ITopology myTopology = myTopologyContainer.CreateTopology(TopologyName, myTopologyContainer.DefaultClusterTolerance, -1, "");
                int count = 0;
                while (count < FCIndex.Length)
                {
                    myTopology.AddClass(myFCContainer.get_Class(int.Parse(FCIndex[count])), 5, 1, 1, false);
                    count++;
                }
                return myTopology;
            }
            else
            {
                MessageBox.Show("Error,your Dataset is not a standar DataSet which can be uesed to created topology!");
                return null;
            }


        }
        public void AddRuleToTopology1(ITopology topology, esriTopologyRuleType ruleType, String ruleName, IFeatureClass featureClass)
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
        public void AddRuleToTopology2(ITopology topology, esriTopologyRuleType ruleType, String ruleName, IFeatureClass originClass, int originSubtype, IFeatureClass destinationClass, int destinationSubtype)
        {
            // Create a topology rule.
            ITopologyRule topologyRule = new TopologyRuleClass();
            topologyRule.TopologyRuleType = ruleType;
            topologyRule.Name = ruleName;
            topologyRule.OriginClassID = originClass.FeatureClassID;
            topologyRule.AllOriginSubtypes = true;
            //topologyRule.OriginSubtype = originSubtype;
            topologyRule.DestinationClassID = destinationClass.FeatureClassID;
            topologyRule.AllDestinationSubtypes = true;
            //topologyRule.DestinationSubtype = destinationSubtype;

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
        public void ValidateTopology(ITopology topology, IEnvelope envelope)
        {
            // Get the dirty area within the provided envelope.
            IPolygon locationPolygon = new PolygonClass();
            ISegmentCollection segmentCollection = (ISegmentCollection)locationPolygon;
            segmentCollection.SetRectangle(envelope);
            IPolygon polygon = topology.get_DirtyArea(locationPolygon);

            // If a dirty area exists, validate the topology.
            if (!polygon.IsEmpty)
            {
                // Define the area to validate and validate the topology.
                IEnvelope areaToValidate = polygon.Envelope;
                IEnvelope areaValidated = topology.ValidateTopology(areaToValidate);
            }
        }



        #region no use
        //public void DisplayErrorFeaturesForRule(ITopology mytopology, esriTopologyRuleType TopologyRuleType)
        //{
        //    IGeoDataset mygeoDS = mytopology as IGeoDataset;
        //    IErrorFeatureContainer myErrorFeatureContainer = mytopology as IErrorFeatureContainer;
        //    IEnumTopologyErrorFeature myEnumErrorFeature;
        //    myEnumErrorFeature = myErrorFeatureContainer.get_ErrorFeaturesByRuleType(mygeoDS.SpatialReference, TopologyRuleType, null, true, false);
        //}
        public string[] get_FCName2(IWorkspace myWorkSpace)
        {//返回DS中的要素名供用户选择

            string[] mystr;
            StringBuilder mySb = new StringBuilder();
            IEnumDataset myEDS = myWorkSpace.get_Datasets(esriDatasetType.esriDTAny);
            IDataset myDS = myEDS.Next();
            DS_Name = myDS.Name;
            while (myDS != null)
            {
                if (myDS.Type == esriDatasetType.esriDTFeatureClass)
                {
                    mySb.Append(myDS.Name + ',');
                    myDS = myEDS.Next();
                }
                else if (myDS.Type == esriDatasetType.esriDTFeatureDataset)
                {
                    IEnumDataset SubmyEDS = myDS.Subsets;
                    IDataset SubmyDS = SubmyEDS.Next();
                    while (SubmyDS != null)
                    {
                        mySb.Append(SubmyDS.Name + ',');
                        SubmyDS = SubmyEDS.Next();
                    }
                    myDS = SubmyDS;
                }
                else
                {
                    MessageBox.Show("Error,there is no standar FCDS in your GeoDB!");
                    break;
                }
            }
            string tempstr = mySb.ToString().Remove(mySb.ToString().Length - 1);
            int count = mySb.ToString().Length;
            mystr = tempstr.Split(',');
            fc_name = mystr;
            return mystr;
        }
        public IFeatureClassContainer get_FCName(IWorkspace myWSp)
        {
            IEnumDataset myEDS = myWSp.get_Datasets(esriDatasetType.esriDTFeatureDataset);
            IDataset myDS = myEDS.Next();
            IFeatureWorkspace myFWSp = myWSp as IFeatureWorkspace;
            if (myDS != null)
            {
                IFeatureDataset myFDS = myDS as IFeatureDataset;
                IFeatureClassContainer myFCContainer = myFDS as IFeatureClassContainer;
                return myFCContainer;
            }
            else
                return null;
        }
        #endregion
    }
}
