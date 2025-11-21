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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"].ConnectionString);

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string mdp = txtMdp.Text;

            Utilisateur unUtilisateur = new Utilisateur(login, mdp);
            bool connexionOK = GestionUtilisateurs.VerifUtilisateur(unUtilisateur);

            if (string.IsNullOrWhiteSpace(unUtilisateur.Mdp) && string.IsNullOrWhiteSpace(unUtilisateur.Login))
            {
                MessageBox.Show("Aucun champ ne doit être vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(unUtilisateur.Login))
            {
                MessageBox.Show("Veuillez renseigner un login", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(unUtilisateur.Mdp))
            {
                MessageBox.Show("Veuillez renseigner un mot de passe !");
                return;
            }

            

            if (connexionOK)
            {
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ouvre le formulaire principal
                FrmModificationClients frm = new FrmModificationClients();
                frm.Show();

                this.Hide(); // Cache la fenêtre login
            }

            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
