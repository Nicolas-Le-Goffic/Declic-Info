using Declic_InfoBLL;
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
    public partial class FormListeClient : Form
    {
        public FormListeClient()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionCategories.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"]);

        }

        private void FormListeClient_Load(object sender, EventArgs e)
        {
            var liste = GestionClients.GetInfosClients();

            dgvClients.DataSource = liste;

            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
