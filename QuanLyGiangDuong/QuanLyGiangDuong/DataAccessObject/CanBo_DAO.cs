using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyGiangDuong.DataAccessObject
{
    class CanBo_DAO : DataProvider
    {
        public DataTable loadDSCanBo()
        {
            string sql = "Select * from dbo.CanBo";
            return GetData(sql);
        }
    }
}
