using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoBO
{
    public class ContenirCalculs : ContenirBO
    {
        public int CodeProduit { get; set; }
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
