using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoBO
{
    public class ProduitBO
    {
        public int CodeProduit { get; set; }
        public string LibelleProduit { get; set; }
        public float PrixVenteProduit { get; set; }
        public CategorieBO CategorieProduit { get; set; }

        public ProduitBO(int codeProduit, string libelleProduit,
                         float prixVenteProduit, CategorieBO categorieProduit)
        {
            CodeProduit = codeProduit;
            LibelleProduit = libelleProduit;
            PrixVenteProduit = prixVenteProduit;
            CategorieProduit = categorieProduit;
        }

        public ProduitBO(string libelleProduit, float prixVenteProduit,
                         CategorieBO categorieProduit)
        {
            LibelleProduit = libelleProduit;
            PrixVenteProduit = prixVenteProduit;
            CategorieProduit = categorieProduit;
        }

        public override string ToString()
        {
            return $"{LibelleProduit} (#{CodeProduit})";
        }
    }
}
