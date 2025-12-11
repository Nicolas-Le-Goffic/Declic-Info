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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSynthese)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSynthese
            // 
            this.dgvSynthese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSynthese.Location = new System.Drawing.Point(40, 206);
            this.dgvSynthese.Name = "dgvSynthese";
            this.dgvSynthese.Size = new System.Drawing.Size(1163, 446);
            this.dgvSynthese.TabIndex = 0;
            // 
            // dateDebutPicker
            // 
            this.dateDebutPicker.Location = new System.Drawing.Point(93, 148);
            this.dateDebutPicker.Name = "dateDebutPicker";
            this.dateDebutPicker.Size = new System.Drawing.Size(200, 20);
            this.dateDebutPicker.TabIndex = 1;
            // 
            // dateFinPicker
            // 
            this.dateFinPicker.Location = new System.Drawing.Point(390, 148);
            this.dateFinPicker.Name = "dateFinPicker";
            this.dateFinPicker.Size = new System.Drawing.Size(200, 20);
            this.dateFinPicker.TabIndex = 2;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(637, 144);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 3;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date début :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date fin :";
            // 
            // FormSynthese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 786);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dateFinPicker);
            this.Controls.Add(this.dateDebutPicker);
            this.Controls.Add(this.dgvSynthese);
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
    }
}