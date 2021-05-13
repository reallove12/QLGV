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
    public partial class PhanCpng : Form
    {
        public PhanCpng()
        {
            InitializeComponent();
        }

        private void PhanCpng_Load(object sender, EventArgs e)
        {
            Loaddl();
        }
        void Loaddl()
        {
            List<DTO_GiaoVien> dsGV = BUS.BUS_GV.GetDSGV();
            txtgv.DataSource = dsGV;
            txtgv.DisplayMember = "TENGV";
            txtgv.ValueMember = "MAGV";
            List<DTO_MH> dsmh = BUS.BUS_MH.GetDSMH();
            cbmh.DataSource = dsmh;
            cbmh.DisplayMember = "TENMH";
            cbmh.ValueMember = "MAMH";
            List<DTO_PhanCong> dspc = BUS.BUS_PhanCong.GetDSPCs();
            dataGridView1.DataSource = dspc;
        }
        int index;
        string mahp;
        void ThemPC()
        {
            if (txtmahp.Text == "" || cbmh.Text == "" || txtgv.Text =="" )
            {
                MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mahp = txtmahp.Text;
                int mamh = Convert.ToInt32(cbmh.SelectedValue.ToString());
                int magv = Convert.ToInt32(txtgv.SelectedValue.ToString());
                DateTime Ngaybd = Convert.ToDateTime(ngaybd.Text);
                DateTime Ngaykt = Convert.ToDateTime(ngaykt.Text);

                BUS.BUS_PhanCong.InsertPC(mahp, mamh, magv, Ngaybd, Ngaykt);
            }
        }
        void SuaPC()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    index = row.Index;
                    mahp = dataGridView1.Rows[index].Cells["Column1"].Value.ToString();
                }
            }
            if (txtmahp.Text == "" || cbmh.Text == "" || txtgv.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mahp = txtmahp.Text;
                int mamh = Convert.ToInt32(cbmh.SelectedValue.ToString());
                int magv = Convert.ToInt32(txtgv.SelectedValue.ToString());
                DateTime Ngaybd = Convert.ToDateTime(ngaybd.Text);
                DateTime Ngaykt = Convert.ToDateTime(ngaykt.Text);

                BUS.BUS_PhanCong.UpdatePC(mahp,mamh, magv, Ngaybd, Ngaykt);
            }
        }
        void XoaPC()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    index = row.Index;
                    mahp = dataGridView1.Rows[index].Cells["Column1"].Value.ToString();
                }
            }
            if (txtmahp.Text == "")
            {
                MessageBox.Show("Không tìm thấy môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.BUS_PhanCong.DeletePC(mahp);
                Loaddl();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemPC();
            Loaddl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuaPC();
            Loaddl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XoaPC();
        }

        private void cbmh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtmahp.Text = row.Cells[0].Value.ToString();
                cbmh.Text = row.Cells[5].Value.ToString();
                txtgv.Text = row.Cells[7].Value.ToString();
                ngaybd.Text = row.Cells[3].Value.ToString();
                ngaykt.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
