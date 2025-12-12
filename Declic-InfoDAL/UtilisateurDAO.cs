using System;
using System.Data.SqlClient;
using Declic_InfoBO;

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
        public static bool VerifUtilisateur(Utilisateur unUtilisateur)
        {
            string requete = @"SELECT COUNT(*) FROM Utilisateur
                       WHERE nom_utilisateur = @login
                       AND mot_de_passe_utilisateur = @mdp";

            using (SqlConnection maConnexion = ConnexionBD.GetSqlConnexion())
            {
                maConnexion.Open();

                using (SqlCommand cmd = new SqlCommand(requete, maConnexion))
                {
                    cmd.Parameters.AddWithValue("@login", unUtilisateur.Login);
                    cmd.Parameters.AddWithValue("@mdp", unUtilisateur.Mdp);

                    int nb = (int)cmd.ExecuteScalar();
                    return nb > 0;
                }
            }
        }
    }
}
