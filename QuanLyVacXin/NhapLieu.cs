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
        DTGFilter1 filter1 = new DTGFilter1();
        ComboBoxData comboBoxData = new ComboBoxData();
        LoadingTable loadingTable = new LoadingTable();
        TruyVan truyVan = new TruyVan();
        sqlMethod sql = new sqlMethod();
        YTeDbContext yteDBContext = new YTeDbContext();

        private void NhapLieu_Load(object sender, EventArgs e)
        {
            cbTenVacXin1.DataSource = comboBoxData.vacxin();
            cbPhongKham.DataSource = comboBoxData.phongkham();
            cbSoLo.DataSource = comboBoxData.solo(cbTenVacXin1.Text);
            dataTable= loadingTable.sudung();
            dtgSuDungVacXin.DataSource = dataTable;
        }


        public class DTGFilter1
        {
            //Dùng để tìm kiếm thông tin trong csdl
            public DataTable searchRow(DataGridView dgv, String nameColumn, String value)
            {
                DataTable dt = dgv.DataSource as DataTable;
                DataTable res;
                try
                {
                    res = (dt.AsEnumerable()
                                .Where(row => row.Field<String>(nameColumn) == value)
                                .OrderByDescending(row => row.Field<String>(nameColumn))
                                .CopyToDataTable());
                    return res;
                }
                catch (Exception)
                {
                    LoadingTable loadingTable = new LoadingTable();
                    MessageBox.Show("Chưa có lịch sử tiêm chủng hoặc sai tên!");
                    DialogResult result = MessageBox.Show("Tạo lịch sử tiêm chủng mới!","",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Chọn thông tin ở bảng dưới!");
                        DataTable dataTable = loadingTable.connguoi();
                        dgv.DataSource = dataTable;
                    }
                    else
                    {
                        DataTable dataTable = loadingTable.sudung();
                        dgv.DataSource = dataTable;
                    }
                    
                }
                 return dgv.DataSource as DataTable;
            }
        }


        private void btnTimKiemVacXin2_Click(object sender, EventArgs e)
        {
            dtgSuDungVacXin.DataSource = dataTable;
            dtgSuDungVacXin.DataSource = filter1.searchRow(dtgSuDungVacXin, "Họ tên", txtTimKiemNguoi.Text);
        }

        private void btnLuuThongTin1_Click(object sender, EventArgs e)
        {
            SuDungVacXin suDungVacXin = new SuDungVacXin();
            {
                if (txtMuiTiem.Text == ""||
                    txtTimKiemNguoi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin!");
                    return;
                }
                else
                {
                    int flag = truyVan.Tim_ID_Nguoi(txtTimKiemNguoi.Text);
                    if (flag == 0)
                    {
                        MessageBox.Show("Chưa có dữ liệu bệnh nhân, kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        suDungVacXin.ID_Nguoi = flag;
                    }
                    suDungVacXin.ID_Nguoi = truyVan.Tim_ID_Nguoi(txtTimKiemNguoi.Text);
                    suDungVacXin.ID_VacXin = truyVan.Tim_ID_Vacxin(cbSoLo.Text);
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
                        //Kiem tra truoc khi luu
                        var vacxin = yteDBContext.VacXins.Find(suDungVacXin.ID_VacXin);
                        if (vacxin.SoLuongConLai <= 0)
                        {
                            MessageBox.Show("Lô vacxin đã hết, chọn lô khác");
                            return;
                        }
                        sql.ThemMoiVaoCSDL(suDungVacXin);
                        sql.ChinhSuaCSDL(suDungVacXin);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kiểm tra lại dữ liệu nhập!");
                        return;
                    }
                    var vacxinSuaDoi = yteDBContext.VacXins.Find(suDungVacXin.ID_VacXin);
                    if (vacxinSuaDoi.SoLuongConLai >= 1)
                    {
                        vacxinSuaDoi.SoLuongConLai = vacxinSuaDoi.SoLuongConLai - 1;
                    }
                    else
                    {
                        MessageBox.Show("Lô vacxin đã hết, chọn lô khác");
                        return;
                    }
                   // sql.ChinhSuaCSDL(suDungVacXin);

                    MessageBox.Show("Lưu thành công!");
                }

            }
        }

        private void dtgSuDungVacXin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtTimKiemNguoi.Text = dtgSuDungVacXin.Rows[numrow].Cells[1].Value.ToString();
        }

        private void cbTenVacXin1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSoLo.DataSource = comboBoxData.solo(cbTenVacXin1.Text);
        }
    }
}
