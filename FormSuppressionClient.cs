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
    public partial class FormSuppressionClient : Form
    {
        public FormSuppressionClient()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionCategories.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"]);


            List<ClientBO> listeClients = GestionClients.GetClients();
            foreach (ClientBO client in listeClients)
            {
                clientComboBox.Items.Add(client);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //Verification qu'il y a une catégorie séléctionnée
                if (clientComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Vous devez saisir un client !");
                    return;
                }
                var confirm = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?",
                              "Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    ClientBO client = (ClientBO)clientComboBox.SelectedItem;
                    bool verifSupClient = GestionClients.SupprimerClient(client.CodeClient);
                    if (verifSupClient == false)
                    {
                        MessageBox.Show(
                            "Impossible de supprimer ce client car il a commandé encore un ou plusieurs devis.",
                            "Suppression impossible",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        MessageBox.Show("Le Client a été supprimé !");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
