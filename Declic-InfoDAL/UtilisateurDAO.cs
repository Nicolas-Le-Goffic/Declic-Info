using System;
using System.Data.SqlClient;

namespace Declic_InfoDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;

        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        // Cette méthode vérifie si un utilisateur existe
        public static bool VerifUtilisateur(string login, string mdp)
        {
            bool existe = false;

            // La connexion est automatiquement fermée grâce au using
            using (SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM Utilisateur 
                                                      WHERE nom_utilisateur = @login 
                                                      AND mot_de_passe_utilisateur = @mdp", maConnexion))
            {
                // Ajout des paramètres sécurisés
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@mdp", mdp);

                int nbUtilisateur = (int)cmd.ExecuteScalar();
                existe = (nbUtilisateur == 1);
            }

            return existe;
        }
    }
}
