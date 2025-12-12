using Declic_InfoBLL;
using Declic_InfoBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Declic_Info
{
    public partial class FormModificationDevis : Form
    {
        List<ContenirBO> produitsDevis;
        List<ProduitBO> produitsHorsDevis;
        List<ContenirBO> suppressionsEnAttente = new List<ContenirBO>();
        public FormModificationDevis()
        {
            InitializeComponent();

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
            dgvProduit.CellClick += dataGridView1_CellClick;
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
            comboBoxClient.SelectedValue = devis.DevisClient.CodeClient;
            comboboxStatut.SelectedValue = devis.DevisStatut.IdStatut;
            produitsDevis = GestionContenir.SelectDevisContenir(devis);
            AjouterColonneSuppression();
            dgvProduit.DataSource = produitsDevis;
            produitsHorsDevis = GestionContenir.SelectProduitsSansDevis(devis);
            dgvProduitsHorsDevis.DataSource = produitsHorsDevis;
            dgvProduitsHorsDevis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduitsHorsDevis.MultiSelect = false;
            dgvProduitsHorsDevis.ReadOnly = true;
            btnModif.Enabled = true;
            btnModifier.Enabled = false;
            SetTextBoxesEnabled(false);
            
        }

        private void AjouterColonneSuppression()
        {
            if (!dgvProduit.Columns.Contains("btnSupprimer"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnSupprimer";
                btn.HeaderText = "Supprimer";
                btn.Text = "Supprimer Produit";
                btn.UseColumnTextForButtonValue = true;
                btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvProduit.Columns.Add(btn);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProduit.Columns["btnSupprimer"].Index)
            {
                SupprimerLigne(e.RowIndex);
            }
        }
        private void SupprimerLigne(int rowIndex)
        {
            DevisBO devis = (DevisBO)dgvProduit.Rows[rowIndex].Cells["Devis"].Value;
            int idDevis = devis.IdDevis;
            ProduitBO produit = (ProduitBO)dgvProduit.Rows[rowIndex].Cells["Produit"].Value;
            int codeProduit = produit.CodeProduit;

            int quantite = Convert.ToInt32(dgvProduit.Rows[rowIndex].Cells["Quantite"].Value);
            int remise = Convert.ToInt32(dgvProduit.Rows[rowIndex].Cells["pourcentage_remise_ligne"].Value);

            DialogResult result = MessageBox.Show(
                "Supprimer ce produit du devis ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;
            ContenirBO contenir = new ContenirBO(devis, produit, quantite, remise);
            suppressionsEnAttente.Add(contenir);
            // Retirer la ligne du DGV
            produitsDevis.RemoveAt(rowIndex);
            dgvProduit.DataSource = null;
            dgvProduit.DataSource = produitsDevis;


            MessageBox.Show("Produit supprimé du devis !");
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
            if (!int.TryParse(txtId.Text, out int idDevis)){
                MessageBox.Show("Veuillez saisir un devis à modifier", "Erreur");
                return;
            }
             if(!float.TryParse(txtTauxTVADevis.Text, out float TauxTVADevis)) {
                MessageBox.Show("Veuillez saisir un Taux de TVA valide à modifier", "Erreur");
                return;
            }
            if (!float.TryParse(txtTauxRemiseGloDevis.Text, out float TauxRemiseGloDevis)) {
                MessageBox.Show("Veuillez saisir un Taux de Remise Global valide à modifier", "Erreur");
                return;
            }
            if (!DateTime.TryParse(dateDevisPicker.Value.ToString(), out DateTime DateDevis))
            {
                MessageBox.Show("Veuillez saisir une Date valide à modifier", "Erreur");
                return;
            }
            if (comboBoxClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez saisir un Client à modifier", "Erreur");
                return;
            }
            if (comboboxStatut.SelectedItem == null)
            {
                MessageBox.Show("Veuillez saisir un Statut à modifier", "Erreur");
                return;
            }
            foreach (ContenirBO liaison in suppressionsEnAttente)
            {
                GestionContenir.SupContenir(liaison.Devis.IdDevis, liaison.Produit.CodeProduit);
            }
            DevisBO devis = new DevisBO(idDevis, DateDevis, TauxTVADevis,TauxRemiseGloDevis, (ClientBO)comboBoxClient.SelectedItem,(StatutBO)comboboxStatut.SelectedItem);

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
            comboboxStatut.Enabled = enabled;
            comboBoxClient.Enabled = enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduitsHorsDevis.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Veuillez sélectionner un produit dans la liste.");
                }

                // Vérifier quantité
                if (string.IsNullOrWhiteSpace(txtQuantite.Text))
                {
                    MessageBox.Show("Veuillez entrer une quantité.");
                }

                if (!int.TryParse(txtQuantite.Text, out int quantite) || quantite <= 0)
                {
                    MessageBox.Show("La quantité doit être un nombre entier positif.");
                }

                // Vérifier remise
                if (string.IsNullOrWhiteSpace(txtRemise.Text))
                {
                    MessageBox.Show("Veuillez entrer un pourcentage de remise.");
                }

                if (!decimal.TryParse(txtRemise.Text, out decimal remise) || remise < 0 || remise > 100)
                {
                    MessageBox.Show("La remise doit être un nombre entre 0 et 100.");
                }

                DevisBO devis = (DevisBO)comboDevis.SelectedItem;
                int idDevis = devis.IdDevis;
                ProduitBO produit = (ProduitBO)dgvProduitsHorsDevis.SelectedRows[0].DataBoundItem;
                quantite = int.Parse(txtQuantite.Text);
                remise = decimal.Parse(txtRemise.Text);
                ContenirBO contenir = new ContenirBO(devis, produit, quantite, remise);

                // Ajout en base + retour de l'objet BO
                GestionContenir.AjoutContenir(contenir);

                // Ajout dans le DataGridView du devis
                dgvProduit.DataSource = null;
                dgvProduit.DataSource = produitsDevis;

                MessageBox.Show("Produit ajouté au devis !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }
    }
}
