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
            InitializeComponent();
            dgvSinhVien.DataSource = svBLL.getListSinhVien();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSinhVien.CurrentRow.Index;
            txtMaSo.Text = dgvSinhVien.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvSinhVien.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvSinhVien.Rows[i].Cells[2].Value.ToString());
            string gioiTinh = dgvSinhVien.Rows[i].Cells[3].Value.ToString();
           

            if (bool.TryParse(gioiTinh, out bool gioiTinhBool))
            {
                chkGioiTinh.Checked = gioiTinhBool;
            }
            else
            {
                chkGioiTinh.Checked = false;

            }
            //cbx.Text = dgvSinhVien.Rows[i].Cells[0].Value.ToString();
            txtDiaChi.Text = dgvSinhVien.Rows[i].Cells[4].Value.ToString();
            txtSoDT.Text = dgvSinhVien.Rows[i].Cells[5].Value.ToString();
            cbxMaKhoa.SelectedItem = dgvSinhVien.Rows[i].Cells[6].Value.ToString();
        }

        private void dgvSinhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvSinhVien.Columns["GioiTinh"].Index && e.Value != null)
            {
                if (e.Value is bool gioiTinhValue)
                {
                    e.Value = gioiTinhValue ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
