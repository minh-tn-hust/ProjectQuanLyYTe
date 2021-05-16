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
using System.Globalization;
using System.Collections;
using Controller.dataGridView;
using Controller.Ef6Operator;

namespace QuanLyYTe
{
    public partial class ThemMoiCoSoYTe : Form
    {
        public ThemMoiCoSoYTe()
        {
            InitializeComponent();
        }
        ef6Method sql = new ef6Method();
        LoadingTable loadingTable = new LoadingTable();
        ConvertToObject convertToObject = new ConvertToObject();
        DataTable dataTable = null;
        private void btnThem_Click(object sender, EventArgs e)
        {
            PhongKham phongKham = new PhongKham();
            {
                phongKham.TenPhongKham = txtTenPhongKham.Text;
                phongKham.ID_NhanVienQuanLy = Convert.ToInt32(cbTenBacSiQuanLy.SelectedValue.ToString());
                phongKham.DiaChi = txtDiaChiPhongKham.Text;
                phongKham.NgayBatDauTrongTuan = cbThuBatDau.SelectedIndex;
                phongKham.NgayKetThucTrongTuan = cbThuKetThuc.SelectedIndex;
                phongKham.GioBatDau = dtGioMoCua.Value.TimeOfDay;
                phongKham.GioketThuc = dtGioDongCua.Value.TimeOfDay;
                phongKham.ThongTinKhac = txtThongTinKhac.Text;
            }
            try
            {
                sql.themMoiVaoCSDL(phongKham);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới thất bại!");
                return;
            }
            MessageBox.Show("Thêm mới thành công!");
            btnHienThiDanhSach.PerformClick();
        }


        private void ThemMoiCoSoYTe_Load(object sender, EventArgs e)
        {
            dataTable = loadingTable.phongkham();
            using (var yteDbContext = new YTeDbContext())
            {
                //Chuyển các nhân viên y tế trở thành 1 danh sách
                List<NhanVienYTe> listNhanVienYTe = yteDbContext.NhanVienYTes.ToList();
                
                List<ConNguoi> listNguoiQuanLy = new List<ConNguoi>();
                ConNguoi hienThiTieuDe = new ConNguoi
                {
                    ID_Nguoi = -1,
                    HoTen = "Tên người quản lý"

                };
                ConNguoi unknownMember = new ConNguoi
                {
                    ID_Nguoi = 0,
                    HoTen = "Chưa có thông tin!"

                };
                listNguoiQuanLy.Add(hienThiTieuDe);
                listNguoiQuanLy.Add(unknownMember);
                for (int i = 0; i < listNhanVienYTe.Count; i++)
                {
                    ConNguoi conNguoi = yteDbContext.ConNguois.Find(listNhanVienYTe[i].ID_Nguoi);
                    listNguoiQuanLy.Add(conNguoi);
                }
                cbTenBacSiQuanLy.DataSource = listNguoiQuanLy;
                cbTenBacSiQuanLy.DisplayMember = "HoTen";
                cbTenBacSiQuanLy.ValueMember = "ID_Nguoi";
                btnHienThiDanhSach.PerformClick();
            }
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            dataTable = loadingTable.phongkham();
            dtgvThongTinCoSoYTe.DataSource = dataTable;

        }

        private void dtgvThongTinCoSoYTe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                        ConNguoi conNguoi = new ConNguoi();
            PhongKham phongKham = convertToObject.bangphongkham(dtgvThongTinCoSoYTe,e);
            txtTenPhongKham.Text = phongKham.TenPhongKham;
            using(var context= new YTeDbContext())
            {
                var nhanVienQuanLy=context.NhanVienYTes.Where(s => s.ID_NhanVien == phongKham.ID_NhanVienQuanLy).FirstOrDefault();
                if (nhanVienQuanLy == null)
                {
                    cbTenBacSiQuanLy.SelectedIndex = 1;    
                }
                else
                {
                    conNguoi = context.ConNguois.Find(nhanVienQuanLy.ID_Nguoi);
                    cbTenBacSiQuanLy.Text = conNguoi.HoTen;

                }
                           
            }
          txtDiaChiPhongKham.Text = phongKham.DiaChi;
            cbThuBatDau.SelectedIndex = (int)phongKham.NgayBatDauTrongTuan;
            cbThuKetThuc.SelectedIndex = (int)phongKham.NgayKetThucTrongTuan;
    dtGioMoCua.Text = phongKham.GioBatDau.ToString();
            dtGioDongCua.Text = phongKham.GioketThuc.ToString();

            txtThongTinKhac.Text = phongKham.ThongTinKhac;
 
        }

           }
}
