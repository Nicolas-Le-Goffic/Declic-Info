namespace Declic_Info
{
    partial class FormSuppressionProduit
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
            this.produitComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produitComboBox
            // 
            this.produitComboBox.FormattingEnabled = true;
            this.produitComboBox.Location = new System.Drawing.Point(257, 203);
            this.produitComboBox.Name = "produitComboBox";
            this.produitComboBox.Size = new System.Drawing.Size(288, 21);
            this.produitComboBox.TabIndex = 0;
            this.produitComboBox.SelectedIndexChanged += new System.EventHandler(this.produitComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supprimez un produit !";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(334, 286);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(143, 57);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "Supprimer le produit";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // FormSuppressionProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produitComboBox);
            this.Name = "FormSuppressionProduit";
            this.Text = "FormSuppressionProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox produitComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}