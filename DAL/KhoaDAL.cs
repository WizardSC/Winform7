using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace DAL
{
    internal class KhoaDAL : MSSQLConnect
    {
        public DataTable getListKhoa()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Khoa";
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

        public bool insertKhoa(KhoaDTO Khoa)
        {
            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                // string query = "INSERT INTO KhuyenMai(MaKM,TenKM,NgayBatDau,NgayKetThuc,PhanTramKM,DieuKienKM,TrangThaiKM) VALUES(@MaKM,@TenKM,@NgayBatDau,@NgayKetThuc,@PhanTramKM,@DieuKienKM,@TrangThaiKM)";
                string query = "INSERT INTO LoaiSP(MaLoai,TenLoai,TrangThai) VALUES(@MaLoai,@TenLoai,@TrangThai)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaKhoa", Khoa.MaKhoa);
                cmd.Parameters.AddWithValue("@TenLoai", Khoa.TenKhoa);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    //MessageBox.Show("Thêm loại sản phẩm thành công thành công."); // Display a success message
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show("Thêm loại sản phẩm thất bại. " + e.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }

        }
    }
}
