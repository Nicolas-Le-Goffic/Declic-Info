using System;

namespace Declic_InfoBO
{
    public class Utilisateur
    {
        // Attributs privés
        private string login;
        private string mdp;

        // Constructeur
        public Utilisateur(string login, string mdp) 
        { 
            this.login = login;
            this.mdp = mdp;
        }

        // Propriétés 
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Mdp
        {
            get { return mdp; }
            set { mdp = value; }
        }

    }
}
