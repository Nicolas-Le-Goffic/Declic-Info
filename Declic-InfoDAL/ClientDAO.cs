
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Declic_InfoBO; // Référence la couche BO



namespace Declic_InfoDAL
{
    public class ClientDAO
    {
        private static ClientDAO unClientDAO;

        // Accesseur en lecture, renvoi une instance
        public static ClientDAO GetunClientDAO()
        {
            if (unClientDAO == null)
            {
                unClientDAO = new ClientDAO();
            }
            return unClientDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<ClientBO> GetInfosClients()
        {
            int codeClient;
            string nomClient;
            int numTelClient;
            int numFaxClient;
            string emailClient;
            int numAdrFactClient;
            string rueAdrFactClient;
            string villeAdrFactClient;
            int cpAdrFactClient;
            int numAdrLivClient;
            string rueAdrLivClient;
            string villeAdrLivClient;
            int cpAdrLivClient;
            ClientBO unClient;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<ClientBO> lesClients = new List<ClientBO>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Client";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                codeClient = Int32.Parse(monReader["code_client"].ToString());
                if (monReader["nom_client"] == DBNull.Value)
                {
                    nomClient = default(string);
                }
                else
                {
                    nomClient = monReader["nom_client"].ToString();
                }
                numTelClient = Int32.Parse(monReader["num_tel_client"].ToString());
                numFaxClient = Int32.Parse(monReader["num_fax_client"].ToString());
                if (monReader["email_client"] == DBNull.Value)
                    {
                        emailClient = default(string);
                    }
                else
                    {
                    emailClient = monReader["email_client"].ToString();
                    }
                    numAdrFactClient = Int32.Parse(monReader["num_adr_fact_client"].ToString());
                if (monReader["rue_adr_fact_client"] == DBNull.Value)
                {
                    rueAdrFactClient = default(string);
                }
                else
                {
                    rueAdrFactClient = monReader["rue_adr_fact_client"].ToString();
                }
                if (monReader["ville_adr_fact_client"] == DBNull.Value)
                {
                    villeAdrFactClient = default(string);
                }
                else
                {
                    villeAdrFactClient = monReader["ville_adr_fact_client"].ToString();
                }
                cpAdrFactClient = Int32.Parse(monReader["cp_adr_fact_client"].ToString());
                numAdrLivClient = Int32.Parse(monReader["num_adr_fact_client"].ToString());
                if (monReader["rue_adr_liv_client"] == DBNull.Value)
                {
                    rueAdrLivClient = default(string);
                }
                else
                {
                    rueAdrLivClient = monReader["rue_adr_liv_client"].ToString();
                }
                if (monReader["ville_adr_liv_client"] == DBNull.Value)
                {
                    villeAdrLivClient = default(string);
                }
                else
                {
                    villeAdrLivClient = monReader["ville_adr_liv_client"].ToString();
                }
                cpAdrLivClient = Int32.Parse(monReader["cp_adr_liv_client"].ToString());


                unClient = new ClientBO(codeClient, nomClient, numTelClient, numFaxClient, emailClient, numAdrFactClient, rueAdrFactClient, villeAdrFactClient, cpAdrFactClient, numAdrLivClient, rueAdrLivClient, villeAdrLivClient, cpAdrLivClient);
                lesClients.Add(unClient);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesClients;
        }
        public static List<ClientBO> GetClients()
        {
            int codeClient;
            string nomClient;
            ClientBO unClient;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<ClientBO> lesClients = new List<ClientBO>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Client";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                codeClient = Int32.Parse(monReader["code_client"].ToString());
                if (monReader["nom_client"] == DBNull.Value)
                {
                    nomClient = default(string);
                }
                else
                {
                    nomClient = monReader["nom_client"].ToString();
                }
                unClient = new ClientBO(codeClient, nomClient);
                lesClients.Add(unClient);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesClients;
        }
        public static List<ClientBO> GetUnClient(int idUnClient)
        {
            int idClient;
            string nomClient;
            ClientBO unClient;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<ClientBO> lesClients = new List<ClientBO>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Categorie WHERE id_categorie = @idClient";
            cmd.Parameters.AddWithValue("@idClient", idUnClient);

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idClient = Int32.Parse(monReader["id_categorie"].ToString());
                if (monReader["nom_categorie"] == DBNull.Value)
                {
                    nomClient = default(string);
                }
                else
                {
                    nomClient = monReader["nom_categorie"].ToString();
                }

                unClient = new ClientBO(idClient, nomClient);
                lesClients.Add(unClient);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesClients;
        }
        public static void SupprimerClient(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<ClientBO> lesClients = new List<ClientBO>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM Client WHERE code_client = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader monReader = cmd.ExecuteReader();
            // Fermeture de la connexion
            maConnexion.Close();
        }
    }
}
