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
using Model;
using Controller;
using Hieu;


namespace QuanLyVaxin
{
    public partial class NhapLieu : Form
    {
        public NhapLieu()
        {
            InitializeComponent();
        }

        DataTable dataTable = null;
        DTGFilter filter = new DTGFilter();
        ComboBoxData comboBoxData = new ComboBoxData();
        LoadingTable loadingTable = new LoadingTable();
        TruyVan truyVan = new TruyVan();
        sqlMethod sql = new sqlMethod();

        private void NhapLieu_Load(object sender, EventArgs e)
        {
            cbTenVacXin1.DataSource = comboBoxData.vacxin();
            cbPhongKham.DataSource = comboBoxData.phongkham();
            dataTable= loadingTable.sudung();
            dtgSuDungVacXin.DataSource = dataTable;
        }

        private void btnTimKiemVacXin2_Click(object sender, EventArgs e)
        {
            dtgSuDungVacXin.DataSource = dataTable;
            dtgSuDungVacXin.DataSource = filter.searchRow(dtgSuDungVacXin, "Họ tên", txtTimKiemNguoi.Text);
        }

        private void btnLuuThongTin1_Click(object sender, EventArgs e)
        {
            SuDungVacXin suDungVacXin = new SuDungVacXin();
            {
                if (txtMuiTiem.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin!");
                    return;
                }
                else
                {
                    suDungVacXin.ID_Nguoi = truyVan.Tim_ID_Nguoi(txtTimKiemNguoi.Text);
                    suDungVacXin.ID_VacXin = truyVan.Tim_ID_Vacxin(cbTenVacXin1.Text);
                    suDungVacXin.ThoiDiemTiem = dtpNgayTiem.Value;
                    suDungVacXin.ID_PhongKham = truyVan.Tim_ID_Phongkham(cbPhongKham.Text);

                    if (int.TryParse(txtMuiTiem.Text, out int result2))
                    {
                        suDungVacXin.SoMuiTiem = Convert.ToInt32(txtMuiTiem.Text);
                    }
                    else
                    {
                        MessageBox.Show("Mũi tiêm phải là số!");
                        return;
                    }
                    try
                    {
                        sql.ThemMoiVaoCSDL(suDungVacXin);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lưu thất bại!", "Kiểm tra lại dữ liệu nhập");
                        return;
                    }

                    MessageBox.Show("Lưu thành công!");
                }

            }
        }
    }
}
