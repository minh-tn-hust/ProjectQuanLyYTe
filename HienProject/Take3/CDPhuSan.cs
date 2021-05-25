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
using System.Windows.Forms.DataVisualization.Charting;

namespace Take3
{
    public partial class CDPhuSan : Form
    {
        public int IDnguoimangthai;
        public CDPhuSan()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThongTinThaiKi thongtin = new ThongTinThaiKi();
            if (guna2TextBox2.Text != "" && guna2TextBox4.Text != "" && guna2ComboBox1.SelectedItem != null)
            {


                using (var yteDbContext = new YTeDbContext())
                {
                    yteDbContext.ThongTinThaiKis.Add(thongtin);
                    thongtin.ThoiGianKham = DateTime.Parse(guna2DateTimePicker1.Value.ToString());
                    thongtin.LanKhamTiepTheo = DateTime.Parse(guna2DateTimePicker2.Value.ToString());
                    thongtin.ID_PhongKham = Int32.Parse(guna2ComboBox1.SelectedItem.ToString().Substring(0, 1));
                    thongtin.ChieuCaoMe = int.Parse(guna2TextBox2.Text);
                    thongtin.CanNangMe = int.Parse(guna2TextBox4.Text);
                    DateTime? dateTime = guna2DateTimePicker3.Value;
                    thongtin.ThoiGianSinhDuKien = dateTime;
                    thongtin.ID_NguoiMangThai = IDnguoimangthai;
                    try
                    {
                        yteDbContext.SaveChanges();
                        MessageBox.Show("Lưu thành công!");
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
                        return;
                    }

                }
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
        }

        private void CDPhuSan_Load(object sender, EventArgs e)
        {
            using (var yteDbcontext = new YTeDbContext())
            {
                List<PhongKham> listPhongKham = yteDbcontext.PhongKhams.ToList();
                foreach (var record in listPhongKham)
                {
                    guna2ComboBox1.Items.Add(record.ID_PhongKham + " - " + record.TenPhongKham);
                }
            }
            this.IDnguoimangthai = 1;
            chartCanNang.Series[0].LegendText = "Cân nặng của mẹ";
            chartCanNang.Series[0].ChartType = SeriesChartType.Line;
            List<DateTime> date = new List<DateTime>();
            List<int> cannang = new List<int>();
            using (var context = new YTeDbContext())
            {
                var nguoimangthais = context.ThongTinThaiKis.Where(b => b.ID_NguoiMangThai == IDnguoimangthai).ToList();
                foreach (var record in nguoimangthais)
                {
                    date.Add(record.ThoiGianKham);
                    cannang.Add(record.CanNangMe);
                }
            }
            chartCanNang.Series[0].IsValueShownAsLabel = true;
            chartCanNang.Series[0].Points.DataBindXY(date, cannang);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
