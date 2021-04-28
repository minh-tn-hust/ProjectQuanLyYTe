﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using System.Windows.Forms;

namespace Controller
{
    public class LoadingTable 
    {
        ColumnName Name = new ColumnName();
        public DataTable connguoi()
        {
            using (var context = new Model1())
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
            using (var context = new Model1())
            {
                List<NhanVienYTe> NhanViens = context.NhanVienYTes.ToList();
                DataTable dt = new DataTable();
                foreach (var name in Name.nhanVien())
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
            using (var context = new Model1())
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
                        dr[9] = chisocoban.ThoiGianKham.GetDateTimeFormats();
                        dr[10] = chisocoban.ChieuCao;
                        dr[11] = chisocoban.CanNang;
                    }

                    dt.Rows.Add(dr);

                }
                return dt;
            }
        }

    }
}
