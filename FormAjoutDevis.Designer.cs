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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statutComboBox = new System.Windows.Forms.ComboBox();
            this.libelleTVATxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.ajoutDevisbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownRemiseGlobale = new System.Windows.Forms.NumericUpDown();
            this.lblTotalTTC = new System.Windows.Forms.Label();
            this.lblTotalHTFinal = new System.Windows.Forms.Label();
            this.lblRemiseGlobaleHT = new System.Windows.Forms.Label();
            this.lblTotalLignes = new System.Windows.Forms.Label();
            this.lblTotalHorsRemise = new System.Windows.Forms.Label();
            this.lblTVA = new System.Windows.Forms.Label();
            this.btnSupprimerLigne = new System.Windows.Forms.Button();
            this.btnAjouterLigne = new System.Windows.Forms.Button();
            this.dgvLignes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemiseGlobale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).BeginInit();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Statut :";
            // 
            // statutComboBox
            // 
            this.statutComboBox.FormattingEnabled = true;
            this.statutComboBox.Location = new System.Drawing.Point(69, 220);
            this.statutComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statutComboBox.Name = "statutComboBox";
            this.statutComboBox.Size = new System.Drawing.Size(180, 21);
            this.statutComboBox.TabIndex = 17;
            // 
            // libelleTVATxt
            // 
            this.libelleTVATxt.Location = new System.Drawing.Point(69, 166);
            this.libelleTVATxt.Margin = new System.Windows.Forms.Padding(2);
            this.libelleTVATxt.Name = "libelleTVATxt";
            this.libelleTVATxt.Size = new System.Drawing.Size(74, 20);
            this.libelleTVATxt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "TVA (%)  :";
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(55, 68);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(374, 79);
            this.dataGridViewClients.TabIndex = 23;
            // 
            // ajoutDevisbtn
            // 
            this.ajoutDevisbtn.Location = new System.Drawing.Point(41, 418);
            this.ajoutDevisbtn.Margin = new System.Windows.Forms.Padding(2);
            this.ajoutDevisbtn.Name = "ajoutDevisbtn";
            this.ajoutDevisbtn.Size = new System.Drawing.Size(122, 25);
            this.ajoutDevisbtn.TabIndex = 8;
            this.ajoutDevisbtn.Text = "Ajouter le devis";
            this.ajoutDevisbtn.UseVisualStyleBackColor = true;
            this.ajoutDevisbtn.Click += new System.EventHandler(this.ajoutDevisbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 110;
            this.label11.Text = "Remise globale (%)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 109;
            this.label12.Text = "Total TTC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 108;
            this.label13.Text = "Montant TVA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 107;
            this.label14.Text = "Total HT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 106;
            this.label15.Text = "Remise globale HT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 13);
            this.label16.TabIndex = 105;
            this.label16.Text = "Total HT avec remises lignes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 274);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 104;
            this.label17.Text = "Total HT hors remise";
            // 
            // numericUpDownRemiseGlobale
            // 
            this.numericUpDownRemiseGlobale.Location = new System.Drawing.Point(292, 326);
            this.numericUpDownRemiseGlobale.Name = "numericUpDownRemiseGlobale";
            this.numericUpDownRemiseGlobale.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRemiseGlobale.TabIndex = 103;
            // 
            // lblTotalTTC
            // 
            this.lblTotalTTC.AutoSize = true;
            this.lblTotalTTC.Location = new System.Drawing.Point(204, 403);
            this.lblTotalTTC.Name = "lblTotalTTC";
            this.lblTotalTTC.Size = new System.Drawing.Size(37, 13);
            this.lblTotalTTC.TabIndex = 102;
            this.lblTotalTTC.Text = "0,00 €";
            // 
            // lblTotalHTFinal
            // 
            this.lblTotalHTFinal.AutoSize = true;
            this.lblTotalHTFinal.Location = new System.Drawing.Point(204, 347);
            this.lblTotalHTFinal.Name = "lblTotalHTFinal";
            this.lblTotalHTFinal.Size = new System.Drawing.Size(37, 13);
            this.lblTotalHTFinal.TabIndex = 101;
            this.lblTotalHTFinal.Text = "0,00 €";
            // 
            // lblRemiseGlobaleHT
            // 
            this.lblRemiseGlobaleHT.AutoSize = true;
            this.lblRemiseGlobaleHT.Location = new System.Drawing.Point(204, 321);
            this.lblRemiseGlobaleHT.Name = "lblRemiseGlobaleHT";
            this.lblRemiseGlobaleHT.Size = new System.Drawing.Size(37, 13);
            this.lblRemiseGlobaleHT.TabIndex = 100;
            this.lblRemiseGlobaleHT.Text = "0,00 €";
            // 
            // lblTotalLignes
            // 
            this.lblTotalLignes.AutoSize = true;
            this.lblTotalLignes.Location = new System.Drawing.Point(204, 297);
            this.lblTotalLignes.Name = "lblTotalLignes";
            this.lblTotalLignes.Size = new System.Drawing.Size(37, 13);
            this.lblTotalLignes.TabIndex = 99;
            this.lblTotalLignes.Text = "0,00 €";
            // 
            // lblTotalHorsRemise
            // 
            this.lblTotalHorsRemise.AutoSize = true;
            this.lblTotalHorsRemise.Location = new System.Drawing.Point(204, 274);
            this.lblTotalHorsRemise.Name = "lblTotalHorsRemise";
            this.lblTotalHorsRemise.Size = new System.Drawing.Size(37, 13);
            this.lblTotalHorsRemise.TabIndex = 98;
            this.lblTotalHorsRemise.Text = "0,00 €";
            // 
            // lblTVA
            // 
            this.lblTVA.AutoSize = true;
            this.lblTVA.Location = new System.Drawing.Point(204, 374);
            this.lblTVA.Name = "lblTVA";
            this.lblTVA.Size = new System.Drawing.Size(37, 13);
            this.lblTVA.TabIndex = 97;
            this.lblTVA.Text = "0,00 €";
            // 
            // btnSupprimerLigne
            // 
            this.btnSupprimerLigne.Location = new System.Drawing.Point(646, 415);
            this.btnSupprimerLigne.Name = "btnSupprimerLigne";
            this.btnSupprimerLigne.Size = new System.Drawing.Size(116, 23);
            this.btnSupprimerLigne.TabIndex = 96;
            this.btnSupprimerLigne.Text = "Retirer la ligne";
            this.btnSupprimerLigne.UseVisualStyleBackColor = true;
            this.btnSupprimerLigne.Click += new System.EventHandler(this.btnSupprimerLigne_Click);
            // 
            // btnAjouterLigne
            // 
            this.btnAjouterLigne.Location = new System.Drawing.Point(512, 415);
            this.btnAjouterLigne.Name = "btnAjouterLigne";
            this.btnAjouterLigne.Size = new System.Drawing.Size(119, 23);
            this.btnAjouterLigne.TabIndex = 95;
            this.btnAjouterLigne.Text = "Ajouter une ligne";
            this.btnAjouterLigne.UseVisualStyleBackColor = true;
            this.btnAjouterLigne.Click += new System.EventHandler(this.btnAjouterLigne_Click);
            // 
            // dgvLignes
            // 
            this.dgvLignes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLignes.Location = new System.Drawing.Point(449, 68);
            this.dgvLignes.Name = "dgvLignes";
            this.dgvLignes.Size = new System.Drawing.Size(339, 341);
            this.dgvLignes.TabIndex = 94;
            // 
            // FormAjoutDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numericUpDownRemiseGlobale);
            this.Controls.Add(this.lblTotalTTC);
            this.Controls.Add(this.lblTotalHTFinal);
            this.Controls.Add(this.lblRemiseGlobaleHT);
            this.Controls.Add(this.lblTotalLignes);
            this.Controls.Add(this.lblTotalHorsRemise);
            this.Controls.Add(this.lblTVA);
            this.Controls.Add(this.btnSupprimerLigne);
            this.Controls.Add(this.btnAjouterLigne);
            this.Controls.Add(this.dgvLignes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.libelleTVATxt);
            this.Controls.Add(this.statutComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ajoutDevisbtn);
            this.Name = "FormAjoutDevis";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemiseGlobale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statutComboBox;
        private System.Windows.Forms.TextBox libelleTVATxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button ajoutDevisbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDownRemiseGlobale;
        private System.Windows.Forms.Label lblTotalTTC;
        private System.Windows.Forms.Label lblTotalHTFinal;
        private System.Windows.Forms.Label lblRemiseGlobaleHT;
        private System.Windows.Forms.Label lblTotalLignes;
        private System.Windows.Forms.Label lblTotalHorsRemise;
        private System.Windows.Forms.Label lblTVA;
        private System.Windows.Forms.Button btnSupprimerLigne;
        private System.Windows.Forms.Button btnAjouterLigne;
        private System.Windows.Forms.DataGridView dgvLignes;
    }
}