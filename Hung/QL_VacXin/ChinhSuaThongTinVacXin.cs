
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
    public partial class ChinhSuaThongTinVacXin : Form
    {
        public ChinhSuaThongTinVacXin()
        {
            InitializeComponent();
        }
        ef6Method sql = new ef6Method();
        DataTable dataTable = null;
        LoadingTable loadingTable = new LoadingTable();
        ConvertToObject convertToObject = new ConvertToObject();
        DTGFilter filter = new DTGFilter();
        VacXin vacXinChonSuaDoi = null;
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dtgvHienThiChiTiet.DataSource = dataTable;
        }

        private void dtgvHienThiChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ChinhSuaThongTinVacXin_Load(object sender, EventArgs e)
        {
            dataTable = loadingTable.vacxin();
            btnHienThi.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvHienThiChiTiet.DataSource = dataTable;
            dtgvHienThiChiTiet.DataSource = filter.searchRow(dtgvHienThiChiTiet, "Tên vắc-xin", txtTimKiem.Text);
            vacXinChonSuaDoi = null;
        }

        private void btnLuuChinhSua_Click(object sender, EventArgs e)
        {
            if (vacXinChonSuaDoi == null) return;
            if (txtTenVacXin.Text == "" ||
              txtSoLoSanPham.Text == "" ||
              txtGiaThanhVacXin.Text == "" ||
              txtThoiGianTaiSuDung.Text == "" ||
              txtSoMuiTiemCanThiet.Text == "" ||
              txtSoLuongConLai.Text == "" ||
              txtChongChiDinh.Text == "" ||
              txtThongTinKhac.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            VacXin vacXinMoi = new VacXin();
            {
                vacXinMoi.TenVacXin = txtTenVacXin.Text;
                vacXinMoi.SoLoVacXin = txtSoLoSanPham.Text;
                if (int.TryParse(txtGiaThanhVacXin.Text,out int result))
                {
                    vacXinMoi.GiaThanh = txtGiaThanhVacXin.Text;
                }
                else
                {
                    MessageBox.Show("Giá thành phải là số!");
                    txtGiaThanhVacXin.Text = "";
                    return;
                }
                vacXinMoi.NgaySanXuat = dtNgaySanXuat.Value;
                vacXinMoi.HanSuDung =dtNgayHetHan.Value;
                vacXinMoi.NgayNhapKho = dtNgayNhapKho.Value;
                 if (int.TryParse(txtThoiGianTaiSuDung.Text,out int result1))
                {
                    vacXinMoi.ThoiGianSuDungLai  = Convert.ToInt32(txtThoiGianTaiSuDung.Text);
                }
                else
                {
                    MessageBox.Show("Thời gian sử dụng lại phải là số!");
                    txtThoiGianTaiSuDung.Text = "";
                    return;
                }
                if (int.TryParse(txtSoMuiTiemCanThiet.Text,out int result2))
                {
                    vacXinMoi.SoMuiCanTiem = Convert.ToInt32(txtSoMuiTiemCanThiet.Text);
                }
                else
                {
                    MessageBox.Show("Số mũi cần tiêm phải là số!");
                    txtSoMuiTiemCanThiet.Text = "";
                    return;
                }

                if (int.TryParse(txtSoLuongConLai.Text,out int result3))
                {
                    vacXinMoi.SoLuongConLai =Convert.ToInt32(txtSoLuongConLai.Text);
                }
                else
                {
                    MessageBox.Show("Số lượng mua mới phải là số!");
                    txtSoLuongConLai.Text = "";
                    return;
                }
                
                vacXinMoi.ChongChiDinh = txtChongChiDinh.Text;
                vacXinMoi.ThongTinKhac = txtThongTinKhac.Text;
            
            }
            try
            {
                sql.ChinhSua(vacXinMoi, vacXinChonSuaDoi);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập(Có thể là sai số lô sản phẩm)!");
                return;
            }

            MessageBox.Show("Chỉnh sửa thành công!");
            dataTable = loadingTable.vacxin();
            btnHienThi.PerformClick();
        }

        private void dtgvHienThiChiTiet_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                VacXin vacXin = convertToObject.bangvacxin(dtgvHienThiChiTiet, e);
                if (vacXin != null)
                {
                    txtTenVacXin.Text = vacXin.TenVacXin;
                    txtSoLoSanPham.Text = vacXin.SoLoVacXin;
                    txtGiaThanhVacXin.Text = vacXin.GiaThanh;
                    dtNgaySanXuat.Value = (DateTime)vacXin.NgaySanXuat;
                    dtNgayHetHan.Value = (DateTime)vacXin.HanSuDung;
                    dtNgayNhapKho.Value = (DateTime)vacXin.NgayNhapKho;
                    txtThoiGianTaiSuDung.Text = vacXin.ThoiGianSuDungLai.ToString();
                    txtSoMuiTiemCanThiet.Text = vacXin.SoMuiCanTiem.ToString();
                    txtSoLuongConLai.Text = vacXin.SoLuongConLai.ToString();
                    txtChongChiDinh.Text = vacXin.ChongChiDinh;
                    txtThongTinKhac.Text = vacXin.ThongTinKhac;
                    vacXinChonSuaDoi = vacXin;
                }
            }

        }
    }
}
