using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoBO
{
    public class ContenirBO
    {
        private DevisBO devis;
        private ProduitBO produit;
        private int quantite;
        private decimal pourcentage_remise_ligne;

        public ContenirBO(DevisBO devis, ProduitBO produit, int quantite, decimal pourcentage_remise_ligne) 
        { 
            this.devis = devis;
            this.produit = produit;
            this.quantite = quantite;
            this.pourcentage_remise_ligne = pourcentage_remise_ligne;
        }
        public ContenirBO()
        {
        }
        public DevisBO Devis { get; set; }
        public ProduitBO Produit { get; set; }
        public int CodeProduit { get; set; }
        public int Quantite { get; set; }
        public decimal Pourcentage_remise_ligne { get; set; }

        public string LibelleProduit
            => Produit != null ? Produit.LibelleProduit : "";

        public decimal PrixUnitaireHT
            => Produit != null ? (decimal)Produit.PrixVenteProduit : 0m;

        public decimal SousTotalHT
            => PrixUnitaireHT * Quantite;

        public decimal MontantRemiseHT
            => SousTotalHT * Pourcentage_remise_ligne / 100m;

        public decimal TotalLigneHT
            => SousTotalHT - MontantRemiseHT;
    }
}
