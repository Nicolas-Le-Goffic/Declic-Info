using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Declic_InfoBO; // Référence la couche BO
using System.Data.SqlClient;

namespace Declic_InfoDAL
{
    public class ClientDAO
    {
        private static ClientDAO unClientDAO;

        // Accesseur en lecture -> renvoie une instance
        public static ClientDAO GetUnClientDAO()
        {
            if (unClientDAO == null)
            {
                unClientDAO = new ClientDAO();
            }
            return unClientDAO;
        }

        // cette méthode insère un nouveau client passé en paramètre dans la BD
        public static int AjoutClient(ClientBO unClient)
        {
            int nbEnr;

            string nom = unClient.NomClient;
            int tel = unClient.NumTelClient;
            int fax = unClient.NumFaxClient;
            string email = unClient.EmailClient;

            int numFact = unClient.NumAdrFactClient;
            string rueFact = unClient.RueAdrFactClient;
            string villeFact = unClient.VilleAdFactClient;
            int cpFact = unClient.CpAdrFactClient;

            int numLiv = unClient.NumAdrLivClient;
            string rueLiv = unClient.RueAdrLivClient;
            string villeLiv = unClient.VilleAdrLivClient;
            int cpLiv = unClient.CpAdrLivClient;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = @"INSERT INTO Client (
                nom_client, num_tel_client, num_fax_client, email_client,
                num_adr_fact_client, rue_adr_fact_client, ville_adr_fact_client, cp_adr_fact_client,
                num_adr_liv_client, rue_adr_liv_client, ville_adr_liv_client, cp_adr_liv_client
            ) 
            VALUES (
                @nom, @tel, @fax, @mail,
                @numFact, @rueFact, @villeFact, @cpFact,
                @numLiv, @rueLiv, @villeLiv, @cpLiv
            )";

            //ajout des paramètres
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@fax", fax);
            cmd.Parameters.AddWithValue("@mail", email);

            cmd.Parameters.AddWithValue("@numFact", numFact);
            cmd.Parameters.AddWithValue("@rueFact", rueFact);
            cmd.Parameters.AddWithValue("@villeFact", villeFact);
            cmd.Parameters.AddWithValue("@cpFact", cpFact);

            cmd.Parameters.AddWithValue("@numLiv", numLiv);
            cmd.Parameters.AddWithValue("@rueLiv", rueLiv);
            cmd.Parameters.AddWithValue("@villeLiv", villeLiv);
            cmd.Parameters.AddWithValue("@cpLiv", cpLiv);

            //execution
            nbEnr = cmd.ExecuteNonQuery();

            //fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
    }
}
