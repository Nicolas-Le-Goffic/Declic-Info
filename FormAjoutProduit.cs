using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Declic_InfoBLL;
using Declic_InfoBO;
using System.Configuration;

namespace Declic_Info
{
    public partial class ajoutProduitbdd : Form
    {
        public ajoutProduitbdd()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionCategories.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"]);


            List<CategorieBO> listeCategories = GestionCategories.GetCategories();
            foreach (CategorieBO categorie in listeCategories)
            {
                categorieComboBox.Items.Add(categorie);
            }
        }

        private void ajoutProduitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (libelleProduitTxt.Text == "")
                {
                    MessageBox.Show("Vous devez saisir un libellé de produit !");
                    return;
                }

                //Verification qu'il y a une catégorie séléctionnée
                if (categorieComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Vous devez saisir une catégorie !");
                    return;
                }

                // Conversion sécurisée du prix
                if (!decimal.TryParse(prixVenteProduittxt.Text, out decimal prix) || prixVenteProduittxt.Text == "")
                {
                    MessageBox.Show("Le prix doit être un nombre valide !");
                    return;
                }
                CategorieBO categorie = (CategorieBO)categorieComboBox.SelectedItem;
                float.TryParse(prixVenteProduittxt.Text, out float prixVenteProduit);
                List<CategorieBO> Categorie = GestionCategories.GetCategorie(categorie.IdCategorie);

                // Création de l'objet Utilisateur avec le nom récupérer dans la GUI
                ProduitBO prod = new ProduitBO(libelleProduitTxt.Text, prixVenteProduit, Categorie[0]);

                // Appel de la méthode CreerUtilisateur de la couche BLL
                GestionProduits.CreerProduit(prod);

                // Boite de dialogue qui confirme l'enregistrement en BD
                MessageBox.Show("Enregistrement effectué !", "Saisie");

                // Effacement de la valeur saisie après confirmation de l'enregristrement
                libelleProduitTxt.Clear();
                prixVenteProduittxt.Clear();
                categorieComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void categorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void prixVenteProduittxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void ajoutProduitbdd_Load(object sender, EventArgs e)
        {

        }
    }
}
