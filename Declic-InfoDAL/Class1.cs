using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Declic_InfoBO;


namespace Declic_InfoDAL
{
    public class ProduitDAL
    {

        private string connectionString = "Data Source=localhost;Initial Catalog=GESTION_COMMERCIALE;Integrated Security=True;TrustServerCertificate=True";

        // Modifier un produit existant
        public void UpdateProduit(Produit produit)
        {
            string query = "UPDATE Produit SET libelle_produit = @Libelle, id_categorie = @Categorie, prix_vente_produit = @Prix WHERE code_produit = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Libelle", produit.getLibelle());
                cmd.Parameters.AddWithValue("@Categorie", produit.getCategorie()); // doit être int
                cmd.Parameters.AddWithValue("@Prix", produit.getPrix());
                cmd.Parameters.AddWithValue("@Id", produit.getId());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Supprimer un produit
        public void DeleteProduit(int id)
        {
            string query = "DELETE FROM Produit WHERE code_produit = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Récupérer un produit existant
        public Produit GetProduitById(int id)
        {
            Produit produit = null;
            string query = "SELECT * FROM Produit WHERE code_produit = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        produit = new Produit();
                        produit.setId(Convert.ToInt32(reader["code_produit"]));
                        produit.setLibelle(reader["libelle_produit"].ToString());
                        produit.setCategorie(Convert.ToInt32(reader["id_categorie"]));
                        produit.setPrix(Convert.ToDecimal(reader["prix_vente_produit"]));
                    }
                }
            }

            return produit;
        }
        public Produit GetProduitAvecNomCategorie(int id, out string nomCategorie)
        {
            Produit produit = null;
            nomCategorie = null;

            string query = @"
                SELECT p.code_produit, p.libelle_produit, p.prix_vente_produit, p.id_categorie, c.nom_categorie
                FROM Produit p
                JOIN Categorie c ON p.id_categorie = c.id_categorie
                WHERE p.code_produit = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        produit = new Produit();
                        produit.setId(Convert.ToInt32(reader["code_produit"]));
                        produit.setLibelle(reader["libelle_produit"].ToString());
                        produit.setCategorie(Convert.ToInt32(reader["id_categorie"]));
                        produit.setPrix(Convert.ToDecimal(reader["prix_vente_produit"]));

                        nomCategorie = reader["nom_categorie"].ToString(); // récupère le nom de la catégorie
                    }
                }
            }

            return produit;
        }

    }
}
