using Declic_InfoDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Declic_InfoBO; // Référence la couche BO


namespace Declic_InfoDAL
{
    public class CategorieDAO
    {
        private static CategorieDAO uneCategorieDAO;

        // Accesseur en lecture, renvoi une instance
        public static CategorieDAO GetuneCategorieDAO()
        {
            if (uneCategorieDAO == null)
            {
                uneCategorieDAO = new CategorieDAO();
            }
            return uneCategorieDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<CategorieBO> GetCategories()
        {
            int idCategorie;
            string nomCategorie;
            CategorieBO uneCategorie;

            // Connexion à la BD

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<CategorieBO> lesCategories = new List<CategorieBO>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Categorie";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idCategorie = Int32.Parse(monReader["id_categorie"].ToString());
                if (monReader["nom_categorie"] == DBNull.Value)
                {
                    nomCategorie = default(string);
                }
                else
                {
                    nomCategorie = monReader["nom_categorie"].ToString();
                }

                uneCategorie = new CategorieBO(idCategorie, nomCategorie);
                lesCategories.Add(uneCategorie);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesCategories;
        }
        public static List<CategorieBO> GetCategorie(int idUneCategorie)
        {
            int idCategorie;
            string nomCategorie;
            CategorieBO uneCategorie;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<CategorieBO> lesCategories = new List<CategorieBO>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Categorie WHERE id_categorie = @idCategorie";
            cmd.Parameters.AddWithValue("@idCategorie", idUneCategorie);

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idCategorie = Int32.Parse(monReader["id_categorie"].ToString());
                if (monReader["nom_categorie"] == DBNull.Value)
                {
                    nomCategorie = default(string);
                }
                else
                {
                    nomCategorie = monReader["nom_categorie"].ToString();
                }

                uneCategorie = new CategorieBO(idCategorie, nomCategorie);
                lesCategories.Add(uneCategorie);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesCategories;
        }
    }
}
