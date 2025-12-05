using Declic_InfoBLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Declic_Info
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GESTION_COMMERCIALE"].ConnectionString);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormModifSupprimerDevis());
        }
    }
}
