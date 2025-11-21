using System;
using System.Data.SqlClient;
using Declic_InfoBO;

namespace Declic_InfoDAL
{
    public static class ClientDAL
    { //ACHANGERRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
        private static string connectionString = @"YOUR_CONNECTION_STRING";

        public static int AjouterClient(ClientBO client)
        {
            int nbLignes;

            string req = @"INSERT INTO Client 
            (
                nom_client, num_tel_client, num_fax_client, email_client,
                num_adr_fact_client, rue_adr_fact_client, ville_adr_fact_client, cp_adr_fact_client,
                num_adr_liv_client, rue_adr_liv_client, ville_adr_liv_client, cp_adr_liv_client
            )
            VALUES
            (
                @nom, @tel, @fax, @mail,
                @numFact, @rueFact, @villeFact, @cpFact,
                @numLiv, @rueLiv, @villeLiv, @cpLiv
            );";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(req, con);

                    cmd.Parameters.AddWithValue("@nom", client.NomClient);
                    cmd.Parameters.AddWithValue("@tel", client.NumTelClient);
                    cmd.Parameters.AddWithValue("@fax", client.NumFaxClient);
                    cmd.Parameters.AddWithValue("@mail", client.EmailClient);

                    cmd.Parameters.AddWithValue("@numFact", client.NumAdrFactClient);
                    cmd.Parameters.AddWithValue("@rueFact", client.RueAdrFactClient);
                    cmd.Parameters.AddWithValue("@villeFact", client.VilleAdFactClient);
                    cmd.Parameters.AddWithValue("@cpFact", client.CpAdrFactClient);

                    cmd.Parameters.AddWithValue("@numLiv", client.NumAdrLivClient);
                    cmd.Parameters.AddWithValue("@rueLiv", client.RueAdrLivClient);
                    cmd.Parameters.AddWithValue("@villeLiv", client.VilleAdrLivClient);
                    cmd.Parameters.AddWithValue("@cpLiv", client.CpAdrLivClient);

                    nbLignes = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur DAL : " + ex.Message);
                }
            }
            return nbLignes;
        }
    }
}
