namespace SpatialDBMS.Forms
{
    partial class FormNormalCheck
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnCheckData = new System.Windows.Forms.Button();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabDataList = new System.Windows.Forms.TabPage();
            this.listData = new System.Windows.Forms.ListBox();
            this.tabTimeCheckResult = new System.Windows.Forms.TabPage();
            this.dataGridCheckResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabDataList.SuspendLayout();
            this.tabTimeCheckResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCheckResult)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabView);
            this.splitContainer1.Size = new System.Drawing.Size(534, 301);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnLoadData);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnCheckData);
            this.splitContainer2.Size = new System.Drawing.Size(534, 63);
            this.splitContainer2.SplitterDistance = 260;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadData.Location = new System.Drawing.Point(0, 0);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(260, 63);
            this.btnLoadData.TabIndex = 5;
            this.btnLoadData.Text = "读取数据";
            this.btnLoadData.UseVisualStyleBackColor = true;
            // 
            // btnCheckData
            // 
            this.btnCheckData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckData.Location = new System.Drawing.Point(0, 0);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(270, 63);
            this.btnCheckData.TabIndex = 6;
            this.btnCheckData.Text = "检查";
            this.btnCheckData.UseVisualStyleBackColor = true;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabDataList);
            this.tabView.Controls.Add(this.tabTimeCheckResult);
            this.tabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabView.Location = new System.Drawing.Point(0, 0);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(534, 234);
            this.tabView.TabIndex = 1;
            // 
            // tabDataList
            // 
            this.tabDataList.Controls.Add(this.listData);
            this.tabDataList.Location = new System.Drawing.Point(4, 22);
            this.tabDataList.Name = "tabDataList";
            this.tabDataList.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataList.Size = new System.Drawing.Size(526, 208);
            this.tabDataList.TabIndex = 0;
            this.tabDataList.Text = "数据列表";
            this.tabDataList.UseVisualStyleBackColor = true;
            // 
            // listData
            // 
            this.listData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listData.FormattingEnabled = true;
            this.listData.ItemHeight = 12;
            this.listData.Location = new System.Drawing.Point(3, 3);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(520, 202);
            this.listData.TabIndex = 0;
            // 
            // tabTimeCheckResult
            // 
            this.tabTimeCheckResult.Controls.Add(this.dataGridCheckResult);
            this.tabTimeCheckResult.Location = new System.Drawing.Point(4, 22);
            this.tabTimeCheckResult.Name = "tabTimeCheckResult";
            this.tabTimeCheckResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeCheckResult.Size = new System.Drawing.Size(526, 208);
            this.tabTimeCheckResult.TabIndex = 1;
            this.tabTimeCheckResult.Text = "检查结果";
            this.tabTimeCheckResult.UseVisualStyleBackColor = true;
            // 
            // dataGridCheckResult
            // 
            this.dataGridCheckResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCheckResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCheckResult.Location = new System.Drawing.Point(3, 3);
            this.dataGridCheckResult.Name = "dataGridCheckResult";
            this.dataGridCheckResult.RowTemplate.Height = 23;
            this.dataGridCheckResult.Size = new System.Drawing.Size(520, 202);
            this.dataGridCheckResult.TabIndex = 0;
            // 
            // FormNormalCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 301);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormNormalCheck";
            this.Text = "NormalCheck";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabDataList.ResumeLayout(false);
            this.tabTimeCheckResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCheckResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabDataList;
        private System.Windows.Forms.ListBox listData;
        private System.Windows.Forms.TabPage tabTimeCheckResult;
        private System.Windows.Forms.DataGridView dataGridCheckResult;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnCheckData;
    }
}