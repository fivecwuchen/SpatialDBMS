namespace SpatialDBMS.Forms
{
    partial class FormTopoSelect
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
            this.checkedListBoxFeatures = new System.Windows.Forms.CheckedListBox();
            this.OpenMDB = new System.Windows.Forms.Button();
            this.textBoxGdbPath = new System.Windows.Forms.TextBox();
            this.OpenGDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxFeatures
            // 
            this.checkedListBoxFeatures.CheckOnClick = true;
            this.checkedListBoxFeatures.FormattingEnabled = true;
            this.checkedListBoxFeatures.Location = new System.Drawing.Point(22, 93);
            this.checkedListBoxFeatures.Name = "checkedListBoxFeatures";
            this.checkedListBoxFeatures.Size = new System.Drawing.Size(190, 212);
            this.checkedListBoxFeatures.TabIndex = 23;
            // 
            // OpenMDB
            // 
            this.OpenMDB.Location = new System.Drawing.Point(226, 10);
            this.OpenMDB.Name = "OpenMDB";
            this.OpenMDB.Size = new System.Drawing.Size(86, 31);
            this.OpenMDB.TabIndex = 22;
            this.OpenMDB.Text = "打开PGDB";
            this.OpenMDB.UseVisualStyleBackColor = true;
            this.OpenMDB.Click += new System.EventHandler(this.OpenMDB_Click);
            // 
            // textBoxGdbPath
            // 
            this.textBoxGdbPath.Location = new System.Drawing.Point(22, 47);
            this.textBoxGdbPath.Multiline = true;
            this.textBoxGdbPath.Name = "textBoxGdbPath";
            this.textBoxGdbPath.Size = new System.Drawing.Size(290, 31);
            this.textBoxGdbPath.TabIndex = 21;
            // 
            // OpenGDB
            // 
            this.OpenGDB.Location = new System.Drawing.Point(126, 10);
            this.OpenGDB.Name = "OpenGDB";
            this.OpenGDB.Size = new System.Drawing.Size(86, 31);
            this.OpenGDB.TabIndex = 20;
            this.OpenGDB.Text = "打开FGDB";
            this.OpenGDB.UseVisualStyleBackColor = true;
            this.OpenGDB.Click += new System.EventHandler(this.OpenGDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "文件路径：";
            // 
            // btnUnSelectAll
            // 
            this.btnUnSelectAll.Location = new System.Drawing.Point(237, 122);
            this.btnUnSelectAll.Name = "btnUnSelectAll";
            this.btnUnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnUnSelectAll.TabIndex = 18;
            this.btnUnSelectAll.Text = "清空";
            this.btnUnSelectAll.UseVisualStyleBackColor = true;
            this.btnUnSelectAll.Click += new System.EventHandler(this.btnUnSelectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(237, 93);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 17;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(237, 273);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FormTopoSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 352);
            this.Controls.Add(this.checkedListBoxFeatures);
            this.Controls.Add(this.OpenMDB);
            this.Controls.Add(this.textBoxGdbPath);
            this.Controls.Add(this.OpenGDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnSelectAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Name = "FormTopoSelect";
            this.Text = "选择拓扑检查要素";
            this.Load += new System.EventHandler(this.FormTopoSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxFeatures;
        private System.Windows.Forms.Button OpenMDB;
        private System.Windows.Forms.TextBox textBoxGdbPath;
        private System.Windows.Forms.Button OpenGDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnSelectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
    }
}