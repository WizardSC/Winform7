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
        private SinhVienGUI svGUI = null; // Biến để theo dõi form SinhVienGUI
        private KhoaGUI khoaGUI = null; // Biến để theo dõi form KhoaGUI
        private NhapDiemGUI nhapDiemGUI = null; // Biến để theo dõi form NhapDiemGUI
        public GiaoDienGUI()
        {
            InitializeComponent();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (khoaGUI == null)
            {
                khoaGUI = new KhoaGUI();
                khoaGUI.TopLevel = false;
                khoaGUI.Parent = pnMain;
                pnMain.Controls.Add(khoaGUI);
                khoaGUI.ControlBox = true;
                khoaGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                khoaGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                khoaGUI.FormClosed += (s, args) => khoaGUI = null; // Đặt khoaGUI thành null khi form bị đóng
                khoaGUI.Show();
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (nhapDiemGUI == null)
            {
                nhapDiemGUI = new NhapDiemGUI();
                nhapDiemGUI.Location = new Point(200, 300);
                nhapDiemGUI.TopLevel = false;
                nhapDiemGUI.Parent = pnMain;
                pnMain.Controls.Add(nhapDiemGUI);
                nhapDiemGUI.ControlBox = true;
                nhapDiemGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                nhapDiemGUI.Click += (s, args) => { ((Form)s).BringToFront(); };
                nhapDiemGUI.FormClosed += (s, args) => nhapDiemGUI = null; // Đặt nhapDiemGUI thành null khi form bị đóng
                nhapDiemGUI.Show();
            }
        }

        private void btnOpenSinhVien_Click(object sender, EventArgs e)
        {

            if (svGUI == null)
            {
                svGUI = new SinhVienGUI();
                svGUI.Location = new Point(10, 10);
                svGUI.TopMost = false;
                svGUI.TopLevel = false;
                svGUI.Parent = pnMain;
                pnMain.Controls.Add(svGUI);
                svGUI.ControlBox = true;
                svGUI.FormBorderStyle = FormBorderStyle.FixedSingle;
                svGUI.Click += (s, args) => svGUI.BringToFront();
                svGUI.FormClosed += (s, args) => svGUI = null; // Đặt svGUI thành null khi form bị đóng
                svGUI.Show();
            }
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
