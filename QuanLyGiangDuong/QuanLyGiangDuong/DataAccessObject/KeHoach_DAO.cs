using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyGiangDuong.DataAccessObject
{
    class KeHoach_DAO : DataProvider
    {
        public DataTable load_DanhSach()
        {
            string sql = "select * from dbo.KeHoach";
            return GetData(sql);
        }
    }
}
