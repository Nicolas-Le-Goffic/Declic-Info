using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Declic_InfoDAL;

namespace Declic_InfoBLL
{
    public class GestionUtilisateurs
    {
            private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

            // Accesseur en lecture
            public static GestionUtilisateurs GetGestionUtilisateurs()
            {
                if (uneGestionUtilisateurs == null)
                {
                    uneGestionUtilisateurs = new GestionUtilisateurs();
                }
                return uneGestionUtilisateurs;
            }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
            {
                string chaine = chset.ConnectionString;
                ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
            }
            // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
            public static bool VerifUtilisateur(string login, string mdp)
            {
                return UtilisateurDAO.VerifUtilisateur(login, mdp);
            }

        }
    }
