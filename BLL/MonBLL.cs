using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonBLL
    {
        private MonHoc_DAL MonDAL;
        public bool insertMonHoc(Mon_DTO monDTO)
        {
            return MonDAL.insert_MonHoc(monDTO);
        }
    }
}
