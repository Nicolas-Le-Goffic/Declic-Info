namespace Declic_Info
{
    partial class Form1
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
            System.Windows.Forms.Button btnSupprimer;
            this.lblModifier = new System.Windows.Forms.Label();
            this.lblLib = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.txtbxLib = new System.Windows.Forms.TextBox();
            this.txtbxCat = new System.Windows.Forms.TextBox();
            this.txtbxPrix = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRevenir = new System.Windows.Forms.Button();
            btnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModifier
            // 
            this.lblModifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModifier.AutoSize = true;
            this.lblModifier.Location = new System.Drawing.Point(108, 60);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(100, 13);
            this.lblModifier.TabIndex = 0;
            this.lblModifier.Text = "Modifier un produit :";
            this.lblModifier.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new System.Drawing.Point(589, 60);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(75, 23);
            btnSupprimer.TabIndex = 1;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblLib
            // 
            this.lblLib.AutoSize = true;
            this.lblLib.Location = new System.Drawing.Point(227, 102);
            this.lblLib.Name = "lblLib";
            this.lblLib.Size = new System.Drawing.Size(33, 13);
            this.lblLib.TabIndex = 3;
            this.lblLib.Text = "libellé";
            this.lblLib.Click += new System.EventHandler(this.txtLbl_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(219, 188);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(41, 13);
            this.lblPrix.TabIndex = 4;
            this.lblPrix.Text = "prix HT";
            this.lblPrix.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(209, 146);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(51, 13);
            this.lblCat.TabIndex = 5;
            this.lblCat.Text = "catégorie";
            this.lblCat.Click += new System.EventHandler(this.lblCat_Click);
            // 
            // txtbxLib
            // 
            this.txtbxLib.Location = new System.Drawing.Point(287, 98);
            this.txtbxLib.Name = "txtbxLib";
            this.txtbxLib.Size = new System.Drawing.Size(236, 20);
            this.txtbxLib.TabIndex = 6;
            this.txtbxLib.TextChanged += new System.EventHandler(this.txtbxLib_TextChanged);
            // 
            // txtbxCat
            // 
            this.txtbxCat.Location = new System.Drawing.Point(287, 142);
            this.txtbxCat.Name = "txtbxCat";
            this.txtbxCat.Size = new System.Drawing.Size(236, 20);
            this.txtbxCat.TabIndex = 7;
            // 
            // txtbxPrix
            // 
            this.txtbxPrix.Location = new System.Drawing.Point(287, 184);
            this.txtbxPrix.Name = "txtbxPrix";
            this.txtbxPrix.Size = new System.Drawing.Size(236, 20);
            this.txtbxPrix.TabIndex = 8;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(287, 241);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnRevenir
            // 
            this.btnRevenir.Location = new System.Drawing.Point(396, 241);
            this.btnRevenir.Name = "btnRevenir";
            this.btnRevenir.Size = new System.Drawing.Size(110, 23);
            this.btnRevenir.TabIndex = 10;
            this.btnRevenir.Text = "Revenir en arrière";
            this.btnRevenir.UseVisualStyleBackColor = true;
            this.btnRevenir.Click += new System.EventHandler(this.btnRevenir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRevenir);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtbxPrix);
            this.Controls.Add(this.txtbxCat);
            this.Controls.Add(this.txtbxLib);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblLib);
            this.Controls.Add(btnSupprimer);
            this.Controls.Add(this.lblModifier);
            this.Name = "Form1";
            this.Text = "Declic-Info Produits";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifier;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtbxLib;
        private System.Windows.Forms.TextBox txtbxCat;
        private System.Windows.Forms.TextBox txtbxPrix;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRevenir;
    }
}

