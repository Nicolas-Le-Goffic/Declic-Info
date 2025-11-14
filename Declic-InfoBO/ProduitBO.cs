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
        public int getCodeProduit() 
        {
            return codeProduit; 
        }
        public string getLibelleProduit() 
        { 
            return libelleProduit; 
        }
        public float getPrixVenteProduit()
        {
            return prixVenteProduit;
        }
        public CategorieBO getCategorieProduit()
        { 
            return categorieProduit;
        }
        public void setCodeProduit(int codeProduit)
        {
            this.codeProduit = codeProduit;
        }
        public void setLibelleProduit (string libelleProduit)
        {
            this.libelleProduit = libelleProduit;
        }
        public void setPrixVenteProduit (float prixVenteProduit)
        {
            this.prixVenteProduit = prixVenteProduit;
        }
        public void setCategorieProduit (CategorieBO categorieProduit)
        {
            this.categorieProduit = categorieProduit;
        }
    }
}
