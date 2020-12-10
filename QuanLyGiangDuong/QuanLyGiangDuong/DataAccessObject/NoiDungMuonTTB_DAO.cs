using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiangDuong.DataAccessObject
{
    class NoiDungMuonTTB_DAO : DataProvider
    {
        public DataTable loadNoiDungAll()
        {
            string sqlString = $"exec XemNoiDungDanhSachMuonTTB";
            return GetData(sqlString);
        }

        public DataTable loadNoiDungDaTra()
        {
            string sqlString = $"exec XemTTB_DaTra '2020-04-05'";
            return GetData(sqlString);
        }

        public DataTable loadNoiDungChuaTra()
        {
            string sqlString = $"exec XemTTB_ChuaTra '2020-04-05'";
            return GetData(sqlString);
        }
    }
}
