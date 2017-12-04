namespace SpatialDBMS.Forms
{
    partial class FormIncludeCheck
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
            this.label1 = new System.Windows.Forms.Label();
            this.comLyrA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comLyr = new System.Windows.Forms.ComboBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.radioNotInclude = new System.Windows.Forms.RadioButton();
            this.radioInclude = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "选择图层A：";
            // 
            // comLyrA
            // 
            this.comLyrA.FormattingEnabled = true;
            this.comLyrA.Location = new System.Drawing.Point(11, 27);
            this.comLyrA.Name = "comLyrA";
            this.comLyrA.Size = new System.Drawing.Size(243, 20);
            this.comLyrA.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "选择图层B：";
            // 
            // comLyr
            // 
            this.comLyr.FormattingEnabled = true;
            this.comLyr.Location = new System.Drawing.Point(11, 82);
            this.comLyr.Name = "comLyr";
            this.comLyr.Size = new System.Drawing.Size(243, 20);
            this.comLyr.TabIndex = 10;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(14, 212);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 12;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(14, 124);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "检查";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.radioNotInclude);
            this.groupResult.Controls.Add(this.radioInclude);
            this.groupResult.Location = new System.Drawing.Point(104, 124);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(168, 111);
            this.groupResult.TabIndex = 14;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "检查结果";
            this.groupResult.Visible = false;
            // 
            // radioNotInclude
            // 
            this.radioNotInclude.AutoSize = true;
            this.radioNotInclude.Location = new System.Drawing.Point(30, 61);
            this.radioNotInclude.Name = "radioNotInclude";
            this.radioNotInclude.Size = new System.Drawing.Size(59, 16);
            this.radioNotInclude.TabIndex = 1;
            this.radioNotInclude.TabStop = true;
            this.radioNotInclude.Text = "不包含";
            this.radioNotInclude.UseVisualStyleBackColor = true;
            // 
            // radioInclude
            // 
            this.radioInclude.AutoSize = true;
            this.radioInclude.Location = new System.Drawing.Point(30, 32);
            this.radioInclude.Name = "radioInclude";
            this.radioInclude.Size = new System.Drawing.Size(47, 16);
            this.radioInclude.TabIndex = 0;
            this.radioInclude.TabStop = true;
            this.radioInclude.Text = "包含";
            this.radioInclude.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(14, 172);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormIncludeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comLyr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comLyrA);
            this.Name = "FormIncludeCheck";
            this.Text = "A包含B关系检查";
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comLyrA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comLyr;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.RadioButton radioNotInclude;
        private System.Windows.Forms.RadioButton radioInclude;
        private System.Windows.Forms.Button btnOK;
    }
}