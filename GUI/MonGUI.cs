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
    public partial class MonGUI : Form
    {
        public MonGUI()
        {
            InitializeComponent();
        }
        private void refreshValue()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtSoTiet.Text = "";
        }
        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvMon.CurrentRow.Index;
            txtMaMH.Text = dgvMon.Rows[i].Cells[i].Value.ToString();
            txtTenMH.Text = dgvMon.Rows[i].Cells[i].Value.ToString();
            txtSoTiet.Text = dgvMon.Rows[i].Cells[i].Value.ToString();

        }
    }
}
