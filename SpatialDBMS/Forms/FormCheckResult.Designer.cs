namespace SpatialDBMS.Forms
{
    partial class FormCheckResult
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
            this.dgvCheckResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckResult
            // 
            this.dgvCheckResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckResult.Location = new System.Drawing.Point(0, 0);
            this.dgvCheckResult.Name = "dgvCheckResult";
            this.dgvCheckResult.RowTemplate.Height = 23;
            this.dgvCheckResult.Size = new System.Drawing.Size(578, 261);
            this.dgvCheckResult.TabIndex = 0;
            // 
            // FormCheckResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 261);
            this.Controls.Add(this.dgvCheckResult);
            this.Name = "FormCheckResult";
            this.Text = "FormCheckResult";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvCheckResult;
    }
}