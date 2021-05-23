using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Model;
using Controller.dataGridView;

namespace QLPK
{
    public partial class FormDatlLich : Form
    {
        public FormDatlLich()
        {
            InitializeComponent();
        }

        //SqlConnection con

        public string SoCMND = null;
        DTGFilter filter = new DTGFilter();
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        public int timchotrong(DateTime dt, string PK)
        {

            using(var context = new YTeDbContext())
            {
                var pk = context.PhongKhams.Where(s => s.TenPhongKham == PK).FirstOrDefault();
                var listdatlich = context.DatLichKhams.Where(s => s.ThoiGianHenKham == dt && s.ID_PhongKham == pk.ID_PhongKham).ToList();
                return listdatlich.Count;
            }
        }
        
        public List<String> listphongkham()
        {
            using (var context = new YTeDbContext())
            {
                var phongkhams = context.PhongKhams.ToList();
                List<String> tenphongkham = new List<string>();
                foreach (var i in phongkhams) 
                {
                    tenphongkham.Add(i.TenPhongKham);
                } 
                var p = new HashSet<String>(tenphongkham);
                return p.ToList();
            }
        }


        private void FormDatlLich_Load(object sender, EventArgs e)
        {
            //lỗi ở đây là khi mà mới load thì cbPhongKham.Text không có gì cả -> sai
            // nãy m MesageBOx.Show(t) -> sai -> không chạy
            cbPhongKham.DataSource = listphongkham();
            var pk = cbPhongKham.Text;
            DateTime dt8 = guna2DateTimePicker2.Value;
            dt8 = new DateTime(dt8.Year, dt8.Month, dt8.Day, 8, 0, 0);

        }


        private void guna2DateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            var pk = cbPhongKham.Text;

            DateTime dt8 = guna2DateTimePicker2.Value;
            dt8 = new DateTime(dt8.Year, dt8.Month, dt8.Day, 8, 0, 0);
            int t8 = timchotrong(dt8, pk);
            if (t8 >= 2) guna2Button3.Enabled = false;

            DateTime dt9 = guna2DateTimePicker2.Value;
            dt9 = new DateTime(dt9.Year, dt9.Month, dt9.Day, 9, 0, 0);
            int t9 = timchotrong(dt9, pk);
            if (t9 > 3) guna2Button4.Enabled = false;

            DateTime dt10 = guna2DateTimePicker2.Value;
            dt10 = new DateTime(dt10.Year, dt10.Month, dt10.Day, 10, 0, 0);
            int t10 = timchotrong(dt10, pk);
            if (t10 > 3) guna2Button5.Enabled = false;

            DateTime dt11 = guna2DateTimePicker2.Value;
            dt11 = new DateTime(dt11.Year, dt11.Month, dt11.Day, 11, 0, 0);
            int t11 = timchotrong(dt11, pk);
            if (t11 > 3) guna2Button6.Enabled = false;

            DateTime dt14 = guna2DateTimePicker2.Value;
            dt14 = new DateTime(dt14.Year, dt14.Month, dt14.Day, 14, 0, 0);
            int t14 = timchotrong(dt14, pk);
            if (t14 > 3) guna2Button7.Enabled = false;

            DateTime dt15 = guna2DateTimePicker2.Value;
            dt15 = new DateTime(dt15.Year, dt15.Month, dt15.Day, 15, 0, 0);
            int t15 = timchotrong(dt15, pk);
            if (t15 > 3) guna2Button8.Enabled = false;

            DateTime dt16 = guna2DateTimePicker2.Value;
            dt16 = new DateTime(dt16.Year, dt16.Month, dt16.Day, 16, 0, 0);
            int t16 = timchotrong(dt16, pk);
            if (t16 > 3) guna2Button9.Enabled = false;

            DateTime dt17 = guna2DateTimePicker2.Value;
            dt17 = new DateTime(dt17.Year, dt17.Month, dt17.Day, 17, 0, 0);
            int t17 = timchotrong(dt17, pk);
            if (t17 > 3) guna2Button10.Enabled = false;

            guna2Button3.Text = "08:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t8.ToString();
            guna2Button4.Text = "09:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t9.ToString();
            guna2Button5.Text = "10:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t10.ToString();
            guna2Button6.Text = "11:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t11.ToString();
            guna2Button7.Text = "14:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t14.ToString();
            guna2Button8.Text = "15:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t15.ToString();
            guna2Button9.Text = "16:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t16.ToString();
            guna2Button10.Text = "17:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t17.ToString();
        }

        private void cbPhongKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pk = cbPhongKham.Text;

            DateTime dt8 = guna2DateTimePicker2.Value;
            dt8 = new DateTime(dt8.Year, dt8.Month, dt8.Day, 8, 0, 0);
            int t8 = timchotrong(dt8, pk);
            if (t8 > 3) guna2Button3.Enabled = false;

            DateTime dt9 = guna2DateTimePicker2.Value;
            dt9 = new DateTime(dt9.Year, dt9.Month, dt9.Day, 9, 0, 0);
            int t9 = timchotrong(dt9, pk);
            if (t9 > 3) guna2Button4.Enabled = false;

            DateTime dt10 = guna2DateTimePicker2.Value;
            dt10 = new DateTime(dt10.Year, dt10.Month, dt10.Day, 10, 0, 0);
            int t10 = timchotrong(dt10, pk);
            if (t10 > 3) guna2Button5.Enabled = false;

            DateTime dt11 = guna2DateTimePicker2.Value;
            dt11 = new DateTime(dt11.Year, dt11.Month, dt11.Day, 11, 0, 0);
            int t11 = timchotrong(dt11, pk);
            if (t11 > 3) guna2Button6.Enabled = false;

            DateTime dt14 = guna2DateTimePicker2.Value;
            dt14 = new DateTime(dt14.Year, dt14.Month, dt14.Day, 14, 0, 0);
            int t14 = timchotrong(dt14, pk);
            if (t14 > 3) guna2Button7.Enabled = false;

            DateTime dt15 = guna2DateTimePicker2.Value;
            dt15 = new DateTime(dt15.Year, dt15.Month, dt15.Day, 15, 0, 0);
            int t15 = timchotrong(dt15, pk);
            if (t15 > 3) guna2Button8.Enabled = false;

            DateTime dt16 = guna2DateTimePicker2.Value;
            dt16 = new DateTime(dt16.Year, dt16.Month, dt16.Day, 16, 0, 0);
            int t16 = timchotrong(dt16, pk);
            if (t16 > 3) guna2Button9.Enabled = false;

            DateTime dt17 = guna2DateTimePicker2.Value;
            dt17 = new DateTime(dt17.Year, dt17.Month, dt17.Day, 17, 0, 0);
            int t17 = timchotrong(dt17, pk);
            if (t17 > 3) guna2Button10.Enabled = false;

            guna2Button3.Text = "08:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t8.ToString();
            guna2Button4.Text = "09:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t9.ToString();
            guna2Button5.Text = "10:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t10.ToString();
            guna2Button6.Text = "11:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t11.ToString();
            guna2Button7.Text = "14:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t14.ToString();
            guna2Button8.Text = "15:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t15.ToString();
            guna2Button9.Text = "16:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t16.ToString();
            guna2Button10.Text = "17:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t17.ToString();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FormDanhSachDatLich f = new FormDanhSachDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DateTime Date = guna2DateTimePicker2.Value;
            Date = new DateTime(Date.Year, Date.Month, Date.Day, 8, 0, 0);
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            f.date = Date;
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DateTime Date = guna2DateTimePicker2.Value;
            Date = new DateTime(Date.Year, Date.Month, Date.Day, 9, 0, 0);
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            f.date = Date;
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DateTime Date = guna2DateTimePicker2.Value;
            Date = new DateTime(Date.Year, Date.Month, Date.Day, 10, 0, 0);
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            f.date = Date;
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DateTime Date = guna2DateTimePicker2.Value;
            Date = new DateTime(Date.Year, Date.Month, Date.Day, 11, 0, 0);
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            DateTime Date = guna2DateTimePicker2.Value;
            Date = new DateTime(Date.Year, Date.Month, Date.Day, 14, 0, 0);
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            f.date = Date;
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            DateTime Date = guna2DateTimePicker2.Value;
            Date = new DateTime(Date.Year, Date.Month, Date.Day, 15, 0, 0);
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            f.date = Date;
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            DateTime Date = guna2DateTimePicker2.Value;
            Date = new DateTime(Date.Year, Date.Month, Date.Day, 16, 0, 0);
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            f.date = Date;
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            DateTime Date = guna2DateTimePicker2.Value;
            Date = new DateTime(Date.Year, Date.Month, Date.Day, 17, 0, 0);
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var pk = cbPhongKham.Text;

            DateTime dt8 = guna2DateTimePicker2.Value;
            dt8 = new DateTime(dt8.Year, dt8.Month, dt8.Day, 8, 0, 0);
            int t8 = timchotrong(dt8, pk);
            if (t8 >= 2) guna2Button3.Enabled = false;

            DateTime dt9 = guna2DateTimePicker2.Value;
            dt9 = new DateTime(dt9.Year, dt9.Month, dt9.Day, 9, 0, 0);
            int t9 = timchotrong(dt9, pk);
            if (t9 > 3) guna2Button4.Enabled = false;

            DateTime dt10 = guna2DateTimePicker2.Value;
            dt10 = new DateTime(dt10.Year, dt10.Month, dt10.Day, 10, 0, 0);
            int t10 = timchotrong(dt10, pk);
            if (t10 > 3) guna2Button5.Enabled = false;

            DateTime dt11 = guna2DateTimePicker2.Value;
            dt11 = new DateTime(dt11.Year, dt11.Month, dt11.Day, 11, 0, 0);
            int t11 = timchotrong(dt11, pk);
            if (t11 > 3) guna2Button6.Enabled = false;

            DateTime dt14 = guna2DateTimePicker2.Value;
            dt14 = new DateTime(dt14.Year, dt14.Month, dt14.Day, 14, 0, 0);
            int t14 = timchotrong(dt14, pk);
            if (t14 > 3) guna2Button7.Enabled = false;

            DateTime dt15 = guna2DateTimePicker2.Value;
            dt15 = new DateTime(dt15.Year, dt15.Month, dt15.Day, 15, 0, 0);
            int t15 = timchotrong(dt15, pk);
            if (t15 > 3) guna2Button8.Enabled = false;

            DateTime dt16 = guna2DateTimePicker2.Value;
            dt16 = new DateTime(dt16.Year, dt16.Month, dt16.Day, 16, 0, 0);
            int t16 = timchotrong(dt16, pk);
            if (t16 > 3) guna2Button9.Enabled = false;

            DateTime dt17 = guna2DateTimePicker2.Value;
            dt17 = new DateTime(dt17.Year, dt17.Month, dt17.Day, 17, 0, 0);
            int t17 = timchotrong(dt17, pk);
            if (t17 > 3) guna2Button10.Enabled = false;

            guna2Button3.Text = "08:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t8.ToString();
            guna2Button4.Text = "09:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t9.ToString();
            guna2Button5.Text = "10:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t10.ToString();
            guna2Button6.Text = "11:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t11.ToString();
            guna2Button7.Text = "14:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t14.ToString();
            guna2Button8.Text = "15:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t15.ToString();
            guna2Button9.Text = "16:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t16.ToString();
            guna2Button10.Text = "17:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t17.ToString();

        }

        private void cbPhongKham_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            var pk = cbPhongKham.Text;

            DateTime dt8 = guna2DateTimePicker2.Value;
            dt8 = new DateTime(dt8.Year, dt8.Month, dt8.Day, 8, 0, 0);
            int t8 = timchotrong(dt8, pk);
            if (t8 >= 2) guna2Button3.Enabled = false;

            DateTime dt9 = guna2DateTimePicker2.Value;
            dt9 = new DateTime(dt9.Year, dt9.Month, dt9.Day, 9, 0, 0);
            int t9 = timchotrong(dt9, pk);
            if (t9 > 3) guna2Button4.Enabled = false;

            DateTime dt10 = guna2DateTimePicker2.Value;
            dt10 = new DateTime(dt10.Year, dt10.Month, dt10.Day, 10, 0, 0);
            int t10 = timchotrong(dt10, pk);
            if (t10 > 3) guna2Button5.Enabled = false;

            DateTime dt11 = guna2DateTimePicker2.Value;
            dt11 = new DateTime(dt11.Year, dt11.Month, dt11.Day, 11, 0, 0);
            int t11 = timchotrong(dt11, pk);
            if (t11 > 3) guna2Button6.Enabled = false;

            DateTime dt14 = guna2DateTimePicker2.Value;
            dt14 = new DateTime(dt14.Year, dt14.Month, dt14.Day, 14, 0, 0);
            int t14 = timchotrong(dt14, pk);
            if (t14 > 3) guna2Button7.Enabled = false;

            DateTime dt15 = guna2DateTimePicker2.Value;
            dt15 = new DateTime(dt15.Year, dt15.Month, dt15.Day, 15, 0, 0);
            int t15 = timchotrong(dt15, pk);
            if (t15 > 3) guna2Button8.Enabled = false;

            DateTime dt16 = guna2DateTimePicker2.Value;
            dt16 = new DateTime(dt16.Year, dt16.Month, dt16.Day, 16, 0, 0);
            int t16 = timchotrong(dt16, pk);
            if (t16 > 3) guna2Button9.Enabled = false;

            DateTime dt17 = guna2DateTimePicker2.Value;
            dt17 = new DateTime(dt17.Year, dt17.Month, dt17.Day, 17, 0, 0);
            int t17 = timchotrong(dt17, pk);
            if (t17 > 3) guna2Button10.Enabled = false;

            guna2Button3.Text = "08:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t8.ToString();
            guna2Button4.Text = "09:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t9.ToString();
            guna2Button5.Text = "10:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t10.ToString();
            guna2Button6.Text = "11:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t11.ToString();
            guna2Button7.Text = "14:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t14.ToString();
            guna2Button8.Text = "15:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t15.ToString();
            guna2Button9.Text = "16:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t16.ToString();
            guna2Button10.Text = "17:00" + "\n" + "Số bệnh nhân đã đăng kí: " + t17.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormDanhSachDatLich f = new FormDanhSachDatLich();
            f.ShowDialog();
            this.Show();

        }

        private void butTimKiem_Click(object sender, EventArgs e)
        {
            if (txtBHYT.Text != "")
            {
                using (var context = new YTeDbContext())
                {
                    var people = context.TreEms.Where(s => s.MaTheBHYTe == txtBHYT.Text).FirstOrDefault();
                    if (people == null)
                    {
                        MessageBox.Show("Sai thông tin!", "Thông báo!");
                    }
                    else
                    {
                        this.Hide();
                        FormDanhSachDatLich f = new FormDanhSachDatLich();
                        f.BHYT = people.MaTheBHYTe;
                        f.Show();
                        this.Close();
                    }
                }
            }
            if (txtCMND.Text != "")
            {
                using (var context = new YTeDbContext())
                {
                    var people = context.ConNguois.Where(s => s.SoCMND == txtCMND.Text).FirstOrDefault();
                    if (people == null)
                    {
                        MessageBox.Show("Sai thông tin!", "Thông báo!");
                    }
                    else
                    {
                        this.Hide();
                        FormDanhSachDatLich f = new FormDanhSachDatLich();
                        f.SoCMND = people.SoCMND;
                        f.Show();
                    }
                }
            }
        }
    }
}
