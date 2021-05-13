using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_PhanCong
    {
        public static List<DTO_PhanCong> GetDSPCs()
        {
            List<DTO_PhanCong> dspc = new List<DTO_PhanCong>();
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                var query = from u in qlgv.PhanCongs
                            join t in qlgv.MonHocs
                            on u.MAMH equals t.MAMH
                            join v in qlgv.GiaoViens
                            on u.MAGV equals v.MAGV
                            select new
                            {
                                MAHP = u.MAHP,
                                MAMH = u.MAMH,
                                TENHP = t.TENMH,
                                SOTC = t.SOTC,
                                NGAYBD = u.NGAYBD,
                                NGAYKT = u.NGAYKT,
                                MAGV = u.MAGV,
                                TENGV = v.TENGV,
                                GV = v.TENGV + " "+ "(" + v.SDT+ ")"
                            };

                foreach (var row in query)
                {
                    DTO_PhanCong pc = new DTO_PhanCong();
                    pc.mahp = row.MAHP;
                    pc.magv = Convert.ToInt32(row.MAGV);
                    pc.mamh = Convert.ToInt32(row.MAMH);
                    pc.tenmh = row.TENHP;
                    pc.sotc = Convert.ToDouble(row.SOTC);
                    pc.ngaybd = Convert.ToDateTime(row.NGAYBD);
                    pc.ngaykt = Convert.ToDateTime(row.NGAYKT);
                    pc.tengv = row.TENGV;
                    pc.GV = row.GV;
                    dspc.Add(pc);
                }
                return dspc;
            }
        }
        public static void InsertPC(string mahp, int mamh, int magv, DateTime ngaybd, DateTime ngaykt)
        {
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                PhanCong pc = new PhanCong();
                pc.MAHP = mahp;
                pc.MAMH = mamh;
                pc.MAGV = magv;
                pc.NGAYBD = Convert.ToDateTime(ngaybd);
                pc.NGAYKT = Convert.ToDateTime(ngaykt);

                qlgv.PhanCongs.InsertOnSubmit(pc);
                qlgv.SubmitChanges();
            }
        }
        public static void UpdatePC(string mahp, int mamh, int magv, DateTime ngaybd, DateTime ngaykt)
        {

            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                PhanCong pc = new PhanCong();
                pc = qlgv.PhanCongs.Where(s => s.MAHP == mahp).Single();

                pc.MAMH = mamh;
                pc.MAGV = magv;
                pc.NGAYBD = Convert.ToDateTime(ngaybd);
                pc.NGAYKT = Convert.ToDateTime(ngaykt);

                qlgv.SubmitChanges();
            }
        }
        public static void DeletePC(string mahp)
        {
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                PhanCong pc = new PhanCong();
                pc = qlgv.PhanCongs.Where(s => s.MAHP == mahp).Single();

                qlgv.PhanCongs.DeleteOnSubmit(pc);
                qlgv.SubmitChanges();
            }
        }
    }
}
