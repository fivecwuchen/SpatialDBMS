namespace SpatialDBMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("2015年长沙市影像");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("2010年长沙市影像");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("2005年长沙市影像");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("长沙市遥感影像", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("2015长沙市土地覆盖图");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("2010长沙市土地覆盖图");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("2005长沙市土地覆盖图");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("长沙市土地覆盖图", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("长沙市行政区矢量图");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("2015长沙市建成区");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("2010长沙市建成区");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("2005长沙市建成区");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("长沙市建成区", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("长沙市历年统计数据");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.w = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusScale = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddShp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddImg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddGdb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimeQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScopeQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCombineQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttributeQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpatialQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPutInGdb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimeCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCoordinateCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTopologyCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLineIntersectCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLineCloseCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAreaCloseCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncludeAnaCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSurfaceCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLineThornCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAreaThornCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAreaHollowCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLittleAreaCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLittleLineCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWholeCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMapunitWholeCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFeatureWholeCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPosQuaCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExtentCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRasterQuaCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserManager = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axToolbarControl2 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.SuspendLayout();
            this.w.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1031, 572);
            this.splitContainer2.SplitterDistance = 148;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(148, 572);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView2);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(140, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "资源列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.CheckBoxes = true;
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(3, 3);
            this.treeView2.Name = "treeView2";
            treeNode15.Name = "csimage2015";
            treeNode15.Text = "2015年长沙市影像";
            treeNode16.Name = "csimage2010";
            treeNode16.Text = "2010年长沙市影像";
            treeNode17.Name = "csimage2005";
            treeNode17.Text = "2005年长沙市影像";
            treeNode18.Name = "csimage";
            treeNode18.Text = "长沙市遥感影像";
            treeNode19.Name = "cslanduse2015";
            treeNode19.Text = "2015长沙市土地覆盖图";
            treeNode20.Name = "cslanduse2010";
            treeNode20.Text = "2010长沙市土地覆盖图";
            treeNode21.Name = "cslanduse2005";
            treeNode21.Text = "2005长沙市土地覆盖图";
            treeNode22.Name = "cslanduse";
            treeNode22.Text = "长沙市土地覆盖图";
            treeNode23.Name = "csadmin";
            treeNode23.Text = "长沙市行政区矢量图";
            treeNode24.Name = "csbuild2015";
            treeNode24.Text = "2015长沙市建成区";
            treeNode25.Name = "csbuild2010";
            treeNode25.Text = "2010长沙市建成区";
            treeNode26.Name = "csbuild2005";
            treeNode26.Text = "2005长沙市建成区";
            treeNode27.Name = "csbuild";
            treeNode27.Text = "长沙市建成区";
            treeNode28.Name = "csstasticinfo";
            treeNode28.Text = "长沙市历年统计数据";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode22,
            treeNode23,
            treeNode27,
            treeNode28});
            this.treeView2.Size = new System.Drawing.Size(134, 540);
            this.treeView2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(134, 540);
            this.treeView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axTOCControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(140, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图层列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(3, 3);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(134, 540);
            this.axTOCControl1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControl2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.textBox1);
            this.splitContainer3.Size = new System.Drawing.Size(879, 572);
            this.splitContainer3.SplitterDistance = 707;
            this.splitContainer3.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(707, 572);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(699, 546);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "地图视图";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.axLicenseControl1);
            this.splitContainer4.Panel1.Controls.Add(this.axMapControl1);
            this.splitContainer4.Panel2Collapsed = true;
            this.splitContainer4.Panel2MinSize = 0;
            this.splitContainer4.Size = new System.Drawing.Size(693, 540);
            this.splitContainer4.SplitterDistance = 298;
            this.splitContainer4.TabIndex = 6;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(612, 3);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 3;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(693, 540);
            this.axMapControl1.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(699, 546);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "其他视图";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.dgvStatistic);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(693, 540);
            this.splitContainer5.SplitterDistance = 270;
            this.splitContainer5.TabIndex = 1;
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistic.Location = new System.Drawing.Point(0, 0);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.RowTemplate.Height = 23;
            this.dgvStatistic.Size = new System.Drawing.Size(693, 270);
            this.dgvStatistic.TabIndex = 0;
            this.dgvStatistic.Visible = false;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Panel2Collapsed = true;
            this.splitContainer6.Size = new System.Drawing.Size(693, 266);
            this.splitContainer6.SplitterDistance = 324;
            this.splitContainer6.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 572);
            this.textBox1.TabIndex = 0;
            // 
            // w
            // 
            this.w.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusScale,
            this.StatusCoordinate});
            this.w.Location = new System.Drawing.Point(0, 677);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(1031, 22);
            this.w.TabIndex = 7;
            this.w.Text = "                                                      ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(916, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "                                            ";
            // 
            // StatusScale
            // 
            this.StatusScale.Name = "StatusScale";
            this.StatusScale.Size = new System.Drawing.Size(44, 17);
            this.StatusScale.Text = "比例尺";
            // 
            // StatusCoordinate
            // 
            this.StatusCoordinate.Name = "StatusCoordinate";
            this.StatusCoordinate.Size = new System.Drawing.Size(56, 17);
            this.StatusCoordinate.Text = "当前坐标";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1031, 677);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer8);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.axToolbarControl2);
            this.splitContainer7.Size = new System.Drawing.Size(1031, 101);
            this.splitContainer7.SplitterDistance = 69;
            this.splitContainer7.TabIndex = 2;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.axToolbarControl1);
            this.splitContainer8.Size = new System.Drawing.Size(1031, 69);
            this.splitContainer8.SplitterDistance = 33;
            this.splitContainer8.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuLogin,
            this.menuAddData,
            this.menuQuery,
            this.menuPutInGdb,
            this.menuCheck,
            this.menuStatistic,
            this.menuUserManager,
            this.menuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.SystemColors.Control;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenFile,
            this.menuSaveFile,
            this.menuSeparator,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(44, 29);
            this.menuFile.Text = "文件";
            // 
            // menuOpenFile
            // 
            this.menuOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenFile.Image")));
            this.menuOpenFile.ImageTransparentColor = System.Drawing.Color.White;
            this.menuOpenFile.Name = "menuOpenFile";
            this.menuOpenFile.Size = new System.Drawing.Size(100, 22);
            this.menuOpenFile.Text = "打开";
            this.menuOpenFile.Click += new System.EventHandler(this.menuOpenFile_Click);
            // 
            // menuSaveFile
            // 
            this.menuSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveFile.Image")));
            this.menuSaveFile.ImageTransparentColor = System.Drawing.Color.White;
            this.menuSaveFile.Name = "menuSaveFile";
            this.menuSaveFile.Size = new System.Drawing.Size(100, 22);
            this.menuSaveFile.Text = "保存";
            this.menuSaveFile.Click += new System.EventHandler(this.menuSaveFile_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(97, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(100, 22);
            this.menuExit.Text = "退出";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(44, 29);
            this.menuLogin.Text = "登录";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuAddData
            // 
            this.menuAddData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddShp,
            this.menuAddImg,
            this.menuAddGdb});
            this.menuAddData.Name = "menuAddData";
            this.menuAddData.Size = new System.Drawing.Size(44, 29);
            this.menuAddData.Text = "导入";
            this.menuAddData.Visible = false;
            // 
            // menuAddShp
            // 
            this.menuAddShp.Name = "menuAddShp";
            this.menuAddShp.Size = new System.Drawing.Size(148, 22);
            this.menuAddShp.Text = "导入shp数据";
            this.menuAddShp.Click += new System.EventHandler(this.menuAddShp_Click);
            // 
            // menuAddImg
            // 
            this.menuAddImg.Name = "menuAddImg";
            this.menuAddImg.Size = new System.Drawing.Size(148, 22);
            this.menuAddImg.Text = "导入影像数据";
            this.menuAddImg.Click += new System.EventHandler(this.menuAddImg_Click);
            // 
            // menuAddGdb
            // 
            this.menuAddGdb.Name = "menuAddGdb";
            this.menuAddGdb.Size = new System.Drawing.Size(148, 22);
            this.menuAddGdb.Text = "导入gdb数据";
            this.menuAddGdb.Click += new System.EventHandler(this.menuAddGdb_Click);
            // 
            // menuQuery
            // 
            this.menuQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTimeQuery,
            this.menuScopeQuery,
            this.menuCombineQuery,
            this.menuAttributeQuery,
            this.menuSpatialQuery});
            this.menuQuery.Name = "menuQuery";
            this.menuQuery.Size = new System.Drawing.Size(44, 29);
            this.menuQuery.Text = "查询";
            this.menuQuery.Visible = false;
            // 
            // menuTimeQuery
            // 
            this.menuTimeQuery.Name = "menuTimeQuery";
            this.menuTimeQuery.Size = new System.Drawing.Size(124, 22);
            this.menuTimeQuery.Text = "时间查询";
            this.menuTimeQuery.Click += new System.EventHandler(this.menuTimeQuery_Click);
            // 
            // menuScopeQuery
            // 
            this.menuScopeQuery.Name = "menuScopeQuery";
            this.menuScopeQuery.Size = new System.Drawing.Size(124, 22);
            this.menuScopeQuery.Text = "图幅查询";
            this.menuScopeQuery.Click += new System.EventHandler(this.menuScopeQuery_Click);
            // 
            // menuCombineQuery
            // 
            this.menuCombineQuery.Name = "menuCombineQuery";
            this.menuCombineQuery.Size = new System.Drawing.Size(124, 22);
            this.menuCombineQuery.Text = "联合查询";
            this.menuCombineQuery.Click += new System.EventHandler(this.menuCombineQuery_Click);
            // 
            // menuAttributeQuery
            // 
            this.menuAttributeQuery.Name = "menuAttributeQuery";
            this.menuAttributeQuery.Size = new System.Drawing.Size(124, 22);
            this.menuAttributeQuery.Text = "属性查询";
            this.menuAttributeQuery.Click += new System.EventHandler(this.menuAttributeQuery_Click);
            // 
            // menuSpatialQuery
            // 
            this.menuSpatialQuery.Name = "menuSpatialQuery";
            this.menuSpatialQuery.Size = new System.Drawing.Size(124, 22);
            this.menuSpatialQuery.Text = "空间查询";
            this.menuSpatialQuery.Click += new System.EventHandler(this.menuSpatialQuery_Click);
            // 
            // menuPutInGdb
            // 
            this.menuPutInGdb.Name = "menuPutInGdb";
            this.menuPutInGdb.Size = new System.Drawing.Size(44, 29);
            this.menuPutInGdb.Text = "入库";
            this.menuPutInGdb.Visible = false;
            this.menuPutInGdb.Click += new System.EventHandler(this.menuPutInGdb_Click);
            // 
            // menuCheck
            // 
            this.menuCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTimeCheck,
            this.menuCoordinateCheck,
            this.menuTopologyCheck,
            this.menuSurfaceCheck,
            this.menuFormatCheck,
            this.menuWholeCheck,
            this.menuPosQuaCheck,
            this.menuRasterQuaCheck});
            this.menuCheck.Name = "menuCheck";
            this.menuCheck.Size = new System.Drawing.Size(68, 29);
            this.menuCheck.Text = "质量控制";
            this.menuCheck.Visible = false;
            // 
            // menuTimeCheck
            // 
            this.menuTimeCheck.Name = "menuTimeCheck";
            this.menuTimeCheck.Size = new System.Drawing.Size(160, 22);
            this.menuTimeCheck.Text = "现势性检查";
            this.menuTimeCheck.Click += new System.EventHandler(this.menuTimeCheck_Click);
            // 
            // menuCoordinateCheck
            // 
            this.menuCoordinateCheck.Name = "menuCoordinateCheck";
            this.menuCoordinateCheck.Size = new System.Drawing.Size(160, 22);
            this.menuCoordinateCheck.Text = "坐标系检查";
            // 
            // menuTopologyCheck
            // 
            this.menuTopologyCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLineIntersectCheck,
            this.menuLineCloseCheck,
            this.menuAreaCloseCheck,
            this.menuIncludeAnaCheck});
            this.menuTopologyCheck.Name = "menuTopologyCheck";
            this.menuTopologyCheck.Size = new System.Drawing.Size(160, 22);
            this.menuTopologyCheck.Text = "拓扑检查";
            // 
            // menuLineIntersectCheck
            // 
            this.menuLineIntersectCheck.Name = "menuLineIntersectCheck";
            this.menuLineIntersectCheck.Size = new System.Drawing.Size(160, 22);
            this.menuLineIntersectCheck.Text = "线要素相接检查";
            // 
            // menuLineCloseCheck
            // 
            this.menuLineCloseCheck.Name = "menuLineCloseCheck";
            this.menuLineCloseCheck.Size = new System.Drawing.Size(160, 22);
            this.menuLineCloseCheck.Text = "线闭合检查";
            // 
            // menuAreaCloseCheck
            // 
            this.menuAreaCloseCheck.Name = "menuAreaCloseCheck";
            this.menuAreaCloseCheck.Size = new System.Drawing.Size(160, 22);
            this.menuAreaCloseCheck.Text = "面闭合检查";
            // 
            // menuIncludeAnaCheck
            // 
            this.menuIncludeAnaCheck.Name = "menuIncludeAnaCheck";
            this.menuIncludeAnaCheck.Size = new System.Drawing.Size(160, 22);
            this.menuIncludeAnaCheck.Text = "包含检查";
            // 
            // menuSurfaceCheck
            // 
            this.menuSurfaceCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLineThornCheck,
            this.menuAreaThornCheck,
            this.menuAreaHollowCheck,
            this.menuLittleAreaCheck,
            this.menuLittleLineCheck});
            this.menuSurfaceCheck.Name = "menuSurfaceCheck";
            this.menuSurfaceCheck.Size = new System.Drawing.Size(160, 22);
            this.menuSurfaceCheck.Text = "表征质量检查";
            // 
            // menuLineThornCheck
            // 
            this.menuLineThornCheck.Name = "menuLineThornCheck";
            this.menuLineThornCheck.Size = new System.Drawing.Size(136, 22);
            this.menuLineThornCheck.Text = "线折刺检查";
            this.menuLineThornCheck.Click += new System.EventHandler(this.menuLineThornCheck_Click);
            // 
            // menuAreaThornCheck
            // 
            this.menuAreaThornCheck.Name = "menuAreaThornCheck";
            this.menuAreaThornCheck.Size = new System.Drawing.Size(136, 22);
            this.menuAreaThornCheck.Text = "面折刺检查";
            this.menuAreaThornCheck.Click += new System.EventHandler(this.menuAreaThornCheck_Click);
            // 
            // menuAreaHollowCheck
            // 
            this.menuAreaHollowCheck.Name = "menuAreaHollowCheck";
            this.menuAreaHollowCheck.Size = new System.Drawing.Size(136, 22);
            this.menuAreaHollowCheck.Text = "面空洞检查";
            this.menuAreaHollowCheck.Click += new System.EventHandler(this.menuAreaHollowCheck_Click);
            // 
            // menuLittleAreaCheck
            // 
            this.menuLittleAreaCheck.Name = "menuLittleAreaCheck";
            this.menuLittleAreaCheck.Size = new System.Drawing.Size(136, 22);
            this.menuLittleAreaCheck.Text = "碎面检查";
            this.menuLittleAreaCheck.Click += new System.EventHandler(this.menuLittleAreaCheck_Click);
            // 
            // menuLittleLineCheck
            // 
            this.menuLittleLineCheck.Name = "menuLittleLineCheck";
            this.menuLittleLineCheck.Size = new System.Drawing.Size(136, 22);
            this.menuLittleLineCheck.Text = "碎线检查";
            this.menuLittleLineCheck.Click += new System.EventHandler(this.menuLittleLineCheck_Click);
            // 
            // menuFormatCheck
            // 
            this.menuFormatCheck.Name = "menuFormatCheck";
            this.menuFormatCheck.Size = new System.Drawing.Size(160, 22);
            this.menuFormatCheck.Text = "格式一致性检查";
            // 
            // menuWholeCheck
            // 
            this.menuWholeCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMapunitWholeCheck,
            this.menuFeatureWholeCheck});
            this.menuWholeCheck.Name = "menuWholeCheck";
            this.menuWholeCheck.Size = new System.Drawing.Size(160, 22);
            this.menuWholeCheck.Text = "完备性检查";
            // 
            // menuMapunitWholeCheck
            // 
            this.menuMapunitWholeCheck.Name = "menuMapunitWholeCheck";
            this.menuMapunitWholeCheck.Size = new System.Drawing.Size(124, 22);
            this.menuMapunitWholeCheck.Text = "图幅检查";
            // 
            // menuFeatureWholeCheck
            // 
            this.menuFeatureWholeCheck.Name = "menuFeatureWholeCheck";
            this.menuFeatureWholeCheck.Size = new System.Drawing.Size(124, 22);
            this.menuFeatureWholeCheck.Text = "要素检查";
            // 
            // menuPosQuaCheck
            // 
            this.menuPosQuaCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExtentCheck});
            this.menuPosQuaCheck.Name = "menuPosQuaCheck";
            this.menuPosQuaCheck.Size = new System.Drawing.Size(160, 22);
            this.menuPosQuaCheck.Text = "位置精度检查";
            // 
            // menuExtentCheck
            // 
            this.menuExtentCheck.Name = "menuExtentCheck";
            this.menuExtentCheck.Size = new System.Drawing.Size(152, 22);
            this.menuExtentCheck.Text = "边界检查";
            this.menuExtentCheck.Click += new System.EventHandler(this.menuExtentCheck_Click);
            // 
            // menuRasterQuaCheck
            // 
            this.menuRasterQuaCheck.Name = "menuRasterQuaCheck";
            this.menuRasterQuaCheck.Size = new System.Drawing.Size(160, 22);
            this.menuRasterQuaCheck.Text = "影像质量检查";
            // 
            // menuStatistic
            // 
            this.menuStatistic.Name = "menuStatistic";
            this.menuStatistic.Size = new System.Drawing.Size(44, 29);
            this.menuStatistic.Text = "统计";
            this.menuStatistic.Visible = false;
            // 
            // menuUserManager
            // 
            this.menuUserManager.Name = "menuUserManager";
            this.menuUserManager.Size = new System.Drawing.Size(68, 29);
            this.menuUserManager.Text = "用户管理";
            this.menuUserManager.Visible = false;
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(44, 29);
            this.menuLogout.Text = "登出";
            this.menuLogout.Visible = false;
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 0);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(1031, 28);
            this.axToolbarControl1.TabIndex = 0;
            // 
            // axToolbarControl2
            // 
            this.axToolbarControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axToolbarControl2.Location = new System.Drawing.Point(0, 0);
            this.axToolbarControl2.Name = "axToolbarControl2";
            this.axToolbarControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl2.OcxState")));
            this.axToolbarControl2.Size = new System.Drawing.Size(1031, 28);
            this.axToolbarControl2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 699);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.w);
            this.Name = "MainForm";
            this.Text = "SpatialDBMS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.w.ResumeLayout(false);
            this.w.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip w;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusScale;
        private System.Windows.Forms.ToolStripStatusLabel StatusCoordinate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuSaveFile;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuAddData;
        private System.Windows.Forms.ToolStripMenuItem menuAddShp;
        private System.Windows.Forms.ToolStripMenuItem menuAddImg;
        private System.Windows.Forms.ToolStripMenuItem menuAddGdb;
        private System.Windows.Forms.ToolStripMenuItem menuQuery;
        private System.Windows.Forms.ToolStripMenuItem menuTimeQuery;
        private System.Windows.Forms.ToolStripMenuItem menuScopeQuery;
        private System.Windows.Forms.ToolStripMenuItem menuCombineQuery;
        private System.Windows.Forms.ToolStripMenuItem menuAttributeQuery;
        private System.Windows.Forms.ToolStripMenuItem menuSpatialQuery;
        private System.Windows.Forms.ToolStripMenuItem menuPutInGdb;
        private System.Windows.Forms.ToolStripMenuItem menuCheck;
        private System.Windows.Forms.ToolStripMenuItem menuTimeCheck;
        private System.Windows.Forms.ToolStripMenuItem menuCoordinateCheck;
        private System.Windows.Forms.ToolStripMenuItem menuTopologyCheck;
        private System.Windows.Forms.ToolStripMenuItem menuSurfaceCheck;
        private System.Windows.Forms.ToolStripMenuItem menuStatistic;
        private System.Windows.Forms.ToolStripMenuItem menuUserManager;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl2;
        private System.Windows.Forms.ToolStripMenuItem menuLineIntersectCheck;
        private System.Windows.Forms.ToolStripMenuItem menuLineCloseCheck;
        private System.Windows.Forms.ToolStripMenuItem menuAreaCloseCheck;
        private System.Windows.Forms.ToolStripMenuItem menuIncludeAnaCheck;
        private System.Windows.Forms.ToolStripMenuItem menuLineThornCheck;
        private System.Windows.Forms.ToolStripMenuItem menuAreaThornCheck;
        private System.Windows.Forms.ToolStripMenuItem menuAreaHollowCheck;
        private System.Windows.Forms.ToolStripMenuItem menuLittleAreaCheck;
        private System.Windows.Forms.ToolStripMenuItem menuLittleLineCheck;
        private System.Windows.Forms.ToolStripMenuItem menuFormatCheck;
        private System.Windows.Forms.ToolStripMenuItem menuWholeCheck;
        private System.Windows.Forms.ToolStripMenuItem menuMapunitWholeCheck;
        private System.Windows.Forms.ToolStripMenuItem menuFeatureWholeCheck;
        private System.Windows.Forms.ToolStripMenuItem menuPosQuaCheck;
        private System.Windows.Forms.ToolStripMenuItem menuExtentCheck;
        private System.Windows.Forms.ToolStripMenuItem menuRasterQuaCheck;
    }
}

