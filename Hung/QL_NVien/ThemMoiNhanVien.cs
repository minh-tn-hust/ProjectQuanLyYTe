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
using Controller.dataGridView;
using Controller.Object;
using Controller.Ef6Operator;

namespace QuanLyYTe
{
    public partial class ThemMoiNhanVien : Form
    {
        public ThemMoiNhanVien()
        {
            InitializeComponent();
        }

        ef6Method sql = new ef6Method();
        DataTable dataTable = new DataTable();
        ConvertToObject convertToObject = new ConvertToObject();
        PhongKham phongKham = new PhongKham();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" ||
                txtMatKhau.Text == "" ||
                txtHovaTen.Text == "" ||
                txtSoCMND.Text == "" ||
                cbGioiTinh.SelectedIndex == -1 ||
                txtNgheNghiep.Text == "" ||
                txtSoDienThoai.Text == "" ||
                txtDiaChiThuongTru.Text == "" ||
                txtEmailLienHe.Text == "" ||
                cbTenCoSoYTe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin vào!");
            }
            else
            {
                // Tạo ra đối tượng con người
                ConNguoi conNguoi = new ConNguoi();
                {
                    conNguoi.HoTen = txtHovaTen.Text;
                    conNguoi.SoCMND = txtSoCMND.Text;
                    conNguoi.NgaySinh = dtNgaySinh.Value;
                    conNguoi.GioiTinh = cbGioiTinh.SelectedIndex;
                    conNguoi.NgheNghiep = txtNgheNghiep.Text;
                    conNguoi.DiaChi = txtDiaChiThuongTru.Text;
                    conNguoi.SoDienThoai = txtSoDienThoai.Text;
                    conNguoi.Email = txtEmailLienHe.Text;


                }
                // Tạo ra đối tượng nhân viên y tế
                NhanVienYTe nhanVien = new NhanVienYTe();
                {
                    nhanVien.UserName = txtTenDangNhap.Text;
                    nhanVien.Password = txtMatKhau.Text;
                    nhanVien.ID_CoSoYTe = Convert.ToInt32(cbTenCoSoYTe.SelectedValue.ToString());
                }

                int flag =  sql.themMoiVaoCSDL(nhanVien, conNguoi);
                if (flag == -1)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại số CMND!");
                    txtSoCMND.Text = null;
                    return;
                }
                 MessageBox.Show("Thêm mới thành công!");
                deleteAllText();
                btnHienThi.PerformClick();
            }
        }


        private void ThemMoiNhanVien_Load(object sender, EventArgs e)
        {

            // YTeDBContext là nơi duy nhất mình có thể thông qua nó để kết nối với cơ sở dữ liệu thông qua các đối tượng đã được tạo
            // Đầu tiên ta tạo ra một đối tượng yteDbContext, thông qua nó ta có thể truy cập vào các bảng trong csdl
            //using được dùng thay cho try catch, thông qua cái using này thì entityFramework nó sẽ nạp dữ liệu từ cơ sở dữ liệu lên
            using (var yteDbContext = new YTeDbContext())
            {
                PhongKham unknownPhongKham = new PhongKham()
                {
                    ID_PhongKham = 0,
                    TenPhongKham = ""
                };
                List<PhongKham> listPhongKham = new List<PhongKham>();
                listPhongKham.Add(unknownPhongKham);
                // tạo ra một danh sách đối tượng các phòng khám có trong bảng.
                //yteDbContext.PhongKhams nó sẽ truy cập vào bảng phòng khám, ToList() biến nó thành một danh sách các phòng khám.
                // Phải dùng ToList() do DataSource phải là 1 tập nhiều cái.
                listPhongKham.AddRange(yteDbContext.PhongKhams.ToList());
                // Nạp dữ liệu vào
                // cbTenCoSoYTe là tên của combobox.
                cbTenCoSoYTe.DataSource = listPhongKham;
                // Cho thông tin cột muốn hiển thị( Như ở đây thì "TenPhongKham" là tên thuộc tính tương ứng với
                // cột TenPhongKham trong CSDL. Giả sử muốn in ra cột ngày khám thì nhập vào "NgayKham"( Phải trùng với tên thuộc tính)
                cbTenCoSoYTe.DisplayMember = "TenPhongKham";
                // Nó cho biết mình đang chọn vào cái có giá trị như thế nào.
                // Như ở đây mình chọn là cột "ID_PhongKham" thì khi mình bấm vào tên nó xổ ra thì mình sẽ lấy đươc id của nó luôn.
                cbTenCoSoYTe.ValueMember = "ID_PhongKham";

                dataTable = loadingTable.nhanvien();
                btnHienThi.PerformClick();
            }
        }
        LoadingTable loadingTable = new LoadingTable();
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dataTable = loadingTable.nhanvien();
            dtgvDanhSachNhanVien.DataSource = dataTable;
        }

        private void cbTenCoSoYTe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Giá trị hiện thời của combobox mình đang chọn chính là memberValue
            // Để in ra được giá trị đó thì chúng ta sử dụng SelectedValue, thông qua đây ta có thể lấy được giá trị của ID_Khóa
            //txtDiaChiThuongTru.Text = cbTenCoSoYTe.SelectedValue.ToString();
        }

        private void dtgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        public void deleteAllText()
        {
            txtHovaTen.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtSoCMND.Text = "";
            cbGioiTinh.SelectedIndex = -1;
            dtNgaySinh.Value = DateTime.Today;
            txtNgheNghiep.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChiThuongTru.Text = "";
            txtEmailLienHe.Text = "";
            cbTenCoSoYTe.SelectedIndex = -1;

        }

        private void dtgvDanhSachNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BangNhanVien nhanVien = convertToObject.nhanvien(dtgvDanhSachNhanVien, e);
            if (nhanVien == null) return;
            txtHovaTen.Text = nhanVien.connguoi.HoTen;
            txtMatKhau.Text = nhanVien.nhanvienyte.Password;
            txtTenDangNhap.Text = nhanVien.nhanvienyte.UserName;
            txtSoCMND.Text = nhanVien.connguoi.SoCMND;
            cbGioiTinh.SelectedIndex = (int)nhanVien.connguoi.GioiTinh;
            dtNgaySinh.Value = (DateTime)nhanVien.connguoi.NgaySinh;
            txtNgheNghiep.Text = nhanVien.connguoi.NgheNghiep;
            txtSoDienThoai.Text = nhanVien.connguoi.SoDienThoai;
            txtDiaChiThuongTru.Text = nhanVien.connguoi.DiaChi;
            txtEmailLienHe.Text = nhanVien.connguoi.Email;
            using (var context = new YTeDbContext())
            {
                var phongKham = context.PhongKhams.Find(nhanVien.nhanvienyte.ID_CoSoYTe);
                  if (phongKham == null)
                {
                    cbTenCoSoYTe.Text = "Chưa có thông tin!";
                }
                else
                {
                    cbTenCoSoYTe.Text = phongKham.TenPhongKham;
                }
            }

        


        }
    }
}
