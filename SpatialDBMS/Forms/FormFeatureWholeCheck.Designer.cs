namespace SpatialDBMS.Forms
{
    partial class FormFeatureWholeCheck
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comLyr = new System.Windows.Forms.ComboBox();
            this.textMeta = new System.Windows.Forms.TextBox();
            this.btnLoadMetaData = new System.Windows.Forms.Button();
            this.groupBoxCheckResult = new System.Windows.Forms.GroupBox();
            this.radioLack = new System.Windows.Forms.RadioButton();
            this.radioExcess = new System.Windows.Forms.RadioButton();
            this.radioFit = new System.Windows.Forms.RadioButton();
            this.btnCommit = new System.Windows.Forms.Button();
            this.textFeatureNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCheckResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(278, 22);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "选择图层：";
            // 
            // comLyr
            // 
            this.comLyr.FormattingEnabled = true;
            this.comLyr.Location = new System.Drawing.Point(5, 25);
            this.comLyr.Name = "comLyr";
            this.comLyr.Size = new System.Drawing.Size(267, 20);
            this.comLyr.TabIndex = 13;
            // 
            // textMeta
            // 
            this.textMeta.Location = new System.Drawing.Point(5, 51);
            this.textMeta.Multiline = true;
            this.textMeta.Name = "textMeta";
            this.textMeta.ReadOnly = true;
            this.textMeta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMeta.Size = new System.Drawing.Size(267, 83);
            this.textMeta.TabIndex = 17;
            // 
            // btnLoadMetaData
            // 
            this.btnLoadMetaData.Location = new System.Drawing.Point(278, 53);
            this.btnLoadMetaData.Name = "btnLoadMetaData";
            this.btnLoadMetaData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMetaData.TabIndex = 16;
            this.btnLoadMetaData.Text = "读入元数据";
            this.btnLoadMetaData.UseVisualStyleBackColor = true;
            this.btnLoadMetaData.Click += new System.EventHandler(this.btnLoadMetaData_Click);
            // 
            // groupBoxCheckResult
            // 
            this.groupBoxCheckResult.Controls.Add(this.radioLack);
            this.groupBoxCheckResult.Controls.Add(this.radioExcess);
            this.groupBoxCheckResult.Controls.Add(this.radioFit);
            this.groupBoxCheckResult.Controls.Add(this.btnCommit);
            this.groupBoxCheckResult.Controls.Add(this.textFeatureNum);
            this.groupBoxCheckResult.Controls.Add(this.label2);
            this.groupBoxCheckResult.Location = new System.Drawing.Point(5, 141);
            this.groupBoxCheckResult.Name = "groupBoxCheckResult";
            this.groupBoxCheckResult.Size = new System.Drawing.Size(348, 100);
            this.groupBoxCheckResult.TabIndex = 18;
            this.groupBoxCheckResult.TabStop = false;
            this.groupBoxCheckResult.Text = "检查结果";
            // 
            // radioLack
            // 
            this.radioLack.AutoSize = true;
            this.radioLack.Location = new System.Drawing.Point(156, 54);
            this.radioLack.Name = "radioLack";
            this.radioLack.Size = new System.Drawing.Size(59, 16);
            this.radioLack.TabIndex = 2;
            this.radioLack.TabStop = true;
            this.radioLack.Text = "有缺失";
            this.radioLack.UseVisualStyleBackColor = true;
            // 
            // radioExcess
            // 
            this.radioExcess.AutoSize = true;
            this.radioExcess.Location = new System.Drawing.Point(77, 54);
            this.radioExcess.Name = "radioExcess";
            this.radioExcess.Size = new System.Drawing.Size(59, 16);
            this.radioExcess.TabIndex = 2;
            this.radioExcess.TabStop = true;
            this.radioExcess.Text = "有多余";
            this.radioExcess.UseVisualStyleBackColor = true;
            // 
            // radioFit
            // 
            this.radioFit.AutoSize = true;
            this.radioFit.Location = new System.Drawing.Point(10, 54);
            this.radioFit.Name = "radioFit";
            this.radioFit.Size = new System.Drawing.Size(47, 16);
            this.radioFit.TabIndex = 2;
            this.radioFit.TabStop = true;
            this.radioFit.Text = "完整";
            this.radioFit.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(256, 51);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 15;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // textFeatureNum
            // 
            this.textFeatureNum.Location = new System.Drawing.Point(115, 18);
            this.textFeatureNum.Name = "textFeatureNum";
            this.textFeatureNum.ReadOnly = true;
            this.textFeatureNum.Size = new System.Drawing.Size(100, 21);
            this.textFeatureNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "检查要素数量为：";
            // 
            // FormFeatureWholeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.groupBoxCheckResult);
            this.Controls.Add(this.textMeta);
            this.Controls.Add(this.btnLoadMetaData);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comLyr);
            this.Name = "FormFeatureWholeCheck";
            this.Text = "要素完整性检查";
            this.Load += new System.EventHandler(this.FormFeatureWholeCheck_Load);
            this.groupBoxCheckResult.ResumeLayout(false);
            this.groupBoxCheckResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comLyr;
        private System.Windows.Forms.TextBox textMeta;
        private System.Windows.Forms.Button btnLoadMetaData;
        private System.Windows.Forms.GroupBox groupBoxCheckResult;
        private System.Windows.Forms.TextBox textFeatureNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioLack;
        private System.Windows.Forms.RadioButton radioExcess;
        private System.Windows.Forms.RadioButton radioFit;
        private System.Windows.Forms.Button btnCommit;
    }
}