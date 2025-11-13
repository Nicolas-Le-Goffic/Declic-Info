namespace Declic_Info
{
    partial class FrmModifierSupprimerProduit
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
            System.Windows.Forms.Button btnSupprimer;
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblModifier = new System.Windows.Forms.Label();
            btnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(410, 304);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(110, 23);
            this.btnRetour.TabIndex = 20;
            this.btnRetour.Text = "Revenir en arrière";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(301, 304);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 19;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(301, 247);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(236, 20);
            this.txtPrix.TabIndex = 18;
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(301, 205);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(236, 20);
            this.txtCategorie.TabIndex = 17;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(301, 161);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(236, 20);
            this.txtLibelle.TabIndex = 16;
            this.txtLibelle.TextChanged += new System.EventHandler(this.txtLibelle_TextChanged);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(223, 209);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(51, 13);
            this.lblCategorie.TabIndex = 15;
            this.lblCategorie.Text = "catégorie";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(233, 251);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(41, 13);
            this.lblPrix.TabIndex = 14;
            this.lblPrix.Text = "prix HT";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(241, 165);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(33, 13);
            this.lblLibelle.TabIndex = 13;
            this.lblLibelle.Text = "libellé";
            this.lblLibelle.Click += new System.EventHandler(this.lblLibelle_Click);
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new System.Drawing.Point(603, 123);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(75, 23);
            btnSupprimer.TabIndex = 12;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblModifier
            // 
            this.lblModifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModifier.AutoSize = true;
            this.lblModifier.Location = new System.Drawing.Point(122, 123);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(100, 13);
            this.lblModifier.TabIndex = 11;
            this.lblModifier.Text = "Modifier un produit :";
            // 
            // FrmModifierSupprimerProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(btnSupprimer);
            this.Controls.Add(this.lblModifier);
            this.Name = "FrmModifierSupprimerProduit";
            this.Text = "FrmModifierSupprimerProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblModifier;
    }
}