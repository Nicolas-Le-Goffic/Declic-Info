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
                categorieComboBox.Items.Add(categorie.getIdCategorie());
            }
        }

        private void ajoutProduitbtn_Click(object sender, EventArgs e)
        {
            float.TryParse(prixVenteProduittxt.Text, out float prixVenteProduit);
            int.TryParse(categorieComboBox.Text, out int idCategorie);
            List<CategorieBO> Categorie = GestionCategories.GetCategorie(idCategorie);

            // Création de l'objet Utilisateur avec le nom récupérer dans la GUI
            ProduitBO prod = new ProduitBO(libelleProduitTxt.Text, prixVenteProduit, Categorie[0]);

            // Appel de la méthode CreerUtilisateur de la couche BLL
            GestionProduits.CreerProduit(prod);

            // Boite de dialogue qui confirme l'enregistrement en BD
            MessageBox.Show("Enregistrement effectué !", "Saisie");

            // Effacement de la valeur saisie après confirmation de l'enregristrement
            libelleProduitTxt.Clear();
        }

        private void ajoutProduitbdd_Load(object sender, EventArgs e)
        {

        }
    }
}
