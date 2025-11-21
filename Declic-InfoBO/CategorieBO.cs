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
        public int IdCategorie
        {
            get => idCategorie;
            set => idCategorie = value;
        }
        public string NomCategorie
        {
            get => nomCategorie;
            set => nomCategorie = value;
        }
        public override string ToString()
        {
            return nomCategorie;   // C’est ce qui sera affiché dans la ComboBox
        }
    }
}
