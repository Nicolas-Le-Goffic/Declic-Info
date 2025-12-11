using Declic_InfoBLL;
using Declic_InfoBO;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace Declic_Info
{
    public partial class FormAjoutDevis : Form
    {
        private BindingList<ContenirBO> lignes = new BindingList<ContenirBO>();
        private BindingList<ProduitBO> produits = new BindingList<ProduitBO>();

        public FormAjoutDevis()
        {
            InitializeComponent();

<<<<<<< HEAD
            // Connexion BDD
            GestionDevis.SetchaineConnexion(
                ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"].ConnectionString
            );
=======
            // Récupération chaîne de connexion
            GestionCategories.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"]);
>>>>>>> 419044fdfd7a991ca83814bfd469f0ad1a112939

            // Clients
            dataGridViewClients.DataSource = GestionClients.GetInfosClients();
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.SelectionChanged += (s, e) => {
                if (dataGridViewClients.SelectedRows.Count > 0)
                {
                }
            };

            // Statuts
            statutComboBox.Items.Clear();
            foreach (StatutBO s in GestionStatut.GetStatuts())
                statutComboBox.Items.Add(s);

            // Produits
            produits = new BindingList<ProduitBO>(GestionProduits.GetProduits());

            // DataGridView lignes
            SetupDgvLignes();

            // Dans le constructeur ou InitializeComponent
            numericUpDownRemiseGlobale.DecimalPlaces = 2;      // 2 décimales
            numericUpDownRemiseGlobale.Increment = 0.1m;       // pas de 1
            numericUpDownRemiseGlobale.Minimum = 0;
            numericUpDownRemiseGlobale.Maximum = 100;


            // Événements boutons
            btnAjouterLigne.Click += btnAjouterLigne_Click;
            btnSupprimerLigne.Click += btnSupprimerLigne_Click;

            // Recalcul dès qu'on modifie TVA ou remise globale
            libelleTVATxt.TextChanged += (s, e) => RecalculerTotaux();
            numericUpDownRemiseGlobale.ValueChanged += (s, e) => 
            {
                RecalculerTotaux();
                };
        }

        private void SetupDgvLignes()
        {
            dgvLignes.AutoGenerateColumns = false;
            dgvLignes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLignes.Columns.Clear();

            // Colonne produit (ComboBox liée au CodeProduit)
            var colProduit = new DataGridViewComboBoxColumn()
            {
                Name = "Produit",
                HeaderText = "Produit",
                DataSource = produits,
                DisplayMember = "LibelleProduit",
                ValueMember = "CodeProduit",
                DataPropertyName = "CodeProduit"  // propriété int dans ContenirBO
            };
            dgvLignes.Columns.Add(colProduit);

            // Quantité
            dgvLignes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Quantite",
                HeaderText = "Qté"
            });

            // Remise ligne
            dgvLignes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Pourcentage_remise_ligne",
                HeaderText = "% Remise",
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Format = "N2",  // 2 décimales
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });



            // Colonnes calculées (lecture seule)
            dgvLignes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PrixUnitaireHT",
                HeaderText = "PU HT",
                ReadOnly = true
            });

            dgvLignes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "SousTotalHT",
                HeaderText = "Sous-total HT",
                ReadOnly = true
            });

            dgvLignes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MontantRemiseHT",
                HeaderText = "Remise HT",
                ReadOnly = true
            });

            dgvLignes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TotalLigneHT",
                HeaderText = "Total ligne HT",
                ReadOnly = true
            });

            dgvLignes.DataSource = lignes;

            // Commit immédiat des changements
            dgvLignes.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvLignes.IsCurrentCellDirty)
                    dgvLignes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            // Recalcul quand une cellule change
            dgvLignes.CellValueChanged += DgvLignes_CellValueChanged;

            // Optionnel : éviter popup DataError
            dgvLignes.DataError += (s, e) =>
            {
                e.ThrowException = false;
            };
        }

        private void btnAjouterLigne_Click(object sender, EventArgs e)
        {
            if (produits.Count == 0) return;
            int code = produits[0].CodeProduit;

            var ligneExistante = lignes.FirstOrDefault(l => l.CodeProduit == code);
            if (ligneExistante != null)
            {
                ligneExistante.Quantite += 1;
            }
            else
            {

                var nouvelleLigne = new ContenirBO()
                {
                    CodeProduit = code,
                    Quantite = 1,
                    Pourcentage_remise_ligne = 0,
                    Produit = produits.First(p => p.CodeProduit == code)
                };
                lignes.Add(nouvelleLigne);
            }

                RecalculerTotaux();
        }

        private void btnSupprimerLigne_Click(object sender, EventArgs e)
        {
            if (dgvLignes.SelectedRows.Count > 0)
            {
                var ligne = (ContenirBO)dgvLignes.SelectedRows[0].DataBoundItem;
                lignes.Remove(ligne);
                RecalculerTotaux();
            }
            else
            {
                MessageBox.Show("Sélectionnez une ligne à supprimer.");
            }
        }

        private void DgvLignes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var ligne = (ContenirBO)dgvLignes.Rows[e.RowIndex].DataBoundItem;

            // Mise à jour de l'objet Produit quand on change la ComboBox
            if (e.ColumnIndex == dgvLignes.Columns["Produit"].Index)
            {
                var prod = produits.FirstOrDefault(p => p.CodeProduit == ligne.CodeProduit);
                ligne.Produit = prod;
            }

            RecalculerTotaux();
            //dgvLignes.Refresh();
        }

        private void RecalculerTotaux()
        {
            // Totaux basés sur les lignes
            decimal totalHorsRemise = lignes.Sum(l => l.SousTotalHT);
            decimal totalApresRemises = lignes.Sum(l => l.TotalLigneHT);

            // Remise globale %
            decimal remiseGlobale = totalApresRemises * (numericUpDownRemiseGlobale.Value / 100m);
            decimal totalHT = totalApresRemises - remiseGlobale;

            // TVA
            if (!decimal.TryParse(libelleTVATxt.Text, out decimal tauxTVA))
                tauxTVA = 0;

            decimal tva = totalHT * tauxTVA / 100m;
            decimal totalTTC = totalHT + tva;

            // Mise à jour des labels
            lblTotalHorsRemise.Text = totalHorsRemise.ToString("N2") + " €";
            lblTotalLignes.Text = totalApresRemises.ToString("N2") + " €";
            lblRemiseGlobaleHT.Text = remiseGlobale.ToString("N2") + " €";
            lblTotalHTFinal.Text = totalHT.ToString("N2") + " €";
            lblTVA.Text = tva.ToString("N2") + " €";
            lblTotalTTC.Text = totalTTC.ToString("N2") + " €";
        }

        private void ResetFormulaire()
        {
            // Vider les lignes
            lignes.Clear();

            // Reset remise globale
            numericUpDownRemiseGlobale.Value = 0;

            // Reset TVA → VIDE (pas de valeur par défaut)
            libelleTVATxt.Text = "";

            // Reset date (aujourd'hui)
            dateTimePicker1.Value = DateTime.Today;

            // Reset statut → RIEN sélectionné
            statutComboBox.SelectedIndex = -1;

            // Désélectionner client
            dataGridViewClients.ClearSelection();

            // Reset tous les labels à 0
            RecalculerTotaux();

            // Focus sur clients
            dataGridViewClients.Focus();
        }



        private void ajoutDevisbtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez un client.");
                return;
            }

            if (statutComboBox.SelectedItem == null)
            {
                MessageBox.Show("Sélectionnez un statut.");
                return;
            }

            ClientBO client = (ClientBO)dataGridViewClients.SelectedRows[0].DataBoundItem;
            StatutBO statut = (StatutBO)statutComboBox.SelectedItem;
            DateTime dateDevis = dateTimePicker1.Value;

            if (!decimal.TryParse(libelleTVATxt.Text, out decimal tva))
            {
                MessageBox.Show("TVA invalide.");
                return;
            }

            if (lignes.Count == 0 || lignes.All(l => l.CodeProduit == 0))
            {
                MessageBox.Show("Ajoutez au moins un produit.");
                return;
            }

            decimal remiseGlobale = numericUpDownRemiseGlobale.Value;

            var devis = new DevisBO(dateDevis, (float)tva, (float)remiseGlobale, client, statut);
            foreach (var l in lignes)
                devis.Lignes.Add(l);

            GestionDevis.CreerDevis(devis);
            MessageBox.Show("Devis enregistré !");
            ResetFormulaire();
        }
    }
}
