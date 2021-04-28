using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using YTeDB;
using System.Windows.Forms;
using Controller;

namespace Controller.InitDataGridView
{
    public class LoadingTable 
    {
        ColumnName Name = new ColumnName();
        public DataTable connguoi()
        {
            using (var context = new YTeDbContext())
            {
                List<ConNguoi> connguoi = context.ConNguois.ToList();
                DataTable dt = new DataTable();
                foreach (var name in Name.connguoi())
                    dt.Columns.Add(name);
                int i = 0;
                foreach (var record in connguoi)
                {
                    DataRow dr;
                    dr = dt.NewRow();
                    dr[0] = ++i;
                    dr[1] = record.HoTen;
                    dr[2] = record.SoCMND;
                    dr[3] = record.NgaySinh;
                    dr[4] = record.GioiTinh;
                    dr[5] = record.NgheNghiep;
                    dr[6] = record.DiaChi;
                    dr[7] = record.SoDienThoai;
                    dr[8] = record.Email;
                    dt.Rows.Add(dr);
                }
                return dt;
            }
        }
        public DataTable nhanvien()
        {
            using (var context = new YTeDbContext())
            {
                List<NhanVienYTe> NhanViens = context.NhanVienYTes.ToList();
                DataTable dt = new DataTable();
                foreach (var name in Name.nhanvien())
                    dt.Columns.Add(name);
                int i = 0;
                foreach (var nhanvien in NhanViens)
                {
                    int id_Nguoi = (int)nhanvien.ID_Nguoi;
                    MessageBox.Show(id_Nguoi.ToString());
                    var record = context.ConNguois.Find(id_Nguoi);
                    DataRow dr;
                    dr = dt.NewRow();
                    dr[0] = ++i;
                    dr[1] = record.HoTen;
                    dr[2] = record.SoCMND;
                    dr[3] = record.NgaySinh;
                    dr[4] = record.GioiTinh;
                    dr[5] = record.NgheNghiep;
                    dr[6] = record.DiaChi;
                    dr[7] = record.SoDienThoai;
                    dr[8] = record.Email;
                    dr[9] = nhanvien.UserName;
                    dr[10] = nhanvien.Password;
                    dt.Rows.Add(dr);

                }
                return dt;
            }
        }
        public DataTable trecon()
        {
            using (var context = new YTeDbContext())
            {
                List<TreEm> TreEms = context.TreEms.ToList();
                DataTable dt = new DataTable();
                foreach (var name in Name.trecon())
                    dt.Columns.Add(name);
                int i = 0;
                foreach (var treem in TreEms)
                {
                    int id_Nguoi = (int)treem.ID_Nguoi;
                    MessageBox.Show(id_Nguoi.ToString());
                    var record = context.ConNguois.Find(id_Nguoi);
                    DataRow dr;
                    dr = dt.NewRow();
                    dr[0] = ++i;
                    dr[1] = record.HoTen;
                    dr[2] = record.SoCMND;
                    dr[3] = record.NgaySinh;
                    dr[4] = record.GioiTinh;
                    dr[5] = record.NgheNghiep;
                    dr[6] = record.DiaChi;
                    dr[7] = record.SoDienThoai;
                    dr[8] = record.Email;
                    var chisocoban = context.ChiSoTreCons.Where(b => b.ID_TreEm == treem.ID_TreEm).FirstOrDefault();
                    if (chisocoban != null)
                    {
                        dr[9] = chisocoban.ThoiGianKham;
                        dr[10] = chisocoban.ChieuCao;
                        dr[11] = chisocoban.CanNang;
                    }

                    dt.Rows.Add(dr);

                }
                return dt;
            }
        }


        public DataTable phunumangthai()
        {
            using (var context = new YTeDbContext())
            {
                List<PhuNuMangThai> Phunus = context.PhuNuMangThais.ToList();
                DataTable dt = new DataTable();
                foreach (var name in Name.phunumangthai())
                    dt.Columns.Add(name);
                int i = 0;
                foreach (var phunu in Phunus)
                {
                    int id_Nguoi = (int)phunu.ID_Nguoi;
                    var record = context.ConNguois.Find(id_Nguoi);
                    DataRow dr;
                    dr = dt.NewRow();
                    dr[0] = ++i;
                    dr[1] = record.HoTen;
                    dr[2] = record.SoCMND;
                    dr[3] = record.NgaySinh;
                    dr[4] = record.GioiTinh;
                    dr[5] = record.NgheNghiep;
                    dr[6] = record.DiaChi;
                    dr[7] = record.SoDienThoai;
                    dr[8] = record.Email;
                    var thongtin = context.ThongTinThaiKis.Where(b => b.ID_NguoiMangThai == phunu.ID_NguoiMangThai).FirstOrDefault();
                    if (thongtin != null)
                    {
                        dr[9] = thongtin.ThoiGianKham;
                        dr[10] = thongtin.CanNangThaiNhi;
                        dr[11] = thongtin.ThoiGianSinhDuKien.GetValueOrDefault();
                    }

                    dt.Rows.Add(dr);

                }
                return dt;
            }
        }

    }
}
