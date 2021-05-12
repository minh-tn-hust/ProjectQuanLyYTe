namespace MyModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.ChiSoTreCon",
            //    c => new
            //        {
            //            ID_TreEm = c.Int(nullable: false),
            //            ThoiGianKham = c.DateTime(nullable: false),
            //            Tuoi = c.Int(),
            //            CanNang = c.Int(),
            //            ChieuCao = c.Int(),
            //            ID_PhongKham = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ID_TreEm, t.ThoiGianKham })
            //    .ForeignKey("dbo.TreEm", t => t.ID_TreEm, cascadeDelete: true)
            //    .Index(t => t.ID_TreEm);
            
            //CreateTable(
            //    "dbo.TreEm",
            //    c => new
            //        {
            //            ID_TreEm = c.Int(nullable: false, identity: true),
            //            MaTheBHYTe = c.String(maxLength: 50),
            //            ID_Bo = c.Int(nullable: false),
            //            ID_Me = c.Int(nullable: false),
            //            ID_Nguoi = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID_TreEm);
            
            //CreateTable(
            //    "dbo.ChiSoTrungBinh",
            //    c => new
            //        {
            //            Thang = c.Int(nullable: false, identity: true),
            //            CanNang = c.Double(),
            //            ChieuCao = c.Double(),
            //        })
            //    .PrimaryKey(t => t.Thang);
            
            //CreateTable(
            //    "dbo.ConNguoi",
            //    c => new
            //        {
            //            ID_Nguoi = c.Int(nullable: false, identity: true),
            //            HoTen = c.String(maxLength: 50),
            //            SoCMND = c.String(maxLength: 13),
            //            NgaySinh = c.DateTime(),
            //            GioiTinh = c.Int(),
            //            NgheNghiep = c.String(maxLength: 50),
            //            DiaChi = c.String(maxLength: 50),
            //            SoDienThoai = c.String(maxLength: 50),
            //            Email = c.String(maxLength: 50),
            //            QuanHeVoiChuHo = c.Int(),
            //            ID_HoGiaDinh = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID_Nguoi);
            
            //CreateTable(
            //    "dbo.DatLichKhams",
            //    c => new
            //        {
            //            ID_Nguoi = c.Int(nullable: false),
            //            ThoiGianHenKham = c.DateTime(nullable: false),
            //            LyDoKham = c.String(),
            //            GhiChu = c.String(),
            //            ID_NhanVien = c.Int(nullable: false),
            //            ID_PhongKham = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ID_Nguoi, t.ThoiGianHenKham });
            
            //CreateTable(
            //    "dbo.HoGiaDinh",
            //    c => new
            //        {
            //            ID_HoGiaDinh = c.Int(nullable: false, identity: true),
            //            SoHoKhau = c.String(nullable: false, maxLength: 50),
            //            TenChuHo = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.ID_HoGiaDinh);
            
            //CreateTable(
            //    "dbo.NguoiQuanLy",
            //    c => new
            //        {
            //            ID_NguoiQuanLy = c.Int(nullable: false, identity: true),
            //            UserName = c.String(maxLength: 50),
            //            Password = c.String(maxLength: 50),
            //            MaXacNhan = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.ID_NguoiQuanLy);
            
            //CreateTable(
            //    "dbo.NhanVienYTe",
            //    c => new
            //        {
            //            ID_NhanVien = c.Int(nullable: false, identity: true),
            //            ID_Nguoi = c.Int(),
            //            UserName = c.String(maxLength: 50),
            //            Password = c.String(maxLength: 50),
            //            ID_CoSoYTe = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID_NhanVien);
            
            //CreateTable(
            //    "dbo.PhongKham",
            //    c => new
            //        {
            //            ID_PhongKham = c.Int(nullable: false, identity: true),
            //            TenPhongKham = c.String(maxLength: 50),
            //            TenNguoiQuanLy = c.String(maxLength: 50),
            //            DiaChi = c.String(maxLength: 50),
            //            NgayBatDauTrongTuan = c.Int(),
            //            NgayKetThucTrongTuan = c.Int(),
            //            GioBatDau = c.Time(precision: 7),
            //            GioketThuc = c.Time(precision: 7),
            //            SoDienThoaiLienHe = c.String(maxLength: 50),
            //            ThongTinKhac = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.ID_PhongKham);
            
            //CreateTable(
            //    "dbo.PhuNuMangThai",
            //    c => new
            //        {
            //            ID_NguoiMangThai = c.Int(nullable: false, identity: true),
            //            ID_Nguoi = c.Int(nullable: false),
            //            SoBHYTe = c.String(maxLength: 13),
            //            NgayHetHanBHYTe = c.DateTime(),
            //            ChieuCao = c.Int(nullable: false),
            //            CanNang = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID_NguoiMangThai);
            
            //CreateTable(
            //    "dbo.ThongTinThaiKi",
            //    c => new
            //        {
            //            ID_NguoiMangThai = c.Int(nullable: false),
            //            ThoiGianKham = c.DateTime(nullable: false),
            //            GioiTinhTreEm = c.Int(nullable: false),
            //            CanNangThaiNhi = c.Int(),
            //            ThoiGianSinhDuKien = c.DateTime(),
            //            ID_PhongKham = c.Int(nullable: false),
            //            ID_NhanVien = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.ID_NguoiMangThai, t.ThoiGianKham })
            //    .ForeignKey("dbo.PhuNuMangThai", t => t.ID_NguoiMangThai, cascadeDelete: true)
            //    .Index(t => t.ID_NguoiMangThai);
            
            //CreateTable(
            //    "dbo.SuDungVacXin",
            //    c => new
            //        {
            //            ID_Nguoi = c.Int(nullable: false),
            //            ID_VacXin = c.Int(nullable: false),
            //            ThoiDiemTiem = c.DateTime(nullable: false),
            //            ID_PhongKham = c.Int(nullable: false),
            //            SoMuiTiem = c.Int(),
            //            AnhVoHopThuoc = c.Binary(),
            //            AnhHoaDon = c.Binary(),
            //            AnhSoTiem = c.Binary(),
            //        })
            //    .PrimaryKey(t => new { t.ID_Nguoi, t.ID_VacXin, t.ThoiDiemTiem });
            
            //CreateTable(
            //    "dbo.ThongKeSuDungVacXin",
            //    c => new
            //        {
            //            ID_VacXin = c.Int(nullable: false, identity: true),
            //            SoLoVacXin = c.String(maxLength: 50),
            //            TenVacXin = c.String(maxLength: 50),
            //            NgaySuDung = c.DateTime(),
            //            SoLuongSuDung = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID_VacXin);
            
            //CreateTable(
            //    "dbo.VacXin",
            //    c => new
            //        {
            //            ID_VacXin = c.Int(nullable: false, identity: true),
            //            NgayNhapKho = c.DateTime(nullable: false),
            //            TenVacXin = c.String(maxLength: 50),
            //            TenLoVacXin = c.String(maxLength: 50),
            //            GiaThanh = c.String(maxLength: 50),
            //            NgaySanXuat = c.DateTime(),
            //            HanSuDung = c.DateTime(),
            //            ThoiGianSuDungLai = c.Int(),
            //            SoMuiCanTiem = c.Int(),
            //            SoLuongConLai = c.Int(),
            //            ChongChiDinh = c.String(maxLength: 200),
            //            ThongTinKhac = c.String(maxLength: 200),
            //        })
            //    .PrimaryKey(t => new { t.ID_VacXin, t.NgayNhapKho });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThongTinThaiKi", "ID_NguoiMangThai", "dbo.PhuNuMangThai");
            DropForeignKey("dbo.ChiSoTreCon", "ID_TreEm", "dbo.TreEm");
            DropIndex("dbo.ThongTinThaiKi", new[] { "ID_NguoiMangThai" });
            DropIndex("dbo.ChiSoTreCon", new[] { "ID_TreEm" });
            DropTable("dbo.VacXin");
            DropTable("dbo.ThongKeSuDungVacXin");
            DropTable("dbo.SuDungVacXin");
            DropTable("dbo.ThongTinThaiKi");
            DropTable("dbo.PhuNuMangThai");
            DropTable("dbo.PhongKham");
            DropTable("dbo.NhanVienYTe");
            DropTable("dbo.NguoiQuanLy");
            DropTable("dbo.HoGiaDinh");
            DropTable("dbo.DatLichKhams");
            DropTable("dbo.ConNguoi");
            DropTable("dbo.ChiSoTrungBinh");
            DropTable("dbo.TreEm");
            DropTable("dbo.ChiSoTreCon");
        }
    }
}
