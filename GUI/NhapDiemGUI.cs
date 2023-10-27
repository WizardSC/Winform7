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
    public partial class NhapDiemGUI : Form
    {
        private KetQuaBLL kqBLL;
        public NhapDiemGUI()
        {
            InitializeComponent();
            kqBLL = new KetQuaBLL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void loadToCBXMaSo()
        {

        }
    }
}
