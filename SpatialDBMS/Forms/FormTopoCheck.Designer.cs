namespace SpatialDBMS.Forms
{
    partial class FormTopoCheck
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
            this.textBoxTopoName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnCreateTopo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFeaB = new System.Windows.Forms.ComboBox();
            this.comboBoxTopoRule = new System.Windows.Forms.ComboBox();
            this.comboBoxFeaA = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddRule = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxTopoName
            // 
            this.textBoxTopoName.Location = new System.Drawing.Point(129, 20);
            this.textBoxTopoName.Name = "textBoxTopoName";
            this.textBoxTopoName.Size = new System.Drawing.Size(121, 21);
            this.textBoxTopoName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "1.输入拓扑名:";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(276, 179);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(93, 26);
            this.btnValidate.TabIndex = 27;
            this.btnValidate.Text = "有效性验证";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click_1);
            // 
            // btnCreateTopo
            // 
            this.btnCreateTopo.Location = new System.Drawing.Point(276, 16);
            this.btnCreateTopo.Name = "btnCreateTopo";
            this.btnCreateTopo.Size = new System.Drawing.Size(93, 26);
            this.btnCreateTopo.TabIndex = 26;
            this.btnCreateTopo.Text = "创建拓扑";
            this.btnCreateTopo.UseVisualStyleBackColor = true;
            this.btnCreateTopo.Click += new System.EventHandler(this.btnCreateTopo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "要素B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "拓扑规则:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "要素A:";
            // 
            // comboBoxFeaB
            // 
            this.comboBoxFeaB.FormattingEnabled = true;
            this.comboBoxFeaB.Location = new System.Drawing.Point(67, 185);
            this.comboBoxFeaB.Name = "comboBoxFeaB";
            this.comboBoxFeaB.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFeaB.TabIndex = 22;
            this.comboBoxFeaB.SelectedIndexChanged += new System.EventHandler(this.comboBoxFeaB_SelectedIndexChanged);
            // 
            // comboBoxTopoRule
            // 
            this.comboBoxTopoRule.DropDownWidth = 200;
            this.comboBoxTopoRule.FormattingEnabled = true;
            this.comboBoxTopoRule.Location = new System.Drawing.Point(67, 137);
            this.comboBoxTopoRule.Name = "comboBoxTopoRule";
            this.comboBoxTopoRule.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTopoRule.TabIndex = 21;
            this.comboBoxTopoRule.SelectedIndexChanged += new System.EventHandler(this.comboBoxTopoRule_SelectedIndexChanged);
            // 
            // comboBoxFeaA
            // 
            this.comboBoxFeaA.FormattingEnabled = true;
            this.comboBoxFeaA.Location = new System.Drawing.Point(67, 82);
            this.comboBoxFeaA.Name = "comboBoxFeaA";
            this.comboBoxFeaA.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFeaA.TabIndex = 20;
            this.comboBoxFeaA.SelectedIndexChanged += new System.EventHandler(this.comboBoxFeaA_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 35);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(31, 323);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 35);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(129, 323);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(71, 35);
            this.btnFinish.TabIndex = 16;
            this.btnFinish.Text = "结束";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "要素B";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "拓扑规则";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "要素A";
            this.columnHeader1.Width = 104;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(276, 131);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(93, 26);
            this.btnAddRule.TabIndex = 19;
            this.btnAddRule.Text = "添加检查规则";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(389, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(349, 342);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FormTopoCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 398);
            this.Controls.Add(this.textBoxTopoName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnCreateTopo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFeaB);
            this.Controls.Add(this.comboBoxTopoRule);
            this.Controls.Add(this.comboBoxFeaA);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.listView1);
            this.Name = "FormTopoCheck";
            this.Text = "拓扑检查";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTopoCheck_FormClosing);
            this.Load += new System.EventHandler(this.FormTopoCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTopoName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnCreateTopo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFeaB;
        private System.Windows.Forms.ComboBox comboBoxTopoRule;
        private System.Windows.Forms.ComboBox comboBoxFeaA;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.ListView listView1;
    }
}