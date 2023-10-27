using DAL;
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
        public KhoaBLL() { 
            kDAL = new KhoaDAL();   
        }
        public DataTable getListKhoa()
        {
            return kDAL.getListKhoa();
        }
    }
}
