namespace SpatialDBMS.Forms
{
    partial class FormSurfaceFeatureCheck
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comLyr = new System.Windows.Forms.ComboBox();
            this.checkedListBoxLyr = new System.Windows.Forms.CheckedListBox();
            this.btnSelectSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(189, 211);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 14;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(189, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(189, 54);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 16;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "选择图层：";
            // 
            // comLyr
            // 
            this.comLyr.FormattingEnabled = true;
            this.comLyr.Location = new System.Drawing.Point(21, 28);
            this.comLyr.Name = "comLyr";
            this.comLyr.Size = new System.Drawing.Size(243, 20);
            this.comLyr.TabIndex = 12;
            this.comLyr.SelectedIndexChanged += new System.EventHandler(this.comLyr_SelectedIndexChanged);
            // 
            // checkedListBoxLyr
            // 
            this.checkedListBoxLyr.CheckOnClick = true;
            this.checkedListBoxLyr.FormattingEnabled = true;
            this.checkedListBoxLyr.Location = new System.Drawing.Point(21, 54);
            this.checkedListBoxLyr.Name = "checkedListBoxLyr";
            this.checkedListBoxLyr.Size = new System.Drawing.Size(162, 180);
            this.checkedListBoxLyr.TabIndex = 17;
            // 
            // btnSelectSwitch
            // 
            this.btnSelectSwitch.Location = new System.Drawing.Point(189, 83);
            this.btnSelectSwitch.Name = "btnSelectSwitch";
            this.btnSelectSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSwitch.TabIndex = 16;
            this.btnSelectSwitch.Text = "反选";
            this.btnSelectSwitch.UseVisualStyleBackColor = true;
            this.btnSelectSwitch.Click += new System.EventHandler(this.btnSelectSwitch_Click);
            // 
            // FormSurfaceFeatureCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkedListBoxLyr);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSelectSwitch);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comLyr);
            this.Name = "FormSurfaceFeatureCheck";
            this.Text = "FormSurfaceFeatureCheck";
            this.Load += new System.EventHandler(this.FormSurfaceFeatureCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comLyr;
        private System.Windows.Forms.CheckedListBox checkedListBoxLyr;
        private System.Windows.Forms.Button btnSelectSwitch;
    }
}