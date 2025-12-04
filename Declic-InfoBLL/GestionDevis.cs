using System.Collections.Generic;
using Declic_InfoBO;
using Declic_InfoDAL;
using System.Configuration;

namespace Declic_InfoBLL
{
    public class GestionDevis
    {
        private static GestionDevis uneGestionDevis;

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

        public List<DevisBO> GetDevis()
        {
            return DevisDAO.GetDevisDAO().GetDevis();
        }

        private static GestionProduits uneGestionProduits; // objet BLL

       
    }
}
