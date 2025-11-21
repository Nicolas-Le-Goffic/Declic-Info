
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoBO
{
    public class ClientBO
    {
        private int codeClient;
        private string nomClient;
        private int numTelClient;
        private int numFaxClient;
        private string emailClient;
        private int numAdrFactClient;
        private string rueAdrFactClient;
        private string villeAdrFactClient;
        private int cpAdrFactClient;
        private int numAdrLivClient;
        private string rueAdrLivClient;
        private string villeAdrLivClient;
        private int cpAdrLivClient;


        public ClientBO(int codeClient, string nomClient, int numTelClient, int numFaxClient, string emailClient, int numAdrFactClient, string rueAdrFactClient, string villeAdrFactClient, int cpAdrFactClient, int numAdrLivClient, string rueAdrLivClient, string villeAdrLivClient, int cpAdrLivClient)
        {
            this.codeClient = codeClient;
            this.nomClient = nomClient;
            this.numTelClient = numTelClient;
            this.numFaxClient = numFaxClient;
            this.emailClient = emailClient;
            this.numAdrFactClient = numAdrFactClient;
            this.rueAdrFactClient = rueAdrFactClient;
            this.villeAdrFactClient = villeAdrFactClient;
            this.cpAdrFactClient = cpAdrFactClient;
            this.numAdrLivClient = numAdrLivClient;
            this.rueAdrLivClient = rueAdrLivClient;
            this.villeAdrLivClient = villeAdrLivClient;
            this.cpAdrLivClient = cpAdrLivClient;
        }
        public ClientBO(string nomClient, int numTelClient, int numFaxClient, string emailClient, int numAdrFactClient, string rueAdrFactClient, string villeAdrFactClient, int cpAdrFactClient, int numAdrLivClient, string rueAdrLivClient, string villeAdrLivClient, int cpAdrLivClient)
        {
            this.nomClient = nomClient;
            this.numTelClient = numTelClient;
            this.numFaxClient = numFaxClient;
            this.emailClient = emailClient;
            this.numAdrFactClient = numAdrFactClient;
            this.rueAdrFactClient = rueAdrFactClient;
            this.villeAdrFactClient = villeAdrFactClient;
            this.cpAdrFactClient = cpAdrFactClient;
            this.numAdrLivClient = numAdrLivClient;
            this.rueAdrLivClient = rueAdrLivClient;
            this.villeAdrLivClient = villeAdrLivClient;
            this.cpAdrLivClient = cpAdrLivClient;
        }
        public ClientBO(int codeClient, string nomClient)
        {
            this.codeClient = codeClient;
            this.nomClient = nomClient;
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
        public int NumTelClient
        {
            get => numTelClient;
            set => numTelClient = value;
        }
        public int NumFaxClient
        {
            get => numFaxClient;
            set => numFaxClient = value;
        }
        public string EmailClient
        {
            get => emailClient;
            set => emailClient = value;
        }
        public int NumAdrFactClient
        {
            get => numAdrFactClient;
            set => numAdrFactClient = value;
        }
        public string RueAdrFactClient
        {
            get => rueAdrFactClient;
            set => rueAdrFactClient = value;
        }
        public string VilleAdFactClient
        {
            get => villeAdrFactClient;
            set => villeAdrFactClient = value;
        }
        public int CpAdrFactClient
        {
            get => cpAdrFactClient;
            set => cpAdrFactClient = value;
        }
        public int NumAdrLivClient
        {
            get => numAdrLivClient;
            set => numAdrLivClient = value;
        }
        public string RueAdrLivClient
        {
            get => rueAdrLivClient;
            set => rueAdrLivClient = value;
        }
        public string VilleAdrLivClient
        {
            get => villeAdrLivClient;
            set => villeAdrLivClient = value;
        }
        public int CpAdrLivClient
        {
            get => cpAdrLivClient;
            set => cpAdrLivClient = value;
        }
        public override string ToString()
        {
            return nomClient;   // C’est ce qui sera affiché dans la ComboBox
        }
    }
}
