using System;
using System.Data.SqlClient;
using Declic_InfoBO;

namespace Declic_InfoDAL
{
    public class DevisDAO
    {
        private static DevisDAO unDevisDAO;

        public static DevisDAO GetUnDevisDAO()
        {
            if (unDevisDAO == null)
            {
                unDevisDAO = new DevisDAO();
            }
            return unDevisDAO;
        }

        /// Ajoute un devis dans la base de données.
        public static int AjoutDevis(DevisBO unDevis)
        {
            int nbEnr;

            // Récupération des champs du BO
            DateTime dateDevis = unDevis.DateDevis;
            float tauxTVA = unDevis.TauxTVADevis;
            float tauxRemise = unDevis.TauxRemiseGloDevis;
            float montantHT = unDevis.MontantHtHorsRemisDevise;
            int codeClient = unDevis.DevisClient.CodeClient;
            int idStatut = unDevis.DevisStatut.IdStatut;

            // Connexion BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = @"
                INSERT INTO Devis 
                (date_devis, taux_TVA_devis, taux_remise_glo_devis, montant_HT_hors_remis_devise, code_client, id_statut)
                VALUES (@date, @tva, @remise, @montantHT, @client, @statut)
            ";

            cmd.Parameters.AddWithValue("@date", dateDevis);
            cmd.Parameters.AddWithValue("@tva", tauxTVA);
            cmd.Parameters.AddWithValue("@remise", tauxRemise);
            cmd.Parameters.AddWithValue("@montantHT", montantHT);
            cmd.Parameters.AddWithValue("@client", codeClient);
            cmd.Parameters.AddWithValue("@statut", idStatut);

            nbEnr = cmd.ExecuteNonQuery();

            maConnexion.Close();

            return nbEnr;
        }
    }
}
