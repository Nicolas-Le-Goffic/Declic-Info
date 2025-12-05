using Declic_InfoBO; // Référence la couche BO
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;


namespace Declic_InfoDAL
{
    public class ProduitDAO
    {
        private static ProduitDAO unProduitDAO;

        // Accesseur en lecture, renvoi une instance
        public static ProduitDAO GetunProduitDAO()
        {
            if (unProduitDAO == null)
            {
                unProduitDAO = new ProduitDAO();
            }
            return unProduitDAO;
        }

        // Cette méthode insert un nouveeau produit passé en paramètre dans la BD
        public static int AjoutProduit(ProduitBO unProduit)
        {
            int nbEnr;
            string libelleProduit = unProduit.LibelleProduit;
            float prixVente = unProduit.PrixVenteProduit;
            int idCategorie = unProduit.CategorieProduit.IdCategorie;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Produit (libelle_produit, prix_vente_produit, id_categorie) values(@libelle, @prix, @categorie)";
            cmd.Parameters.AddWithValue("@libelle", libelleProduit);
            cmd.Parameters.AddWithValue("@prix", prixVente);
            cmd.Parameters.AddWithValue("@categorie", idCategorie);

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        public List<ProduitBO> GetProduits()
        {
            List<ProduitBO> lesProduits = new List<ProduitBO>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"
                SELECT p.*, c.nom_categorie
                FROM Produit p
                INNER JOIN Categorie c ON p.id_categorie = c.id_categorie";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                int code_produit = Int32.Parse(monReader["code_produit"].ToString());
                string libelle_produit = monReader["libelle_produit"].ToString();
                float prix_vente_produit = float.Parse(monReader["prix_vente_produit"].ToString());
                int id_categorie = Int32.Parse(monReader["id_categorie"].ToString());
                string nom_categorie = monReader["nom_categorie"].ToString();
                CategorieBO categorieProduit = new CategorieBO(id_categorie, nom_categorie);

                ProduitBO unProduit = new ProduitBO(code_produit, libelle_produit, prix_vente_produit, categorieProduit);

                lesProduits.Add(unProduit);
            }
            

            // Fermeture de la connexion
            maConnexion.Close();

            return lesProduits;

            
        }
            //Methode supprimer un produit
            public static void SupprimerProduit(int id)
            {
                // Connexion à la BD
                SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;
                cmd.CommandText = "DELETE FROM Produit WHERE code_produit = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery(); // exécute la suppression

                // Fermeture de la connexion
                maConnexion.Close();
            }


            // Cette méthode modifie un utilisateur passé en paramètre dans la BD
            public static int ModificationProduit(ProduitBO unProduit)
            {
                int nbEnr;

            // Connexion à la BD

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;
                cmd.CommandText = @"UPDATE Produit
                        SET libelle_produit = @libelle,
                            prix_vente_produit = @prix,
                            id_categorie = @categorie
                        WHERE code_produit = @id";

                cmd.Parameters.AddWithValue("@libelle", unProduit.LibelleProduit);
                cmd.Parameters.AddWithValue("@prix", unProduit.PrixVenteProduit);
                cmd.Parameters.AddWithValue("@categorie", unProduit.CategorieProduit.IdCategorie);
                cmd.Parameters.AddWithValue("@id", unProduit.CodeProduit);

                nbEnr = cmd.ExecuteNonQuery();

                maConnexion.Close();

                return nbEnr;
        }
    }
}