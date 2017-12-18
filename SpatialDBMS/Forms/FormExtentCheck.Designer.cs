namespace SpatialDBMS.Forms
{
    partial class FormExtentCheck
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
            this.textBoxMeta = new System.Windows.Forms.TextBox();
            this.btnLoadMetaData = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.textYMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textYMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textXMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textXMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comLyr = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxMeta
            // 
            this.textBoxMeta.Location = new System.Drawing.Point(11, 178);
            this.textBoxMeta.Multiline = true;
            this.textBoxMeta.Name = "textBoxMeta";
            this.textBoxMeta.ReadOnly = true;
            this.textBoxMeta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMeta.Size = new System.Drawing.Size(348, 83);
            this.textBoxMeta.TabIndex = 26;
            // 
            // btnLoadMetaData
            // 
            this.btnLoadMetaData.Location = new System.Drawing.Point(11, 142);
            this.btnLoadMetaData.Name = "btnLoadMetaData";
            this.btnLoadMetaData.Size = new System.Drawing.Size(75, 30);
            this.btnLoadMetaData.TabIndex = 24;
            this.btnLoadMetaData.Text = "读入元数据";
            this.btnLoadMetaData.UseVisualStyleBackColor = true;
            this.btnLoadMetaData.Click += new System.EventHandler(this.btnLoadMetaData_Click_1);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(284, 18);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // textYMax
            // 
            this.textYMax.Location = new System.Drawing.Point(233, 100);
            this.textYMax.Name = "textYMax";
            this.textYMax.ReadOnly = true;
            this.textYMax.Size = new System.Drawing.Size(126, 21);
            this.textYMax.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "YMax:";
            // 
            // textYMin
            // 
            this.textYMin.Location = new System.Drawing.Point(53, 97);
            this.textYMin.Name = "textYMin";
            this.textYMin.ReadOnly = true;
            this.textYMin.Size = new System.Drawing.Size(123, 21);
            this.textYMin.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ymin:";
            // 
            // textXMax
            // 
            this.textXMax.Location = new System.Drawing.Point(233, 59);
            this.textXMax.Name = "textXMax";
            this.textXMax.ReadOnly = true;
            this.textXMax.Size = new System.Drawing.Size(126, 21);
            this.textXMax.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "Xmax:";
            // 
            // textXMin
            // 
            this.textXMin.Location = new System.Drawing.Point(53, 59);
            this.textXMin.Name = "textXMin";
            this.textXMin.ReadOnly = true;
            this.textXMin.Size = new System.Drawing.Size(123, 21);
            this.textXMin.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Xmin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "选择图层：";
            // 
            // comLyr
            // 
            this.comLyr.FormattingEnabled = true;
            this.comLyr.Location = new System.Drawing.Point(11, 21);
            this.comLyr.Name = "comLyr";
            this.comLyr.Size = new System.Drawing.Size(267, 20);
            this.comLyr.TabIndex = 14;
            // 
            // FormExtentCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.textBoxMeta);
            this.Controls.Add(this.btnLoadMetaData);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textYMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textYMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textXMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textXMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comLyr);
            this.Name = "FormExtentCheck";
            this.Text = "边界范围检查";
            this.Load += new System.EventHandler(this.FormExtentCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMeta;
        private System.Windows.Forms.Button btnLoadMetaData;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textYMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textYMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textXMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textXMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comLyr;
    }
}