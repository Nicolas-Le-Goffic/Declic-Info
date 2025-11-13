using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Declic_InfoBO;
using Declic_InfoBLL;

namespace Declic_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        public void ModifierProduit(Produit produit)
        {
            this.txtbxLib.Text = produit.libelle;
            this.txtbxCat.Text = produit.categorie;
            this.txtbxPrix.Text = produit.prix.ToString("F2") + " €";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCat_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnRevenir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void txtbxLib_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
