using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Declic_InfoDAL
{
    // Classe de gestion de la connexion à la BD
    public class ConnexionBD
    {
        private SqlConnection maConnexion;
        private static ConnexionBD uneConnexionBD; // instance d'une connexion
        private static string chaineConnexion = ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"].ConnectionString; // chaîne de connexion à la BD

        // Accesseur en lecture de la chaîne de connexion
        public string GetchaineConnexion()
        {
            return chaineConnexion;
        }

        // Accesseur en écriture de la chaîne de connexion
        public void SetchaineConnexion(string ch)
        {
            chaineConnexion = ch;
        }

        // Accesseur en lecture, renvoi une instance de connexion
        public static ConnexionBD GetConnexionBD()
        {
            if (uneConnexionBD == null)
            {
                uneConnexionBD = new ConnexionBD();
            }
            return uneConnexionBD;
        }

        // Constructeur privé
        private ConnexionBD(){}

        public static SqlConnection GetSqlConnexion()
        {
            return new SqlConnection(chaineConnexion);
        }

        public void CloseConnexion()
        {
            // Si la connexion est ouverte, on la ferme
            if (this.maConnexion != null && this.maConnexion.State != System.Data.ConnectionState.Closed)
            {
                this.maConnexion.Close();
            }
        }
    }
}
