using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiangDuong.DataAccessObject
{
    class NhatKySuDungHoiTruong_DAO : DataProvider
    {
        public DataTable loadNhatKy(string date , int mand)
        {
            string sqlString = $"exec XemNhatKySuDungHoiTruong @Ngay = '{date}' , @MaND = {mand}";
            return GetData(sqlString);
        }
    }
}
