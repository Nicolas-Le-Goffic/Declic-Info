using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Declic_InfoBO;
using Declic_InfoBLL;

namespace Declic_Info
{
    public partial class FrmModificationClients : Form
    {
        public FrmModificationClients()
        {
            InitializeComponent();

            // Connexion BD
            GestionUtilisateurs.SetchaineConnexion(
                ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"].ConnectionString);

            // Charger les clients dans la ComboBox
            LoadClients();

            // Désactiver les champs et bouton modifier
            SetTextBoxesEnabled(false);
            btnModifier.Enabled = false;

            // Brancher l'événement du bouton Modifier
            btnModif.Click += btnModif_Click;
        }

        private void LoadClients()
        {
            List<ClientBO> clients = GestionClients.GetInfosClients();

            comboClients.DataSource = null; // réinitialisation
            comboClients.DataSource = clients;
            comboClients.DisplayMember = "NomClient";  // ce que l'utilisateur voit
            comboClients.ValueMember = "CodeClient";   // valeur réelle
        }

        private void comboClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboClients.SelectedItem == null) return;

            ClientBO client = (ClientBO)comboClients.SelectedItem;

            txtId.Text = client.CodeClient.ToString();
            txtNom.Text = client.NomClient;
            txtTel.Text = client.NumTelClient.ToString();
            txtFax.Text = client.NumFaxClient.ToString();
            txtEmail.Text = client.EmailClient;
            txtNumAdrFact.Text = client.NumAdrFactClient.ToString();
            txtRueAdrFact.Text = client.RueAdrFactClient;
            txtVilleAdrFact.Text = client.VilleAdrLivClient;
            txtCpAdrFact.Text = client.CpAdrFactClient.ToString();
            txtNumAdrLiv.Text = client.NumAdrLivClient.ToString();
            txtRueAdrLiv.Text = client.RueAdrLivClient;
            txtVilleAdrLiv.Text = client.VilleAdrLivClient;
            txtCpAdrLiv.Text = client.CpAdrLivClient.ToString();

            btnModif.Enabled = true;
            btnModifier.Enabled = false;
            SetTextBoxesEnabled(false);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            // Activer TextBox pour modification
            SetTextBoxesEnabled(true);
            btnModifier.Enabled = true;
            btnModif.Enabled = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Validation des champs numériques
            if (!int.TryParse(txtId.Text, out int codeClient) ||
                !int.TryParse(txtTel.Text, out int numTel) ||
                !int.TryParse(txtFax.Text, out int numFax) ||
                !int.TryParse(txtNumAdrFact.Text, out int numAdrFact) ||
                !int.TryParse(txtCpAdrFact.Text, out int cpAdrFact) ||
                !int.TryParse(txtNumAdrLiv.Text, out int numAdrLiv) ||
                !int.TryParse(txtCpAdrLiv.Text, out int cpAdrLiv))
            {
                MessageBox.Show("Veuillez saisir des valeurs numériques valides !", "Erreur");
                return;
            }

            ClientBO client = new ClientBO(
                codeClient,
                txtNom.Text,
                numTel,
                numFax,
                txtEmail.Text,
                numAdrFact,
                txtRueAdrFact.Text,
                txtVilleAdrFact.Text,
                cpAdrFact,
                numAdrLiv,
                txtRueAdrLiv.Text,
                txtVilleAdrLiv.Text,
                cpAdrLiv
            );

            // Appliquer la modification
            GestionClients.ModificationClient(client);
            MessageBox.Show("Modification effectuée !", "Modification");

            // Rafraîchir la ComboBox et garder le client sélectionné
            LoadClients();
            comboClients.SelectedValue = client.CodeClient;

            // Désactiver et nettoyer les champs
            SetTextBoxesEnabled(false);
            btnModifier.Enabled = false;
            btnModif.Enabled = true;
        }

        private void SetTextBoxesEnabled(bool enabled)
        {
            txtNom.Enabled = enabled;
            txtTel.Enabled = enabled;
            txtFax.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtNumAdrFact.Enabled = enabled;
            txtRueAdrFact.Enabled = enabled;
            txtVilleAdrFact.Enabled = enabled;
            txtCpAdrFact.Enabled = enabled;
            txtNumAdrLiv.Enabled = enabled;
            txtRueAdrLiv.Enabled = enabled;
            txtVilleAdrLiv.Enabled = enabled;
            txtCpAdrLiv.Enabled = enabled;
        }

        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtNom.Clear();
            txtTel.Clear();
            txtFax.Clear();
            txtEmail.Clear();
            txtNumAdrFact.Clear();
            txtRueAdrFact.Clear();
            txtVilleAdrFact.Clear();
            txtCpAdrFact.Clear();
            txtNumAdrLiv.Clear();
            txtRueAdrLiv.Clear();
            txtVilleAdrLiv.Clear();
            txtCpAdrLiv.Clear();
        }
    }
}
