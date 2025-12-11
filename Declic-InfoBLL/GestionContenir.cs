using Declic_InfoBO;
using Declic_InfoDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoBLL
{
    public class GestionContenir
    {
        private static GestionContenir uneGestionContenir;

        public static GestionContenir GetGestionDevis()
        {
            if (uneGestionContenir == null)
            {
                uneGestionContenir = new GestionContenir();
            }
            return uneGestionContenir;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoi l'objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL

        public static int AjoutContenir(ContenirBO unContenir)
        {
            return ContenirDAO.AjoutContenir(unContenir);
        }
        public static int ModifContenir(ContenirBO unContenir)
        {
            return ContenirDAO.ModifContenir(unContenir);
        }
        public static bool SupContenir(int idDevis, int codeProduit)
        {
            return ContenirDAO.SupContenir(idDevis, codeProduit);
        }
        public static List<ContenirBO> SelectDevisContenir(DevisBO devis)
        {
            return ContenirDAO.SelectDevisContenir(devis);
        }
        public static List<ProduitBO> SelectProduitsSansDevis(DevisBO devis)
        {
            return ContenirDAO.SelectProduitsSansDevis(devis);
        }
    }
}
