using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_GV
    {
        public static List<DTO_GiaoVien> GetDSGV()
        {
            return DAO.DAO_GV.GetDSGVs();
        }
        public static void InsertGV(string tengv, DateTime ngaysinh, string diachi, string sdt)
        {
            DAO.DAO_GV.InsertGVt(tengv, ngaysinh, diachi, sdt);
        }
        public static void UpdateGV(int magv,string tengv, DateTime ngaysinh, string diachi, string sdt)
        {
            DAO.DAO_GV.UpdateGV(magv,tengv, ngaysinh, diachi, sdt);
        }
        public static void DeleteGV(int magv)
        {
            DAO.DAO_GV.DeleteGV(magv);
        }
    }
}
