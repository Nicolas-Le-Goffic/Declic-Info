using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Declic_InfoBO; // Référence la couche BO
using Declic_InfoDAL; // Référence la couche DAL

namespace Declic_InfoBLL
{
    public class GestionCategories
    {
        private static GestionCategories uneGestionCategories; // objet BLL

        // Accesseur en lecture
        public static GestionCategories GetGestionCategories()
        {
            if (uneGestionCategories == null)
            {
                uneGestionCategories = new GestionCategories();
            }
            return uneGestionCategories;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<CategorieBO> GetCategories()
        {
            return CategorieDAO.GetCategories();
        }
        public static List<CategorieBO> GetCategorie(int unIdCategorie)
        {
            return CategorieDAO.GetCategorie(unIdCategorie);
        }
    }
}
