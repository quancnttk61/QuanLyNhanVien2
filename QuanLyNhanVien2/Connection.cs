using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace QuanLyNhanVien2
{
    public class Connection
    {
        public static string stringconnection = @"Data Source=DESKTOP-1BOF7VE\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringconnection);
        }
    }
}
