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
        ConNguoi nhanvien;
        public FormThongTinNguoiDatLich(ConNguoi nhanvien)
        {
            InitializeComponent();
            this.nhanvien = nhanvien;
        }
        DateTime ngaykham;
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

        //private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có muốn thoát phiếu mà chưa lưu không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        public DateTime date;
        public String phongkham;
        private void FormThongTinNguoiDatLich_Load_1(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = date;
            //txtNguoiTaoDon.Text = nhanvien.HoTen;
            //MessageBox.Show(date.ToString());
        }
        public List<String> listconnguoi()
        {
            using (var context = new YTeDbContext())
            {
                var connguoi = context.ConNguois.ToList();
                List<String> connguois = new List<string>();
                foreach (var i in connguoi)
                {
                    connguois.Add(i.HoTen);
                }
                var p = new HashSet<String>(connguois);
                return p.ToList();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" && txtSDT.Text == "")
            {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo!");
                    //this.Close();
            }
            else
            {
                using (var context = new YTeDbContext())
                {
                    var phongKham = context.PhongKhams.Where(s => s.TenPhongKham == phongkham).FirstOrDefault();
                    if (phongKham == null)
                    {
                        MessageBox.Show("Chưa có phòng khám nào hoạt động!", "Thông báo!");
                    }
                    else
                    {
                        var people = new ConNguoi();
                        {
                            people.HoTen = txtHoTen.Text;
                            if(txtCMND.Text == "")
                            {
                                var listconnguoi = context.ConNguois.ToList();
                                int i = listconnguoi.Count;
                                people.SoCMND = (i+1).ToString();

                            }
                            else
                            {
                                people.SoCMND = txtCMND.Text;
                            }
                            people.SoDienThoai = txtSDT.Text;
                            people.Email = txtEmail.Text;
                            people.DiaChi = txtDiaChi.Text;
                            if (cbGioiTinh.Text == "Nữ") people.GioiTinh = 1;
                            else people.GioiTinh = 0;
                        }
                        context.ConNguois.Add(people); // add nó vào bảng connguoi
                        context.SaveChanges();
                        
                        var trecon = new TreEm();
                        if (txtBHYT.Text != "")
                        {
                            trecon.ID_Nguoi = people.ID_Nguoi;
                            trecon.MaTheBHYTe = txtBHYT.Text;
                            context.TreEms.Add(trecon);
                            context.SaveChanges();
                        }

                        var connguoi = new DatLichKham();
                        {
                            connguoi.ID_Nguoi = people.ID_Nguoi;
                            connguoi.GhiChu = txtGhiChu.Text;
                            connguoi.LyDoKham = txtLyDoKham.Text;
                            connguoi.ID_PhongKham = phongKham.ID_PhongKham;
                            connguoi.ThoiGianHenKham = guna2DateTimePicker1.Value;
                            //connguoi.ID_NhanVien =  txtNguoiTaoDon.Text;
                        }
                        context.DatLichKhams.Add(connguoi);
                        context.SaveChanges();
                        MessageBox.Show("Bạn đã tạo phiếu thành công!", "Thông báo!");
                        MessageBox.Show(phongKham.DiaChi);
                        MessageBox.Show(people.HoTen + '\n' + phongKham.DiaChi + '\n' + connguoi.ThoiGianHenKham.ToString() + '\n' + people.Email);
                        SendingMail sendingMail = new SendingMail(people.HoTen, phongKham.DiaChi, connguoi.ThoiGianHenKham.ToString(), people.Email);
                        sendingMail.send();
                        this.Close();

                    }
                }
            }
        }
    }
}
