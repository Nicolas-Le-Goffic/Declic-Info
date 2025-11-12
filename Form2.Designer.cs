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
            this.categorieComboBox.Location = new System.Drawing.Point(258, 203);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(239, 24);
            this.categorieComboBox.TabIndex = 4;
            // 
            // ajoutProduitbdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}