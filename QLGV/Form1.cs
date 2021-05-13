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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDSGV();
        }
        void LoadDSGV()
        {
            List<DTO_GiaoVien> dsGV = BUS.BUS_GV.GetDSGV();
            dataGridView1.DataSource = dsGV;
        }
        int index;
        int maGV;
        private void button2_Click(object sender, EventArgs e)
        {
            SuaGV();
            LoadDSGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemGV();
            LoadDSGV();
        }
        void ThemGV()
        {
            if (txttengv.Text == "" || txtngaysinh.Text == "" || txtdc.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                string tengv = txttengv.Text;
                DateTime ngaysinh = Convert.ToDateTime(txtngaysinh.Text);
                string diachi = txtdc.Text;
                string sdt = maskedTextBox1.Text;
                if (sdt.Length > 10)
                {
                    MessageBox.Show("Số điện thoại nhập không hợp lệ");
                    IsValidPhone(maskedTextBox1.Text);
                }
                else
                {
                    BUS.BUS_GV.InsertGV(tengv, ngaysinh, diachi, sdt);
                }
            }    
        }
        void SuaGV()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    index = row.Index;
                    maGV = Convert.ToInt32(dataGridView1.Rows[index].Cells["MAGV"].Value.ToString());
                }
            }
            if (txttengv.Text == "" || txtngaysinh.Text == "" || txtdc.Text =="" || maskedTextBox1.Text =="")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tengv = txttengv.Text;
                DateTime ngaysinh = Convert.ToDateTime(txtngaysinh.Text);
                string diachi = txtdc.Text;
                string sdt = maskedTextBox1.Text;
                if (sdt.Length > 10)
                {
                    MessageBox.Show("Số điện thoại nhập không hợp lệ");
                    IsValidPhone(maskedTextBox1.Text);
                }
                else
                {
                    BUS.BUS_GV.UpdateGV(maGV, tengv, ngaysinh, diachi, sdt);
                }
            }    
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtmagv.Text = row.Cells[0].Value.ToString();
                txttengv.Text = row.Cells[1].Value.ToString();
                txtngaysinh.Text = row.Cells[2].Value.ToString();
                txtdc.Text = row.Cells[3].Value.ToString();
                maskedTextBox1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XoaGV();
        }
        void XoaGV()
        {
             
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {
                    index = row.Index;
                    maGV = Convert.ToInt32(dataGridView1.Rows[index].Cells["MAGV"].Value.ToString());
                }
            }
            if (txtmagv.Text == "")
            {
                MessageBox.Show("Không tìm thấy môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BUS.BUS_GV.DeleteGV(maGV);
                LoadDSGV();
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        public static bool IsValidPhone(string value)
        {
            string pattern = @"^-*[0-9,\.?\-?\(?\)?\ ]+$";
            return Regex.IsMatch(value, pattern);
        }
    }
}
