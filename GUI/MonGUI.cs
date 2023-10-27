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

namespace GUI
{
    public partial class MonGUI : Form
    {

        private MonBLL mon_BLL;
        private DataTable dt;
        public MonGUI()
        {
            InitializeComponent();
            mon_BLL = new MonBLL();
            dt = mon_BLL.DSMonHoc();
            init();
        }


        public void init()
        {
            dataGridView1.DataSource = dt;
        }
        private void MonGUI_Load(object sender, EventArgs e)
        {
            init();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            string MaMH = txtMa.Text;
            string  TenMH = txtTen.Text;
            string sotiet = txtSoTiet.Text;
            Mon_DTO model_mon = new Mon_DTO();

            model_mon.MaMH = MaMH;
            model_mon.TenMH = TenMH;
            model_mon.SoTiet = int.Parse(sotiet);
            mon_BLL.insertMonHoc(model_mon);
            init();
        }
    }
}
