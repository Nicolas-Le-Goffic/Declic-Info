using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoBO
{
    public class SyntheseClientBO
    {
        private int codeClient;
        private string nomClient;
        private int nbDevisTotal;
        private int nbDevisAcceptes;
        private int nbDevisRefuses;
        private int nbDevisEnAttente;
        private float pourcentageAcceptes;
        private float pourcentageRefuses;
        private float pourcentageEnAttente;
        private double montantTotalFactureHT;

        
        public SyntheseClientBO(
            int codeClient,
            string nomClient,
            int nbDevisTotal,
            int nbDevisAcceptes,
            int nbDevisRefuses,
            int nbDevisEnAttente,
            double montantTotalFactureHT)
        {
            this.codeClient = codeClient;
            this.nomClient = nomClient;
            this.nbDevisTotal = nbDevisTotal;
            this.nbDevisAcceptes = nbDevisAcceptes;
            this.nbDevisRefuses = nbDevisRefuses;
            this.nbDevisEnAttente = nbDevisEnAttente;
            this.montantTotalFactureHT = montantTotalFactureHT;

            if (nbDevisTotal > 0)
            {
                this.pourcentageAcceptes = (nbDevisAcceptes * 100f) / nbDevisTotal;
                this.pourcentageRefuses = (nbDevisRefuses * 100f) / nbDevisTotal;
                this.pourcentageEnAttente = (nbDevisEnAttente * 100f) / nbDevisTotal;
            }
            else
            {
                this.pourcentageAcceptes = 0;
                this.pourcentageRefuses = 0;
                this.pourcentageEnAttente = 0;
            }
        }


        public int CodeClient
        {
            get => codeClient;
            set => codeClient = value;
        }

        public string NomClient
        {
            get => nomClient;
            set => nomClient = value;
        }

        public int NbDevisTotal
        {
            get => nbDevisTotal;
            set => nbDevisTotal = value;
        }

        public int NbDevisAcceptes
        {
            get => nbDevisAcceptes;
            set => nbDevisAcceptes = value;
        }

        public int NbDevisRefuses
        {
            get => nbDevisRefuses;
            set => nbDevisRefuses = value;
        }

        public int NbDevisEnAttente
        {
            get => nbDevisEnAttente;
            set => nbDevisEnAttente = value;
        }

        public float PourcentageAcceptes
        {
            get => pourcentageAcceptes;
            set => pourcentageAcceptes = value;
        }

        public float PourcentageRefuses
        {
            get => pourcentageRefuses;
            set => pourcentageRefuses = value;
        }

        public float PourcentageEnAttente
        {
            get => pourcentageEnAttente;
            set => pourcentageEnAttente = value;
        }

        public double MontantTotalFactureHT
        {
            get => montantTotalFactureHT;
            set => montantTotalFactureHT = value;
        }
    }
}
