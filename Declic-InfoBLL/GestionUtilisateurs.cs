using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Declic_InfoDAL;

namespace Declic_InfoBLL
{
    public class GestionUtilisateurs
    {
            private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

            // Accesseur en lecture
            public static GestionUtilisateurs GetGestionUtilisateurs()
            {
                if (uneGestionUtilisateurs == null)
                {
                    uneGestionUtilisateurs = new GestionUtilisateurs();
                }
                return uneGestionUtilisateurs;
            }

            // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
            

        }
    }
