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
    public class MonHoc_DAL : MSSQLConnect
    {

        public DataTable getMH_DAL()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Mon";
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
        public bool insert_MonHoc(Mon_DTO mon_DTO)
        {

            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "INSERT INTO Mon(MaMH,TenMH,SoTiet) VALUES(@MaMH,@TenMH,@SoTiet)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaMH", mon_DTO.MaMH);
                cmd.Parameters.AddWithValue("@TenMH", mon_DTO.TenMH);
                cmd.Parameters.AddWithValue("@SoTiet", mon_DTO.SoTiet);
                cmd.ExecuteReader();
                return true;


            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
