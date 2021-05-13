using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_MH
    {
        public static List<DTO_MH> GetDSMH()
        {
            return DAO.DAO_MH.GetDSMH();
        }
        public static void InsertMH(string tenmh, double stc)
        {
            DAO.DAO_MH.Insertmh(tenmh, stc);
        }
        public static void UpdateMH(int mamh, string tenmh, double stc)
        {
            DAO.DAO_MH.Updatemh(mamh, tenmh, stc);
        }
        public static void DeleteMH(int mamh)
        {
            DAO.DAO_MH.Deletemh(mamh);
        }
    }
}
