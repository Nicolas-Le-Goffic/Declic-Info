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

namespace Declic_Info
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textMdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string mdp = txtMdp.Text;

            bool connexionOK = GestionUtilisateurs.VerifUtilisateur(login, mdp);

            if (connexionOK)
            {
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ouvre le formulaire principal
                FrmAccueil frm = new FrmAccueil();
                frm.Show();

                this.Hide(); // Cache la fenêtre login
            }
            else
            {
                MessageBox.Show("Identifiants incorrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
