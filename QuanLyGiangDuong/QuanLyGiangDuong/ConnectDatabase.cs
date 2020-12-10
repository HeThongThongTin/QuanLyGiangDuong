using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiangDuong
{
    class ConnectDatabase
    {
        //z
        public string connect = "Data Source=SCORPION;Initial Catalog=QuanLyGiangDuong;Integrated Security=True";
        private SqlConnection sqlcn;
        private SqlCommand sqlcm;
        private SqlDataAdapter sqladt;

        public void Connect()
        {
            sqlcn = new SqlConnection(connect);
            sqlcn.Open();
        }
    }
}
