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

        private void FormThongTinNguoiDatLich_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using(var context1 = new YTeDbContext())
            {
                var people = new ConNguoi();
                people.HoTen = txtHoTen.Text;
                people.SoDienThoai = txtSDT.Text;
                people.SoCMND = txtCMND.Text;
                people.DiaChi = txtDiaChi.Text;
                //people.GioiTinh = ;
                people.Email = txtEmail.Text;
                context1.ConNguois.Add(people);
                context1.SaveChanges();
                var people1 = context1.ConNguois.Where(s => s.SoDienThoai == people.SoDienThoai).FirstOrDefault();
                var datlichkham = new DatLichKham();
                datlichkham.ID_Nguoi = people1.ID_Nguoi;
                datlichkham.ThoiGianHenKham = DateTime.Now;
                context1.DatLichKhams.Add(datlichkham);
                context1.SaveChanges();


            };
            
        }
    }
}
