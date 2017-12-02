using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.DataSourcesGDB;
using System.Collections;

namespace SpatialDBMS.Classes
{
    class DBHelper
    {       
        //connect gdb
        public static IWorkspace FileGdbWorkspaceFromPath(String path, string name)
        {
            string GDBPath = path + name;

            if (!Directory.Exists(GDBPath))
            {
                MessageBox.Show("路径不存在，请选择有效路径！ ");
                return null;
            }
            else
            {
                try
                {
                    Type factoryType = Type.GetTypeFromProgID("esriDataSourcesGDB.FileGDBWorkspaceFactory");
                    IWorkspaceFactory workspaceFactory = (IWorkspaceFactory)Activator.CreateInstance(factoryType);
                    return workspaceFactory.OpenFromFile(GDBPath, 0);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("OpenFileGdbWorkspace error:" + ex.Message);
                    return null;
                }
            }
        }

        //open datasets
        public IFeatureClass GetDatasets(IWorkspace workspace, string name)
        {
            // Cast the workspace to IFeatureWorkspace and open a feature class.
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;
            return featureWorkspace.OpenFeatureClass(name);
        }

        //get fields exam. not finished
        public void DisplayDistinctFieldAliasNames(IFeatureClass featureClass)
        {
            // Get the Fields collection from the feature class.
            IFields fields = featureClass.Fields;
            IField field = null;

            // On a zero based index, iterate through the fields in the collection.
            for (int i = 0; i < fields.FieldCount; i++)
            {
                // Get the field at the given index.
                field = fields.get_Field(i);
                if (field.Name != field.AliasName)
                {
                    Console.WriteLine("{0} : {1}", field.Name, field.AliasName);
                }
            }
        }
    }
}
