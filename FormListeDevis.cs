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
    public partial class FormListeDevis : Form
    {
        public FormListeDevis()
        {
            InitializeComponent();
            this.Load += FormListeDevis_Load;
        }

        private void FormListeDevis_Load(object sender, EventArgs e)
        {
            try
            {
                var liste = GestionDevis.GetDevis();
                dgvDevis.DataSource = liste;
                dgvDevis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des devis : " + ex.Message);
            }
        }
        private void dgvDevis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
