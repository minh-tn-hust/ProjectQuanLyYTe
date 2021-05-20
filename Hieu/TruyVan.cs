using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;

namespace Hieu
{
    public class TruyVan
    {
        public int Tim_ID_Nguoi(String HoTen)
        {
            using (var context = new YTeDbContext())
            {
                var connguoi = context.ConNguois.Where(s => s.HoTen == HoTen)
                                             .FirstOrDefault();
                if (connguoi == null)
                {
                    return 0;
                }
                int ID = connguoi.ID_Nguoi;
                return ID;
            }
        }


        public int Tim_ID_Vacxin(String SoLo)
        {
            using (var context = new YTeDbContext())
            {
                var vacxin = context.VacXins.Where(s => s.SoLoVacXin == SoLo|| s.TenVacXin == SoLo)
                                            .FirstOrDefault();
                if (vacxin == null)
                {
                    return 0;
                }
                else
                {
                    int ID = vacxin.ID_VacXin;
                    return ID;
                }

            }
        }

        public int Tim_ID_Phongkham(String TenPhongKham)
        {
            using (var context = new YTeDbContext())
            {
                var phongkham = context.PhongKhams.Where(s => s.TenPhongKham == TenPhongKham)
                                                    .FirstOrDefault();
                int ID = phongkham.ID_PhongKham;
                return ID;
            }
        }

    }
    public class sqlMethod
    {
        public void ThemMoiVaoCSDL(SuDungVacXin suDungVacXin)
        {
            using (var yteDbContext = new YTeDbContext())
            {
                yteDbContext.SuDungVacXins.Add(suDungVacXin);
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

        public void ChinhSuaCSDL(SuDungVacXin suDungVacXin)
        {
            using (var yteDBContext = new YTeDbContext())
            {

                var vacxinSuaDoi = yteDBContext.VacXins.Find(suDungVacXin.ID_VacXin);
                {
                    vacxinSuaDoi.ID_VacXin = vacxinSuaDoi.ID_VacXin;
                    vacxinSuaDoi.TenVacXin = vacxinSuaDoi.TenVacXin ;
                    vacxinSuaDoi.SoLoVacXin = vacxinSuaDoi.SoLoVacXin;
                    vacxinSuaDoi.GiaThanh = vacxinSuaDoi.GiaThanh;
                    vacxinSuaDoi.NgaySanXuat = vacxinSuaDoi.NgaySanXuat;
                    vacxinSuaDoi.HanSuDung = vacxinSuaDoi.HanSuDung;
                    vacxinSuaDoi.NgayNhapKho = vacxinSuaDoi.NgayNhapKho;
                    vacxinSuaDoi.ThoiGianSuDungLai = vacxinSuaDoi.ThoiGianSuDungLai;
                    vacxinSuaDoi.SoMuiCanTiem = vacxinSuaDoi.SoMuiCanTiem ;
                    vacxinSuaDoi.SoLuongNhapKho = vacxinSuaDoi.SoLuongNhapKho;
                    vacxinSuaDoi.SoLuongConLai = vacxinSuaDoi.SoLuongConLai - 1;
                    vacxinSuaDoi.ChongChiDinh = vacxinSuaDoi.ChongChiDinh ;
                    vacxinSuaDoi.ThongTinKhac = vacxinSuaDoi.ThongTinKhac;
                }
                
                yteDBContext.SaveChanges();
            }
        }
    }
}
