using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Declic_InfoBO;

namespace Declic_InfoDAL
{
    public class StatutDAO
    {
        private static StatutDAO unStatutDAO;

        // Singleton
        public static StatutDAO GetInstance()
        {
            if (unStatutDAO == null)
                unStatutDAO = new StatutDAO();
            return unStatutDAO;
        }

        private StatutDAO() { }

        // Récupérer tous les statuts
        public static List<StatutBO> GetStatuts()
        {
            List<StatutBO> lesStatuts = new List<StatutBO>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT id_statut, nom_statut FROM Statut;";

            SqlDataReader lecteur = cmd.ExecuteReader();

            while (lecteur.Read())
            {
                StatutBO statut = new StatutBO(
                    (int)lecteur["id_statut"],
                    lecteur["nom_statut"].ToString()
                );
                lesStatuts.Add(statut);
            }

            lecteur.Close();
            maConnexion.Close();

            return lesStatuts;
        }

        // Récupérer un statut par ID
        public static StatutBO GetStatutById(int id)
        {
            StatutBO statut = null;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT id_statut, nom_statut FROM Statut WHERE id_statut = @id;";
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader lecteur = cmd.ExecuteReader();

            if (lecteur.Read())
            {
                statut = new StatutBO(
                    (int)lecteur["id_statut"],
                    lecteur["nom_statut"].ToString()
                );
            }

            lecteur.Close();
            maConnexion.Close();

            return statut;
        }

        // Exemple d'ajout d'un nouveau statut
        public static int AjoutStatut(StatutBO unStatut)
        {
            int nbEnr;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Statut (nom_statut) VALUES (@nom);";
            cmd.Parameters.AddWithValue("@nom", unStatut.NomStatut);

            nbEnr = cmd.ExecuteNonQuery();

            maConnexion.Close();

            return nbEnr;
        }
    }
}
