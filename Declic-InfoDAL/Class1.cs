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
        //METTRE LA CHAINE DE CONNEXION ENTRE ""
        private string connectionString = "CHAINE_DE_CONNEXION";

        // Modifier un produit existant
        public void UpdateProduit(Produit produit)
        {
            string query = "UPDATE Produits SET Libelle = @Libelle, Categorie = @Categorie, Prix = @Prix WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Libelle", produit.getLibelle());
                cmd.Parameters.AddWithValue("@Categorie", produit.getCategorie());
                cmd.Parameters.AddWithValue("@Prix", produit.getPrix());
                cmd.Parameters.AddWithValue("@Id", produit.getId());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Supprimer un produit
        public void DeleteProduit(int id)
        {
            string query = "DELETE FROM Produits WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //  Récupérer un produit existant
        public Produit GetProduitById(int id)
        {
            Produit produit = null;
            string query = "SELECT * FROM Produits WHERE Id = @Id";

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
                        produit.setId((int)reader["Id"]);
                        produit.setLibelle(reader["Libelle"].ToString());
                        produit.setCategorie(reader["Categorie"].ToString());
                        produit.setPrix((decimal)reader["Prix"]);
                    }
                }
            }

            return produit;
        }
    }
}
