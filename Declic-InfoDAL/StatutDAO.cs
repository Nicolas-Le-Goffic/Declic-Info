using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Declic_InfoBO;

namespace Declic_InfoDAL
{
    public class StatutDAO
    {
        private static StatutDAO unStatutDAO;

        public static StatutDAO GetStatutDAO()
        {
            if (unStatutDAO == null)
            {
                unStatutDAO = new StatutDAO();
            }
            return unStatutDAO;
        }

        private StatutDAO() { }

        // Récupérer tous les statuts
        public static List<StatutBO> GetStatuts()
        {
            int idStatut;
            string nomStatut;
            StatutBO unStatut;

            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();
            List<StatutBO> lesStatuts = new List<StatutBO>();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Statut";
            SqlDataReader monreader = cmd.ExecuteReader();

            while (monreader.Read())
            {
                idStatut = Int32.Parse(monreader["id_statut"].ToString());
                if (monreader["nom_statut"] == DBNull.Value)
                {
                    nomStatut = default(string);
                }
                else
                {
                    nomStatut = monreader["nom_statut"].ToString();
                }

                unStatut = new StatutBO(idStatut, nomStatut);

                lesStatuts.Add(unStatut);
            }

            maConnexion.Close();
            return lesStatuts;
        }

        // Récupérer un statut par ID
        public static StatutBO GetStatutById(int id)
        {
            int idStatut;
            string nomStatut;
            StatutBO unStatut = null;

            SqlConnection maConnexion = ConnexionBD.GetSqlConnexion();
            maConnexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Statut WHERE id_statut = @idStatut";
            cmd.Parameters.AddWithValue("@idStatut", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) 
            {
                idStatut = Int32.Parse(reader["id_statut"].ToString());
                nomStatut = reader["nom_statut"] == DBNull.Value ? null : reader["nom_statut"].ToString();

                unStatut = new StatutBO(idStatut, nomStatut);
            }

            maConnexion.Close();
            return unStatut;   
        }

    }
}
