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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_DAOcs login = new Login_DAOcs();
            DataTable dt = login.Login(this.textBox1.Text, this.textBox2.Text);
            if(dt.Rows.Count != 0)
            {
                if((string)dt.Rows[0][3] == "1")
                {
                    this.Hide();
                    FormMain fm = new FormMain();
                    fm.ShowDialog();
                    this.Show();
                }
                if ((string)dt.Rows[0][3] == "2")
                {
                    this.Hide();
                    //FormMain2 fm = new FormMain2();
                    //fm.ShowDialog();
                    this.Show();
                }
                if ((string)dt.Rows[0][3] == "3")
                {
                    this.Hide();
                    //FormMain3 fm = new FormMain3();
                    //fm.ShowDialog();
                    this.Show();
                }

            }
            else
            {
                MessageBox.Show("Bạn nhập sai tên hoặc mật khẩu");
            }
        }
    }
}
