using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form1 : Form
    {
        private string taiKhoanDung = "danh";
        private string matKhauDung = "123";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            // Kiểm tra định dạng tài khoản và mật khẩu
            if (!IsValidUsername(taiKhoan))
            {
                lblThongBao.Text = "Tên người dùng không hợp lệ!";
                return;
            }

            // Kiểm tra tài khoản và mật khẩu
            if (taiKhoan == taiKhoanDung && matKhau == matKhauDung)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private bool IsValidUsername(string taiKhoan)
        {
            
            
                // Kiểm tra định dạng tên người dùng (không có ký tự đặc biệt)
                string pattern = "^[a-zA-Z0-9_]+$";
                return Regex.IsMatch(taiKhoan, pattern);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}

 

       