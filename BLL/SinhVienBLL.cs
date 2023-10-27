using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SinhVienBLL
    {
        private SinhVienDAL svDAL;
        public SinhVienBLL()
        {
            svDAL = new SinhVienDAL();

        }

        public DataTable getListSinhVien()
        {
            return svDAL.getListSinhVien();
        }

        public bool insertSinhVien(SinhVienDTO sv)
        {
            return svDAL.insertSinhVien(sv);
        }
    }
}
