using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Declic_InfoBO;


namespace Declic_InfoDAL
{
    public class SyntheseDAO
    {
        public static List<SyntheseClientBO> GetSyntheseClients(DateTime dateDebut, DateTime dateFin)
        {
            var syntheses = new List<SyntheseClientBO>();

            
            using (SqlConnection cnx = ConnexionBD.GetSqlConnexion())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
               
                cmd.CommandText = @"
                    SELECT 
                        c.code_client,
                        c.nom_client,
                        COUNT(d.id_devis) AS totalDevis,
                        SUM(CASE WHEN s.nom_statut = 'Accepté' THEN 1 ELSE 0 END) AS nbAcceptes,
                        SUM(CASE WHEN s.nom_statut = 'Refusé' THEN 1 ELSE 0 END) AS nbRefuses,
                        SUM(CASE WHEN s.nom_statut = 'En attente' THEN 1 ELSE 0 END) AS nbAttente,
                        ISNULL(SUM(CASE WHEN s.nom_statut = 'Accepté' THEN d.montant_HT_hors_remis_devise ELSE 0 END), 0) AS montantHT
                    FROM Client c
                    LEFT JOIN Devis d 
                        ON c.code_client = d.code_client
                        AND d.date_devis BETWEEN @dateDebut AND @dateFin
                    LEFT JOIN Statut s
                        ON d.id_statut = s.id_statut
                    GROUP BY c.code_client, c.nom_client
                    ORDER BY c.nom_client;";

                cmd.Parameters.AddWithValue("@dateDebut", dateDebut.Date);
                
                cmd.Parameters.AddWithValue("@dateFin", dateFin.Date);

                
                if (cnx.State == System.Data.ConnectionState.Closed)
                    cnx.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        int code = rd["code_client"] != DBNull.Value ? Convert.ToInt32(rd["code_client"]) : 0;
                        string nom = rd["nom_client"] != DBNull.Value ? rd["nom_client"].ToString() : "";

                        int total = rd["totalDevis"] != DBNull.Value ? Convert.ToInt32(rd["totalDevis"]) : 0;
                        int acc = rd["nbAcceptes"] != DBNull.Value ? Convert.ToInt32(rd["nbAcceptes"]) : 0;
                        int refu = rd["nbRefuses"] != DBNull.Value ? Convert.ToInt32(rd["nbRefuses"]) : 0;
                        int att = rd["nbAttente"] != DBNull.Value ? Convert.ToInt32(rd["nbAttente"]) : 0;
                        double montant = rd["montantHT"] != DBNull.Value ? Convert.ToDouble(rd["montantHT"]) : 0.0;

                        var syn = new SyntheseClientBO(code, nom, total, acc, refu, att, montant);
                        syntheses.Add(syn);
                    }
                }
            }

            return syntheses;
        }
    }
}
