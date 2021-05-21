using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;
using QuanLyYTe.GD_Chung;
using QuanLyYTe.Admin;

namespace QuanLyYTe
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "admin")
            {
                using (var context = new YTeDbContext())
                {
                    var admin = context.NguoiQuanLies.Where(s => s.Password == txtMatKhau.Text).FirstOrDefault();
                    if (admin != null)
                    {
                        this.Hide();
                        MenuUI menu = new MenuUI();
                        menu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại!");
                        return;
                    }
                }
            }
            else
            {
                using(var context= new YTeDbContext())
                {
                    var nhanVien = context.NhanVienYTes.Where(s => s.UserName == txtTenDangNhap.Text && s.Password == txtMatKhau.Text).FirstOrDefault();
                    if (nhanVien != null)
                    {
                        this.Hide();
                        CuaNhanVien cuaNhanVien = new CuaNhanVien();
                        this.Close();
                        cuaNhanVien.ShowDialog();
                        

                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại!");
                        return;

                    }
                }
            }
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LayLaiMatKhau layLaiMatKhau = new LayLaiMatKhau();
            layLaiMatKhau.ShowDialog();
            this.Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            var context = new YTeDbContext();
        }

        //private void lblQuenMatKhau_Click(object sender, EventArgs e)
        //{

        //}
    }
}
