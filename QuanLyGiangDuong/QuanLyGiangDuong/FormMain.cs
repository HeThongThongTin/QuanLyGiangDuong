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
        NoiDungMuonTTB_DAO nd = new NoiDungMuonTTB_DAO();
        DataTable dt = new DataTable();

        public FormMain()
        {
            InitializeComponent();
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
            //this.xtraTabPageKeHoachTop.PageVisible = true;
            //this.xtraTabPageKeHoachTop.PageEnabled = true;
            //this.xtraTabPageKeHoachTop.Show();
            //this.xtraTabPageDSKH.Show();
            //KeHoach_DAO kh = new KeHoach_DAO();
            //this.dataGridViewDSKH.DataSource = kh.load_DanhSach();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiangDuongDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.quanLyGiangDuongDataSet.Phong);
            // TODO: This line of code loads data into the 'quanLyGiangDuongDataSet.HoiTruong' table. You can move, or remove it, as needed.
            this.hoiTruongTableAdapter.Fill(this.quanLyGiangDuongDataSet.HoiTruong);
            // TODO: This line of code loads data into the 'quanLyGiangDuongDataSet.VatChat' table. You can move, or remove it, as needed.
            this.vatChatTableAdapter.Fill(this.quanLyGiangDuongDataSet.VatChat);

            dt = nd.loadNoiDungAll();
            this.dtgv_MuonTTB.DataSource = dt;

            DataGridViewButtonColumn modifycolumn = new DataGridViewButtonColumn();
            modifycolumn.Name = "Sửa";
            modifycolumn.Text = "Sửa";
            modifycolumn.UseColumnTextForButtonValue = true;
            int columnIndex = 7;
            if (dtgv_MuonTTB.Columns["Sửa"] == null)
            {
                dtgv_MuonTTB.Columns.Insert(columnIndex, modifycolumn);
            }

            DataGridViewButtonColumn deletecolumn = new DataGridViewButtonColumn();
            deletecolumn.Name = "Xóa";
            deletecolumn.Text = "Xóa";
            deletecolumn.UseColumnTextForButtonValue = true;
            int columnIndex2 = 8;
            if (dtgv_MuonTTB.Columns["Xóa"] == null)
            {
                dtgv_MuonTTB.Columns.Insert(columnIndex2, deletecolumn);
            }
        }

        private void DSVC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                pn_sua_qlvc.Visible = true;
                pn_sua_qlvc.Dock = DockStyle.Fill;

                btn_them_qlvc.Visible = false;
                tb_mavc_suavc.Text = dtgv_dsvc.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_madm_suavc.Text = dtgv_dsvc.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_tenvc_suavc.Text = dtgv_dsvc.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_giatien_suavc.Text = dtgv_dsvc.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_ngaynhap_suavc.Text = dtgv_dsvc.Rows[e.RowIndex].Cells[4].Value.ToString();
                lstbx_trangthai_suavc.Text = dtgv_dsvc.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else
            {
                if (e.ColumnIndex == 7)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa môn học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DanhSachVatChat_DAO ds = new DanhSachVatChat_DAO();
                        ds.XoaVC(dtgv_dsvc.Rows[e.RowIndex].Cells[0].Value.ToString());
                        
                        FormMain_Load(sender, e);
                    }
                }
            }
        }

        private void btn_them_qlvc_Click(object sender, EventArgs e)
        {
            pn_them_qlvc.Visible = true;
            pn_them_qlvc.Dock = DockStyle.Fill;
            btn_them_qlvc.Visible = false;
            pn_sua_qlvc.Visible = false;
        }

        private void btn_huy_themvc_Click(object sender, EventArgs e)
        {
            btn_them_qlvc.Visible = true;
            pn_them_qlvc.Visible = false;
            FormMain_Load(sender, e);
        }

        private void btn_them_themvc_Click(object sender, EventArgs e)
        {
            string a;
            DanhSachVatChat_DAO ds = new DanhSachVatChat_DAO();
            if (lstbx_trangthai_themvc.Text == "Tốt")
            {
                a = "1";
            }
            else
            {
                a = "0";
            }
            ds.ThemVC(tb_mavc_themvc.Text, tb_madm_themvc.Text, tb_tenvc_themvc.Text, tb_giatien_themvc.Text, tb_ngaynhap_themvc.Text, a);
            tb_mavc_themvc.Text = "";
            tb_madm_themvc.Text = "";
            tb_tenvc_themvc.Text = "";
            tb_giatien_themvc.Text = "";
            tb_ngaynhap_themvc.Text = "";
            lstbx_trangthai_themvc.Text = "Tốt";
        }

        private void btn_huy_suavc_Click(object sender, EventArgs e)
        {
            pn_sua_qlvc.Visible = false;
            btn_them_qlvc.Visible = true;
            FormMain_Load(sender, e);
        }

        private void btn_sua_suavc_Click(object sender, EventArgs e)
        {
            string a;
            DanhSachVatChat_DAO ds = new DanhSachVatChat_DAO();
            btn_them_qlvc.Visible = true;
            if (lstbx_trangthai_suavc.Text == "Tốt")
            {
                a = "1";
            }
            else
            {
                a = "0";
            }
            ds.SuaVC(tb_mavc_suavc.Text, tb_tenvc_suavc.Text, tb_giatien_suavc.Text, tb_ngaynhap_suavc.Text, a);
            pn_sua_qlvc.Visible = false;
            FormMain_Load(sender, e);
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.vatChatTableAdapter.Fill(this.quanLyGiangDuongDataSet.VatChat);
            dtgv_dsvc.Update();
            dtgv_dsvc.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.xtraTabPageQuanLyCanBoTop.PageVisible = true;
            this.xtraTabPageQuanLyCanBoTop.Show();
            this.xtraTabPageLCT.Show();
            LichCongTac_DAO lct = new LichCongTac_DAO();
            this.dataGridViewLCT.DataSource = lct.loadLichCongTac();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.xtraTabPageQuanLyCanBoTop.PageVisible = true;
            this.xtraTabPageQuanLyCanBoTop.Show();
            this.xtraTabPageLCT.Show();
            CanBo_DAO cb = new CanBo_DAO();
            this.dataGridViewDSCB.DataSource = cb.loadDanhSachCanBo();
        }

        private void dtgv_MuonTTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
