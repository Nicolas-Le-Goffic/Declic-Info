using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoBO
{
    public class ProduitBO
    {
        private int codeProduit;
        private string libelleProduit;
        private float prixVenteProduit;
        private CategorieBO categorieProduit;

        public ProduitBO(int codeProduit, string libelleProduit, float prixVenteProduit, CategorieBO categorieProduit)
        {
            this.codeProduit = codeProduit;
            this.libelleProduit = libelleProduit;
            this.prixVenteProduit = prixVenteProduit;
            this.categorieProduit = categorieProduit;
        }
        public ProduitBO(string libelleProduit, float prixVenteProduit, CategorieBO categorieProduit)
        {
            this.libelleProduit = libelleProduit;
            this.prixVenteProduit = prixVenteProduit;
            this.categorieProduit = categorieProduit;
        }
        public int CodeProduit
        {
            get => codeProduit;
            set => codeProduit = value;
        }
        public string LibelleProduit
        {
            get => libelleProduit;
            set => libelleProduit = value;
        }
        public float PrixVenteProduit
        {
            get => prixVenteProduit;
            set => prixVenteProduit = value;
        }
        public CategorieBO CategorieProduit
        {
            get => categorieProduit;
            set => categorieProduit = value;
        }
        public override string ToString()
        {
            return $"{LibelleProduit} (#{CodeProduit})";
        }

    }
}
