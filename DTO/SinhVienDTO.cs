using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class SinhVienDTO
    {
        private int maSo;
        private string hoTen;
        private DateTime ngaySinh;
        private int gioiTinh;
        private string diaChi;
        private int dienThoai;
        private string maKhoa; 

        SinhVienDTO(int maSo,string hoTen,DateTime ngaySinh,int gioiTinh, string diaChi, int dienThoai, string maKhoa) {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi =   diaChi;
            this.dienThoai = dienThoai;
            this.maKhoa     = maKhoa;
        }
        public int MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public int DienThoai { get  => dienThoai; set => dienThoai = value;}

        public string MaKhoa { get => maKhoa; set => maKhoa = value;     }
    }
}
