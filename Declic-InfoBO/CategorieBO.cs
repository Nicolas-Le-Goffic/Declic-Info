using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Declic_InfoBO
{
    public class CategorieBO
    {
        private int idCategorie;
        private string nomCategorie;
        public CategorieBO(int idCategorie, string nomCategorie) 
        {
            this.idCategorie = idCategorie;
            this.nomCategorie = nomCategorie;
        }
        public int getIdCategorie()
        {
            return idCategorie;
        }
        public string getNomCategorie()
        {
            return nomCategorie;
        }
        public void setIdCategorie(int idCategorie)
        {
            this.idCategorie = idCategorie;
        }
        public void setNomCategorie(string nomCategorie)
        {
            this.nomCategorie = nomCategorie;
        }
        public override string ToString()
        {
            return nomCategorie;   // C’est ce qui sera affiché dans la ComboBox
        }
    }
}
