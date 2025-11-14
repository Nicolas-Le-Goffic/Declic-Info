using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Declic_InfoBO;
using Declic_InfoDAL;

namespace Declic_InfoBLL
{
    public class ProduitBLL
    {
        private ProduitDAL produitDal = new ProduitDAL();

        public void ModifierProduit(Produit produit)
        {
            if (produit == null) throw new ArgumentNullException("produit");
            if (string.IsNullOrWhiteSpace(produit.getLibelle())) throw new ArgumentException("Libellé obligatoire");
            if (produit.getCategorie() <= 0) throw new ArgumentException("Catégorie obligatoire");
            if (produit.getPrix() < 0) throw new ArgumentException("Prix doit être positif");

            produitDal.UpdateProduit(produit);
        }

        public void SupprimerProduit(int id)
        {
            if (id <= 0) throw new ArgumentException("Id invalide");
            produitDal.DeleteProduit(id);
        }

        public Produit ObtenirProduit(int id)
        {
            return produitDal.GetProduitById(id);
        }
    }
}