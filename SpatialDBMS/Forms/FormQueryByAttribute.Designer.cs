namespace SpatialDBMS.Forms
{
    partial class FormQueryByAttribute
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.labelwhere = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            this.buttonGetUniqeValue = new System.Windows.Forms.Button();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonUnderLine = new System.Windows.Forms.Button();
            this.buttonIs = new System.Windows.Forms.Button();
            this.buttonNot = new System.Windows.Forms.Button();
            this.buttonBrackets = new System.Windows.Forms.Button();
            this.buttonOr = new System.Windows.Forms.Button();
            this.buttonLessEqual = new System.Windows.Forms.Button();
            this.buttonLess = new System.Windows.Forms.Button();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.buttonGeaterEqual = new System.Windows.Forms.Button();
            this.buttonGreater = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.buttonNotEqual = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.listBoxFields = new System.Windows.Forms.ListBox();
            this.comboBoxSelectMethod = new System.Windows.Forms.ComboBox();
            this.labelSelectionMethod = new System.Windows.Forms.Label();
            this.checkBoxSelectableLayers = new System.Windows.Forms.CheckBox();
            this.comboBoxLayerName = new System.Windows.Forms.ComboBox();
            this.labelLayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(386, 435);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(56, 20);
            this.buttonClose.TabIndex = 64;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(310, 435);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(56, 20);
            this.buttonApply.TabIndex = 63;
            this.buttonApply.Text = "应用";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(230, 435);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(56, 20);
            this.buttonOK.TabIndex = 62;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 3);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(32, 389);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 20);
            this.buttonClear.TabIndex = 60;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(15, 294);
            this.textBoxWhere.Multiline = true;
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxWhere.Size = new System.Drawing.Size(436, 89);
            this.textBoxWhere.TabIndex = 59;
            // 
            // labelwhere
            // 
            this.labelwhere.AutoSize = true;
            this.labelwhere.Location = new System.Drawing.Point(101, 269);
            this.labelwhere.Name = "labelwhere";
            this.labelwhere.Size = new System.Drawing.Size(11, 12);
            this.labelwhere.TabIndex = 58;
            this.labelwhere.Text = " ";
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(13, 269);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(89, 12);
            this.labelSelect.TabIndex = 57;
            this.labelSelect.Text = "SELECT * FORM ";
            // 
            // buttonGetUniqeValue
            // 
            this.buttonGetUniqeValue.Location = new System.Drawing.Point(322, 245);
            this.buttonGetUniqeValue.Name = "buttonGetUniqeValue";
            this.buttonGetUniqeValue.Size = new System.Drawing.Size(120, 20);
            this.buttonGetUniqeValue.TabIndex = 56;
            this.buttonGetUniqeValue.Text = "获取唯一属性值";
            this.buttonGetUniqeValue.UseVisualStyleBackColor = true;
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 12;
            this.listBoxValues.Location = new System.Drawing.Point(320, 91);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(131, 148);
            this.listBoxValues.TabIndex = 55;
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(185, 184);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(20, 31);
            this.buttonPercent.TabIndex = 54;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            // 
            // buttonUnderLine
            // 
            this.buttonUnderLine.Location = new System.Drawing.Point(163, 184);
            this.buttonUnderLine.Name = "buttonUnderLine";
            this.buttonUnderLine.Size = new System.Drawing.Size(20, 31);
            this.buttonUnderLine.TabIndex = 53;
            this.buttonUnderLine.Text = "_";
            this.buttonUnderLine.UseVisualStyleBackColor = true;
            // 
            // buttonIs
            // 
            this.buttonIs.Location = new System.Drawing.Point(163, 221);
            this.buttonIs.Name = "buttonIs";
            this.buttonIs.Size = new System.Drawing.Size(42, 18);
            this.buttonIs.TabIndex = 52;
            this.buttonIs.Text = "Is";
            this.buttonIs.UseVisualStyleBackColor = true;
            // 
            // buttonNot
            // 
            this.buttonNot.Location = new System.Drawing.Point(259, 184);
            this.buttonNot.Name = "buttonNot";
            this.buttonNot.Size = new System.Drawing.Size(42, 31);
            this.buttonNot.TabIndex = 51;
            this.buttonNot.Text = "Not";
            this.buttonNot.UseVisualStyleBackColor = true;
            // 
            // buttonBrackets
            // 
            this.buttonBrackets.Location = new System.Drawing.Point(211, 184);
            this.buttonBrackets.Name = "buttonBrackets";
            this.buttonBrackets.Size = new System.Drawing.Size(42, 31);
            this.buttonBrackets.TabIndex = 50;
            this.buttonBrackets.Text = "( )";
            this.buttonBrackets.UseVisualStyleBackColor = true;
            // 
            // buttonOr
            // 
            this.buttonOr.Location = new System.Drawing.Point(259, 153);
            this.buttonOr.Name = "buttonOr";
            this.buttonOr.Size = new System.Drawing.Size(42, 18);
            this.buttonOr.TabIndex = 49;
            this.buttonOr.Text = "Or";
            this.buttonOr.UseVisualStyleBackColor = true;
            // 
            // buttonLessEqual
            // 
            this.buttonLessEqual.Location = new System.Drawing.Point(211, 153);
            this.buttonLessEqual.Name = "buttonLessEqual";
            this.buttonLessEqual.Size = new System.Drawing.Size(42, 18);
            this.buttonLessEqual.TabIndex = 48;
            this.buttonLessEqual.Text = "<=";
            this.buttonLessEqual.UseVisualStyleBackColor = true;
            // 
            // buttonLess
            // 
            this.buttonLess.Location = new System.Drawing.Point(163, 153);
            this.buttonLess.Name = "buttonLess";
            this.buttonLess.Size = new System.Drawing.Size(42, 18);
            this.buttonLess.TabIndex = 47;
            this.buttonLess.Text = "<";
            this.buttonLess.UseVisualStyleBackColor = true;
            // 
            // buttonAnd
            // 
            this.buttonAnd.Location = new System.Drawing.Point(259, 122);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(42, 18);
            this.buttonAnd.TabIndex = 46;
            this.buttonAnd.Text = "And";
            this.buttonAnd.UseVisualStyleBackColor = true;
            // 
            // buttonGeaterEqual
            // 
            this.buttonGeaterEqual.Location = new System.Drawing.Point(211, 122);
            this.buttonGeaterEqual.Name = "buttonGeaterEqual";
            this.buttonGeaterEqual.Size = new System.Drawing.Size(42, 18);
            this.buttonGeaterEqual.TabIndex = 45;
            this.buttonGeaterEqual.Text = ">=";
            this.buttonGeaterEqual.UseVisualStyleBackColor = true;
            // 
            // buttonGreater
            // 
            this.buttonGreater.Location = new System.Drawing.Point(163, 122);
            this.buttonGreater.Name = "buttonGreater";
            this.buttonGreater.Size = new System.Drawing.Size(42, 18);
            this.buttonGreater.TabIndex = 44;
            this.buttonGreater.Text = ">";
            this.buttonGreater.UseVisualStyleBackColor = true;
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(259, 91);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(42, 18);
            this.buttonLike.TabIndex = 43;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            // 
            // buttonNotEqual
            // 
            this.buttonNotEqual.Location = new System.Drawing.Point(211, 91);
            this.buttonNotEqual.Name = "buttonNotEqual";
            this.buttonNotEqual.Size = new System.Drawing.Size(42, 18);
            this.buttonNotEqual.TabIndex = 42;
            this.buttonNotEqual.Text = "<>";
            this.buttonNotEqual.UseVisualStyleBackColor = true;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(163, 91);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(42, 18);
            this.buttonEqual.TabIndex = 41;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            // 
            // listBoxFields
            // 
            this.listBoxFields.FormattingEnabled = true;
            this.listBoxFields.ItemHeight = 12;
            this.listBoxFields.Location = new System.Drawing.Point(15, 91);
            this.listBoxFields.Name = "listBoxFields";
            this.listBoxFields.Size = new System.Drawing.Size(131, 148);
            this.listBoxFields.TabIndex = 40;
            // 
            // comboBoxSelectMethod
            // 
            this.comboBoxSelectMethod.FormattingEnabled = true;
            this.comboBoxSelectMethod.Items.AddRange(new object[] {
            "创建新选择集",
            "添加到当前选择集",
            "从当前选择集中删除",
            "从当前选择集中选择"});
            this.comboBoxSelectMethod.Location = new System.Drawing.Point(84, 55);
            this.comboBoxSelectMethod.Name = "comboBoxSelectMethod";
            this.comboBoxSelectMethod.Size = new System.Drawing.Size(367, 20);
            this.comboBoxSelectMethod.TabIndex = 39;
            // 
            // labelSelectionMethod
            // 
            this.labelSelectionMethod.AutoSize = true;
            this.labelSelectionMethod.Location = new System.Drawing.Point(13, 58);
            this.labelSelectionMethod.Name = "labelSelectionMethod";
            this.labelSelectionMethod.Size = new System.Drawing.Size(65, 12);
            this.labelSelectionMethod.TabIndex = 38;
            this.labelSelectionMethod.Text = "选择方式：";
            // 
            // checkBoxSelectableLayers
            // 
            this.checkBoxSelectableLayers.AutoSize = true;
            this.checkBoxSelectableLayers.Location = new System.Drawing.Point(84, 32);
            this.checkBoxSelectableLayers.Name = "checkBoxSelectableLayers";
            this.checkBoxSelectableLayers.Size = new System.Drawing.Size(108, 16);
            this.checkBoxSelectableLayers.TabIndex = 37;
            this.checkBoxSelectableLayers.Text = "只显示可选图层";
            this.checkBoxSelectableLayers.UseVisualStyleBackColor = true;
            // 
            // comboBoxLayerName
            // 
            this.comboBoxLayerName.FormattingEnabled = true;
            this.comboBoxLayerName.Location = new System.Drawing.Point(84, 6);
            this.comboBoxLayerName.Name = "comboBoxLayerName";
            this.comboBoxLayerName.Size = new System.Drawing.Size(367, 20);
            this.comboBoxLayerName.TabIndex = 36;
            // 
            // labelLayerName
            // 
            this.labelLayerName.AutoSize = true;
            this.labelLayerName.Location = new System.Drawing.Point(13, 14);
            this.labelLayerName.Name = "labelLayerName";
            this.labelLayerName.Size = new System.Drawing.Size(65, 12);
            this.labelLayerName.TabIndex = 35;
            this.labelLayerName.Text = "图层名称：";
            // 
            // FormQueryByAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 461);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxWhere);
            this.Controls.Add(this.labelwhere);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.buttonGetUniqeValue);
            this.Controls.Add(this.listBoxValues);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonUnderLine);
            this.Controls.Add(this.buttonIs);
            this.Controls.Add(this.buttonNot);
            this.Controls.Add(this.buttonBrackets);
            this.Controls.Add(this.buttonOr);
            this.Controls.Add(this.buttonLessEqual);
            this.Controls.Add(this.buttonLess);
            this.Controls.Add(this.buttonAnd);
            this.Controls.Add(this.buttonGeaterEqual);
            this.Controls.Add(this.buttonGreater);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.buttonNotEqual);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.listBoxFields);
            this.Controls.Add(this.comboBoxSelectMethod);
            this.Controls.Add(this.labelSelectionMethod);
            this.Controls.Add(this.checkBoxSelectableLayers);
            this.Controls.Add(this.comboBoxLayerName);
            this.Controls.Add(this.labelLayerName);
            this.Name = "FormQueryByAttribute";
            this.Text = "属性查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.Label labelwhere;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Button buttonGetUniqeValue;
        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonUnderLine;
        private System.Windows.Forms.Button buttonIs;
        private System.Windows.Forms.Button buttonNot;
        private System.Windows.Forms.Button buttonBrackets;
        private System.Windows.Forms.Button buttonOr;
        private System.Windows.Forms.Button buttonLessEqual;
        private System.Windows.Forms.Button buttonLess;
        private System.Windows.Forms.Button buttonAnd;
        private System.Windows.Forms.Button buttonGeaterEqual;
        private System.Windows.Forms.Button buttonGreater;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonNotEqual;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.ListBox listBoxFields;
        private System.Windows.Forms.ComboBox comboBoxSelectMethod;
        private System.Windows.Forms.Label labelSelectionMethod;
        private System.Windows.Forms.CheckBox checkBoxSelectableLayers;
        private System.Windows.Forms.ComboBox comboBoxLayerName;
        private System.Windows.Forms.Label labelLayerName;
    }
}