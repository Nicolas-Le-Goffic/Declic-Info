using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Declic_InfoBO;
using Declic_InfoDAL;

namespace Declic_InfoBLL
{
    public class GestionStatut
    {
        private static GestionStatut uneGestionStatut;

        public static GestionStatut GetGestionStatut()
        {
            if (uneGestionStatut == null)
            { 
                uneGestionStatut = new GestionStatut();
            }
            return uneGestionStatut;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Récupérer tous les statuts
        public List<StatutBO> GetStatuts()
        {
            return StatutDAO.GetStatuts();
        }

        // Récupérer un statut par ID
        /*
        public static List<StatutBO> GetStatut(int unIdStatut)
        {
            return StatutDAO.GetStatut(unIdStatut);
        }
        */
        public static StatutBO GetStatut(int unIdStatut)
        {
            return StatutDAO.GetStatut(unIdStatut);
        }




    }
}
