using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using Declic_InfoBO;

namespace Declic_InfoDAL
{
    public class DevisDAO
    {
        private static DevisDAO unDevisDAO;

        public static DevisDAO GetDevisDAO()
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
        public List<DevisBO> GetDevis()
        {
            List<DevisBO> listeDevis = new List<DevisBO>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"
                SELECT d.*, c.nom_client, s.nom_statut
                FROM Devis d
                INNER JOIN Client c ON d.code_client = c.code_client
                
            INNER JOIN Statut s ON d.id_statut = s.id_statut";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int idDevis = Int32.Parse(reader["id_devis"].ToString());
                DateTime dateDevis = DateTime.Parse(reader["date_devis"].ToString());

                float tauxTVA = float.Parse(reader["taux_TVA_devis"].ToString());
                float remiseGlobale = float.Parse(reader["taux_remise_glo_devis"].ToString());
                float montantHT = float.Parse(reader["montant_HT_hors_remis_devise"].ToString());

                int codeClient = Int32.Parse(reader["code_client"].ToString());
                string nomClient = reader["nom_client"].ToString();
                ClientBO clientBO = new ClientBO(codeClient, nomClient);

                int idStatut = Int32.Parse(reader["id_statut"].ToString());
                string nomStatut = reader["nom_statut"].ToString();
                StatutBO statut = new StatutBO(idStatut, nomStatut);

                DevisBO unDevis = new DevisBO(
                    idDevis,
                    dateDevis,
                    tauxTVA,
                    remiseGlobale,
                    montantHT,
                    clientBO,
                    statut
                );


                listeDevis.Add(unDevis);
            }
           
            reader.Close();
            maConnexion.Close();

            return listeDevis;
        }

        //______________________________________


    }
}
