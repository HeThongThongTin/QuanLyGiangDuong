﻿using System;
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
    public partial class NhatKySuDungGD : Form
    {
        public NhatKySuDungGD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NhatKySuDungGD_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NhatKySuDungHoiTruong_DAO nk = new NhatKySuDungHoiTruong_DAO();
            dt = nk.loadNhatKy("2020-12-02",1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var cell = dt.Rows[i][0];
                if(cell.ToString() == "1")
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

        
    }
}
