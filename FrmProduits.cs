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

namespace Declic_Info
{
    public partial class FrmProduits : Form
    {
        public FrmProduits()
        {
            InitializeComponent();
            this.Load += FrmProduits_Load;


        }

        private void FrmProduits_Load(object sender, EventArgs e)
        {
            var liste = GestionProduits.GetProduits();

            dgvProduits.DataSource = liste;

            dgvProduits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmProduits_Load_1(object sender, EventArgs e)
        {
            var liste = GestionProduits.GetProduits();

            dgvProduits.DataSource = liste;

            dgvProduits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtvProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
