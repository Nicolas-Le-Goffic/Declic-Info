using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Declic_InfoBO; // Référence la couche BO
using Declic_InfoDAL; // Référence la couche DAL

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

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la
        // méthode GetProduits() de la DAL
        public static List<ClientBO> GetInfosClients()
        {
            return ClientDAO.GetInfosClients();
        }

        public static int ModificationClient(ClientBO unClient)
        {
            return ClientDAO.ModificationClient(unClient);
        }
    }
}

