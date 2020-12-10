using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiangDuong.DataAccessObject;

namespace QuanLyGiangDuong
{
    public partial class MuonTTBhoctap : Form
    {
        public MuonTTBhoctap()
        {
            InitializeComponent();
        }

        private void MuonTTB_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            NoiDungMuonTTB_DAO nd = new NoiDungMuonTTB_DAO();
            dt1 = nd.loadNoiDungChuaTra();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dt1.Rows[i][7] = false;
            }
            dt2 = nd.loadNoiDungDaTra();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                dt2.Rows[i][7] = true;
            }
            dt = dt1.Clone();
            dt.Merge(dt2);
            this.dtgv_MuonTTB.DataSource = dt;
        }
    }
}
