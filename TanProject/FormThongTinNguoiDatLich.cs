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
using Controller.dataGridView;
using Model;

namespace QLPK
{
    public partial class FormThongTinNguoiDatLich : Form
    {
        public FormThongTinNguoiDatLich()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        public DateTime date = DateTime.Now;
        public String phongkham = "";
        private void FormThongTinNguoiDatLich_Load_1(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = date;
            //MessageBox.Show(date.ToString());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using (var context = new YTeDbContext())
            {
                var phongKham = context.PhongKhams.Where(s => s.TenPhongKham == phongkham).FirstOrDefault();
                var People = context.DatLichKhams.Where(s => s.ID_PhongKham == phongKham.ID_PhongKham).FirstOrDefault();
                var people = new ConNguoi();
                {
                    people.HoTen = txtHoTen.Text;
                    people.SoCMND = txtCMND.Text;
                    people.SoDienThoai = txtSDT.Text;
                    people.Email = txtEmail.Text;
                    people.DiaChi = txtDiaChi.Text;
                    //  people.GioiTinh = cbGioiTinh.Text;
                }
                context.ConNguois.Add(people);
                context.SaveChanges();

                var connguoi = new DatLichKham();
                {
                    connguoi.GhiChu = txtGhiChu.Text;
                    connguoi.LyDoKham = txtLyDoKham.Text;
                    connguoi.ID_PhongKham = People.ID_PhongKham;
                }
                context.DatLichKhams.Add(connguoi);
                context.SaveChanges();
            }
        }
    }
}
