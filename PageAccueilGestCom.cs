using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Declic_Info
{
    public partial class PageAccueilGestCom : Form
    {
        public PageAccueilGestCom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmProduits frm = new FrmProduits();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ajoutProduitbdd form = new ajoutProduitbdd();
            form.ShowDialog();
        }
    }
}
