using Declic_InfoBO;
using Declic_InfoBLL;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Declic_Info
{
    public partial class FormAjoutClient : Form
    {
        public FormAjoutClient()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void prixVenteProduittxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void categorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void libelleProduitTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajoutProduitbtn_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Vérification des champs vides
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text) ||
                string.IsNullOrWhiteSpace(txtFax.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtNumAdrFact.Text) ||
                string.IsNullOrWhiteSpace(txtRueAdrFact.Text) ||
                string.IsNullOrWhiteSpace(txtVilleAdrFact.Text) ||
                string.IsNullOrWhiteSpace(txtCpAdrFact.Text) ||
                string.IsNullOrWhiteSpace(txtNumAdrLiv.Text) ||
                string.IsNullOrWhiteSpace(txtRueAdrLiv.Text) ||
                string.IsNullOrWhiteSpace(txtVilleAdrLiv.Text) ||
                string.IsNullOrWhiteSpace(txtCpAdrLiv.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérification des nombres
            if (!int.TryParse(txtTel.Text, out int tel) ||
                !int.TryParse(txtFax.Text, out int fax) ||
                !int.TryParse(txtNumAdrFact.Text, out int numFact) ||
                !int.TryParse(txtCpAdrFact.Text, out int cpFact) ||
                !int.TryParse(txtNumAdrLiv.Text, out int numLiv) ||
                !int.TryParse(txtCpAdrLiv.Text, out int cpLiv))
            {
                MessageBox.Show("Les champs numériques doivent contenir uniquement des chiffres !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérification email
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("L'adresse email n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Création du client
                ClientBO c = new ClientBO(
                    txtNom.Text,
                    tel,
                    fax,
                    txtEmail.Text,
                    numFact,
                    txtRueAdrFact.Text,
                    txtVilleAdrFact.Text,
                    cpFact,
                    numLiv,
                    txtRueAdrLiv.Text,
                    txtVilleAdrLiv.Text,
                    cpLiv
                );

                // Appel au BLL
                int nb = GestionClients.CreerClient(c);

                if (nb > 0)
                {
                    MessageBox.Show("Client ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // ou ClearForm();
                }
                else
                {
                    MessageBox.Show("L'ajout du client a échoué.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Contrainte UNIQUE
                {
                    MessageBox.Show(
                        "Erreur : le téléphone, fax ou email est déjà utilisé par un autre client.",
                        "Doublon détecté",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    MessageBox.Show("Erreur SQL : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
