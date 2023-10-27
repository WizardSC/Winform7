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
    public class MonBLL
    {
        private MonHoc_DAL MonDAL;

        public MonBLL()
        {
            MonDAL = new MonHoc_DAL();
        }

        public DataTable DSMonHoc()
        {

            return MonDAL.getMH_DAL();
        }
        public bool insertMonHoc(Mon_DTO monDTO)
        {
            return MonDAL.insert_MonHoc(monDTO);
        }
    }
}
