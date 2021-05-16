
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
using Controller.dataGridView;
using Controller.Object;

namespace QuanLyYTe.QL_NVien
{
    public partial class HienThiToanBoNhanVien : Form
    {
        public HienThiToanBoNhanVien()
        {
            InitializeComponent();
        }
        
        ef6Method sql = new ef6Method();
        LoadingTable loadingTable = new LoadingTable();
        DataTable dataTable=null;
        ConvertToObject convertToObject = new ConvertToObject();
        DTGFilter filter = new DTGFilter();
        NhanVienYTe nhanVienDuocXoa = new NhanVienYTe();
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ConNguoi conNguoi = new ConNguoi();
            {
                conNguoi.HoTen = txtHoVaTen.Text;
                conNguoi.SoCMND = txtSoCMND.Text;
                conNguoi.NgaySinh = dtNgaySinh.Value;
                conNguoi.GioiTinh = cbGioiTinh.SelectedIndex;
                conNguoi.NgheNghiep = txtNgheNghiep.Text;
                conNguoi.DiaChi = txtDiaChi.Text;
                conNguoi.SoDienThoai = txtSoDienThoai.Text;
                conNguoi.Email = txtEmailLienHe.Text;

            }
            NhanVienYTe nhanVien = new NhanVienYTe();
            {
                nhanVien.UserName = txtTenDangNhap.Text;
                nhanVien.Password = txtMatKhau.Text;
            }
            sql.themMoiVaoCSDL(nhanVien, conNguoi);
        }
        


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dtgvHienThiToanBo.DataSource = dataTable;
        }

        private void btnPhongKhamDangLamViec_Click(object sender, EventArgs e)
        {
           
        }
        private void dtgvHienThiToanBo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BangNhanVien nhanVien = convertToObject.nhanvien(dtgvHienThiToanBo, e);
            if (nhanVien == null)
            {
                nhanVienDuocXoa = null;
                return;
            }
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
                    cbNoiDangLamViec.Text = "Chưa có thông tin";
                }
                else
                {
                    cbNoiDangLamViec.Text = phongKham.TenPhongKham;
                }
            }
            nhanVienDuocXoa = nhanVien.nhanvienyte;
        }

        private void HienThiToanBoNhanVien_Load(object sender, EventArgs e)
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
                cbNoiDangLamViec.DataSource = listPhongKham;
                cbNoiDangLamViec.DisplayMember = "TenPhongKham";
                cbNoiDangLamViec.ValueMember = "ID_PhongKham";
            }
            dataTable = loadingTable.nhanvien();
            btnHienThi.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvHienThiToanBo.DataSource = dataTable;
            dtgvHienThiToanBo.DataSource = filter.searchRow(dtgvHienThiToanBo, "Số CMND", txtTimKiem.Text);
            nhanVienDuocXoa = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nhanVienDuocXoa == null)
            {
                MessageBox.Show("Xóa thất bại do chưa chọn nhân viên để xóa!");
            }
            else
            {
                sql.xoaKhoiCSDL(nhanVienDuocXoa);
                MessageBox.Show("Xóa thành công!");
                nhanVienDuocXoa = null;
                dataTable = loadingTable.nhanvien();
                btnHienThi.PerformClick();
                deleteAllText();
            }
        }
        public void deleteAllText()
        {
            txtHoVaTen.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtSoCMND.Text = "";
            cbGioiTinh.SelectedIndex = -1;
            dtNgaySinh.Value = DateTime.Today;
            txtNgheNghiep.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtEmailLienHe.Text = "";
            cbNoiDangLamViec.SelectedIndex = -1;

        }
    }
}
