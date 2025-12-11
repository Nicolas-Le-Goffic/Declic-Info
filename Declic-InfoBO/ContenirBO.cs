using System;

namespace Declic_InfoBO
{
    public class ContenirBO
    {
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
