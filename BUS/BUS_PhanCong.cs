using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_PhanCong
    {
        public static List<DTO_PhanCong> GetDSPCs()
        {
            return DAO.DAO_PhanCong.GetDSPCs();
        }
        public static void InsertPC(string mahp, int mamh, int magv, DateTime ngaybd, DateTime ngaykt)
        {
            DAO.DAO_PhanCong.InsertPC(mahp, mamh, magv, ngaybd, ngaykt);
        }
        public static void UpdatePC(string mahp, int mamh, int magv, DateTime ngaybd, DateTime ngaykt)
        {
            DAO.DAO_PhanCong.UpdatePC(mahp, mamh, magv, ngaybd, ngaykt);
        }
        public static void DeletePC(string mahp)
        {
            DAO.DAO_PhanCong.DeletePC(mahp);
        }
    }
}
