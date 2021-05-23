using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BieuDo;
using Bieudo2;
using Model;

namespace Take3
{
    public partial class CDTreSoSinh : Form
    {
        public int IDtreem;
        public DateTime? born;
        public string Gioitinh;
        public CDTreSoSinh()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Gioitinh == "Nam")
            {
                BDNam BD1 = new BDNam(IDtreem);
                BD1.Show();
            }
            else
            {
                BDNu BD2 = new BDNu(IDtreem);
                BD2.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text != "" && guna2TextBox2.Text != "")
            {
                using (var yteDbContext = new YTeDbContext())
                {
                    ChiSoTreCon trecon = new ChiSoTreCon();
                    yteDbContext.ChiSoTreCons.Add(trecon);
                    trecon.ThoiGianKham = DateTime.Parse(guna2DateTimePicker1.Value.ToString());
                    trecon.LanKhamTiepTheo = DateTime.Parse(guna2DateTimePicker2.Value.ToString());
                    trecon.Tuoi = Convert.ToInt32((guna2DateTimePicker1.Value - Convert.ToDateTime(born)).TotalDays / 30);
                    trecon.ID_TreEm = IDtreem;
                    trecon.ChieuCao = int.Parse(guna2TextBox2.Text);
                    trecon.CanNang = int.Parse(guna2TextBox3.Text);
                    if (guna2ComboBox1.SelectedItem != null)
                    {
                        trecon.ID_PhongKham = Int32.Parse(guna2ComboBox1.SelectedItem.ToString().Substring(0, 1));
                    }
                    try
                    {
                        yteDbContext.SaveChanges();
                        MessageBox.Show("Lưu thành công!");
                    }
                    catch
                    {
                        MessageBox.Show("Thêm mới thất bại, kiểm tra lại dữ liệu đã nhập!");
                        return;
                    }
                }
                
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void CDTreSoSinh_Load(object sender, EventArgs e)
        {
            using (var yteDbcontext = new YTeDbContext())
            {
                List<PhongKham> listPhongKham = yteDbcontext.PhongKhams.ToList();
                foreach (var record in listPhongKham)
                {
                    guna2ComboBox1.Items.Add(record.ID_PhongKham + " - " + record.TenPhongKham);
                }
            }
        }
    }
}
