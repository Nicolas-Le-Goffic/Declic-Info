namespace Declic_Info
{
    partial class FormSynthese
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
            this.dgvSynthese = new System.Windows.Forms.DataGridView();
            this.dateDebutPicker = new System.Windows.Forms.DateTimePicker();
            this.dateFinPicker = new System.Windows.Forms.DateTimePicker();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelModModif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSynthese)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSynthese
            // 
            this.dgvSynthese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSynthese.Location = new System.Drawing.Point(53, 254);
            this.dgvSynthese.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSynthese.Name = "dgvSynthese";
            this.dgvSynthese.RowHeadersWidth = 51;
            this.dgvSynthese.Size = new System.Drawing.Size(1551, 549);
            this.dgvSynthese.TabIndex = 0;
            // 
            // dateDebutPicker
            // 
            this.dateDebutPicker.Location = new System.Drawing.Point(124, 182);
            this.dateDebutPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDebutPicker.Name = "dateDebutPicker";
            this.dateDebutPicker.Size = new System.Drawing.Size(265, 22);
            this.dateDebutPicker.TabIndex = 1;
            // 
            // dateFinPicker
            // 
            this.dateFinPicker.Location = new System.Drawing.Point(520, 182);
            this.dateFinPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFinPicker.Name = "dateFinPicker";
            this.dateFinPicker.Size = new System.Drawing.Size(265, 22);
            this.dateFinPicker.TabIndex = 2;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(849, 177);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(100, 28);
            this.btnAfficher.TabIndex = 3;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date début :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date fin :";
            // 
            // labelModModif
            // 
            this.labelModModif.AutoSize = true;
            this.labelModModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModModif.Location = new System.Drawing.Point(399, 62);
            this.labelModModif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModModif.Name = "labelModModif";
            this.labelModModif.Size = new System.Drawing.Size(368, 37);
            this.labelModModif.TabIndex = 49;
            this.labelModModif.Text = "SYNTHESE DES DEVIS";
            this.labelModModif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormSynthese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 967);
            this.Controls.Add(this.labelModModif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dateFinPicker);
            this.Controls.Add(this.dateDebutPicker);
            this.Controls.Add(this.dgvSynthese);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSynthese";
            this.Text = "FormSynthese";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSynthese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSynthese;
        private System.Windows.Forms.DateTimePicker dateDebutPicker;
        private System.Windows.Forms.DateTimePicker dateFinPicker;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelModModif;
    }
}