namespace Declic_Info
{
    partial class FormAjoutDevis
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
            this.libelleDateTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.libelleMontantHTHorsRemiseTxt = new System.Windows.Forms.TextBox();
            this.ajoutDevisbtn = new System.Windows.Forms.Button();
            this.statutComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.libelleTVATxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.libelleRemiseGloTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ajoutez un Devis !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date :";
            // 
            // libelleDateTxt
            // 
            this.libelleDateTxt.Location = new System.Drawing.Point(156, 266);
            this.libelleDateTxt.Margin = new System.Windows.Forms.Padding(2);
            this.libelleDateTxt.Name = "libelleDateTxt";
            this.libelleDateTxt.Size = new System.Drawing.Size(74, 20);
            this.libelleDateTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Client :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Montant HT hors remise :";
            // 
            // libelleMontantHTHorsRemiseTxt
            // 
            this.libelleMontantHTHorsRemiseTxt.Location = new System.Drawing.Point(530, 315);
            this.libelleMontantHTHorsRemiseTxt.Margin = new System.Windows.Forms.Padding(2);
            this.libelleMontantHTHorsRemiseTxt.Name = "libelleMontantHTHorsRemiseTxt";
            this.libelleMontantHTHorsRemiseTxt.Size = new System.Drawing.Size(64, 20);
            this.libelleMontantHTHorsRemiseTxt.TabIndex = 9;
            // 
            // ajoutDevisbtn
            // 
            this.ajoutDevisbtn.Location = new System.Drawing.Point(271, 355);
            this.ajoutDevisbtn.Margin = new System.Windows.Forms.Padding(2);
            this.ajoutDevisbtn.Name = "ajoutDevisbtn";
            this.ajoutDevisbtn.Size = new System.Drawing.Size(193, 71);
            this.ajoutDevisbtn.TabIndex = 8;
            this.ajoutDevisbtn.Text = "Ajouter le devis";
            this.ajoutDevisbtn.UseVisualStyleBackColor = true;
            this.ajoutDevisbtn.Click += new System.EventHandler(this.ajoutDevisbtn_Click);
            // 
            // statutComboBox
            // 
            this.statutComboBox.FormattingEnabled = true;
            this.statutComboBox.Location = new System.Drawing.Point(294, 266);
            this.statutComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statutComboBox.Name = "statutComboBox";
            this.statutComboBox.Size = new System.Drawing.Size(180, 21);
            this.statutComboBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Statut :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "TVA (%)  :";
            // 
            // libelleTVATxt
            // 
            this.libelleTVATxt.Location = new System.Drawing.Point(554, 266);
            this.libelleTVATxt.Margin = new System.Windows.Forms.Padding(2);
            this.libelleTVATxt.Name = "libelleTVATxt";
            this.libelleTVATxt.Size = new System.Drawing.Size(74, 20);
            this.libelleTVATxt.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Remise Globale (%) :";
            // 
            // libelleRemiseGloTxt
            // 
            this.libelleRemiseGloTxt.Location = new System.Drawing.Point(257, 312);
            this.libelleRemiseGloTxt.Margin = new System.Windows.Forms.Padding(2);
            this.libelleRemiseGloTxt.Name = "libelleRemiseGloTxt";
            this.libelleRemiseGloTxt.Size = new System.Drawing.Size(74, 20);
            this.libelleRemiseGloTxt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 319);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "€";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // FormAjoutDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.libelleRemiseGloTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.libelleTVATxt);
            this.Controls.Add(this.statutComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.libelleDateTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libelleMontantHTHorsRemiseTxt);
            this.Controls.Add(this.ajoutDevisbtn);
            this.Name = "FormAjoutDevis";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox libelleDateTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox libelleMontantHTHorsRemiseTxt;
        private System.Windows.Forms.Button ajoutDevisbtn;
        private System.Windows.Forms.ComboBox statutComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox libelleTVATxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox libelleRemiseGloTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}