namespace SpatialDBMS.Forms
{
    partial class FormQueryShowResult
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
            this.dgvQueryResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQueryResult
            // 
            this.dgvQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQueryResult.Location = new System.Drawing.Point(0, 0);
            this.dgvQueryResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQueryResult.Name = "dgvQueryResult";
            this.dgvQueryResult.RowTemplate.Height = 27;
            this.dgvQueryResult.Size = new System.Drawing.Size(426, 261);
            this.dgvQueryResult.TabIndex = 2;
            // 
            // FormQueryShowResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.dgvQueryResult);
            this.Name = "FormQueryShowResult";
            this.Text = "查询结果";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvQueryResult;
    }
}