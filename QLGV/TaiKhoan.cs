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
using BUS;

namespace QLGV
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDStk();
        }
        void LoadDStk()
        {
            List<DTO_TaiKhoan> dstk = BUS.BUS_TaiKhoan.GetDSTK();
            dataGridView1.DataSource = dstk;
        }
        int index;
        int maTK;
        void Themtk()
        {
            if (txtusername.Text == "" || txtpass.Text == "" || cbquyen.Text =="")
            {
                MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string user = txtusername.Text;
                string pass = txtpass.Text;
                string quyen = cbquyen.Text;
                BUS.BUS_TaiKhoan.InsertTK(user, pass, quyen);
                LoadDStk();
            }
        }
        void Suatk()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    index = row.Index;
                    maTK = Convert.ToInt32(dataGridView1.Rows[index].Cells["MATK"].Value.ToString());
                }
            }
            if (txtusername.Text == "" || txtpass.Text == "" || cbquyen.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int matk = Convert.ToInt32(txtmatk.Text);
                string user = txtusername.Text;
                string pass = txtpass.Text;
                string quyen = cbquyen.Text;

                BUS.BUS_TaiKhoan.UpdateTK(matk, user, pass, quyen);
                LoadDStk();
            }
        }
        void Xoatk()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    index = row.Index;
                    maTK = Convert.ToInt32(dataGridView1.Rows[index].Cells["MATK"].Value.ToString());
                }
            }
            if (txtmatk.Text == "")
            {
                MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.BUS_TaiKhoan.DeleteTK(maTK);
                LoadDStk();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themtk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suatk();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xoatk();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtmatk.Text = row.Cells[0].Value.ToString();
                txtusername.Text = row.Cells[1].Value.ToString();
                txtpass.Text = row.Cells[2].Value.ToString();
                cbquyen.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
