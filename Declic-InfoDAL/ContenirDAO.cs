using Declic_InfoBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoDAL
{
    public class ContenirDAO
    {
        private static ContenirDAO unContenirDAO;

        // Accesseur en lecture, renvoi une instance
        public static ContenirDAO GetunContenirDAO()
        {
            if (unContenirDAO == null)
            {
                unContenirDAO = new ContenirDAO();
            }
            return unContenirDAO;
        }
        public static int AjoutContenir(ContenirBO unContenir)
        {
            int nbEnr;

            // Récupération des valeurs du BO
            DevisBO devis = unContenir.Devis;
            ProduitBO produit = unContenir.Produit;
            int quantite = unContenir.Quantite;
            decimal pourcentage_remise_ligne = unContenir.Pourcentage_remise_ligne;

            // Connexion
            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = maConnexion;

            cmd.CommandText = @"
                INSERT INTO Contenir 
                (id_devis, code_produit, quantite, pourcentage_remise_ligne)
                VALUES
                (@id_devis, @code_produit, @quantite, @pourcentage_remise_ligne)
            ";

            // Paramètres
            cmd.Parameters.AddWithValue("@id_devis", devis);
            cmd.Parameters.AddWithValue("@code_produit", produit);
            cmd.Parameters.AddWithValue("@quantite", quantite);
            cmd.Parameters.AddWithValue("@pourcentage_remise_ligne", pourcentage_remise_ligne);

            // Exécution
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture
            maConnexion.Close();

            return nbEnr;
        }
        public static int ModifContenir(ContenirBO unContenir)
        {
            int nbEnr;

            // Récupération des valeurs du BO
            DevisBO devis = unContenir.Devis;
            ProduitBO produit = unContenir.Produit;
            int quantite = unContenir.Quantite;
            decimal pourcentage_remise_ligne = unContenir.Pourcentage_remise_ligne;

            // Connexion
            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = @"UPDATE contenir
                           SET quantite = @quantite,
                               pourcentage_remise_ligne = @pourcentage_remise_ligne
                           WHERE id_devis = @id_devis
                           AND code_produit = @code_produit";

            // Paramètres
            cmd.Parameters.AddWithValue("@id_devis", devis.IdDevis);
            cmd.Parameters.AddWithValue("@code_produit", produit.CodeProduit);
            cmd.Parameters.AddWithValue("@quantite", quantite);
            cmd.Parameters.AddWithValue("@pourcentage_remise_ligne", pourcentage_remise_ligne);

            // Exécution
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture
            maConnexion.Close();

            return nbEnr;
        }

        public static bool SupContenir(int idDevis, int codeProduit)
        {
            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;

                cmd.CommandText = "DELETE FROM Contenir WHERE id_devis = @idDevis AND code_produit = @codeProduit";
                cmd.Parameters.AddWithValue("@idDevis", idDevis);
                cmd.Parameters.AddWithValue("@codeProduit", codeProduit);

                SqlDataReader monReader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                // Code 547 = violation de contrainte FK
                if (ex.Number == 547)
                {
                    maConnexion.Close();
                    return false;
                }
            }

            return true;
        }
        public static List<ContenirBO> SelectDevisContenir(DevisBO devis)
        {
            List<ContenirBO> listeContenir = new List<ContenirBO>();

            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"SELECT p.*,cat.nom_categorie,c.quantite, c.pourcentage_remise_ligne
                    FROM contenir c
                    JOIN produit p ON p.code_produit = c.code_produit
                    JOIN Categorie cat ON p.id_categorie = cat.id_categorie
                    WHERE c.id_devis = @idDevis";

            cmd.Parameters.AddWithValue("@idDevis", devis.IdDevis);
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                int code_produit = Int32.Parse(monReader["code_produit"].ToString());
                string libelle_produit = monReader["libelle_produit"].ToString();
                float prix_vente_produit = float.Parse(monReader["prix_vente_produit"].ToString());
                int id_categorie = Int32.Parse(monReader["id_categorie"].ToString());
                string nom_categorie = monReader["nom_categorie"].ToString();
                CategorieBO categorie = new CategorieBO (id_categorie, nom_categorie);
                ProduitBO produit = new ProduitBO(code_produit,libelle_produit,prix_vente_produit,categorie);
                int quantite = Int32.Parse(monReader["quantite"].ToString());
                int pourcentage_remise_ligne = Int32.Parse(monReader["pourcentage_remise_ligne"].ToString());
                ContenirBO contenir = new ContenirBO(devis, produit, quantite, pourcentage_remise_ligne);

                listeContenir.Add(contenir);
            }

            maConnexion.Close();

            return listeContenir;
        }
        public static List<ProduitBO> SelectProduitsSansDevis(DevisBO devis)
        {
            List<ProduitBO> lesProduits = new List<ProduitBO>();

            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"SELECT * FROM Produit
                                JOIN Categorie ON Categorie.id_categorie = Produit.id_categorie
                                WHERE code_produit NOT IN (
                                    SELECT code_produit FROM Contenir WHERE id_devis = @idDevis )";
            cmd.Parameters.AddWithValue("@idDevis", devis.IdDevis);
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

            maConnexion.Close();

            return lesProduits;
        }
        public static void InsererLigne(ContenirBO ligne, int idDevis)
        {
            using (var cnx = ConnexionBD.GetSqlConnexion())
            {
                cnx.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cnx;
                    cmd.CommandText = @"
                        INSERT INTO Contenir (id_devis, code_produit, quantite, pourcentage_remise_ligne)
                        VALUES (@idDevis, @codeProduit, @qte, @remise);";
                    cmd.Parameters.AddWithValue("@idDevis", idDevis);
                    cmd.Parameters.AddWithValue("@codeProduit", ligne.Produit.CodeProduit);
                    cmd.Parameters.AddWithValue("@qte", ligne.Quantite);
                    cmd.Parameters.AddWithValue("@remise", ligne.Pourcentage_remise_ligne);

                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
        }

    }
}
