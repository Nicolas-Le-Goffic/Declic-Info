using Declic_InfoBO;
using Declic_InfoDAL;
using System.Collections.Generic;

namespace Declic_InfoBLL
{
    public class GestionStatut
    {
        public static List<StatutBO> GetStatuts()
        {
            return StatutDAO.GetInstance().GetStatuts();
        }

        public static StatutBO GetStatutById(int id)
        {
            return StatutDAO.GetInstance().GetStatutById(id);
        }
    }

}
