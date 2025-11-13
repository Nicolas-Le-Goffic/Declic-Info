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

namespace Declic_Info
{
    public partial class FrmModifierSupprimerProduit : Form
    {
        private ProduitBLL produitBLL;
        private Produit produitSelectionne;



        public FrmModifierSupprimerProduit()
        {
            InitializeComponent();
            produitBLL = new ProduitBLL();
        }

        //Constructeur surcharge pour passer le produit à modifier/supprimer
        public FrmModifierSupprimerProduit(Produit produit) : this()
        {
            produitSelectionne = produit;
            // On pré-remplit les champs
            txtLibelle.Text = produit.getLibelle();
            txtCategorie.Text = produit.getCategorie();
            txtPrix.Text = produit.getPrix().ToString();
        }

        private void lblLibelle_Click(object sender, EventArgs e)
        {
         
        }

        //Bouton modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (produitSelectionne == null)
                {
                    MessageBox.Show("Aucun produit sélectionné !");
                    return;
                }

                produitSelectionne.setLibelle(txtLibelle.Text);
                produitSelectionne.setCategorie(txtCategorie.Text);
                produitSelectionne.setPrix(decimal.Parse(txtPrix.Text));

                produitBLL.ModifierProduit(produitSelectionne);
                MessageBox.Show("Produit modifié avec succès !");
                this.Close(); // ferme la fenêtre
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void txtLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (produitSelectionne == null)
                {
                    MessageBox.Show("Aucun produit sélectionné !");
                    return;
                }

                var confirm = MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?",
                                              "Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    produitBLL.SupprimerProduit(produitSelectionne.getId());
                    MessageBox.Show("Produit supprimé !");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
