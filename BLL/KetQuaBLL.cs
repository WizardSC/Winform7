using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KetQuaBLL
    {
        private KetQuaDAL kqDAL;
        public KetQuaBLL() { 
            kqDAL = new KetQuaDAL();
        }
        public bool insertKetQua(KetQua_DTO kq)
        {
            return kqDAL.insertKetQua(kq);
        }
    }
}
