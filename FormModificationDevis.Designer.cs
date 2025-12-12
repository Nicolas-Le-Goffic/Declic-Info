namespace Declic_Info
{
    partial class FormModificationDevis
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
            this.components = new System.ComponentModel.Container();
            this.comboDevis = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTauxTVADevis = new System.Windows.Forms.TextBox();
            this.txtTauxRemiseGloDevis = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.labelModModif = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboboxStatut = new System.Windows.Forms.ComboBox();
            this.dateDevisPicker = new System.Windows.Forms.DateTimePicker();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.gESTIONCOMMERCIALEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_COMMERCIALEDataSet = new Declic_Info.GESTION_COMMERCIALEDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProduitsHorsDevis = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTIONCOMMERCIALEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_COMMERCIALEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsHorsDevis)).BeginInit();
            this.SuspendLayout();
            // 
            // comboDevis
            // 
            this.comboDevis.FormattingEnabled = true;
            this.comboDevis.Location = new System.Drawing.Point(337, 114);
            this.comboDevis.Margin = new System.Windows.Forms.Padding(4);
            this.comboDevis.Name = "comboDevis";
            this.comboDevis.Size = new System.Drawing.Size(517, 24);
            this.comboDevis.TabIndex = 77;
            this.comboDevis.Click += new System.EventHandler(this.comboDevis_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 71;
            this.label8.Text = "Client du devis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Taux de remise global";
            // 
            // txtTauxTVADevis
            // 
            this.txtTauxTVADevis.Location = new System.Drawing.Point(309, 274);
            this.txtTauxTVADevis.Margin = new System.Windows.Forms.Padding(4);
            this.txtTauxTVADevis.Name = "txtTauxTVADevis";
            this.txtTauxTVADevis.Size = new System.Drawing.Size(132, 22);
            this.txtTauxTVADevis.TabIndex = 57;
            // 
            // txtTauxRemiseGloDevis
            // 
            this.txtTauxRemiseGloDevis.Location = new System.Drawing.Point(309, 306);
            this.txtTauxRemiseGloDevis.Margin = new System.Windows.Forms.Padding(4);
            this.txtTauxRemiseGloDevis.Name = "txtTauxRemiseGloDevis";
            this.txtTauxRemiseGloDevis.Size = new System.Drawing.Size(132, 22);
            this.txtTauxRemiseGloDevis.TabIndex = 56;
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel.Location = new System.Drawing.Point(125, 272);
            this.Tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(172, 24);
            this.Tel.TabIndex = 55;
            this.Tel.Text = "Taux TVA du devis";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNom.Location = new System.Drawing.Point(163, 239);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(134, 24);
            this.lblNom.TabIndex = 53;
            this.lblNom.Text = "Date du devis :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(309, 206);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 26);
            this.txtId.TabIndex = 52;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(199, 206);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(98, 24);
            this.lblId.TabIndex = 51;
            this.lblId.Text = "Identifiant :";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnModifier.Location = new System.Drawing.Point(51, 574);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(260, 46);
            this.btnModifier.TabIndex = 50;
            this.btnModifier.Text = "Appliquer les modifications";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnModif
            // 
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnModif.Location = new System.Drawing.Point(99, 102);
            this.btnModif.Margin = new System.Windows.Forms.Padding(4);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(149, 46);
            this.btnModif.TabIndex = 49;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // labelModModif
            // 
            this.labelModModif.AutoSize = true;
            this.labelModModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModModif.Location = new System.Drawing.Point(361, 52);
            this.labelModModif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModModif.Name = "labelModModif";
            this.labelModModif.Size = new System.Drawing.Size(427, 37);
            this.labelModModif.TabIndex = 48;
            this.labelModModif.Text = "MODIFICATION DES DEVIS";
            this.labelModModif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 79;
            this.label3.Text = "Statut du devis";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(72, 426);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(239, 24);
            this.comboBoxClient.TabIndex = 80;
            // 
            // comboboxStatut
            // 
            this.comboboxStatut.FormattingEnabled = true;
            this.comboboxStatut.Location = new System.Drawing.Point(331, 426);
            this.comboboxStatut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboboxStatut.Name = "comboboxStatut";
            this.comboboxStatut.Size = new System.Drawing.Size(201, 24);
            this.comboboxStatut.TabIndex = 81;
            // 
            // dateDevisPicker
            // 
            this.dateDevisPicker.Location = new System.Drawing.Point(309, 241);
            this.dateDevisPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDevisPicker.Name = "dateDevisPicker";
            this.dateDevisPicker.Size = new System.Drawing.Size(193, 22);
            this.dateDevisPicker.TabIndex = 82;
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToOrderColumns = true;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Location = new System.Drawing.Point(709, 206);
            this.dgvProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.RowHeadersWidth = 51;
            this.dgvProduit.RowTemplate.Height = 24;
            this.dgvProduit.Size = new System.Drawing.Size(812, 138);
            this.dgvProduit.TabIndex = 83;
            // 
            // gESTIONCOMMERCIALEDataSetBindingSource
            // 
            this.gESTIONCOMMERCIALEDataSetBindingSource.DataSource = this.gESTION_COMMERCIALEDataSet;
            this.gESTIONCOMMERCIALEDataSetBindingSource.Position = 0;
            // 
            // gESTION_COMMERCIALEDataSet
            // 
            this.gESTION_COMMERCIALEDataSet.DataSetName = "GESTION_COMMERCIALEDataSet";
            this.gESTION_COMMERCIALEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(791, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(462, 37);
            this.label4.TabIndex = 84;
            this.label4.Text = "Liste des produits dans le devis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvProduitsHorsDevis
            // 
            this.dgvProduitsHorsDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduitsHorsDevis.Location = new System.Drawing.Point(579, 451);
            this.dgvProduitsHorsDevis.Name = "dgvProduitsHorsDevis";
            this.dgvProduitsHorsDevis.RowHeadersWidth = 51;
            this.dgvProduitsHorsDevis.Size = new System.Drawing.Size(554, 188);
            this.dgvProduitsHorsDevis.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label5.Location = new System.Drawing.Point(617, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 26);
            this.label5.TabIndex = 86;
            this.label5.Text = "Liste des produits qui ne sont pas dans le devis";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label6.Location = new System.Drawing.Point(1145, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 26);
            this.label6.TabIndex = 87;
            this.label6.Text = "Quantité de produits";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1150, 466);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 88;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1400, 466);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 22);
            this.textBox2.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label7.Location = new System.Drawing.Point(1385, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 26);
            this.label7.TabIndex = 89;
            this.label7.Text = "Pourcentage de remise";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(1150, 531);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 46);
            this.button1.TabIndex = 91;
            this.button1.Text = "Ajouter un produit dans le devis";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormModificationDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProduitsHorsDevis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.dateDevisPicker);
            this.Controls.Add(this.comboboxStatut);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboDevis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTauxTVADevis);
            this.Controls.Add(this.txtTauxRemiseGloDevis);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.labelModModif);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModificationDevis";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTIONCOMMERCIALEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_COMMERCIALEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsHorsDevis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDevis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTauxTVADevis;
        private System.Windows.Forms.TextBox txtTauxRemiseGloDevis;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Label labelModModif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboboxStatut;
        private System.Windows.Forms.DateTimePicker dateDevisPicker;
        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.BindingSource gESTIONCOMMERCIALEDataSetBindingSource;
        private GESTION_COMMERCIALEDataSet gESTION_COMMERCIALEDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProduitsHorsDevis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}