using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using Hieu;

namespace QuanLyVaxin
{
    public partial class ThongKeSuDung : Form
    {
        public ThongKeSuDung()
        {
            InitializeComponent();
        }

        ComboBoxData comboBox = new ComboBoxData();
        GraphData graph = new GraphData();
        TruyVan truyVan = new TruyVan();
        sqlMethod sql = new sqlMethod();
        YTeDbContext yteDBContext = new YTeDbContext();


        private void ThongKeSuDungVacXin_Load(object sender, EventArgs e)
        {
            cbTenVacXin2.DataSource = comboBox.vacxin();
            cbTenVacXin3.DataSource = comboBox.thongke();
            cbSoLo.DataSource = comboBox.solo(cbTenVacXin2.Text);
            LoadChart();
        }

        private void btnLuuThongTin2_Click(object sender, EventArgs e)
        {
            ThongKeSuDungVacXin thongKeSuDungVacXin = new ThongKeSuDungVacXin();
            {   if(txtSoLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin!");
                    return;
                }
                else
                {
                    int flag = truyVan.Tim_ID_Vacxin(cbSoLo.Text);
                    if (flag == 0)
                    {
                        MessageBox.Show("Vui lòng nhập đúng số lô!");
                        return;
                    }
                    else
                    {
                        thongKeSuDungVacXin.SoLoVacXin = cbSoLo.Text;
                    }

                    thongKeSuDungVacXin.NgaySuDung = dtpNgaySuDung.Value;

                    thongKeSuDungVacXin.ID_VacXin = truyVan.Tim_ID_Vacxin(cbSoLo.Text);

                    if (int.TryParse(txtSoLuong.Text, out int result2))
                    {
                        thongKeSuDungVacXin.SoLuongSuDung = Convert.ToInt32(txtSoLuong.Text);
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sử dụng phải là số!");
                        return;
                    }
                }

                //try
                //{
                //    sql.ChinhSuaCSDL(thongKeSuDungVacXin);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Lưu thất bại, vui lòng kiểm tra lại!");
                //    return;
                //}
                try
                {
                    sql.ThemMoiVaoCSDL(thongKeSuDungVacXin);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu thất bại!");
                    return;
                }

                MessageBox.Show("Lưu thành công!");
            }
        }
                

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        public void LoadChart()
        {
            chartThongKe.Series["Số lượng"].Points.Clear();
            chartThongKe.ChartAreas["ChartArea1"].AxisX.Interval = 20;
            DateTime[] X = graph.GetDataX(dtpTuNgay.Value, dtpDenNgay.Value, cbTenVacXin3.Text).ToArray();
            int?[] Y = graph.GetDataY(dtpTuNgay.Value, dtpDenNgay.Value, cbTenVacXin3.Text).ToArray();

            for (int i = Y.Length - 1; i >=0; i--)
            {
                chartThongKe.Series["Số lượng"].Points.AddXY(X[i], Y[i]);
            }

        }

        private void cbTenVacXin2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSoLo.DataSource = comboBox.solo(cbTenVacXin2.Text);
        }

        private void chartThongKe_Click(object sender, EventArgs e)
        {

        }
    }
}
