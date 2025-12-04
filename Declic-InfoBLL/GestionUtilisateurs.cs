using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Declic_InfoDAL;
using Declic_InfoBO;
using Declic_InfoBLL;

namespace Declic_InfoBLL
{
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs;  // objet BLL

        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }
<<<<<<< HEAD

            // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
                public static void SetchaineConnexion(string value)
                {
                    ConnexionBD.GetConnexionBD().SetchaineConnexion(value);
                }
                // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode VerifUtilisateurs() de la DAL
                public static bool VerifUtilisateur(Utilisateur unUtilisateur)
                        {
                            return UtilisateurDAO.VerifUtilisateur(unUtilisateur);
                }
=======
            return uneGestionUtilisateurs;
>>>>>>> 020a55c (résolution des conflits)
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de
        // la DAL
        public static void SetchaineConnexion(string value)
        {
            ConnexionBD.GetConnexionBD().SetchaineConnexion(value);
        }
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la
        // méthode VerifUtilisateurs() de la DAL
        public static bool VerifUtilisateur(Utilisateur unUtilisateur)
        {
            return UtilisateurDAO.VerifUtilisateur(unUtilisateur);
        }

    }
}
