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
            this.ajoutProduitbtn.Location = new System.Drawing.Point(187, 254);
            this.ajoutProduitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutProduitbtn.Name = "ajoutProduitbtn";
            this.ajoutProduitbtn.Size = new System.Drawing.Size(193, 71);
            this.ajoutProduitbtn.TabIndex = 0;
            this.ajoutProduitbtn.Text = "Ajouter le produit";
            this.ajoutProduitbtn.UseVisualStyleBackColor = true;
            this.ajoutProduitbtn.Click += new System.EventHandler(this.ajoutProduitbtn_Click);
            // 
            // libelleProduitTxt
            // 
            this.libelleProduitTxt.Location = new System.Drawing.Point(157, 89);
            this.libelleProduitTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.libelleProduitTxt.Name = "libelleProduitTxt";
            this.libelleProduitTxt.Size = new System.Drawing.Size(275, 20);
            this.libelleProduitTxt.TabIndex = 1;
            this.libelleProduitTxt.TextChanged += new System.EventHandler(this.libelleProduitTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libellé du produit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catégorie du produit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(157, 167);
            this.categorieComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(180, 21);
            this.categorieComboBox.TabIndex = 4;
            this.categorieComboBox.SelectedIndexChanged += new System.EventHandler(this.categorieComboBox_SelectedIndexChanged);
            // 
            // prixVenteProduittxt
            // 
            this.prixVenteProduittxt.Location = new System.Drawing.Point(157, 126);
            this.prixVenteProduittxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prixVenteProduittxt.Name = "prixVenteProduittxt";
            this.prixVenteProduittxt.Size = new System.Drawing.Size(77, 20);
            this.prixVenteProduittxt.TabIndex = 5;
            this.prixVenteProduittxt.TextChanged += new System.EventHandler(this.prixVenteProduittxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prix de vente du produit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ajoutez un Produit !";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ajoutProduitbdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prixVenteProduittxt);
            this.Controls.Add(this.categorieComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libelleProduitTxt);
            this.Controls.Add(this.ajoutProduitbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ajoutProduitbdd";
            this.Text = "ajoutProduit";
            this.Load += new System.EventHandler(this.ajoutProduitbdd_Load);
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