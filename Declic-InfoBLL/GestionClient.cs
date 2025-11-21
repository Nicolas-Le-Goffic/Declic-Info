using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Declic_InfoBLL;
using Declic_InfoBO; // Référence la couche BO
using Declic_InfoDAL; // Référence la couche DAL


namespace Declic_InfoDAO
{
    public class GestionClient
    {
        private static GestionClient uneGestionClient; // objet BLL

        // Accesseur en lecture
        public static GestionClient GetGestionClient()
        {
            if (uneGestionClient == null)
            {
                uneGestionClient = new GestionClient();
            }
            return uneGestionClient;
        }

        private static GestionProduits uneGestionProduits; // objet BLL

        

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

       
        public static int CreerClient(ClientBO client)
        {
            return ClientDAO.AjoutClient(client);
        }
    }
}
