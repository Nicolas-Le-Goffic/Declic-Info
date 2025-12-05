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
    public class GestionDevis
    {
        private static GestionDevis uneGestionDevis; // objet BLL

        // Accesseur en lecture
        public static GestionDevis GetGestionDevis()
        {
            if (uneGestionDevis == null)
            {
                uneGestionDevis = new GestionDevis();
            }
            return uneGestionDevis;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<DevisBO> GetDevis()
        {
            return DevisDAO.GetDevis();
        }
        public static DevisBO GetUnDevis(int unIdDevis)
        {
            return DevisDAO.GetUnDevis(unIdDevis);
        }
        public static bool SupprimerDevis(int idDevis)
        {
            return DevisDAO.SupprimerDevis(idDevis);
        }
        public static int ModificationDevis(DevisBO unDevis)
        {
            return DevisDAO.ModificationDevis(unDevis);
        }

    }
}
