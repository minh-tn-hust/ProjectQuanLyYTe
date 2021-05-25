
using Controller.dataGridView;
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
    public partial class ChinhSuaThongTinCoSoYTe : Form
    {
             LoadingTable loadingTable = new LoadingTable();
        DataTable dataTable = new DataTable();
        ConvertToObject convertToObject = new ConvertToObject();
        PhongKham phongKhamChinhSua = null;
        ef6Method sql=new ef6Method();
        DTGFilter filter = new DTGFilter();

   public ChinhSuaThongTinCoSoYTe()
        {
            InitializeComponent();
        }

        private void dtgvHienThiChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ChinhSuaThongTinCoSoYTe_Load(object sender, EventArgs e)
        {
                dataTable = loadingTable.phongkham();
            dtgvHienThiChiTiet.DataSource = dataTable;
           using (var yteDbContext = new YTeDbContext())
            {
                              List<NhanVienYTe> listNhanVienYTe = yteDbContext.NhanVienYTes.ToList();
                               List<ConNguoi> listNguoiQuanLy = new List<ConNguoi>();
                          ConNguoi unknownMember = new ConNguoi
                {
                    ID_Nguoi = 0,
                    HoTen = "Chưa có thông tin!"

                };
                           listNguoiQuanLy.Add(unknownMember);
               for (int i = 0; i < listNhanVienYTe.Count; i++)
                {
                    ConNguoi conNguoi = yteDbContext.ConNguois.Find(listNhanVienYTe[i].ID_Nguoi);
                    listNguoiQuanLy.Add(conNguoi);
                }
 cbNguoiQuanLy.DataSource = listNguoiQuanLy;
               cbNguoiQuanLy.DisplayMember = "HoTen";
               cbNguoiQuanLy.ValueMember = "ID_Nguoi";
            } 
        }

        private void btnHienThiToanBo_Click(object sender, EventArgs e)
        {
    dataTable = loadingTable.phongkham();
       dtgvHienThiChiTiet.DataSource = dataTable;
        
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
dtgvHienThiChiTiet.DataSource = dataTable;
            dtgvHienThiChiTiet.DataSource = filter.searchRow(dtgvHienThiChiTiet, "Tên phòng khám", txtTimKiem.Text);
            phongKhamChinhSua = null;
        
        }

        private void btnLuuChinhSua_Click(object sender, EventArgs e)
        {
            if (txtTenCoSoYTe.Text == "" ||
          txtDiaChi.Text == "" ||
          cbNguoiQuanLy.SelectedIndex == -1 ||
          txtSoDienThoai.Text == "" ||
          txtThongTinKhac.Text == ""
          )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào!");
            }
            else
            {
                PhongKham phongKhamMoi = new PhongKham();
                {
                    phongKhamMoi.TenPhongKham = txtTenCoSoYTe.Text;
                    phongKhamMoi.ID_NhanVienQuanLy = Convert.ToInt32(cbNguoiQuanLy.SelectedValue.ToString());
                    phongKhamMoi.DiaChi = txtDiaChi.Text;
                    phongKhamMoi.SoDienThoaiLienHe = txtSoDienThoai.Text;
                    phongKhamMoi.NgayBatDauTrongTuan = cbThuBatDau.SelectedIndex;
                    phongKhamMoi.NgayKetThucTrongTuan = cbThuKetThuc.SelectedIndex;
                    phongKhamMoi.GioBatDau = dtGioMoCua.Value.TimeOfDay;
                    phongKhamMoi.GioketThuc = dtGioDongCua.Value.TimeOfDay;
                    phongKhamMoi.ThongTinKhac = txtThongTinKhac.Text;
                }
                sql.ChinhSua(phongKhamMoi, phongKhamChinhSua);
                MessageBox.Show("Lưu thành công!");
                btnHienThiToanBo.PerformClick();
            }
        }

        private void dtgvHienThiChiTiet_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ConNguoi conNguoi = new ConNguoi();
            PhongKham phongKham = convertToObject.bangphongkham(dtgvHienThiChiTiet,e);
            if (phongKham == null) return;

           txtTenCoSoYTe.Text = phongKham.TenPhongKham;
            using(var context= new YTeDbContext())
            {
                var nhanVienQuanLy=context.NhanVienYTes.Where(s => s.ID_NhanVien == phongKham.ID_NhanVienQuanLy).FirstOrDefault();
                if (nhanVienQuanLy == null)
                {
                  cbNguoiQuanLy.SelectedIndex = 1;    
                }
                else
                {
                    conNguoi = context.ConNguois.Find(nhanVienQuanLy.ID_Nguoi);
                    cbNguoiQuanLy.Text = conNguoi.HoTen;



                }
                           
            }
            txtDiaChi.Text = phongKham.DiaChi;
            txtSoDienThoai.Text = phongKham.SoDienThoaiLienHe;
            cbThuBatDau.SelectedIndex = (int)phongKham.NgayBatDauTrongTuan;
            cbThuKetThuc.SelectedIndex = (int)phongKham.NgayKetThucTrongTuan;
            dtGioMoCua.Text = phongKham.GioBatDau.ToString();
            dtGioDongCua.Text = phongKham.GioketThuc.ToString();
            txtThongTinKhac.Text = phongKham.ThongTinKhac;
            phongKhamChinhSua = phongKham;

        }
    }
}
