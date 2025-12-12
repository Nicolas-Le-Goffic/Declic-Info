using Declic_InfoBO;// Référence la couche BO
using Declic_InfoDAL;// Référence la couche DAL
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;



namespace Declic_InfoBLL
{
    public class GestionDevis
    {
        private static GestionDevis uneGestionDevis;// objet BLL
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

        public static void SetchaineConnexion(string value)
        {
            ConnexionBD.GetConnexionBD().SetchaineConnexion(value);
        }

        public static int CreerDevis(DevisBO unDevis)
        {
            return DevisDAO.AjoutDevis(unDevis);
        }

        // Méthode utilitaire pour supprimer les lignes d'un devis
        public static void SupprimerLignesDevis(int idDevis)
        {
            DevisDAO.SupprimerLignesDevis(idDevis);
        }





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
