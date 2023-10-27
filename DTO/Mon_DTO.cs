using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Mon_DTO
    {
        private string maMH;
        private string tenMH;
        private int soTiet;
        public Mon_DTO() { }

        public Mon_DTO(string maMH, string tenMH, int soTiet)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTiet = soTiet;
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public int  SoTiet { get => soTiet; set => soTiet = value; }
    }
}
