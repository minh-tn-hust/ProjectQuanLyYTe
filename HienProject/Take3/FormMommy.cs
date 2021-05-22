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
using Controller.Object;

namespace Take3
{
    public partial class FormMommy : Form
    {
        public FormMommy()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FormMommy_Load(object sender, EventArgs e)
        {
            ColumnName Name = new ColumnName();
            LoadingTable TE = new LoadingTable();
            using (var context = new YTeDbContext())
            {
                List<ChiSoTreCon> chisotrecon = context.ChiSoTreCons.ToList();
                DataTable dt = new DataTable();
                foreach (var name in Name.trecon())
                {
                    dt.Columns.Add(name);
                    
                }
                int i = 0;
                foreach (var chiso in chisotrecon)
                {
                    int id_TreEm = (int)chiso.ID_TreEm;

                    var link = context.TreEms.Find(id_TreEm); //Load thong tin tu bang tre em 
                    var record = context.ConNguois.Find(link.ID_Nguoi);
                    DataRow dr;
                    dr = dt.NewRow();
                    dr[0] = ++i;
                    dr[1] = record.HoTen;
                    dr[4] = record.SoCMND;
                    dr[5] = record.NgaySinh;
                    dr[6] = record.GioiTinh;
                    dr[7] = record.NgheNghiep;
                    dr[8] = record.DiaChi;
                    dr[9] = record.SoDienThoai;
                    dr[10] = record.Email;

                    var Bo = context.ConNguois // Load ten bo
                                .Where(b => b.ID_Nguoi == link.ID_Bo)
                                .FirstOrDefault();
                    var Me = context.ConNguois // Load ten me
                                .Where(b => b.ID_Nguoi == link.ID_Me)
                                .FirstOrDefault();

                    dr[2] = Bo.HoTen;
                    dr[3] = Me.HoTen;

                    //Load cac chi so co ban
                    if (chiso != null)
                    {
                        dr[11] = chiso.ThoiGianKham;
                        dr[12] = chiso.ChieuCao;
                        dr[13] = chiso.CanNang;
                    }

                    dt.Rows.Add(dr);

                }
                dataGridView1.DataSource = dt;
            }
            
            
            
            using (var context2 = new YTeDbContext())
            {
                List<PhuNuMangThai> phunumangthai = context2.PhuNuMangThais.ToList();
                DataTable dtt = new DataTable();
                foreach (var name in Name.phunumangthai())
                {
                    dtt.Columns.Add(name);

                }
                int i = 0;
                foreach (var chiso in phunumangthai)
                {
                    int id_Nguoimangthai = (int)chiso.ID_NguoiMangThai;

                    var link = context2.ConNguois.Find(id_Nguoimangthai); //Load thong tin tu bang nguoi mang thai
                    var record = context2.ConNguois.Find(link.ID_Nguoi);
                    DataRow dr;
                    dr = dtt.NewRow();
                    dr[0] = ++i;
                    dr[1] = record.HoTen;
                    dr[4] = record.SoCMND;
                    dr[5] = record.NgaySinh;
                    dr[6] = record.NgheNghiep;
                    dr[7] = record.DiaChi;
                    dr[8] = record.SoDienThoai;
                    dr[9] = record.Email;
                    //var Bo = context2.ConNguois // Load ten bo
                    //            .Where(b => b.ID_Nguoi == link.ID_Bo)
                    //            .FirstOrDefault();
                    //var Me = context2.ConNguois // Load ten me
                    //            .Where(b => b.ID_Nguoi == link.ID_Me)
                    //            .FirstOrDefault();
                    //dr[2] = Bo.HoTen;
                    //dr[3] = Me.HoTen;

                    //Load cac chi so co ban
                    //if (chiso != null)
                    //{
                    //    dr[11] = chiso.ThoiGianKham;
                    //    dr[12] = chiso.ChieuCao;
                    //    dr[13] = chiso.CanNang;
                    //}

                    dtt.Rows.Add(dr);
                }
                dataGridView2.DataSource = dtt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
