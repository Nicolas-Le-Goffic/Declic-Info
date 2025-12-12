using System;
using System.Collections.Generic;
using System.Linq;

namespace Declic_InfoBO
{
    public class DevisBO
    {
        private int idDevis;
        private DateTime dateDevis;
        private float tauxTVA;
        private float tauxRemiseGlobale;
        private ClientBO client;
        private StatutBO statut;

        // Constructeur complet
        public DevisBO(int idDevis, DateTime dateDevis, float tauxTVA,
                       float tauxRemiseGlobale, ClientBO client, StatutBO statut)
        {
            this.idDevis = idDevis;
            this.dateDevis = dateDevis;
            this.tauxTVA = tauxTVA;
            this.tauxRemiseGlobale = tauxRemiseGlobale;
            this.client = client;
            this.statut = statut;
        }

        // Constructeur sans ID
        public DevisBO(DateTime dateDevis, float tauxTVA, float tauxRemiseGlobale, ClientBO client, StatutBO statut)
        {
            this.dateDevis = dateDevis;
            this.tauxTVA = tauxTVA;
            this.tauxRemiseGlobale = tauxRemiseGlobale;
            this.client = client;
            this.statut = statut;
        }
        public DevisBO()
        {
        }

        public List<ContenirCalculs> Lignes { get; set; } = new List<ContenirCalculs>();

        public decimal TotalHTHorsRemise => Lignes.Sum(l => l.SousTotalHT);
        public decimal TotalRemiseLignes => Lignes.Sum(l => l.MontantRemiseHT);
        public decimal TotalHTApresRemisesLignes => Lignes.Sum(l => l.TotalLigneHT);

        public decimal RemiseGlobaleHT
            => TotalHTApresRemisesLignes * ((decimal)tauxRemiseGlobale / 100m);

        public decimal TotalHTFinal
            => TotalHTApresRemisesLignes - RemiseGlobaleHT;

        public decimal MontantTVA
            => TotalHTFinal * ((decimal)tauxTVA / 100m);

        public decimal TotalTTC
            => TotalHTFinal + MontantTVA;

        // Montant stocké dans la colonne montant_HT_hors_remis_devise
        public float MontantHtHorsRemise
        {
            get => (float)TotalHTApresRemisesLignes;
            set { /* setter présent si tu veux l'assigner depuis la BDD */ }
        }

        public int IdDevis
        {
            get => idDevis;
            set => idDevis = value;
        }

        public DateTime DateDevis
        {
            get => dateDevis;
            set => dateDevis = value;
        }

        public float TauxTVADevis
        {
            get => tauxTVA;
            set => tauxTVA = value;
        }

        public float TauxRemiseGloDevis
        {
            get => tauxRemiseGlobale;
            set => tauxRemiseGlobale = value;
        }

        public ClientBO DevisClient
        {
            get => client;
            set => client = value;
        }

        public StatutBO DevisStatut
        {
            get => statut;
            set => statut = value;
        }

        public override string ToString()
        {
            return $"{idDevis}";
        }
    }
}
