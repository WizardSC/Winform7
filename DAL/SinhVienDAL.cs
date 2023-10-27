using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.SinhVienDAL;

namespace DAL
{
    public class SinhVienDAL
    {
        public class SanPhamDAL : MSSQLConnect
        {
            public DataTable getListSanPham()
            {
                DataTable dt = new DataTable();
                try
                {
                    Connect();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from sinhvien";
                    cmd.Connection = conn;
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    adt.Fill(dt);
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    Disconnect();
                }
                return dt;
            }

          
        }
    }

}
