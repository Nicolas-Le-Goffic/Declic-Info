using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            bool existe=false;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = cmd.CommandText = "SELECT * FROM Utilisateur WHERE nom_utilisateur =  " + login + "AND mot_de_passe_utilisateur = " + mdp;
            SqlDataReader monReader = cmd.ExecuteReader();


            int nbUtilisateur = (int)cmd.ExecuteScalar();
            if (nbUtilisateur == 1)
            {
                existe = true;
            }

            return existe;


            // Fermeture de la connexion
            maConnexion.Close();

        }


    }
}

