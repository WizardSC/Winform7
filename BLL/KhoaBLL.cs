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
    public class KhoaBLL
    {
        private KhoaDAL kDAL;
        public KhoaBLL()
        {
            kDAL = new KhoaDAL();
        }
        public DataTable getListKhoa()
        {
            return kDAL.getListKhoa();
        }

        public bool insertKhoa(KhoaDTO khoa)
        {
            return kDAL.insertKhoa(khoa);
        }
    }
}
