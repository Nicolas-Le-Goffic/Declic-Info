using Declic_InfoBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace Declic_InfoDAL
{
    public class DevisDAO
    {

        private static DevisDAO unDevisDAO;

        // Accesseur en lecture, renvoi une instance
        public static DevisDAO GetunDevisDAO()
        {
            if (unDevisDAO == null)
            {
                unDevisDAO = new DevisDAO();
            }
            return unDevisDAO;
        }

        public static List<DevisBO> GetDevis()
        {
            List<DevisBO> lesDevis = new List<DevisBO>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
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
                int id_devis = Int32.Parse(monReader["id_devis"].ToString());
                DateTime date_devis = DateTime.Parse(monReader["date_devis"].ToString());
                float taux_TVA_devis = float.Parse(monReader["taux_TVA_devis"].ToString());
                float taux_remise_glo_devis = float.Parse(monReader["taux_remise_glo_devis"].ToString());
                float montant_HT_hors_remis_devise = float.Parse(monReader["montant_HT_hors_remis_devise"].ToString());

                int codeClient = Int32.Parse(monReader["code_client"].ToString());
                string nomClient = monReader["nom_client"].ToString();
                string numTelClient = monReader["num_tel_client"].ToString();
                string numFaxClient = monReader["num_fax_client"].ToString();
                string emailClient = monReader["email_client"].ToString();
                int numAdrFactClient = Int32.Parse(monReader["num_adr_fact_client"].ToString());
                string rueAdrFactClient = monReader["rue_adr_fact_client"].ToString();
                string villeAdrFactClient = monReader["ville_adr_fact_client"].ToString();
                int cpAdrFactClient = Int32.Parse(monReader["cp_adr_fact_client"].ToString());
                int numAdrLivClient = Int32.Parse(monReader["num_adr_fact_client"].ToString());
                string rueAdrLivClient = monReader["rue_adr_liv_client"].ToString();
                string villeAdrLivClient = monReader["ville_adr_liv_client"].ToString();
                int cpAdrLivClient = Int32.Parse(monReader["cp_adr_liv_client"].ToString());
                ClientBO client = new ClientBO(codeClient, nomClient, numTelClient, numFaxClient, emailClient, numAdrFactClient, rueAdrFactClient, villeAdrFactClient, cpAdrFactClient, numAdrLivClient, rueAdrLivClient, villeAdrLivClient, cpAdrLivClient);

                int id_statut = Int32.Parse(monReader["id_statut"].ToString());
                string nom_statut = monReader["nom_statut"].ToString();
                StatutBO statut = new StatutBO (id_statut, nom_statut);

                DevisBO unDevis = new DevisBO(id_devis, date_devis, taux_TVA_devis, taux_remise_glo_devis, montant_HT_hors_remis_devise,client,statut);

                lesDevis.Add(unDevis);
            }

            maConnexion.Close();

            return lesDevis;
        }
        public static DevisBO GetUnDevis(int idDevis)
        {
            DevisBO unDevis = new DevisBO();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"
                SELECT d.id_devis, d.date_devis, d.taux_TVA_devis, d.taux_remise_glo_devis, d.montant_HT_hors_remis_devise, c.* , s.*
                FROM Devis d, client c, statut s
                WHERE d.code_client = c.code_client
                AND d.id_statut = s.id_statut 
                AND d.id_devis = @idDevis";

            cmd.Parameters.AddWithValue("@idDevis", idDevis);

            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.Read())
            {
                int id_devis = Int32.Parse(monReader["id_devis"].ToString());
                DateTime date_devis = DateTime.Parse(monReader["date_devis"].ToString());
                float taux_TVA_devis = float.Parse(monReader["taux_TVA_devis"].ToString());
                float taux_remise_glo_devis = float.Parse(monReader["taux_remise_glo_devis"].ToString());
                float montant_HT_hors_remis_devise = float.Parse(monReader["montant_HT_hors_remis_devise"].ToString());

                int codeClient = Int32.Parse(monReader["code_client"].ToString());
                string nomClient = monReader["nom_client"].ToString();
                string numTelClient = monReader["num_tel_client"].ToString();
                string numFaxClient = monReader["num_fax_client"].ToString();
                string emailClient = monReader["email_client"].ToString();
                int numAdrFactClient = Int32.Parse(monReader["num_adr_fact_client"].ToString());
                string rueAdrFactClient = monReader["rue_adr_fact_client"].ToString();
                string villeAdrFactClient = monReader["ville_adr_fact_client"].ToString();
                int cpAdrFactClient = Int32.Parse(monReader["cp_adr_fact_client"].ToString());
                int numAdrLivClient = Int32.Parse(monReader["num_adr_fact_client"].ToString());
                string rueAdrLivClient = monReader["rue_adr_liv_client"].ToString();
                string villeAdrLivClient = monReader["ville_adr_liv_client"].ToString();
                int cpAdrLivClient = Int32.Parse(monReader["cp_adr_liv_client"].ToString());
                ClientBO client = new ClientBO(codeClient, nomClient, numTelClient, numFaxClient, emailClient, numAdrFactClient, rueAdrFactClient, villeAdrFactClient, cpAdrFactClient, numAdrLivClient, rueAdrLivClient, villeAdrLivClient, cpAdrLivClient);

                int id_statut = Int32.Parse(monReader["id_statut"].ToString());
                string nom_statut = monReader["nom_statut"].ToString();
                StatutBO statut = new StatutBO(id_statut, nom_statut);
                
                unDevis = new DevisBO(id_devis, date_devis, taux_TVA_devis, taux_remise_glo_devis, montant_HT_hors_remis_devise, client, statut);
            }

            maConnexion.Close();

            return unDevis;
        }
        public static bool SupprimerDevis(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;

                cmd.CommandText = "DELETE FROM Devis WHERE id_devis = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

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
            // Fermeture de la connexion
            maConnexion.Close();
            return true;
        }
        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int ModificationDevis(DevisBO devis)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"UPDATE Devis 
                    SET date_devis = @dateDevis,
                        taux_TVA_devis = @tauxTVADevis,
                        taux_remise_glo_devis = @tauxRemiseGloDevis,
                        montant_HT_hors_remis_devise = @montantHTHorsRemisDevise,
                        code_client = @codeClient,
                        id_statut = @idStatut
                    WHERE id_devis = @idDevis";




            cmd.Parameters.AddWithValue("@dateDevis", devis.DateDevis);
            cmd.Parameters.AddWithValue("@tauxTVADevis", devis.TauxTVADevis);
            cmd.Parameters.AddWithValue("@tauxRemiseGloDevis", devis.TauxRemiseGloDevis);
            cmd.Parameters.AddWithValue("@montantHTHorsRemisDevise", devis.MontantHtHorsRemisDevise);
            cmd.Parameters.AddWithValue("@codeClient", devis.DevisClient);
            cmd.Parameters.AddWithValue("@idStatut", devis.DevisStatut);
            cmd.Parameters.AddWithValue("@idDevis", devis.IdDevis);

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
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
