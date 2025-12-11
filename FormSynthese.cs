using Declic_InfoBLL;
using Declic_InfoBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Declic_InfoBO;
using Declic_InfoBLL;

namespace Declic_Info
{
    public partial class FormSynthese : Form
    {
        public FormSynthese()
        {
            InitializeComponent();

            // désigner le DataGridView pour affichage propre
            dgvSynthese.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSynthese.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSynthese.ReadOnly = true;
            dgvSynthese.AllowUserToAddRows = false;

            // valeurs par défaut : début du mois -> aujourd'hui
            dateDebutPicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateFinPicker.Value = DateTime.Now;

            btnAfficher.Click += btnAfficher_Click;
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime d1 = dateDebutPicker.Value.Date;
                DateTime d2 = dateFinPicker.Value.Date;
                if (d2 < d1)
                {
                    MessageBox.Show("La date de fin doit être supérieure ou égale à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Appel BLL
                List<SyntheseClientBO> result = GestionSynthese.GetSyntheseClients(d1, d2);

                // liaison au DataGridView
                dgvSynthese.DataSource = null;
                dgvSynthese.DataSource = result;

                // optionnel : formater certaines colonnes
                if (dgvSynthese.Columns["PourcentageAcceptes"] != null)
                {
                    dgvSynthese.Columns["PourcentageAcceptes"].DefaultCellStyle.Format = "N2";
                    dgvSynthese.Columns["PourcentageRefuses"].DefaultCellStyle.Format = "N2";
                    dgvSynthese.Columns["PourcentageEnAttente"].DefaultCellStyle.Format = "N2";
                }
                if (dgvSynthese.Columns["MontantTotalFactureHT"] != null)
                {
                    dgvSynthese.Columns["MontantTotalFactureHT"].DefaultCellStyle.Format = "N2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
