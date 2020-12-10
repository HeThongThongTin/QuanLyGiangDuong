using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiangDuong.DataAccessObject
{
    class DanhSachVatChat_DAO : DataProvider
    {
        public void SuaVC(string mavc, string tenvc, string giatien, string ngaynhap, string trangthai)
        {
            Execute("update Vatchat set tenvatchat = N'" + tenvc + "', GiaTien = " + giatien + ", ngaynhap = '" + ngaynhap + "', TrangThai = " + trangthai + " where mavatchat = " + mavc);
        }

        public void XoaVC(string mavc)
        {
            Execute("delete from Vatchatdikem where mavatchat = " + mavc);
            Execute("delete from noidungdsm_ttb where mavatchat = " + mavc);
            Execute("delete from Vatchat where mavatchat = " + mavc);
        }

        public void ThemVC(string mavc, string madm, string tenvc, string giatien, string ngaynhap, string trangthai)
        {
            ConnectDatabase connectDatabase = new ConnectDatabase();
            SqlCommand command;
            SqlConnection connectstr;
            string add = "INSERT INTO VatChat values(" + mavc + ", " + madm + ", N'" + tenvc + "', " + giatien + ", '" + ngaynhap + "', " + trangthai + ");";
            //Execute(add);

            using (connectstr = new SqlConnection(connectDatabase.connect))
            {
                connectstr.Open();
                command = new SqlCommand("INSERT INTO VatChat values(" + mavc + ", " + madm + ", N'" + tenvc + "', " + giatien + ", '" + ngaynhap + "', " + trangthai + ")", connectstr);
                command.ExecuteNonQuery();
            }
        }
    }
}
