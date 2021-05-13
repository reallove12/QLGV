using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        public static List<DTO_TaiKhoan> GetDSTK()
        {
            return DAO.DAO_TaiKhoan.GetDSTK();
        }
        public static void InsertTK(string username, string password, string quyen)
        {
            DAO.DAO_TaiKhoan.InsertTK(username, password, quyen);
        }
        public static void UpdateTK(int matk, string username, string password, string quyen)
        {
            DAO.DAO_TaiKhoan.UpdateTK(matk,username, password, quyen);
        }
        public static void DeleteTK(int matk)
        {
            DAO.DAO_TaiKhoan.DeleteTK(matk);
        }
    }
}
