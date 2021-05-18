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

namespace QLPK
{
    public partial class FormDanhSachDatLich : Form
    {
        public string SoCMND= null;
        DTGFilter filter = new DTGFilter();
        public FormDanhSachDatLich()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void FormDanhSachDatLich_Load(object sender, EventArgs e)
        {
            if (SoCMND == null)
            {
                LoadingTable ld = new LoadingTable(); // tạo đối tượng loadingtable (file class trong Cotroller -> dataGridView -> LoadingTable.cs
                dataGridView1.DataSource = ld.datlichkham();
            }
            else
            {
                LoadingTable ld = new LoadingTable(); // tạo đối tượng loadingtable (file class trong Cotroller -> dataGridView -> LoadingTable.cs
                dataGridView1.DataSource = ld.datlichkham();
                dataGridView1.DataSource = filter.searchRow(dataGridView1, "Số CMND", SoCMND);
            }

        }

        int i = 0;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DataTable bangtruoc = dataGridView1.DataSource as DataTable;
            DataRow dr = bangtruoc.NewRow();
            dr[0] = i++;
            dr[1] = textboxHoTen.Text;
            dr[2] = textboxCMND.Text;
            dr[4] = comboboxGioiTinh.Text;
            dr[5] = textboxDiaChi.Text;
            dr[6] = textboxSDT.Text;
            dr[7] = textboxEmail.Text;
            bangtruoc.Rows.Add(dr);
            dataGridView1.DataSource = bangtruoc;
           
            int gioitinhT = 0 ;
            if (comboboxGioiTinh.Text == "Nữ")
            {
                gioitinhT = 0;
            }
            else gioitinhT = 1;
           
            using (var context = new YTeDbContext())
            {
                var connguoimoi = new ConNguoi()
                {
                    HoTen = textboxHoTen.Text,
                    SoCMND = textboxCMND.Text,
                    GioiTinh = gioitinhT,
                    DiaChi = textboxDiaChi.Text,
                    SoDienThoai = textboxSDT.Text,
                    Email = textboxEmail.Text
                };

                context.ConNguois.Add(connguoimoi);
                context.SaveChanges();
                var people = context.ConNguois.Where(s => s.SoDienThoai == connguoimoi.SoDienThoai).FirstOrDefault();
                var datlichkham = new DatLichKham();
                datlichkham.LyDoKham = textboxLyDoKham.Text;
                datlichkham.ID_Nguoi = people.ID_Nguoi;
                datlichkham.ThoiGianHenKham = DateTime.Now;
                context.DatLichKhams.Add(datlichkham);
                context.SaveChanges();
                // xóa được rồi, nãy tại trong cái bảng datlichkham, m thiếu cái nào đấy, nên nó không cho xóa
            };
           
    }

        private IDisposable YTeDbContext()
        {
            throw new NotImplementedException();
        }


        string c;
         public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                c = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {          
            using (var context = new YTeDbContext())
            {
                DataTable bangtruoc = dataGridView1.DataSource as DataTable;
                var people = context.ConNguois.Where(s => s.SoDienThoai == c).FirstOrDefault();
                if (people == null)
                    MessageBox.Show("Khong tim thay");
                else
                {
                    MessageBox.Show("ID bệnh nhân đã xóa: " + people.ID_Nguoi.ToString(), "Thông báo!");
                }
                var people1 = context.DatLichKhams.Where(s => s.ID_Nguoi == people.ID_Nguoi).FirstOrDefault();
                //MessageBox.Show(people1.ID_Nguoi.ToString());
                context.ConNguois.Remove(people);
                context.SaveChanges();
                context.DatLichKhams.Remove(people1);
                context.SaveChanges();

                dataGridView1.DataSource = bangtruoc;
            }
        }

        private void FormDanhSachDatLich_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
