using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Declic_InfoBO; // Référence la couche BO
using System.Data.SqlClient;


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

        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutProduit(ProduitBO unProduit)
        {
            int nbEnr;
            string libelleProduit = unProduit.getLibelleProduit();
            float prixVente = unProduit.getPrixVenteProduit();
            int idCategorie = unProduit.getCategorieProduit().getIdCategorie();

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
    }
}
