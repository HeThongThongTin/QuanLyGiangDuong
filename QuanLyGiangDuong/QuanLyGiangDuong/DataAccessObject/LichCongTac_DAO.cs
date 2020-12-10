using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyGiangDuong.DataAccessObject
{
    class LichCongTac_DAO : DataProvider
    {
        public DataTable loadLichCongTac()
        {
            string sqlString = $"exec XemLichCongTac";
            return GetData(sqlString);
        }
    }
}
