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
using Controller.Ef6Operator;
using Model;

namespace QuanLyYTe.QL_VacXin
{
    public partial class HienThiToanBoVacXin : Form
    {
        public HienThiToanBoVacXin()
        {
            InitializeComponent();
        }
        ef6Method sql = new ef6Method();
        DataTable dataTable = null;
        LoadingTable loadingTable = new LoadingTable();
        ConvertToObject convertToObject = new ConvertToObject();
        DTGFilter filter =  new DTGFilter();
        VacXin vacXinChonDeXoa = null;
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dtgvHienThiChiTiet.DataSource = dataTable;
        }

        private void HienThiToanBoVacXin_Load(object sender, EventArgs e)
        {
            dataTable = loadingTable.vacxin();
            btnHienThi.PerformClick();
        }

        private void dtgvHienThiChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
            
        {
            dtgvHienThiChiTiet.DataSource = dataTable;
            dtgvHienThiChiTiet.DataSource=filter.searchRow(dtgvHienThiChiTiet, "Tên vắc-xin", txtTimKiem.Text);
            vacXinChonDeXoa = null;
            
        }

        private void btnXoaKhoiDanhSach_Click(object sender, EventArgs e)
        {
            if (vacXinChonDeXoa == null)
            {
                MessageBox.Show("Vui lòng chọn vắc xin cần xóa!");
            }
            else
            {
                sql.xoaKhoiCSDL(vacXinChonDeXoa);
                MessageBox.Show("Xóa thành công!");
                vacXinChonDeXoa = null;
                dataTable = loadingTable.vacxin();
                deleteAllText();
                btnHienThi.PerformClick();
            }
        }
        public void deleteAllText()
        {
            txtTenVacXin.Text = "";
            txtTenLoSanPham.Text = "";
            txtGiaThanh.Text = "";
            dtNgaySanXuat.Value = Convert.ToDateTime("1/1/2001");
            dtNgayNhapKho.Value = Convert.ToDateTime("1/1/2001");
            dtHanSuDung.Value = Convert.ToDateTime("1/1/2001");
            txtThoiGianTaiSuDung.Text = "";
            txtSoMuiCanTiem.Text = "";
            txtSoLuongConLai.Text = "";
            txtChongChiDinh.Text = "";
            txtThongTinKhac.Text = "";

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                VacXin vacXin = convertToObject.bangvacxin(dtgvHienThiChiTiet, e);
                if (vacXin != null)
                {
                    txtTenVacXin.Text = vacXin.TenVacXin;
                    txtTenLoSanPham.Text = vacXin.SoLoVacXin;
                    txtGiaThanh.Text = vacXin.GiaThanh;
                    dtNgaySanXuat.Value = (DateTime)vacXin.NgaySanXuat;
                    dtHanSuDung.Value = (DateTime)vacXin.HanSuDung;
                    dtNgayNhapKho.Value = (DateTime)vacXin.NgayNhapKho;
                    txtThoiGianTaiSuDung.Text = vacXin.ThoiGianSuDungLai.ToString();
                    txtSoMuiCanTiem.Text = vacXin.SoMuiCanTiem.ToString();
                    txtSoLuongConLai.Text = vacXin.SoLuongConLai.ToString();
                    txtChongChiDinh.Text = vacXin.ChongChiDinh;
                    txtThongTinKhac.Text = vacXin.ThongTinKhac;
                    vacXinChonDeXoa = vacXin;
                }
            }

        }

        private void dtgvHienThiChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
