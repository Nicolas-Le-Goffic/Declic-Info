<<<<<<< HEAD
﻿using Declic_InfoBO; // Référence la couche BO
using Declic_InfoDAL; // Référence la couche DAL
using System;
=======
﻿using System;
>>>>>>> 020a55c (résolution des conflits)
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
using Declic_InfoBO; // Référence la couche BO
using Declic_InfoDAL; // Référence la couche DAL
>>>>>>> 020a55c (résolution des conflits)

namespace Declic_InfoBLL
{
    public class GestionClients
    {
        private static GestionClients uneGestionClients; // objet BLL

        // Accesseur en lecture
        public static GestionClients GetGestionClients()
        {
            if (uneGestionClients == null)
            {
                uneGestionClients = new GestionClients();
            }
            return uneGestionClients;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

<<<<<<< HEAD
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
=======
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la
        // méthode GetProduits() de la DAL
>>>>>>> 020a55c (résolution des conflits)
        public static List<ClientBO> GetInfosClients()
        {
            return ClientDAO.GetInfosClients();
        }
<<<<<<< HEAD
        public static List<ClientBO> GetClients()
        {
            return ClientDAO.GetClients();
        }
        public static List<ClientBO> GetUnClient(int unIdClient)
        {
            return ClientDAO.GetUnClient(unIdClient);
        }
        public static void SupprimerClient(int idClient)
        {
            ClientDAO.SupprimerClient(idClient);
        }
=======

>>>>>>> 020a55c (résolution des conflits)
        public static int ModificationClient(ClientBO unClient)
        {
            return ClientDAO.ModificationClient(unClient);
        }
<<<<<<< HEAD

    }
}
=======
    }
}

>>>>>>> 020a55c (résolution des conflits)
