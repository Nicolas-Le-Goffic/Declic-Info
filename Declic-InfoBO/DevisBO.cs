using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DevisBO()
        {

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

        public float MontantHtHorsRemisDevise
        {
            get => montantHT;
            set => montantHT = value;
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
    }
}
