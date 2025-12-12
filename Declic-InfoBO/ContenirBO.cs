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
        private int pourcentage_remise_ligne;

        public ContenirBO(DevisBO devis, ProduitBO produit, int quantite, int pourcentage_remise_ligne) 
        { 
            this.devis = devis;
            this.produit = produit;
            this.quantite = quantite;
            this.pourcentage_remise_ligne = pourcentage_remise_ligne;
        }
        public ContenirBO()
        {
        }
        public DevisBO Devis
        {
            get => devis;
            set => devis = value;
        }
        public ProduitBO Produit
        {
            get => produit;
            set => produit = value;
        }
        public int Quantite
        {
            get => quantite;
            set => quantite = value;
        }
        public int Pourcentage_remise_ligne
        {
            get => pourcentage_remise_ligne;
            set => pourcentage_remise_ligne = value;
        }

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
