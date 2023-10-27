using BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI
{
    public partial class KhoaGUI : Form
    {
        private DataTable dt;
        private KhoaBLL kBLL;
        public KhoaGUI()
        {
            InitializeComponent();
            kBLL = new KhoaBLL();
            dt = kBLL.getListKhoa();
        }

        private void KhoaGUI_Load(object sender, EventArgs e)
        {

            dgvKhoa.DataSource = kBLL.getListKhoa();
            Console.WriteLine(1);
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhoa.CurrentRow.Index;
            txtMaKhoa.Text = dgvKhoa.Rows[i].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[i].Cells[1].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            refreshValue();
        }

        private void refreshValue()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            dgvKhoa.DataSource = kBLL.getListKhoa();

        }
        private bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }
        private void btnNhapThongTin_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtMaKhoa.Text) || string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (IsNumeric(txtMaKhoa.Text) || IsNumeric(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập chuỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            KhoaDTO khoa = new KhoaDTO(txtMaKhoa.Text, txtTenKhoa.Text);
            int result = (kBLL.insertKhoa(khoa)) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                refreshValue();
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
