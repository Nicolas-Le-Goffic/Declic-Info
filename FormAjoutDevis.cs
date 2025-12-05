using Declic_InfoBLL;
using Declic_InfoBO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Declic_Info
{
    public partial class FormAjoutDevis : Form
    {
        public FormAjoutDevis()
        {
            InitializeComponent();

            // Récupération chaîne de connexion
            GestionDevis.SetchaineConnexion(
                ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"].ConnectionString
            );

            // Chargement des clients
            dataGridView1.DataSource = GestionClients.GetClients();

            // Chargement des statuts
            statutComboBox.Items.Clear();
            foreach (StatutBO s in GestionStatut.GetStatuts())
                statutComboBox.Items.Add(s);
        }

        private void ajoutDevisbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Veuillez sélectionner un client.");
                    return;
                }

                var client = (ClientBO)dataGridView1.SelectedRows[0].DataBoundItem;

                if (statutComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner un statut.");
                    return;
                }

                var statut = (StatutBO)statutComboBox.SelectedItem;

                // Récupération de la date via DateTimePicker
                DateTime dateDevis = dateTimePicker1.Value;


                if (!decimal.TryParse(libelleTVATxt.Text, out decimal tva))
                {
                    MessageBox.Show("TVA invalide.");
                    return;
                }

                if (!decimal.TryParse(libelleRemiseGloTxt.Text, out decimal remise))
                {
                    MessageBox.Show("Remise invalide.");
                    return;
                }

                if (!decimal.TryParse(libelleMontantHTHorsRemiseTxt.Text, out decimal montantHT))
                {
                    MessageBox.Show("Montant HT invalide.");
                    return;
                }

                // Création du devis
                DevisBO devis = new DevisBO(
                    dateDevis,
                    (float)tva,
                    (float)remise,
                    (float)montantHT,
                    client,
                    statut
                );

                GestionDevis.CreerDevis(devis);

                MessageBox.Show("Devis enregistré avec succès !");

                // Réinitialisation
                libelleTVATxt.Clear();
                libelleRemiseGloTxt.Clear();
                libelleMontantHTHorsRemiseTxt.Clear();
                statutComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
