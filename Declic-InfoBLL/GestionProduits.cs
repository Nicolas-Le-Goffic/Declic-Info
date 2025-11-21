using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Declic_InfoBO; // Référence la couche BO
using Declic_InfoDAL; // Référence la couche DAL

namespace Declic_InfoBLL
{
    public class GestionProduits
    {
        private static GestionProduits uneGestionProduits; // objet BLL

        // Accesseur en lecture
        public static GestionProduits GetGestionProduits()
        {
            if (uneGestionProduits == null)
            {
                uneGestionProduits = new GestionProduits();
            }
            return uneGestionProduits;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoi l'objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerProduit(ProduitBO ut)
        {
            return ProduitDAO.AjoutProduit(ut);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetProduits() de la DAL
        public static List<ProduitBO> GetProduits()
        {
            return ProduitDAO.GetunProduitDAO().GetProduits();
        }
    }
}
