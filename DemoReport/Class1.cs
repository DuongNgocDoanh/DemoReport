using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoReport
{
    internal class Class1
    {
        private string connectionString = @"Data Source=DESKTOP-VT4B3DF\SQLEXPRESS;Initial Catalog=TranhAnh;User ID=sa;Password=abc123";


        public DataTable GetThuMuc()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "Select * from HangHoa";
                SqlDataAdapter adt = new SqlDataAdapter(query,conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
        }
    }
}