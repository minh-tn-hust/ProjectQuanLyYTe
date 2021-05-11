using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModelIO
{
    public class sqlMethod
    {
        #region Them moi
        public void themMoiVaoCSDL(NhanVienYTe nhanVien, ConNguoi conNguoi)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.ConNguois.Add(conNguoi);
                yteDbContext.SaveChanges();
                nhanVien.ID_Nguoi = conNguoi.ID_Nguoi;
                yteDbContext.NhanVienYTes.Add(nhanVien);
                yteDbContext.SaveChanges();

            }
        }

        public void themMoiVaoCSDL(PhuNuMangThai phuNuMangThai, ConNguoi conNguoi)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.ConNguois.Add(conNguoi);
                yteDbContext.SaveChanges();
                phuNuMangThai.ID_Nguoi = conNguoi.ID_Nguoi;
                yteDbContext.PhuNuMangThais.Add(phuNuMangThai);
                yteDbContext.SaveChanges();
            }
        }

        public void themMoiVaoCSDL(TreEm treEm, ConNguoi conNguoi)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.ConNguois.Add(conNguoi);
                yteDbContext.SaveChanges();
                treEm.ID_Nguoi = conNguoi.ID_Nguoi;
                yteDbContext.TreEms.Add(treEm);
                yteDbContext.SaveChanges();
            }
        }

        public void themMoiVaoCSDL(NguoiQuanLy nguoiQuanLy)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.NguoiQuanLies.Add(nguoiQuanLy);
                yteDbContext.SaveChanges();
            }
        }

        public void themMoiVaoCSDL(VacXin vacXin)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.VacXins.Add(vacXin);
                yteDbContext.SaveChanges();
            }
        }

        public void themMoiVaoCSDL(PhongKham phongKham)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.PhongKhams.Add(phongKham);
                yteDbContext.SaveChanges();
            }
        }
        public void ThemMoiVaoCSDL(SuDungVacXin suDung)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.SuDungVacXins.Add(suDung);
                yteDbContext.SaveChanges();
            }
        }

        public void ThemMoiVaoCSDL(ChiSoTreCon chiSo)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.ChiSoTreCons.Add(chiSo);
                yteDbContext.SaveChanges();
            }
        }
        public void ThemMoiVaoCSDL(ThongTinThaiKi thongTinThaiKi)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.ThongTinThaiKis.Add(thongTinThaiKi);
                yteDbContext.SaveChanges();
            }
        }

        public void ThemMoiVaoCSDL(ThongKeSuDungVacXin thongKeSuDungVacXin)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.ThongKeSuDungVacXins.Add(thongKeSuDungVacXin);
                yteDbContext.SaveChanges();
            }
        }

        public void ThemMoiVaoCSDL(ChiSoTrungBinh chiSoTrungBinh)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.ChiSoTrungBinhs.Add(chiSoTrungBinh);
                yteDbContext.SaveChanges();
            }
        }
        public void ThemMoiVaoCSDL(DatLichKham datLichKham)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.DatLichKhams.Add(datLichKham);
                yteDbContext.SaveChanges();
            }
        }
        #endregion
        #region XoaKhoiCSDL
        public void xoaKhoiCSDL(NhanVienYTe x)
        {
            
            using (var yteDbContext = new YTeDbContext())
            {
                var nhanVien = yteDbContext.NhanVienYTes.Find(x.ID_NhanVien);
                int id_ConNguoi = (int)nhanVien.ID_Nguoi;
                var conNguoi = (from s in yteDbContext.ConNguois
                                where s.ID_Nguoi == id_ConNguoi
                                select s).FirstOrDefault();
                var thongTinThaiKis = yteDbContext.ThongTinThaiKis.Where(s => s.ID_NhanVien == nhanVien.ID_NhanVien).ToList();
                var datLichKham = yteDbContext.DatLichKhams.Where(s => s.ID_NhanVien == nhanVien.ID_NhanVien).ToList();
                var phongKhams = yteDbContext.PhongKhams.Where(s => s.ID_NhanVienQuanLy == nhanVien.ID_NhanVien).ToList();
                
                foreach (var phongKham in phongKhams)
                {
                    phongKham.ID_NhanVienQuanLy = 0;
                }
                foreach (var lichKham in datLichKham)
                {
                    lichKham.ID_NhanVien = 0;
                }
                foreach (var thongTinThaiKi in thongTinThaiKis)
                {
                    thongTinThaiKi.ID_NhanVien = 0;
                }
                yteDbContext.ConNguois.Remove(conNguoi);
                yteDbContext.NhanVienYTes.Remove(nhanVien);
                yteDbContext.SaveChanges();


            }
        }
        public void xoaKhoiCSDL(TreEm x)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                var treEm = yteDbContext.TreEms.Find(x.ID_TreEm);
                int id_ConNguoi = (int)treEm.ID_Nguoi;
                var conNguoi = (from s in yteDbContext.ConNguois
                                where s.ID_Nguoi == id_ConNguoi
                                select s).FirstOrDefault();
                
                // var chiSo = yteDbContext.ChiSoTreCons.Where(c => c.ID_TreEm == treEm.ID_TreEm);
                var suDungVacXin = yteDbContext.SuDungVacXins.Where(s => s.ID_Nguoi == treEm.ID_Nguoi);
                yteDbContext.ConNguois.Remove(conNguoi);
                yteDbContext.TreEms.Remove(treEm);
                yteDbContext.SuDungVacXins.RemoveRange(suDungVacXin);
              //  yteDbContext.ChiSoTreCons.RemoveRange(chiSo);
                yteDbContext.SaveChanges();

            }
        }
        public void xoaKhoiCSDL(PhuNuMangThai x)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                var phuNuMangThai = yteDbContext.PhuNuMangThais.Find(x.ID_NguoiMangThai);
                int id_ConNguoi = (int)phuNuMangThai.ID_Nguoi;
                var conNguoi = (from s in yteDbContext.ConNguois
                                where s.ID_Nguoi == id_ConNguoi
                                select s).FirstOrDefault();
                //    var thongTinThaiKi = yteDbContext.ThongTinThaiKis.Where(s => s.ID_NguoiMangThai == phuNuMangThai.ID_NguoiMangThai);
                var suDungVacXin = yteDbContext.SuDungVacXins.Where(s => s.ID_Nguoi == phuNuMangThai.ID_Nguoi);
                yteDbContext.ConNguois.Remove(conNguoi);
                yteDbContext.PhuNuMangThais.Remove(phuNuMangThai);
                yteDbContext.SuDungVacXins.RemoveRange(suDungVacXin);
              //  yteDbContext.ThongTinThaiKis.RemoveRange();
                yteDbContext.SaveChanges();

            }
        }
        public void xoaKhoiCSDL(VacXin vacXin)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                var vacXinXoa = yteDbContext.VacXins.Find(vacXin.ID_VacXin);
                var suDungVacXin = yteDbContext.SuDungVacXins.Where(s => s.ID_VacXin == vacXin.ID_VacXin);
                var thongKeSuDungVacXin = yteDbContext.ThongKeSuDungVacXins.Where(s => s.ID_VacXin == vacXin.ID_VacXin);

                yteDbContext.VacXins.Remove(vacXinXoa);
                yteDbContext.SuDungVacXins.RemoveRange(suDungVacXin);
                yteDbContext.ThongKeSuDungVacXins.RemoveRange(thongKeSuDungVacXin);
                yteDbContext.SaveChanges();

            }
        }
        public void xoaKhoiCSDL(PhongKham phongKham)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                var phongKhamCanXoa = yteDbContext.PhongKhams.Find(phongKham.ID_PhongKham);
                var suDungVacXins = yteDbContext.SuDungVacXins.Where(s => s.ID_PhongKham == phongKham.ID_PhongKham).ToList();
                var thongTinThaiKis = yteDbContext.ThongTinThaiKis.Where(s => s.ID_PhongKham == phongKham.ID_PhongKham).ToList();
                var nhanVienYTes = yteDbContext.NhanVienYTes.Where(s => s.ID_CoSoYTe == phongKham.ID_PhongKham).ToList();
                var datLichKhams = yteDbContext.DatLichKhams.Where(s => s.ID_PhongKham == phongKham.ID_PhongKham).ToList();
                var chiSoTreEms = yteDbContext.ChiSoTreCons.Where(s => s.ID_PhongKham == phongKham.ID_PhongKham).ToList();
                foreach( var suDungVacXin in suDungVacXins)
                    suDungVacXin.ID_PhongKham = 0;
                foreach (var thongTinThaiKi in thongTinThaiKis)
                    thongTinThaiKi.ID_PhongKham = 0;
                foreach (var nhanVienYTe in nhanVienYTes)
                    nhanVienYTe.ID_CoSoYTe = 0;
                foreach (var datLichKham in datLichKhams)
                    datLichKham.ID_PhongKham = 0;
                foreach (var chiSoTreEm in chiSoTreEms)
                    chiSoTreEm.ID_PhongKham = 0;
                yteDbContext.PhongKhams.Remove(phongKhamCanXoa);
                yteDbContext.SaveChanges();

            }
        }

        #endregion
        #region Chinh Sua
        public void ChinhSua(NhanVienYTe nhanVienMoi,ConNguoi conNguoiMoi, NhanVienYTe nhanVienYTeCu)
        {
            using(var yteDBContext= new YTeDbContext())
            {
                var nhanVienCu = yteDBContext.NhanVienYTes.Find(nhanVienYTeCu.ID_NhanVien);
                nhanVienMoi.ID_NhanVien = nhanVienCu.ID_NhanVien;
                nhanVienMoi.ID_Nguoi = nhanVienCu.ID_Nguoi;
                var conNguoiCu = yteDBContext.ConNguois.Find(nhanVienCu.ID_Nguoi);
                conNguoiMoi.ID_Nguoi = conNguoiCu.ID_Nguoi;
                {
                    conNguoiCu.DiaChi = conNguoiMoi.DiaChi;
                    conNguoiCu.HoTen = conNguoiMoi.HoTen;
                    conNguoiCu.ID_HoGiaDinh = conNguoiMoi.ID_HoGiaDinh;
                    conNguoiCu.NgaySinh = conNguoiMoi.NgaySinh;
                    conNguoiCu.NgheNghiep = conNguoiMoi.NgheNghiep;
                    conNguoiCu.QuanHeVoiChuHo = conNguoiMoi.QuanHeVoiChuHo;
                    conNguoiCu.SoCMND = conNguoiMoi.SoCMND;
                    conNguoiCu.SoDienThoai = conNguoiMoi.SoDienThoai;
                    conNguoiCu.Email = conNguoiMoi.Email;
                    conNguoiCu.GioiTinh = conNguoiMoi.GioiTinh;
                    nhanVienCu.ID_CoSoYTe = nhanVienMoi.ID_CoSoYTe;
                    nhanVienCu.Password = nhanVienMoi.Password;
                    nhanVienCu.UserName = nhanVienMoi.UserName;
                }
               
                    yteDBContext.SaveChanges();
              
            }
        }
        public void ChinhSua(PhongKham phongKhamMoi, PhongKham phongKhamCu)
        {
            using (var yteDBContext = new YTeDbContext())
            {
                var phongKhamChinhSua = yteDBContext.PhongKhams.Find(phongKhamCu.ID_PhongKham);
                phongKhamChinhSua.ID_PhongKham = phongKhamCu.ID_PhongKham;
                {
                    phongKhamChinhSua.TenPhongKham = phongKhamMoi.TenPhongKham;
                    phongKhamChinhSua.ID_NhanVienQuanLy = phongKhamMoi.ID_NhanVienQuanLy;
                    phongKhamChinhSua.DiaChi = phongKhamMoi.DiaChi;
                    phongKhamChinhSua.NgayBatDauTrongTuan = phongKhamMoi.NgayBatDauTrongTuan;
                    phongKhamChinhSua.NgayKetThucTrongTuan = phongKhamMoi.NgayKetThucTrongTuan;
                    phongKhamChinhSua.GioBatDau = phongKhamMoi.GioBatDau;
                    phongKhamChinhSua.GioketThuc = phongKhamMoi.GioketThuc;
                    phongKhamChinhSua.SoDienThoaiLienHe = phongKhamMoi.SoDienThoaiLienHe;
                    phongKhamChinhSua.ThongTinKhac = phongKhamMoi.ThongTinKhac;
                }
                yteDBContext.SaveChanges();
            }
        }
        public void ChinhSua(VacXin vacXinMoi, VacXin vacXinCu)
        {
            using (var yteDBContext = new YTeDbContext())
            {
                var vacXinSuaDoi = yteDBContext.VacXins.Find(vacXinCu.ID_VacXin);
                vacXinSuaDoi.ID_VacXin = vacXinCu.ID_VacXin;
                {
                    vacXinSuaDoi.TenVacXin = vacXinMoi.TenVacXin;
                    vacXinSuaDoi.SoLoVacXin = vacXinMoi.SoLoVacXin;
                    vacXinSuaDoi.GiaThanh = vacXinMoi.GiaThanh;
                    vacXinSuaDoi.NgaySanXuat = vacXinMoi.NgaySanXuat;
                    vacXinSuaDoi.HanSuDung = vacXinMoi.HanSuDung;
                    vacXinSuaDoi.ThoiGianSuDungLai = vacXinMoi.ThoiGianSuDungLai;
                    vacXinSuaDoi.SoMuiCanTiem = vacXinMoi.SoMuiCanTiem;
                    vacXinSuaDoi.SoLuongConLai = vacXinMoi.SoLuongConLai;
                    vacXinSuaDoi.ChongChiDinh = vacXinMoi.ChongChiDinh;
                    vacXinSuaDoi.ThongTinKhac = vacXinMoi.ThongTinKhac;
                }
                yteDBContext.SaveChanges();
            }
        }
        public void ChinhSua(PhuNuMangThai phuNuMoi,ConNguoi conNguoiMoi, int Id_PhuNu)
        {
            //var nhanVienCu = yteDBContext.NhanVienYTes.Find(IdNhanVien);
            //nhanVienMoi.ID_NhanVien = nhanVienCu.ID_NhanVien;
            //nhanVienMoi.ID_Nguoi = nhanVienCu.ID_Nguoi;
            //var conNguoiCu = yteDBContext.ConNguois.Find(nhanVienCu.ID_Nguoi);
            //conNguoiMoi.ID_Nguoi = conNguoiCu.ID_Nguoi;
            //nhanVienCu = nhanVienMoi;
            //conNguoiCu = conNguoiMoi;
            //yteDBContext.SaveChanges();
        }
        #endregion
    }

}
