using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KetQuaDAL
    {
        public DataTable getKetQua_DAL()
        {
            sql.openConnectToMySql();
            string query = "select nhanvien.idnhanvien,nhanvien.tennhanvien,nhanvien.diachi,chucvu.tenchucvu from nhanvien,chucvu where nhanvien.idchucvu = chucvu.idchucvu";

            MySqlCommand cmd = new MySqlCommand(query, sql.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            sql.closeConnectToMySql();
            return data;

        }
    }
}
