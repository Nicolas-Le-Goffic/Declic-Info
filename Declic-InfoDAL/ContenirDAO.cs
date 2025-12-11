using System.Data.SqlClient;
using Declic_InfoBO;

namespace Declic_InfoDAL
{
    public class ContenirDAO
    {
        public static void InsererLigne(ContenirBO ligne, int idDevis)
        {
            using (var cnx = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = cnx;
                cmd.CommandText = @"
            INSERT INTO Contenir (id_devis, code_produit, quantite, pourcentage_remise_ligne)
            VALUES (@idDevis, @codeProduit, @qte, @remise);";

                cmd.Parameters.AddWithValue("@idDevis", idDevis);
                cmd.Parameters.AddWithValue("@codeProduit", ligne.CodeProduit);  
                cmd.Parameters.AddWithValue("@qte", ligne.Quantite);
                cmd.Parameters.AddWithValue("@remise", ligne.Pourcentage_remise_ligne);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
