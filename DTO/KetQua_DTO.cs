using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KetQua_DTO
    {
        private int maSo;
        private string maMH;
        private int Diem;
        public KetQua_DTO() { }

        public KetQua_DTO(int maSo, string maMH, int Diem)
        {
            this.maSo = maSo;
            this.maMH = maMH;
            this.Diem = Diem;
        }

        public int MaSo { get => maSo; set => maSo = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public int DiemSo  { get => Diem; set => Diem = value; }
    }
}
