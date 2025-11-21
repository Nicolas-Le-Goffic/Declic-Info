namespace Declic_Info
{
    partial class ajoutProduitbdd
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
            this.ajoutProduitbtn = new System.Windows.Forms.Button();
            this.libelleProduitTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.prixVenteProduittxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ajoutProduitbtn
            // 
            this.ajoutProduitbtn.Location = new System.Drawing.Point(249, 313);
            this.ajoutProduitbtn.Name = "ajoutProduitbtn";
            this.ajoutProduitbtn.Size = new System.Drawing.Size(257, 87);
            this.ajoutProduitbtn.TabIndex = 0;
            this.ajoutProduitbtn.Text = "Ajouter le produit";
            this.ajoutProduitbtn.UseVisualStyleBackColor = true;
            this.ajoutProduitbtn.Click += new System.EventHandler(this.ajoutProduitbtn_Click);
            // 
            // libelleProduitTxt
            // 
            this.libelleProduitTxt.Location = new System.Drawing.Point(209, 109);
            this.libelleProduitTxt.Name = "libelleProduitTxt";
            this.libelleProduitTxt.Size = new System.Drawing.Size(365, 22);
            this.libelleProduitTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libellé du produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catégorie du produit";
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(209, 206);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(239, 24);
            this.categorieComboBox.TabIndex = 4;
            // 
            // prixVenteProduittxt
            // 
            this.prixVenteProduittxt.Location = new System.Drawing.Point(209, 155);
            this.prixVenteProduittxt.Name = "prixVenteProduittxt";
            this.prixVenteProduittxt.Size = new System.Drawing.Size(101, 22);
            this.prixVenteProduittxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prix de vente du produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ajoutez un Produit !";
            // 
            // ajoutProduitbdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prixVenteProduittxt);
            this.Controls.Add(this.categorieComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libelleProduitTxt);
            this.Controls.Add(this.ajoutProduitbtn);
            this.Name = "ajoutProduitbdd";
            this.Text = "ajoutProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajoutProduitbtn;
        private System.Windows.Forms.TextBox libelleProduitTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categorieComboBox;
        private System.Windows.Forms.TextBox prixVenteProduittxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}