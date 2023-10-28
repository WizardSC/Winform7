using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonDAL : MSSQLConnect
    {
        public DataTable getListMon() {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from mon";
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
        public bool insertMonHoc(MonDTO mon_DTO)
        {

            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "INSERT INTO Mon VALUES(@MaMH,@TenMH,@SoTiet)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaMH", mon_DTO.MaMH).SqlDbType = System.Data.SqlDbType.NChar;
                cmd.Parameters.AddWithValue("@TenMH", mon_DTO.TenMH).SqlDbType = SqlDbType.NChar;
                cmd.Parameters.AddWithValue("@SoTiet", mon_DTO.SoTiet).SqlDbType = SqlDbType.Int;
                cmd.ExecuteReader();
                return true;


            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);

                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
