using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_TaiKhoan
    {
        public static List<DTO_TaiKhoan> GetDSTK()
        {
            List<DTO_TaiKhoan> dstk = new List<DTO_TaiKhoan>();
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                var query = from u in qlgv.TaiKhoans
                            select u;

                foreach (var row in query)
                {
                    DTO_TaiKhoan tk = new DTO_TaiKhoan();
                    tk.matk = row.MATK;
                    tk.username = row.USERNAME;
                    tk.password = row.PASSWORD;
                    tk.quyen = row.QUYEN;
                    dstk.Add(tk);
                }
                return dstk;
            }
        }
        public static void InsertTK(string username, string password, string quyen)
        {
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                TaiKhoan tk = new TaiKhoan();
                tk.USERNAME = username;
                tk.PASSWORD = password;
                tk.QUYEN = quyen;

                qlgv.TaiKhoans.InsertOnSubmit(tk);
                qlgv.SubmitChanges();
            }
        }
        public static void UpdateTK(int matk, string username, string password, string quyen)
        {

            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                TaiKhoan tk = new TaiKhoan();
                tk = qlgv.TaiKhoans.Where(s => s.MATK == matk).Single();

                tk.USERNAME = username;
                tk.PASSWORD = password;
                tk.QUYEN = quyen;

                qlgv.SubmitChanges();
            }
        }
        public static void DeleteTK(int matk)
        {
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                TaiKhoan tk = new TaiKhoan();
                tk = qlgv.TaiKhoans.Where(s => s.MATK == matk).Single();

                qlgv.TaiKhoans.DeleteOnSubmit(tk);
                qlgv.SubmitChanges();
            }
        }
    }
}
