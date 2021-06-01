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
using System.Configuration;
using Controller.dataGridView; // thư viên dùng để load data cho csdl của mình
using Model;
using Controller.Object;

namespace QLPK
{
    public partial class FormDanhSachDatLich : Form
    {
        public FormDanhSachDatLich()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        public string SoCMND = null;
        public string soBHYT = null;
        public string SDT = null;
        public int ID_Nguoi = 0;
        DTGFilter filter = new DTGFilter();
        private void FormDanhSachDatLich_Load(object sender, EventArgs e)
        {
            if (SoCMND != null)
            {
                LoadingTable ld = new LoadingTable(); // tạo đối tượng loadingtable (file class trong Cotroller -> dataGridView -> LoadingTable.cs
                dataGridView1.DataSource = ld.datlichkham();
                dataGridView1.DataSource = filter.searchRow(dataGridView1, "Số CMND", SoCMND);
            }

            if (SDT != null)
            {
                LoadingTable ld = new LoadingTable();
                dataGridView1.DataSource = ld.datlichkham();
                dataGridView1.DataSource = filter.searchRow(dataGridView1, "Số điện thoại", SDT);
            }
            if (SoCMND == null && SDT == null)
            {
                LoadingTable ld = new LoadingTable();
                dataGridView1.DataSource = ld.datlichkham();
            }
        }
        

        private IDisposable YTeDbContext()
        {
            throw new NotImplementedException();
        }


        string c;


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (var context = new YTeDbContext())
            {
                var people = context.ConNguois.Where(s => s.SoDienThoai == c).FirstOrDefault();
                if (people == null)
                    MessageBox.Show("Không tìm thấy bệnh nhân!");
                else
                {
                    MessageBox.Show("ID bệnh nhân đã xóa: " + people.ID_Nguoi.ToString(), "Thông báo!");
                }
                var people1 = context.DatLichKhams.Where(s => s.ID_Nguoi == people.ID_Nguoi).FirstOrDefault();
                context.DatLichKhams.Remove(people1);
                context.SaveChanges();
                LoadingTable ld = new LoadingTable();
                dataGridView1.DataSource = ld.datlichkham();
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            using (var context = new YTeDbContext())
            {
                var oldconnguoi = context.ConNguois.Where(s => s.SoDienThoai == c).FirstOrDefault();
                var oldpeople = context.DatLichKhams.Where(s => s.ID_Nguoi == oldconnguoi.ID_Nguoi).FirstOrDefault();
                {
                    oldpeople.LyDoKham = textboxLyDoKham.Text;
                    oldpeople.ThoiGianHenKham = guna2DateTimePicker1.Value;
                    oldconnguoi.HoTen = textboxHoTen.Text;
                    oldconnguoi.SoCMND = textboxCMND.Text;
                    oldconnguoi.SoDienThoai = textboxSDT.Text;
                    oldconnguoi.DiaChi = textboxDiaChi.Text;
                    oldconnguoi.Email = textboxEmail.Text;
                    if (comboboxGioiTinh.Text == "Nam") oldconnguoi.GioiTinh = 1;
                    else oldconnguoi.GioiTinh = 0;
                }
                context.SaveChanges();
                try
                {
                    
                    LoadingTable ld = new LoadingTable();
                    dataGridView1.DataSource = ld.datlichkham();
                    MessageBox.Show("Đã lưu bệnh nhân có ID: " + oldconnguoi.ID_Nguoi, "Thông báo!");
                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
                    return;
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textboxHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textboxCMND.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textboxDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textboxSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textboxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                textboxLyDoKham.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                string i = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (i == "1") comboboxGioiTinh.Text = "Nữ";
                else comboboxGioiTinh.Text = "Nam";
                guna2DateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }
    }
}
