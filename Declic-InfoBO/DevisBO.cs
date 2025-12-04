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
        private float tauxTVADevis;
        private float tauxRemiseGloDevis;
        private float montantHtHorsRemisDevise;
        private ClientBO devisClient;
        private StatutBO devisStatut;

        public DevisBO(int idDevis, DateTime dateDevis, float tauxTVADevis, float tauxRemiseGloDevis, float montantHtHorsRemisDevise, ClientBO devisClient, StatutBO devisStatut)
        {
            this.idDevis = idDevis;
            this.dateDevis = dateDevis;
            this.tauxTVADevis = tauxTVADevis;
            this.tauxRemiseGloDevis = tauxRemiseGloDevis;
            this.montantHtHorsRemisDevise = montantHtHorsRemisDevise;
            this.devisClient = devisClient;
            this.devisStatut = devisStatut;
        }


        public DevisBO(DateTime dateDevis, float tauxTVADevis, float tauxRemiseGloDevis, float montantHtHorsRemisDevise, ClientBO devisClient, StatutBO devisStatut)
        {
            this.dateDevis = dateDevis;
            this.tauxTVADevis = tauxTVADevis;
            this.tauxRemiseGloDevis = tauxRemiseGloDevis;
            this.montantHtHorsRemisDevise = montantHtHorsRemisDevise;
            this.devisClient = devisClient;
            this.devisStatut = devisStatut;
        }
        public DevisBO()
        {

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
            get => tauxTVADevis;
            set => tauxTVADevis = value;
        }

        public float TauxRemiseGloDevis
        {
            get => tauxRemiseGloDevis;
            set => tauxRemiseGloDevis = value;
        }

        public float MontantHtHorsRemisDevise
        {
            get => montantHtHorsRemisDevise;
            set => montantHtHorsRemisDevise = value;
        }

        public ClientBO DevisClient
        {
            get => devisClient;
            set => devisClient = value;
        }

        public StatutBO DevisStatut
        {
            get => devisStatut;
            set => devisStatut = value;
        }
    }
}