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
    public partial class HSPhuSan : Form
    {
        ConNguoi connguoi;
        PhuNuMangThai phunumangthai;
        public HSPhuSan(ConNguoi connguoi, PhuNuMangThai phunumangthai)
        {
            InitializeComponent();
            this.connguoi = connguoi;
            this.phunumangthai = phunumangthai;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox8.Text.Length <= 13 && guna2TextBox8.Text.Length > 0) 
            {
                CDPhuSan CD = new CDPhuSan();
                //Kiem tra xem co ton tai chua
                bool flag = false;
                using (var yteDbContext = new YTeDbContext())
                {
                    List<ConNguoi> listconnguoi = yteDbContext.ConNguois.ToList();
                    foreach (var record in listconnguoi)
                    {
                        if (record.SoCMND == guna2TextBox8.Text)
                        {
                            flag = true;
                            CD.IDnguoimangthai = record.ID_Nguoi;
                        }
                    }
                }
                
                //neu chua co nguoi nay
                if (flag == false)
                {
                    int IDnguoi = 0;
                    //tao 1 con nguoi moi
                    using (var yteDbContext = new YTeDbContext())
                    {
                        ConNguoi conNguoi = new ConNguoi();
                        yteDbContext.ConNguois.Add(conNguoi);
                        conNguoi.HoTen = guna2TextBox1.Text;
                        conNguoi.SoCMND = guna2TextBox8.Text;
                        conNguoi.NgaySinh = DateTime.Parse(guna2DateTimePicker1.Value.ToString());
                        conNguoi.GioiTinh = 1;
                        conNguoi.NgheNghiep = guna2TextBox3.Text;
                        conNguoi.DiaChi = guna2TextBox12.Text;
                        conNguoi.SoDienThoai = guna2TextBox5.Text;
                        conNguoi.Email = guna2TextBox6.Text;
                        yteDbContext.SaveChanges();
                        IDnguoi = conNguoi.ID_Nguoi;
                    }

                    //Tao mot phu nu mang thai moi
                    using (var yteDbContext = new YTeDbContext())
                    {
                        PhuNuMangThai phuNuMangThai = new PhuNuMangThai();
                        yteDbContext.PhuNuMangThais.Add(phuNuMangThai);
                        phuNuMangThai.SoBHYTe = guna2TextBox7.Text;
                        phuNuMangThai.ID_Nguoi = IDnguoi;
                        phuNuMangThai.ThongTinNguoiCanBaoTin = guna2TextBox9.Text;
                        yteDbContext.SaveChanges();
                        CD.IDnguoimangthai = phuNuMangThai.ID_NguoiMangThai;
                    }
                }
                CD.Show();
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HSPhuSan_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Text = connguoi.HoTen;
            guna2TextBox8.Text = connguoi.SoCMND;
            guna2TextBox7.Text = phunumangthai.SoBHYTe;
            guna2DateTimePicker1.Value = connguoi.NgaySinh.Value;
            guna2TextBox3.Text = connguoi.NgheNghiep;
            guna2TextBox5.Text = connguoi.SoDienThoai;
            guna2TextBox12.Text = connguoi.DiaChi;
            guna2TextBox6.Text = connguoi.Email;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
