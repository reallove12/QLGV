using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace QLGV
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHoc f = new MonHoc();
            f.ShowDialog();
        }

        private void phânCôngLịchDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanCpng f = new PhanCpng();
            f.ShowDialog();
        }

        private void quảnTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (role.quyen == "Admin")
            {
                TaiKhoan f = new TaiKhoan();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có quyền truy cập");
            }    
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
