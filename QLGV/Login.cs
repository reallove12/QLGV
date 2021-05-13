using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsvalidUser(txtuser.Text, txtpass.Text))
            {
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
                using (QLGVDataContext qlgv = new QLGVDataContext())
                {
                    var q = from p in qlgv.TaiKhoans
                            where p.USERNAME == txtuser.Text
                            && p.PASSWORD == txtpass.Text
                            select p.QUYEN;
                    foreach (var quyen in q)
                        DTO.role.quyen  = quyen;
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Clear();
                txtpass.Clear();
            }    
        }
        
        private bool IsvalidUser(string userName, string password)
        {
            using (QLGVDataContext qlgv = new QLGVDataContext())
            {
                var q = from p in qlgv.TaiKhoans
                        where p.USERNAME == userName
                        && p.PASSWORD == password
                        select p;                    
                if (q.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }    
        }
    }
}
