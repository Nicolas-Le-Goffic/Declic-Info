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
        private string connectionString = "TA_CHAINE_DE_CONNEXION";

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


    }
}
