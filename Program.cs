using Declic_InfoBLL;
using Declic_InfoBO;
using System;
using System.Collections.Generic;
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
            // Toujours avant Application.Run
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Démarrage du formulaire que tu veux
            Application.Run(new FormAjoutClient());






        }
    }
}
