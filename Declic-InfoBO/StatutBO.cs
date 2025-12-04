using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Declic_InfoBO
{
    public class StatutBO
    {
        public int idStatut;
        public string nomStatut;

        public StatutBO(int idStatut, string nomStatut)
        {
            this.idStatut = idStatut;
            this.nomStatut = nomStatut;
        }

        public int IdStatut
        {
            get => idStatut;
            set => idStatut = value;
        }
        public string NomStatut
        {
            get => nomStatut;
            set => nomStatut = value;
        }
        public override string ToString()
        {
            return NomStatut;
        }
    }
}
