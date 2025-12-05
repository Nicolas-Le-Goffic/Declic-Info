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
using Declic_InfoBLL;
using Declic_InfoBO;


namespace Declic_Info
{
    public partial class FormSuppressionProduit : Form
    {
        public FormSuppressionProduit()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionProduits.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"]);

            // Charger la liste des produits dans la ComboBox
            List<ProduitBO> listeProduits = GestionProduits.GetProduits();
            foreach (ProduitBO produit in listeProduits)
            {
                produitComboBox.Items.Add(produit);
            }
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier qu'un produit est sélectionné
                if (produitComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Vous devez sélectionner un produit !");
                    return;
                }

                ProduitBO produit = (ProduitBO)produitComboBox.SelectedItem;

                // Appel à la BLL pour suppression
                GestionProduits.SupprimerProduit(produit.CodeProduit);

                MessageBox.Show("Le produit a été supprimé avec succès !");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void produitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
