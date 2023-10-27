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
    }
}
