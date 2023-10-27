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
    }
}
