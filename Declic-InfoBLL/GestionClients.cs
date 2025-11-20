using Declic_InfoBO; // Référence la couche BO
using Declic_InfoDAL; // Référence la couche DAL
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<ClientBO> GetInfosClients()
        {
            return ClientDAO.GetInfosClients();
        }
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
    }
}
