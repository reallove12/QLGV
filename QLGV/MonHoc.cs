using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLGV
{
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            LoadDSMH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemMH();
            LoadDSMH();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuaMH();
            LoadDSMH();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XoaMH();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtmamh.Text = row.Cells[0].Value.ToString();
                txttenmh.Text = row.Cells[1].Value.ToString();
                txtstc.Text = row.Cells[2].Value.ToString();
            }
        }
        void LoadDSMH()
        {
            List<DTO_MH> dsMH = BUS.BUS_MH.GetDSMH();
            dataGridView1.DataSource = dsMH;
        }
        int index;
        int maMH;
        void ThemMH()
        {
            if(txttenmh.Text =="" || txtstc.Text =="")
            {
                MessageBox.Show("Nhập tên môn học, số tín chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                string tenmh = txttenmh.Text;
                double sotc = Convert.ToDouble(txtstc.Text);
                BUS.BUS_MH.InsertMH(tenmh, sotc);
            }    
        }
        void SuaMH()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    index = row.Index;
                    maMH = Convert.ToInt32(dataGridView1.Rows[index].Cells["MAMH"].Value.ToString());
                }
            }
            if (txttenmh.Text == "" || txtstc.Text == "")
            {
                MessageBox.Show("Nhập tên môn học, số tín chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tenmh = txttenmh.Text;
                double sotc = Convert.ToDouble(txtstc.Text);

                BUS.BUS_MH.UpdateMH(maMH, tenmh, sotc);
            }    
        }
        void XoaMH()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    index = row.Index;
                    maMH = Convert.ToInt32(dataGridView1.Rows[index].Cells["MAMH"].Value.ToString());
                }
            }
            if (txtmamh.Text == "")
            {
                MessageBox.Show("Không tìm thấy môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.BUS_MH.DeleteMH(maMH);
                LoadDSMH();
            }    
        }

        private void txtstc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
