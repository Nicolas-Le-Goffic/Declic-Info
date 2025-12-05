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
using System.Configuration;

namespace Declic_Info
{
    public partial class FormModificationProduit : Form
    {
        public FormModificationProduit()
        {
            InitializeComponent();
            // Connexion BD
            GestionProduits.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"]);
            GestionCategories.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"]);

            // Charger les produits et catégories
            LoadProduits();
            LoadCategories();

            // Désactiver les champs et bouton modifier au départ
            SetTextBoxesEnabled(false);
            btnModif.Enabled = false;
            modifierProduitbtn.Enabled = false;

            // Brancher les événements
            comboProduits.SelectedIndexChanged += comboProduits_SelectedIndexChanged;
            btnModif.Click += btnModif_Click;
            modifierProduitbtn.Click += modifierProduitbtn_Click;
        }
        private void LoadProduits()
        {
            List<ProduitBO> produits = GestionProduits.GetProduits();
            comboProduits.DataSource = null;
            comboProduits.DataSource = produits;
            comboProduits.DisplayMember = "LibelleProduit";
            comboProduits.ValueMember = "CodeProduit";
        }

        private void LoadCategories()
        {
            List<CategorieBO> categories = GestionCategories.GetCategories();
            categorieComboBox.DataSource = null;
            categorieComboBox.DataSource = categories;
            categorieComboBox.DisplayMember = "NomCategorie";
            categorieComboBox.ValueMember = "IdCategorie";
        }

        private void modifierProduitbtn_Click(object sender, EventArgs e)
        {   // Validation du prix
            if (!float.TryParse(prixVenteProduittxt.Text, out float prixVente))
            {
                MessageBox.Show("Veuillez saisir un prix valide !", "Erreur");
                return;
            }

            ProduitBO produit = new ProduitBO(
                int.Parse(((ProduitBO)comboProduits.SelectedItem).CodeProduit.ToString()),
                libelleProduitTxt.Text,
                prixVente,
                (CategorieBO)categorieComboBox.SelectedItem
            );

            // Appliquer la modification
            GestionProduits.ModificationProduit(produit);
            MessageBox.Show("Produit modifié !", "Modification");

            // Rafraîchir la ComboBox et garder le produit sélectionné
            LoadProduits();
            comboProduits.SelectedValue = produit.CodeProduit;

            SetTextBoxesEnabled(false);
            modifierProduitbtn.Enabled = false;
            btnModif.Enabled = true; // Réactiver le bouton modifier
        }

        private void prixVenteProduittxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void libelleProduitTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void categorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProduits.SelectedItem == null) return;

            ProduitBO produit = (ProduitBO)comboProduits.SelectedItem;

            libelleProduitTxt.Text = produit.LibelleProduit;
            prixVenteProduittxt.Text = produit.PrixVenteProduit.ToString();
            categorieComboBox.SelectedValue = produit.CategorieProduit.IdCategorie;

            SetTextBoxesEnabled(false);
            btnModif.Enabled = true;           // Permet d’activer la modification
            modifierProduitbtn.Enabled = false; // Désactive la validation au départ
        }
        private void SetTextBoxesEnabled(bool enabled)
        {
            libelleProduitTxt.Enabled = enabled;
            prixVenteProduittxt.Enabled = enabled;
            categorieComboBox.Enabled = enabled;
        }

        private void ClearTextBoxes()
        {
            libelleProduitTxt.Clear();
            prixVenteProduittxt.Clear();
            categorieComboBox.SelectedIndex = -1;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            // Activer les champs pour modification
            SetTextBoxesEnabled(true);
            modifierProduitbtn.Enabled = true; // Activer le bouton valider
            btnModif.Enabled = false;          // Désactiver le bouton modifier
        }
    }
}
