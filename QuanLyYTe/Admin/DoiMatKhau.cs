using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyYTe.Admin
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if(txtMatKhauHienTai.Text==""||
                txtMatKhauMoi.Text==""||
                txtMatKhauXacNhan.Text==""
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (txtMatKhauMoi.Text != txtMatKhauXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!");
                return;
            }
            using(var context= new YTeDbContext())
            {
                var nguoiQuanLy = context.NguoiQuanLies.Where(s => s.Password == txtMatKhauHienTai.Text).FirstOrDefault();
                if (nguoiQuanLy == null)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng!");
                    return;
                }
                nguoiQuanLy.Password = txtMatKhauMoi.Text;
                context.SaveChanges();
            }
            this.Hide();
            SignIn signIn = new SignIn();
            this.Close();
            signIn.ShowDialog();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
             this.Hide();
            SignIn signIn = new SignIn();
            this.Close();
            signIn.ShowDialog();


        }
    }
}
