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
using Controller.dataGridView;
using Model;

namespace QLPK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DTGFilter filter = new DTGFilter();
        //SqlConnection con
        
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormDanhSachDatLich f = new FormDanhSachDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           using(var context= new YTeDbContext())
            {
                var conNguoi = context.ConNguois.Where(b => b.SoCMND == txtSoCMND.Text).FirstOrDefault();
                if (conNguoi == null)
                {
                    MessageBox.Show("Chưa có dữ liệu đặt lịch khám của người này!");
                    this.Hide();
                    FormThongTinNguoiDatLich form = new FormThongTinNguoiDatLich();
                    form.ShowDialog();
                    this.Close();
                }
                else {
                    var datLichKham = context.DatLichKhams.Where(b => b.ID_Nguoi == conNguoi.ID_Nguoi).FirstOrDefault();
                    if (datLichKham == null)
                    {
                        MessageBox.Show("Chưa có dữ liệu đặt lịch khám của người này!");
                        this.Hide();
                        FormDatLichNeuDaCoThongTin form = new FormDatLichNeuDaCoThongTin();
                        form.ID_Nguoi = conNguoi.ID_Nguoi;

                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        FormDanhSachDatLich form = new FormDanhSachDatLich();
                        form.SoCMND = conNguoi.SoCMND;
                        form.Show();
                        this.Close();
                    }
                        }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
            //if (giờ trả lại != 8 giờ)
            //guna2Button3.FillColor = Color.Black;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            FormThongTinNguoiDatLich f = new FormThongTinNguoiDatLich();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
