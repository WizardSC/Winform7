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
    public partial class GiaoDienGUI : Form
    {
        public GiaoDienGUI()
        {
            InitializeComponent();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            KhoaGUI khoaGUI = new KhoaGUI();
            khoaGUI.TopLevel = false; // Đặt TopLevel thành false để làm cho form con
            khoaGUI.Parent = pnMain; // Thiết lập form cha là pnMain
            pnMain.Controls.Add(khoaGUI); // Thêm form con vào Controls của pnMain
            khoaGUI.ControlBox = true; // Cho phép hiển thị ControlBox trên form con
            khoaGUI.FormBorderStyle = FormBorderStyle.FixedSingle; // Loại bỏ viền trên form con (nếu cần)
            khoaGUI.Show();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            NhapDiemGUI nhapDiemGUI = new NhapDiemGUI();
            nhapDiemGUI.TopLevel = false; // Đặt TopLevel thành false để làm cho form con
            nhapDiemGUI.Parent = pnMain; // Thiết lập form cha là pnMain
            pnMain.Controls.Add(nhapDiemGUI); // Thêm form con vào Controls của pnMain
            nhapDiemGUI.ControlBox = true; // Cho phép hiển thị ControlBox trên form con
            nhapDiemGUI.FormBorderStyle = FormBorderStyle.FixedSingle; // Loại bỏ viền trên form con (nếu cần)
            nhapDiemGUI.Show();
        }
    }
}
