using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyGiangDuong.DataAccessObject
{
    class Login_DAOcs : DataProvider
    {
        public DataTable Login(string user, string pass)
        {
            string sql = $"select * from dbo.TaiKhoan where TenTaiKhoan = '{user}' and MatKhau = '{pass}'";
            return GetData(sql);
        }
    }
}
