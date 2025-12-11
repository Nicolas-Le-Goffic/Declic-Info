using Declic_InfoBO;// Référence la couche BO
using Declic_InfoDAL;// Référence la couche DAL
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;



namespace Declic_InfoBLL
{
    public class GestionDevis
    {
<<<<<<< HEAD
        private static GestionDevis uneGestionDevis;// objet BLL
        // Accesseur en lecture
=======
        private static GestionDevis uneGestionDevis;

>>>>>>> 419044fdfd7a991ca83814bfd469f0ad1a112939
        public static GestionDevis GetGestionDevis()
        {
            if (uneGestionDevis == null)
            {
                uneGestionDevis = new GestionDevis();
            }
            return uneGestionDevis;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
<<<<<<< HEAD

        public static void SetchaineConnexion(string value)
=======
        public static void SetchaineConnexion(ConnectionStringSettings chset)
>>>>>>> 419044fdfd7a991ca83814bfd469f0ad1a112939
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static int CreerDevis(DevisBO unDevis)
        {
            // 1. Créer le devis ET récupérer son ID
            int idDevis = DevisDAO.AjoutDevis(unDevis);

            // 2. SUPPRIMER d'abord toutes les lignes existantes pour ce devis (sécurité)
            SupprimerLignesDevis(idDevis);

            // 3. Regrouper les lignes par CodeProduit pour éviter les doublons
            var lignesRegroupees = unDevis.Lignes
                .Where(l => l.CodeProduit > 0)  // ignorer les lignes vides
                .GroupBy(l => l.CodeProduit)
                .Select(g => new ContenirBO
                {
                    CodeProduit = g.Key,
                    Produit = g.First().Produit,
                    Quantite = g.Sum(l => l.Quantite),
                    Pourcentage_remise_ligne = g.First().Pourcentage_remise_ligne
                }).ToList();



            // 4. Insérer chaque ligne unique
            foreach (var ligne in lignesRegroupees)
            {
                ContenirDAO.InsererLigne(ligne, idDevis);
            }

            return idDevis;
        }

        // Méthode utilitaire pour supprimer les lignes d'un devis
        private static void SupprimerLignesDevis(int idDevis)
        {
            using (var cnx = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            using (var cmd = new SqlCommand("DELETE FROM Contenir WHERE id_devis = @idDevis", cnx))
            {
                cmd.Parameters.AddWithValue("@idDevis", idDevis);
                cmd.ExecuteNonQuery();
            }
        }





        public static List<DevisBO> GetDevis()
        {
            return DevisDAO.GetDevis();
        }

        public static DevisBO GetUnDevis(int unIdDevis)
        {
            return DevisDAO.GetUnDevis(unIdDevis);
        }

        public static bool SupprimerDevis(int idDevis)
        {
            return DevisDAO.SupprimerDevis(idDevis);
        }

        public static int ModificationDevis(DevisBO unDevis)
        {
            return DevisDAO.ModificationDevis(unDevis);
        }
    }
}
