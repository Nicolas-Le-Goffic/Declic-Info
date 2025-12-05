namespace Declic_Info
{
    partial class FormModificationProduit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prixVenteProduittxt = new System.Windows.Forms.TextBox();
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.libelleProduitTxt = new System.Windows.Forms.TextBox();
            this.modifierProduitbtn = new System.Windows.Forms.Button();
            this.comboProduits = new System.Windows.Forms.ComboBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Modifier un Produit !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prix de vente du produit";
            // 
            // prixVenteProduittxt
            // 
            this.prixVenteProduittxt.Location = new System.Drawing.Point(305, 179);
            this.prixVenteProduittxt.Margin = new System.Windows.Forms.Padding(2);
            this.prixVenteProduittxt.Name = "prixVenteProduittxt";
            this.prixVenteProduittxt.Size = new System.Drawing.Size(77, 20);
            this.prixVenteProduittxt.TabIndex = 13;
            this.prixVenteProduittxt.TextChanged += new System.EventHandler(this.prixVenteProduittxt_TextChanged);
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(305, 220);
            this.categorieComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(180, 21);
            this.categorieComboBox.TabIndex = 12;
            this.categorieComboBox.SelectedIndexChanged += new System.EventHandler(this.categorieComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Catégorie du produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Libellé du produit";
            // 
            // libelleProduitTxt
            // 
            this.libelleProduitTxt.Location = new System.Drawing.Point(305, 142);
            this.libelleProduitTxt.Margin = new System.Windows.Forms.Padding(2);
            this.libelleProduitTxt.Name = "libelleProduitTxt";
            this.libelleProduitTxt.Size = new System.Drawing.Size(275, 20);
            this.libelleProduitTxt.TabIndex = 9;
            this.libelleProduitTxt.TextChanged += new System.EventHandler(this.libelleProduitTxt_TextChanged);
            // 
            // modifierProduitbtn
            // 
            this.modifierProduitbtn.Location = new System.Drawing.Point(335, 307);
            this.modifierProduitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.modifierProduitbtn.Name = "modifierProduitbtn";
            this.modifierProduitbtn.Size = new System.Drawing.Size(193, 71);
            this.modifierProduitbtn.TabIndex = 8;
            this.modifierProduitbtn.Text = "Modifier le produit";
            this.modifierProduitbtn.UseVisualStyleBackColor = true;
            this.modifierProduitbtn.Click += new System.EventHandler(this.modifierProduitbtn_Click);
            // 
            // comboProduits
            // 
            this.comboProduits.FormattingEnabled = true;
            this.comboProduits.Location = new System.Drawing.Point(221, 91);
            this.comboProduits.Name = "comboProduits";
            this.comboProduits.Size = new System.Drawing.Size(389, 21);
            this.comboProduits.TabIndex = 48;
            this.comboProduits.SelectedIndexChanged += new System.EventHandler(this.comboProduits_SelectedIndexChanged);
            // 
            // btnModif
            // 
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnModif.Location = new System.Drawing.Point(659, 75);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(112, 37);
            this.btnModif.TabIndex = 49;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // FormModificationProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.comboProduits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prixVenteProduittxt);
            this.Controls.Add(this.categorieComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libelleProduitTxt);
            this.Controls.Add(this.modifierProduitbtn);
            this.Name = "FormModificationProduit";
            this.Text = "FormModificationProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prixVenteProduittxt;
        private System.Windows.Forms.ComboBox categorieComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox libelleProduitTxt;
        private System.Windows.Forms.Button modifierProduitbtn;
        private System.Windows.Forms.ComboBox comboProduits;
        private System.Windows.Forms.Button btnModif;
    }
}