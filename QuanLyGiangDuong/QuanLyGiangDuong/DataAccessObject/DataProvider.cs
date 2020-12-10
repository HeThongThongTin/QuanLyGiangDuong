using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace QuanLyGiangDuong.DataAccessObject
{
    class DataProvider
    {
        static string provider = ConfigurationManager.ConnectionStrings["Conn"].ToString();  // get connection string from app.config
        SqlConnection connect = new SqlConnection(provider);
        
        public bool Check(string sql)
        {
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            var result =  command.ExecuteScalar();
            return (bool) result;
        }
        
        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            adapter.Fill(dt);
            return dt;
        }
        public void Execute(string sql)
        {
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            command.ExecuteNonQuery();
           
            connect.Close();
        }
    }
}
