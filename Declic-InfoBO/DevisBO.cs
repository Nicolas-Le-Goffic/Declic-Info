using System;
using System.Collections.Generic;

namespace Declic_InfoBO
{
    public class DevisBO
    {
        private int idDevis;
        private DateTime dateDevis;
        private float tauxTVA;
        private float tauxRemiseGlobale;
        private float montantHT;
        private ClientBO client;
        private StatutBO statut;

        private float remiseGlobale;

        // Constructeur complet
        public DevisBO(int idDevis, DateTime dateDevis, float tauxTVA, float tauxRemiseGlobale,
                       float montantHT, ClientBO client, StatutBO statut)
        {
            this.idDevis = idDevis;
            this.dateDevis = dateDevis;
            this.tauxTVA = tauxTVA;
            this.tauxRemiseGlobale = tauxRemiseGlobale;
            this.montantHT = montantHT;
            this.client = client;
            this.statut = statut;
           
        }

        // Constructeur sans ID (pour nouveau devis)
        public DevisBO(DateTime dateDevis, float tauxTVA, float tauxRemiseGlobale,
                       float montantHT, ClientBO client, StatutBO statut)
        {
            this.dateDevis = dateDevis;
            this.tauxTVA = tauxTVA;
            this.tauxRemiseGlobale = tauxRemiseGlobale;
            this.montantHT = montantHT;
            this.client = client;
            this.statut = statut;
            
        }

        

        // Propriétés
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

        public float TauxTVA
        {
            get => tauxTVA;
            set => tauxTVA = value;
        }

        public float TauxRemiseGlobale
        {
            get => tauxRemiseGlobale;
            set => tauxRemiseGlobale = value;
        }

        public float MontantHT
        {
            get => montantHT;
            set => montantHT = value;
        }

        public ClientBO Client
        {
            get => client;
            set => client = value;
        }

        public StatutBO Statut
        {
            get => statut;
            set => statut = value;
        }

        

        public override string ToString()
        {
            return $"Devis #{IdDevis} - {Client?.NomClient} - {DateDevis.ToShortDateString()} - {MontantHT}€ HT - Statut : {Statut?.NomStatut}";
        }


    }
}
