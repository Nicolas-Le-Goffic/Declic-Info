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
    public partial class FormSuppressionDevis : Form
    {
        public FormSuppressionDevis()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionCategories.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"]);

            List<DevisBO> listeDevis = GestionDevis.GetDevis();
            foreach (DevisBO devis in listeDevis)
            {
                devisCombobox.Items.Add(devis);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            try
            {

                //Verification qu'il y a une catégorie séléctionnée
                if (devisCombobox.SelectedItem == null)
                {
                    MessageBox.Show("Vous devez saisir un devis !");
                    return;
                }
                var confirm = MessageBox.Show("Voulez-vous vraiment supprimer ce devis ?",
                              "Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    DevisBO Devis = (DevisBO)devisCombobox.SelectedItem;
                    bool verifSupClient = GestionDevis.SupprimerDevis(Devis.IdDevis);
                    MessageBox.Show("Le Devis a été supprimé !");
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
