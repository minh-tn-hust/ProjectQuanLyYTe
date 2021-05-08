using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using System.Windows.Forms;
using Controller;

namespace Controller.dataGridView
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
                List<ChiSoTreCon> chisotrecon = context.ChiSoTreCons.ToList();
                DataTable dt = new DataTable();
                foreach (var name in Name.trecon())
                    dt.Columns.Add(name);
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
        public DataTable vacxin()
        {
            using (var context = new YTeDbContext())
            {
                List<VacXin> Vacxins = context.VacXins.ToList();
                DataTable dt = new DataTable();
                foreach (var name in Name.vacxin())
                    dt.Columns.Add(name);
                int i = 0;
                foreach (var vacxin in Vacxins)
                {
                    DataRow dr;
                    dr = dt.NewRow();
                    dr[0] = ++i;
                    dr[1] = vacxin.TenVacXin;
                    dr[2] = vacxin.TenLoVacXin;
                    dr[3] = vacxin.GiaThanh;
                    dr[4] = vacxin.NgaySanXuat;
                    dr[5] = vacxin.HanSuDung;
                    dr[6] = vacxin.ThoiGianSuDungLai;
                    dr[7] = vacxin.SoLuongConLai;
                    dr[8] = vacxin.ChongChiDinh;
                    dr[9] = vacxin.ThongTinKhac;
                    dt.Rows.Add(dr);

                }
                return dt;
            }
        }

    }
}
