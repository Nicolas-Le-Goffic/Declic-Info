namespace Declic_Info
{
    partial class FormListeDevis
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
            this.dgvDevis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDevis
            // 
            this.dgvDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevis.Location = new System.Drawing.Point(26, 60);
            this.dgvDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDevis.Name = "dgvDevis";
            this.dgvDevis.RowHeadersWidth = 51;
            this.dgvDevis.RowTemplate.Height = 24;
            this.dgvDevis.Size = new System.Drawing.Size(1309, 437);
            this.dgvDevis.TabIndex = 1;
            this.dgvDevis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevis_CellContentClick);
            // 
            // FormListeDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvDevis);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormListeDevis";
            this.Text = "FormListeDevis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevis;
    }
}