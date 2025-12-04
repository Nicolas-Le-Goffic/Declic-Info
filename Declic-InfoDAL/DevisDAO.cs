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
