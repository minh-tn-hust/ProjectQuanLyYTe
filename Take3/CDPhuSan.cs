using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Take3
{
    public partial class CDPhuSan : Form
    {
        public int IDnguoimangthai;
        public CDPhuSan()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThongTinThaiKi thongtin = new ThongTinThaiKi();
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.ThongTinThaiKis.Add(thongtin);
                thongtin.ThoiGianKham = DateTime.Parse(guna2DateTimePicker1.Value.ToString());
                thongtin.ID_NguoiMangThai = IDnguoimangthai;
                thongtin.LanKhamTiepTheo = DateTime.Parse(guna2DateTimePicker2.Value.ToString());
                thongtin.ChieuCaoMe = int.Parse(guna2TextBox2.Text);
                thongtin.CanNangMe = int.Parse(guna2TextBox4.Text);
                thongtin.ThoiGianSinhDuKien = DateTime.Parse(guna2DateTimePicker3.Value.ToString());
                try
                {
                    yteDbContext.SaveChanges();
                    MessageBox.Show("Lưu thành công!");
                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
                }
                
            }
        }
    }
}
