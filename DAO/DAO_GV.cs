using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_GV
    {
        public static List<DTO_GiaoVien> GetDSGVs()
        {
            List<DTO_GiaoVien> dsGV = new List<DTO_GiaoVien>();
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                var query = from u in qlgv.GiaoViens
                            select u;

                foreach (var row in query)
                {
                    DTO_GiaoVien gv = new DTO_GiaoVien();
                    gv.magv = row.MAGV;
                    gv.tengv = row.TENGV;
                    gv.ngaysinh = Convert.ToDateTime(row.NGAYSINH);
                    gv.diachi = row.DIACHI;
                    gv.sdt = row.SDT;
                    dsGV.Add(gv);
                }
                return dsGV;
            }
        }
        public static void InsertGVt(string tengv, DateTime ngaysinh, string diachi, string sdt)
        {
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                GiaoVien gv = new GiaoVien();
                gv.TENGV = tengv;
                gv.NGAYSINH = ngaysinh;
                gv.DIACHI = diachi;
                gv.SDT = sdt;
                
                qlgv.GiaoViens.InsertOnSubmit(gv);
                qlgv.SubmitChanges();
            }
        }
        public static void UpdateGV(int magv, string tengv, DateTime ngaysinh, string diachi, string sdt)
        {

            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                GiaoVien gv = new GiaoVien();
                gv = qlgv.GiaoViens.Where(s => s.MAGV == magv).Single();

                gv.TENGV = tengv;
                gv.NGAYSINH = ngaysinh;
                gv.DIACHI = diachi;
                gv.SDT = sdt;

                qlgv.SubmitChanges();
            }
        }
        public static void DeleteGV(int magv)
        {
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                GiaoVien gv = new GiaoVien();
                gv = qlgv.GiaoViens.Where(s => s.MAGV == magv).Single();

                qlgv.GiaoViens.DeleteOnSubmit(gv);
                qlgv.SubmitChanges();
            }
        }
    }
}
