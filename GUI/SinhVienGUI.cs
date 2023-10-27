using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SinhVienGUI : Form
    {

        private SinhVienBLL svBLL;
        private DataTable dt;
        public SinhVienGUI()
        {
            svBLL = new SinhVienBLL();
            dt = svBLL.getSinhVien();
            InitializeComponent();
            loadForm();
        }
        private void loadForm()
        {
            dgvSinhVien.DataSource = dt;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void SinhVienGUI_Load(object sender, EventArgs e)
        {

        }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSinhVien.CurrentRow.Index;
            txtMaSo.Text = dgvSinhVien.Rows[i].Cells[0].Value.ToString();  
            txtHoTen.Text = dgvSinhVien.Rows[i].Cells[1].Value.ToString();
            DateTime dtpNgaySinh = DateTime.Parse(dgvSinhVien.Rows[i].Cells[2].Value.ToString());
            txtDiaChi.Text = dgvSinhVien.Rows[i].Cells[4].Value.ToString();
            txtDienThoai.Text = dgvSinhVien.Rows[i].Cells[5].Value.ToString();
            txtMaKhoa.Text = dgvSinhVien.Rows[i].Cells[6].Value.ToString();


        }
    }
}
