using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_MH
    {
        public static List<DTO_MH> GetDSMH()
        {
            List<DTO_MH> dsMH = new List<DTO_MH>();
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                var query = from u in qlgv.MonHocs
                            select u;

                foreach (var row in query)
                {
                    DTO_MH mh = new DTO_MH();
                    mh.mamh = row.MAMH;
                    mh.tenmh = row.TENMH;
                    mh.sotc = Convert.ToDouble(row.SOTC);
                    dsMH.Add(mh);
                }
                return dsMH;
            }
        }
        public static void Insertmh(string tenmh, double stc)
        {
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                MonHoc mh = new MonHoc();
                mh.TENMH = tenmh;
                mh.SOTC = stc;

                qlgv.MonHocs.InsertOnSubmit(mh);
                qlgv.SubmitChanges();
            }
        }
        public static void Updatemh(int mamh, string tenmh, double stc)
        {

            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                MonHoc mh = new MonHoc();
                mh = qlgv.MonHocs.Where(s => s.MAMH == mamh).Single();

                mh.TENMH = tenmh;
                mh.SOTC = stc;

                qlgv.SubmitChanges();
            }
        }
        public static void Deletemh(int mamh)
        {
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                MonHoc mh = new MonHoc();
                mh = qlgv.MonHocs.Where(s => s.MAMH == mamh).Single();

                qlgv.MonHocs.DeleteOnSubmit(mh);
                qlgv.SubmitChanges();
            }
        }
    }

}
