using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KetQuaDAL : MSSQLConnect
    {
        public bool insertKetQua(KetQuaDTO kq)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into ketqua values (@MaSo, @MaMH, @Diem)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaSo", kq.MaSo).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaMH", kq.MaMH).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@Diem", kq.DiemSo).SqlDbType = SqlDbType.Int;
               

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }

        }
    }
}
