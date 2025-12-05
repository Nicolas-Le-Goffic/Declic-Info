using System.Collections.Generic;
using Declic_InfoBO;
using Declic_InfoDAL;
using System.Configuration;

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
        public static void SetchaineConnexion(string value)
        {
            ConnexionBD.GetConnexionBD().SetchaineConnexion(value);
        }

        // Méthode qui renvoi l'objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerDevis(DevisBO unDevis)
        {
            return DevisDAO.AjoutDevis(unDevis);
        }
      

        public List<DevisBO> GetDevis()
        {
            return DevisDAO.GetDevisDAO().GetDevis();
        }
    }
}
