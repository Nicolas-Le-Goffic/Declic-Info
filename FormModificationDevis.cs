using Declic_InfoBLL;
using Declic_InfoBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Declic_Info
{
    public partial class FormModificationDevis : Form
    {
        public FormModificationDevis()
        {
            InitializeComponent();

            // Connexion BD
            GestionUtilisateurs.SetchaineConnexion(
                ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"].ConnectionString);

            // Charger les clients dans la ComboBox
            LoadDevis();
            LoadClients();
            LoadStatuts();

            // Désactiver les champs et bouton modifier
            SetTextBoxesEnabled(false);
            btnModifier.Enabled = false;

            // Brancher les événements
            comboDevis.SelectedIndexChanged += comboDevis_SelectedIndexChanged;
            btnModif.Click += btnModif_Click;
        }
        private void LoadDevis()
        {
            List<DevisBO> devis = GestionDevis.GetDevis();

            comboDevis.DataSource = null; // réinitialisation
            comboDevis.DataSource = devis;
            comboDevis.DisplayMember = "idDevis";  // ce que l'utilisateur voit
            comboDevis.ValueMember = "idDevis";   // valeur réelle
        }

        private void LoadClients()
        {
            List<ClientBO> clients = GestionClients.GetClients();
            comboBoxClient.DataSource = null;
            comboBoxClient.DataSource = clients;
            comboBoxClient.DisplayMember = "NomClient";
            comboBoxClient.ValueMember = "CodeClient";
        }
        private void LoadStatuts()
        {
            List<StatutBO> statuts = GestionStatut.GetStatuts();
            comboboxStatut.DataSource = null;
            comboboxStatut.DataSource = statuts;
            comboboxStatut.DisplayMember = "NomStatut";
            comboboxStatut.ValueMember = "IdStatut";
        }

        private void comboDevis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDevis.SelectedItem == null) return;

            DevisBO devis = (DevisBO)comboDevis.SelectedItem;

            txtId.Text = devis.IdDevis.ToString();
            dateDevisPicker.Value = devis.DateDevis;
            txtTauxTVADevis.Text = devis.TauxTVADevis.ToString();
            txtTauxRemiseGloDevis.Text = devis.TauxRemiseGloDevis.ToString();
            txtMontantHTHorsRemiseDevis.Text = devis.MontantHtHorsRemise.ToString();
            comboBoxClient.SelectedValue = devis.DevisClient.CodeClient;
            comboboxStatut.SelectedValue = devis.DevisStatut.IdStatut;

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
            if (!int.TryParse(txtId.Text, out int idDevis) ||
                !float.TryParse(txtTauxTVADevis.Text, out float TauxTVADevis) ||
                !float.TryParse(txtTauxRemiseGloDevis.Text, out float TauxRemiseGloDevis) ||
                !float.TryParse(txtMontantHTHorsRemiseDevis.Text,out float MontantHtHorsRemise))

            {
                MessageBox.Show("Veuillez saisir des valeurs numériques valides !", "Erreur");
                return;
            }
            DevisBO devis = new DevisBO(idDevis,dateDevisPicker.Value,TauxTVADevis,TauxRemiseGloDevis, (ClientBO)comboBoxClient.SelectedItem,(StatutBO)comboboxStatut.SelectedItem);

            // Appliquer la modification
            GestionDevis.ModificationDevis(devis);
            MessageBox.Show("Modification effectuée !", "Modification");

            // Rafraîchir la ComboBox et garder le client sélectionné
            LoadDevis();
            comboDevis.SelectedValue = devis.IdDevis;

            // Désactiver et nettoyer les champs
            SetTextBoxesEnabled(false);
            btnModifier.Enabled = false;
            btnModif.Enabled = true;
        }

        private void SetTextBoxesEnabled(bool enabled)
        {
            dateDevisPicker.Enabled = enabled;
            txtTauxTVADevis.Enabled = enabled;
            txtTauxRemiseGloDevis.Enabled = enabled;
            txtMontantHTHorsRemiseDevis.Enabled = enabled;
            comboboxStatut.Enabled = enabled;
            comboBoxClient.Enabled = enabled;
        }
        private void btnsupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
