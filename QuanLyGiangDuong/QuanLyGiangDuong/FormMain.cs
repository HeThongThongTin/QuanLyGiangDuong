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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.xtraTabPageNhatKySDGDTop.PageVisible = true;
            this.xtraTabPageNhatKySDGDTop.PageEnabled = true;
            this.xtraTabPageNhatKySDGDTop.Show();
            DataTable dt = new DataTable();
            NhatKySuDungHoiTruong_DAO nk = new NhatKySuDungHoiTruong_DAO();
            dt = nk.loadNhatKy("2020-12-02", 1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var cell = dt.Rows[i][0];
                if (cell.ToString() == "1")
                {
                    dt.Rows[i][0] = true;
                }
                else
                {
                    dt.Rows[i][0] = false;
                }
            }
            this.dataGridView_NKSDGD.DataSource = dt;
        }

        private void dataGridView_NKSDGD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.xtraTabPageKeHoachTop.PageVisible = true;
            this.xtraTabPageKeHoachTop.PageEnabled = true;
            this.xtraTabPageKeHoachTop.Show();
            this.xtraTabPageDSKH.Show();
            KeHoach_DAO kh = new KeHoach_DAO();
            this.dataGridViewDSKH.DataSource = kh.load_DanhSach();
        }
    }
}
