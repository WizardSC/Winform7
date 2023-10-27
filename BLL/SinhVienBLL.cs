using DAL;
using System;
using System.Collections.Generic;
using System.Data;


using static DAL.SinhVienDAL;

namespace BLL
{
    public class SinhVienBLL
    {
        private SinhVien svDAL;


        public SinhVienBLL()
        {
            svDAL = new SinhVien();
        }
        public DataTable getSinhVien()
        {
            return svDAL.getListSinhVien();
        }   
        
    }
}
