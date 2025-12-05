namespace Declic_Info
{
    partial class FormSuppressionDevis
    {
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox devisCombobox;

        private void InitializeComponent()
        {
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.devisCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(532, 353);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(191, 70);
            this.buttonSupprimer.TabIndex = 7;
            this.buttonSupprimer.Text = "Supprimer le produit";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Supprimez un devis !";
            // 
            // devisCombobox
            // 
            this.devisCombobox.FormattingEnabled = true;
            this.devisCombobox.Location = new System.Drawing.Point(430, 251);
            this.devisCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.devisCombobox.Name = "devisCombobox";
            this.devisCombobox.Size = new System.Drawing.Size(383, 24);
            this.devisCombobox.TabIndex = 5;
            // 
            // FormSuppressionDevis
            // 
            this.ClientSize = new System.Drawing.Size(1254, 502);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devisCombobox);
            this.Name = "FormSuppressionDevis";
            this.Text = "Supprimez un Produit !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}