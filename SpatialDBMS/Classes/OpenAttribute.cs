using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;

using SpatialDBMS.Forms;

namespace SpatialDBMS.Classes
{
    /// <summary>
    /// Summary description for OpenAttribute.
    /// </summary>
    [Guid("794097e2-e9be-496f-9149-880d3c45f954")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("CCAGIS.OpenAttribute")]
    public sealed class OpenAttribute : BaseCommand
    {
        #region COM Registration Function(s)
        [ComRegisterFunction()]
        [ComVisible(false)]
        static void RegisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryRegistration(registerType);

            //
            // TODO: Add any COM registration code here
            //
        }

        [ComUnregisterFunction()]
        [ComVisible(false)]
        static void UnregisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryUnregistration(registerType);

            //
            // TODO: Add any COM unregistration code here
            //
        }

        #region ArcGIS Component Category Registrar generated code
        /// <summary>
        /// Required method for ArcGIS Component Category registration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryRegistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            ControlsCommands.Register(regKey);

        }
        /// <summary>
        /// Required method for ArcGIS Component Category unregistration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryUnregistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            ControlsCommands.Unregister(regKey);

        }

        #endregion
        #endregion

        private ILayer m_pLayer;
        private IHookHelper m_hookHelper;
        IMapControl3 m_mapControl;
        AxMapControl _MapControl;


        public OpenAttribute(ILayer pLayer, IMapControl3 pMapCtrl, AxMapControl pMapControl)
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = ""; //localizable text
            base.m_caption = "查看属性表";  //localizable text
            base.m_message = "打开属性表";  //localizable text 
            base.m_toolTip = "打开属性表";  //localizable text 
            base.m_name = "打开属性表";   //unique id, non-localizable (e.g. "MyCategory_MyCommand")
            m_pLayer = pLayer;
            m_mapControl = (IMapControl3)pMapCtrl.Object;
            _MapControl = pMapControl;
            try
            {
                //
                // TODO: change bitmap name if necessary
                //
                string bitmapResourceName = GetType().Name + ".bmp";
                base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
            }
        }

        #region Overridden Class Methods


        public override void OnCreate(object hook)
        {
            if (hook == null)
                return;

            if (m_hookHelper == null)
                m_hookHelper = new HookHelper();

            m_hookHelper.Hook = hook;

            // TODO:  Add other initialization code
        }


        public override void OnClick()
        {
            // TODO: Add OpenAttribute.OnClick implementation


            FormAttribute attributeTable = new FormAttribute(m_mapControl, _MapControl);
            attributeTable.CreateAttributeTable(m_pLayer);
            attributeTable.ShowDialog();
        }

        #endregion
    }
}
