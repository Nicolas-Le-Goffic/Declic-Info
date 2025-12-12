using Declic_InfoBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Declic_InfoDAL
{
    public class DevisDAO
    {
        private static DevisDAO unDevisDAO;

        public static DevisDAO GetunDevisDAO()
        {
            if (unDevisDAO == null)
            {
                unDevisDAO = new DevisDAO();
            }
            return unDevisDAO;
        }

        /// <summary>Ajoute un devis dans la base de données.</summary>

        public static int AjoutDevis(DevisBO unDevis)
        {
            int nbEnr;

            // Récupération des champs du BO
            DateTime dateDevis = unDevis.DateDevis;
            float tauxTVA = unDevis.TauxTVADevis;
            float tauxRemise = unDevis.TauxRemiseGloDevis;
            int codeClient = unDevis.DevisClient.CodeClient;
            int idStatut = unDevis.DevisStatut.IdStatut;

            // Connexion BD
            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = @"
        INSERT INTO Devis 
        (date_devis, taux_TVA_devis, taux_remise_glo_devis,
         montant_HT_hors_remis_devise, code_client, id_statut)
        OUTPUT INSERTED.id_devis
        VALUES (@date, @tva, @remise, @mntHt, @client, @statut);";

            cmd.Parameters.AddWithValue("@date", unDevis.DateDevis);
            cmd.Parameters.AddWithValue("@tva", unDevis.TauxTVADevis);
            cmd.Parameters.AddWithValue("@remise", unDevis.TauxRemiseGloDevis);
            cmd.Parameters.AddWithValue("@mntHt", unDevis.MontantHtHorsRemise);
            cmd.Parameters.AddWithValue("@client", unDevis.DevisClient.CodeClient);
            cmd.Parameters.AddWithValue("@statut", unDevis.DevisStatut.IdStatut);

            int idDevis = (int)cmd.ExecuteScalar();  // ← ÇA C'EST L'ID DU DEVIS CRÉÉ

            maConnexion.Close();
            return idDevis;  // ← RETOURNE L'ID, PAS nbEnr
        }


        public static List<DevisBO> GetDevis()
        {
            List<DevisBO> lesDevis = new List<DevisBO>();

            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"
                SELECT d.id_devis, d.date_devis, d.taux_TVA_devis, d.taux_remise_glo_devis, d.montant_HT_hors_remis_devise, c.* , s.*
                FROM Devis d, client c, statut s
            
                WHERE d.code_client = c.code_client
                AND d.id_statut = s.id_statut ";
            
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                int id_devis = int.Parse(monReader["id_devis"].ToString());
                DateTime date_devis = DateTime.Parse(monReader["date_devis"].ToString());
                float taux_TVA_devis = float.Parse(monReader["taux_TVA_devis"].ToString());
                float taux_remise_glo_devis = float.Parse(monReader["taux_remise_glo_devis"].ToString());
                float montant_HT_hors_remis_devise =
                    float.Parse(monReader["montant_HT_hors_remis_devise"].ToString());

                int codeClient = int.Parse(monReader["code_client"].ToString());
                string nomClient = monReader["nom_client"].ToString();
                string numTelClient = monReader["num_tel_client"].ToString();
                string numFaxClient = monReader["num_fax_client"].ToString();
                string emailClient = monReader["email_client"].ToString();
                int numAdrFactClient = int.Parse(monReader["num_adr_fact_client"].ToString());
                string rueAdrFactClient = monReader["rue_adr_fact_client"].ToString();
                string villeAdrFactClient = monReader["ville_adr_fact_client"].ToString();
                int cpAdrFactClient = int.Parse(monReader["cp_adr_fact_client"].ToString());
                int numAdrLivClient = int.Parse(monReader["num_adr_fact_client"].ToString());
                string rueAdrLivClient = monReader["rue_adr_liv_client"].ToString();
                string villeAdrLivClient = monReader["ville_adr_liv_client"].ToString();
                int cpAdrLivClient = int.Parse(monReader["cp_adr_liv_client"].ToString());

                ClientBO client = new ClientBO(
                    codeClient, nomClient, numTelClient, numFaxClient, emailClient,
                    numAdrFactClient, rueAdrFactClient, villeAdrFactClient, cpAdrFactClient,
                    numAdrLivClient, rueAdrLivClient, villeAdrLivClient, cpAdrLivClient);

                int id_statut = int.Parse(monReader["id_statut"].ToString());
                string nom_statut = monReader["nom_statut"].ToString();
                StatutBO statut = new StatutBO(id_statut, nom_statut);

                DevisBO unDevis = new DevisBO(id_devis, date_devis,
                                              taux_TVA_devis, taux_remise_glo_devis,
                                              client, statut);

                unDevis.MontantHtHorsRemise = montant_HT_hors_remis_devise;

                lesDevis.Add(unDevis);
            }

            maConnexion.Close();
            return lesDevis;
        }

        public static DevisBO GetUnDevis(int idDevis)
        {
            DevisBO unDevis = null;

            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"
                SELECT d.id_devis, d.date_devis, d.taux_TVA_devis, d.taux_remise_glo_devis,
                       d.montant_HT_hors_remis_devise,
                       c.*, s.*
                FROM Devis d
                JOIN client c ON d.code_client = c.code_client
                JOIN statut s ON d.id_statut = s.id_statut
                WHERE d.id_devis = @idDevis;
            ";

            cmd.Parameters.AddWithValue("@idDevis", idDevis);

            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.Read())
            {
                int id_devis = int.Parse(monReader["id_devis"].ToString());
                DateTime date_devis = DateTime.Parse(monReader["date_devis"].ToString());
                float taux_TVA_devis = float.Parse(monReader["taux_TVA_devis"].ToString());
                float taux_remise_glo_devis = float.Parse(monReader["taux_remise_glo_devis"].ToString());
                float montant_HT_hors_remis_devise =
                    float.Parse(monReader["montant_HT_hors_remis_devise"].ToString());

                int codeClient = int.Parse(monReader["code_client"].ToString());
                string nomClient = monReader["nom_client"].ToString();
                string numTelClient = monReader["num_tel_client"].ToString();
                string numFaxClient = monReader["num_fax_client"].ToString();
                string emailClient = monReader["email_client"].ToString();
                int numAdrFactClient = int.Parse(monReader["num_adr_fact_client"].ToString());
                string rueAdrFactClient = monReader["rue_adr_fact_client"].ToString();
                string villeAdrFactClient = monReader["ville_adr_fact_client"].ToString();
                int cpAdrFactClient = int.Parse(monReader["cp_adr_fact_client"].ToString());
                int numAdrLivClient = int.Parse(monReader["num_adr_fact_client"].ToString());
                string rueAdrLivClient = monReader["rue_adr_liv_client"].ToString();
                string villeAdrLivClient = monReader["ville_adr_liv_client"].ToString();
                int cpAdrLivClient = int.Parse(monReader["cp_adr_liv_client"].ToString());

                ClientBO client = new ClientBO(
                    codeClient, nomClient, numTelClient, numFaxClient, emailClient,
                    numAdrFactClient, rueAdrFactClient, villeAdrFactClient, cpAdrFactClient,
                    numAdrLivClient, rueAdrLivClient, villeAdrLivClient, cpAdrLivClient);

                int id_statut = int.Parse(monReader["id_statut"].ToString());
                string nom_statut = monReader["nom_statut"].ToString();
                StatutBO statut = new StatutBO(id_statut, nom_statut);

                unDevis = new DevisBO(id_devis, date_devis,
                                      taux_TVA_devis, taux_remise_glo_devis,
                                      client, statut);
                unDevis.MontantHtHorsRemise = montant_HT_hors_remis_devise;
            }

            maConnexion.Close();
            return unDevis;
        }

        public static bool SupprimerDevis(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;
                cmd.CommandText = "DELETE FROM Devis WHERE id_devis = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // contrainte FK
                {
                    maConnexion.Close();
                    return false;
                }
            }

            maConnexion.Close();
            return true;
        }

        public static int ModificationDevis(DevisBO devis)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = @"
                UPDATE Devis 
                SET date_devis = @dateDevis,
                    taux_TVA_devis = @tauxTVADevis,
                    taux_remise_glo_devis = @tauxRemiseGloDevis,
                    montant_HT_hors_remis_devise = @mntHt,
                    code_client = @codeClient,
                    id_statut = @idStatut
                WHERE id_devis = @idDevis;
            ";

            cmd.Parameters.AddWithValue("@dateDevis", devis.DateDevis);
            cmd.Parameters.AddWithValue("@tauxTVADevis", devis.TauxTVADevis);
            cmd.Parameters.AddWithValue("@tauxRemiseGloDevis", devis.TauxRemiseGloDevis);
            cmd.Parameters.AddWithValue("@mntHt", devis.MontantHtHorsRemise);
            cmd.Parameters.AddWithValue("@codeClient", devis.DevisClient.CodeClient);
            cmd.Parameters.AddWithValue("@idStatut", devis.DevisStatut.IdStatut);
            cmd.Parameters.AddWithValue("@idDevis", devis.IdDevis);

            nbEnr = cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nbEnr;
        }
        public static void SupprimerLignesDevis(int idDevis)
        {
            using (var cnx = ConnexionBD.GetSqlConnexion())
            {
                cnx.Open();
                using (var cmd = new SqlCommand("DELETE FROM Contenir WHERE id_devis = @idDevis", cnx))
                {
                    cmd.Parameters.AddWithValue("@idDevis", idDevis);
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
        }
    }
}
