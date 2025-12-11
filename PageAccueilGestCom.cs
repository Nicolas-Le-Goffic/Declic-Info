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

        private void button3_Click(object sender, EventArgs e)
        {
            FrmModificationClients frm = new FrmModificationClients();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormSuppressionClient frm = new FormSuppressionClient();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormListeClient frm = new FormListeClient();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSuppressionProduit frm = new FormSuppressionProduit();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormModificationProduit frm = new FormModificationProduit();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormListeDevis frm = new FormListeDevis();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormModificationDevis frm = new FormModificationDevis();
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormAjoutClient frm = new FormAjoutClient();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormSuppressionDevis frm = new FormSuppressionDevis();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormAjoutDevis frm = new FormAjoutDevis();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormSynthese frm = new FormSynthese();
            frm.ShowDialog();
        }
    }
}
