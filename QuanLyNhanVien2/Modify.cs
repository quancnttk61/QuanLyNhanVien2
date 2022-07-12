using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanVien2
{
    public class Modify
    {
        SqlDataAdapter adapter;// se truy xuat toan bo du lieu vao datatable
        SqlCommand command;// dùng để truy vấn cập nhật với cơ sở  dữ liệu
        public Modify() { }
        public DataTable GetAllNhanVien()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from NhanVien ";
            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                adapter=new SqlDataAdapter(query,sqlConnection);
                adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert(QuanLyNhanVien nhanVien)
        {
            SqlConnection sqlConnection=Connection.GetSqlConnection();
            string query = "insert into  NhanVien values(@MaNV,@Hoten,@GioiTinh,@NgaySinh,@DiaChi,@sodienthoai)";
            try
            {
                sqlConnection.Open();
                command=new SqlCommand(query,sqlConnection);
                command.Parameters.Add("@MaNV",SqlDbType.NVarChar).Value =nhanVien.id;
                command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nhanVien.id;
                command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.gender;
                command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanVien.DateoOfBrith.ToShortDateString();// ngay thang ngắn
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.address;
                command.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = nhanVien.phonenumber;
                command.ExecuteNonQuery();// thuc thi lệnh truy vấn
            }
            catch {
                return false;

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool update(QuanLyNhanVien nhanVien)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "update NhanVien set Hoten=@Hoten,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,sodienthoai=@sodienthoai where MaNV=@MaNV";
            try
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nhanVien.id;
                command.Parameters.Add("@HoTen",SqlDbType.NVarChar).Value = nhanVien.name;
                command.Parameters.Add("GioiTinh",SqlDbType.NVarChar).Value= nhanVien.gender;
                command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanVien.DateoOfBrith.ToShortDateString();
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.address;
                command.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = nhanVien.phonenumber;
                command.ExecuteNonQuery();


            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
                
            }
            return true;
        }
        public bool Delete(string id)
           
        {
            SqlConnection sqlConnection=Connection.GetSqlConnection();
            string query = "delete NhanVien Where MaNV= @MaNV";
            try
            {
                command = new SqlCommand(query, sqlConnection);
                command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = id;
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
