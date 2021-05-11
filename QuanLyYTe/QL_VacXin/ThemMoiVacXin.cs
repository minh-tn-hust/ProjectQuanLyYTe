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
using ModelIO;
using Model;
using Controller.dataGridView;

namespace QuanLyYTe
{
    public partial class ThemMoiVacXin : Form
    {
        public ThemMoiVacXin()
        {
            InitializeComponent();
        }
        sqlMethod sql = new sqlMethod();
        DataTable dataTable = null;
        LoadingTable loadingTable = new LoadingTable();
        ConvertToObject convertToObject = new ConvertToObject();
        private void btnThemVaoDanhSach_Click(object sender, EventArgs e)
        {
            VacXin vacXin = new VacXin();
            {
                vacXin.TenVacXin = txtTenVacXin.Text;
                vacXin.SoLoVacXin = txtTenLoVacXin.Text;
                if (int.TryParse(txtGiaThanhVacXin.Text,out int result))
                {
                    vacXin.GiaThanh = txtGiaThanhVacXin.Text;
                }
                else
                {
                    MessageBox.Show("Giá thành phải là số!");
                    return;
                }
                vacXin.NgaySanXuat = dtNgaySanXuat.Value;
                vacXin.HanSuDung = dtHanSuDung.Value;
                vacXin.NgayNhapKho = dtNgayNhapKho.Value;
                 if (int.TryParse(txtThoiGianTaiSuDung.Text,out int result1))
                {
                    vacXin.ThoiGianSuDungLai  = Convert.ToInt32(txtThoiGianTaiSuDung.Text);
                }
                else
                {
                    MessageBox.Show("Thời gian sử dụng lại phải là số!");
                    return;
                }
                if (int.TryParse(txtSoMuiTiem.Text,out int result2))
                {
                     vacXin.SoMuiCanTiem = Convert.ToInt32(txtSoMuiTiem.Text);
                }
                else
                {
                    MessageBox.Show("Số mũi cần tiêm phải là số!");
                    return;
                }

                if (int.TryParse(txtSoLuongVacXinMuaMoi.Text,out int result3))
                {
                    vacXin.SoLuongNhapKho =Convert.ToInt32(txtSoLuongVacXinMuaMoi.Text);
                }
                else
                {
                    MessageBox.Show(" Số lượng mua mới phải là số!");
                    return;
                }
               vacXin.SoLuongConLai = Convert.ToInt32(txtSoLuongVacXinMuaMoi.Text); 
               
                vacXin.ChongChiDinh = txtChongChiDinh.Text;
                vacXin.ThongTinKhac = txtThongTinVacXin.Text;
            }
            try
            {
                sql.themMoiVaoCSDL(vacXin);
            }catch(Exception)
            {
                MessageBox.Show("Thêm mới thất bại, kiểm tra lại dữ liệu đã nhập!");
                return;
            }
            MessageBox.Show("Thêm mới thành công!");
            dataTable = loadingTable.vacxinThemMoi();
            btnHienThi.PerformClick();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dtgvDanhSachVacXin.DataSource = dataTable;
        }

        private void ThemMoiVacXin_Load(object sender, EventArgs e)
        {
            dataTable = loadingTable.vacxinThemMoi();
            btnHienThi.PerformClick();
            
        }

        private void dtgvDanhSachVacXin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            VacXin vacXin = convertToObject.bangvacxin(dtgvDanhSachVacXin,e);
            txtTenVacXin.Text = vacXin.TenVacXin;
            txtTenLoVacXin.Text = vacXin.SoLoVacXin;
            txtGiaThanhVacXin.Text = vacXin.GiaThanh;
            dtNgaySanXuat.Value = (DateTime)vacXin.NgaySanXuat;
            dtHanSuDung.Value = (DateTime)vacXin.HanSuDung;
            dtNgayNhapKho.Value = (DateTime)vacXin.NgayNhapKho;
            txtThoiGianTaiSuDung.Text = vacXin.ThoiGianSuDungLai.ToString();
            txtSoMuiTiem.Text = vacXin.SoMuiCanTiem.ToString();
            txtSoLuongVacXinMuaMoi.Text = vacXin.SoLuongNhapKho.ToString();
            txtChongChiDinh.Text = vacXin.ChongChiDinh;
            txtThongTinVacXin.Text = vacXin.ThongTinKhac;

        }
    }
}
