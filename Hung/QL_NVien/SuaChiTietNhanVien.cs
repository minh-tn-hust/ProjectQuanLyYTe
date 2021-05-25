using Controller.dataGridView;
using Controller.Object;
using Model;
using Controller.Ef6Operator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyYTe
{
    
    public partial class SuaChiTietNhanVien : Form
    {
        DataTable dataTable = null;
        ConvertToObject convertToObject = new ConvertToObject();
        LoadingTable loadingTable = new LoadingTable();
        DTGFilter filter = new DTGFilter();
        NhanVienYTe nhanVienSuaDoi = null;
        public SuaChiTietNhanVien()
        {
            InitializeComponent();
        }
        ef6Method sql = new ef6Method();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" ||
             txtMatKhau.Text == "" ||
             txtHoVaTen.Text == "" ||
             txtSoCMND.Text == "" ||
             cbGioiTinh.SelectedIndex == -1 ||
             txtNgheNghiep.Text == "" ||
             txtSoDienThoai.Text == "" ||
             txtDiaChi.Text == "" ||
             txtEmailLienHe.Text == "" ||
             cbPhongKhamDangLamViec.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin vào!");
            }
            else
            {

                NhanVienYTe nhanVienYTeMoi = new NhanVienYTe();
                {
                    nhanVienYTeMoi.UserName = txtTenDangNhap.Text;
                    nhanVienYTeMoi.Password = txtMatKhau.Text;
                    nhanVienYTeMoi.ID_CoSoYTe = Convert.ToInt32(cbPhongKhamDangLamViec.SelectedValue.ToString());
                }
                ConNguoi conNguoiMoi = new ConNguoi();
                {
                    conNguoiMoi.HoTen = txtHoVaTen.Text;
                    conNguoiMoi.SoCMND = txtSoCMND.Text;
                    conNguoiMoi.NgaySinh = dtNgaySinh.Value;
                    conNguoiMoi.GioiTinh = cbGioiTinh.SelectedIndex;
                    conNguoiMoi.NgheNghiep = txtNgheNghiep.Text;
                    conNguoiMoi.DiaChi = txtDiaChi.Text;
                    conNguoiMoi.SoDienThoai = txtSoDienThoai.Text;
                    conNguoiMoi.Email = txtEmailLienHe.Text;

                }
                try
                {
                    sql.ChinhSua(nhanVienYTeMoi, conNguoiMoi, nhanVienSuaDoi);
                }
                catch(Exception)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập(có thể là sai số CMND)!");
                    return;
                }

                MessageBox.Show("Chỉnh sửa thành công!");
                dataTable = loadingTable.nhanvien();
                btnHienThi.PerformClick();
            }
        }

        private void cbPhongKhamDangLamViec_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dtgvHienThiThongTin.DataSource = dataTable;
        }

        private void dtgvHienThiThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void SuaChiTietNhanVien_Load(object sender, EventArgs e)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                PhongKham unknownPhongKham = new PhongKham()
                {
                    ID_PhongKham = 0,
                    TenPhongKham = ""
                };
                List<PhongKham> listPhongKham = new List<PhongKham>();
                listPhongKham.Add(unknownPhongKham);
               listPhongKham.AddRange(yteDbContext.PhongKhams.ToList());

                cbPhongKhamDangLamViec.DataSource = listPhongKham;
                cbPhongKhamDangLamViec.DisplayMember = "TenPhongKham";
                cbPhongKhamDangLamViec.ValueMember = "ID_PhongKham";
            }
            dataTable = loadingTable.nhanvien();
            btnHienThi.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)

        {
            //dataTable = loadingTable.nhanvien();
            dtgvHienThiThongTin.DataSource = dataTable;
            //btnHienThi.PerformClick();
            dtgvHienThiThongTin.DataSource = filter.searchRow(dtgvHienThiThongTin, "Số CMND", txtTimKiem.Text);
        }

        private void dtgvHienThiThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BangNhanVien nhanVien = convertToObject.nhanvien(dtgvHienThiThongTin, e);
            if (nhanVien == null) return;
            txtHoVaTen.Text = nhanVien.connguoi.HoTen;
            txtMatKhau.Text = nhanVien.nhanvienyte.Password;
            txtTenDangNhap.Text = nhanVien.nhanvienyte.UserName;
            txtSoCMND.Text = nhanVien.connguoi.SoCMND;
            cbGioiTinh.SelectedIndex = (int)nhanVien.connguoi.GioiTinh;
            dtNgaySinh.Value = (DateTime)nhanVien.connguoi.NgaySinh;
            txtNgheNghiep.Text = nhanVien.connguoi.NgheNghiep;
            txtSoDienThoai.Text = nhanVien.connguoi.SoDienThoai;
            txtDiaChi.Text = nhanVien.connguoi.DiaChi;
            txtEmailLienHe.Text = nhanVien.connguoi.Email;
            using (var context = new YTeDbContext())
            {
                var phongKham = context.PhongKhams.Find(nhanVien.nhanvienyte.ID_CoSoYTe);
                 if (phongKham == null)
                {
                    cbPhongKhamDangLamViec.Text = "Chưa có thông tin";
                }
                else
                {
                    cbPhongKhamDangLamViec.Text = phongKham.TenPhongKham;
                }
            }
            nhanVienSuaDoi = nhanVien.nhanvienyte;


        }
    }
}
