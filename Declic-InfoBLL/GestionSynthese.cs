using Declic_InfoBO;
using Declic_InfoDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declic_InfoBLL
{
    public class GestionSynthese
    {
        public static List<SyntheseClientBO> GetSyntheseClients(DateTime dateDebut, DateTime dateFin)
        {
            return SyntheseDAO.GetSyntheseClients(dateDebut, dateFin);
        }

    }
}
