namespace Declic_Info
{
    partial class FormListeClient
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
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
            this.dgvDevis.Location = new System.Drawing.Point(24, 13);
            this.dgvDevis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDevis.Name = "dgvDevis";
            this.dgvDevis.RowHeadersWidth = 51;
            this.dgvDevis.RowTemplate.Height = 24;
            this.dgvDevis.Size = new System.Drawing.Size(1163, 355);
            this.dgvDevis.TabIndex = 0;
            this.dgvDevis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // FormListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvDevis);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListeClient";
            this.Text = "FormListeClient";
            this.Load += new System.EventHandler(this.FormListeClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevis;
    }
}

