using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Declic_InfoBO;

namespace Declic_InfoDAL
{
    public class ProduitDAO
    {
        private static ProduitDAO unProduitDAO;

        public static ProduitDAO GetunProduitDAO()
        {
            if (unProduitDAO == null)
            {
                unProduitDAO = new ProduitDAO();
            }
            return unProduitDAO;
        }

        // Retourne une liste d'objets Produit
        public List<Produit> GetProduits()
        {
            List<Produit> lesProduits = new List<Produit>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"
                SELECT p.code_produit, p.libelle_produit, p.prix_vente_produit, c.nom_categorie
                FROM Produit p
                INNER JOIN Categorie c ON p.id_categorie = c.id_categorie";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                int code_produit = Int32.Parse(monReader["code_produit"].ToString());
                string libelle_produit = monReader["libelle_produit"].ToString();
                float prix_vente_produit = float.Parse(monReader["prix_vente_produit"].ToString());
                string categorie = monReader["nom_categorie"].ToString();

                Produit unProduit = new Produit(code_produit, prix_vente_produit, libelle_produit,categorie);

                lesProduits.Add(unProduit);
            }

            maConnexion.Close();

            return lesProduits;
        }
    }
}
