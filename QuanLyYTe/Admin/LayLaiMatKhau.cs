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
    public partial class LayLaiMatKhau : Form
    {
        public LayLaiMatKhau()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtMaXacNhan == null)
            {
                MessageBox.Show("Vui lòng nhập mã xác nhận vào!");
                return;
            }
            using(var context= new YTeDbContext())
            {
                var nguoiQuanLy = context.NguoiQuanLies.Where(s => s.MaXacNhan == txtMaXacNhan.Text).FirstOrDefault();
                if (nguoiQuanLy == null)
                {
                    MessageBox.Show("Mã xác nhận không chính xác!");
                    return;
                }
                
                MessageBox.Show("Mật khẩu là: " + nguoiQuanLy.Password);
                this.Hide();
                SignIn signIn = new SignIn();
                signIn.ShowDialog();
                this.Close(); 
                            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            this.Close();
            signIn.ShowDialog();
        }
    }
}
