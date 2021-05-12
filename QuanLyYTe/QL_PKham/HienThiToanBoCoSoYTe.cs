﻿
using Controller.dataGridView;
using Model;
using ModelIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyYTe.QL_PKham
{
    public partial class HienThiToanBoCoSoYTe : Form
    {
        LoadingTable loadingTable = new LoadingTable();
        DataTable dataTable = new DataTable();
        ConvertToObject convertToObject = new ConvertToObject();
        PhongKham phongKhamCanXoa = null;
        sqlMethod sql=new sqlMethod();
        DTGFilter filter = new DTGFilter();

        public HienThiToanBoCoSoYTe()
        {
            InitializeComponent();
        }
        private void xoaHetHienThi()
        {
            txtDiaChi.Text = null;
            txtSoDienThoai.Text = null;
            cbTenBacSiQuanLy.Text = null;
            txtTenPhongKham.Text = null;
            txtThongTinKhac.Text = null;
            txtTimKiem.Text = null;
            cbThuBatDau.SelectedIndex = 0;
            cbThuKetThuc.SelectedIndex = 0;
                    }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dataTable = loadingTable.phongkham();
            dtgvHienThi.DataSource = dataTable;
        }

        private void HienThiToanBoCoSoYTe_Load(object sender, EventArgs e)
        {
            dataTable = loadingTable.phongkham();
            dtgvHienThi.DataSource = dataTable;
            // YTeDBContext là nơi duy nhất mình có thể thông qua nó để kết nối với cơ sở dữ liệu thông qua các đối tượng đã được tạo
            // Đầu tiên ta tạo ra một đối tượng yteDbContext, thông qua nó ta có thể truy cập vào các bảng trong csdl
            //using được dùng thay cho try catch, thông qua cái using này thì entityFramework nó sẽ nạp dữ liệu từ cơ sở dữ liệu lên
            using (var yteDbContext = new YTeDbContext())
            {
                //Chuyển các nhân viên y tế trở thành 1 danh sách
                List<NhanVienYTe> listNhanVienYTe = yteDbContext.NhanVienYTes.ToList();
                //Những người quản lý sẽ được lấy thông tin từ bảng con người, vì vậy nên ta tạo ra một danh con người
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
                //Ta sẽ duyệt qua hết tất cả các nhân viên y tế có trong bảng nhân viên y tế, xong lấy ra thông tin 
                //từ bảng con người sao cho id_người trùng nhau.
                for (int i = 0; i < listNhanVienYTe.Count; i++)
                {
                    ConNguoi conNguoi = yteDbContext.ConNguois.Find(listNhanVienYTe[i].ID_Nguoi);
                    listNguoiQuanLy.Add(conNguoi);
                }
                
                // Nạp dữ liệu vào
                // cbTenBacSiQuanLy là tên của combobox.
                cbTenBacSiQuanLy.DataSource = listNguoiQuanLy;
                // Cho thông tin cột muốn hiển thị( Như ở đây thì "HoTen" là tên thuộc tính tương ứng với
                // cột HoTen trong CSDL. Giả sử muốn in ra cột ngày khám thì nhập vào "NgayKham"( Phải trùng với tên thuộc tính)
                cbTenBacSiQuanLy.DisplayMember = "HoTen";
                // Nó cho biết mình đang chọn vào cái có giá trị như thế nào.
                // Như ở đây mình chọn là cột "ID_Nguoi" thì khi mình bấm vào tên nó xổ ra thì mình sẽ lấy đươc id của nó luôn.
                cbTenBacSiQuanLy.ValueMember = "ID_Nguoi";
            }

        }

        private void dtgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            ConNguoi conNguoi = new ConNguoi();
            PhongKham phongKham = convertToObject.bangphongkham(dtgvHienThi,e);
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
            txtDiaChi.Text = phongKham.DiaChi;
            cbThuBatDau.SelectedIndex = (int)phongKham.NgayBatDauTrongTuan;
            cbThuKetThuc.SelectedIndex = (int)phongKham.NgayKetThucTrongTuan;
            dtGioMoCua.Text = phongKham.GioBatDau.ToString();
            dtGioDongCua.Text = phongKham.GioketThuc.ToString();
            txtThongTinKhac.Text = phongKham.ThongTinKhac;
            phongKhamCanXoa = phongKham;
        }

        private void btnXoaCoSo_Click(object sender, EventArgs e)
        {
            sql.xoaKhoiCSDL(phongKhamCanXoa);
            MessageBox.Show("Xóa dữ liệu thành công!");
            btnHienThi.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvHienThi.DataSource = dataTable;
            dtgvHienThi.DataSource = filter.searchRow(dtgvHienThi, "Tên phòng khám", txtTimKiem.Text);
        }
    }
}