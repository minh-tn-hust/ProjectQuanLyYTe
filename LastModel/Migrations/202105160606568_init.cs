namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiSoTreCon",
                c => new
                    {
                        ID_TreEm = c.Int(nullable: false),
                        ThoiGianKham = c.DateTime(nullable: false),
                        LanKhamTiepTheo = c.DateTime(nullable: false),
                        Tuoi = c.Int(),
                        CanNang = c.Int(),
                        ChieuCao = c.Int(),
                        ID_PhongKham = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_TreEm, t.ThoiGianKham });
            
            CreateTable(
                "dbo.ChiSoTrungBinh",
                c => new
                    {
                        Thang = c.Int(nullable: false, identity: true),
                        CanNang = c.Double(),
                        ChieuCao = c.Double(),
                    })
                .PrimaryKey(t => t.Thang);
            
            CreateTable(
                "dbo.ConNguoi",
                c => new
                    {
                        ID_Nguoi = c.Int(nullable: false, identity: true),
                        HoTen = c.String(maxLength: 50),
                        SoCMND = c.String(maxLength: 13),
                        NgaySinh = c.DateTime(),
                        GioiTinh = c.Int(),
                        NgheNghiep = c.String(maxLength: 50),
                        DiaChi = c.String(maxLength: 50),
                        SoDienThoai = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        QuanHeVoiChuHo = c.Int(),
                        ID_HoGiaDinh = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Nguoi)
                .Index(t => t.SoCMND, unique: true);
            
            CreateTable(
                "dbo.DatLichKham",
                c => new
                    {
                        ID_Nguoi = c.Int(nullable: false),
                        ThoiGianHenKham = c.DateTime(nullable: false),
                        LyDoKham = c.String(),
                        GhiChu = c.String(),
                        ID_NhanVien = c.Int(nullable: false),
                        ID_PhongKham = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_Nguoi, t.ThoiGianHenKham });
            
            CreateTable(
                "dbo.HoGiaDinh",
                c => new
                    {
                        ID_HoGiaDinh = c.Int(nullable: false, identity: true),
                        SoHoKhau = c.String(nullable: false, maxLength: 50),
                        Id_Nguoi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_HoGiaDinh)
                .Index(t => t.SoHoKhau, unique: true);
            
            CreateTable(
                "dbo.NguoiQuanLy",
                c => new
                    {
                        ID_NguoiQuanLy = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        MaXacNhan = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_NguoiQuanLy);
            
            CreateTable(
                "dbo.NhanVienYTe",
                c => new
                    {
                        ID_NhanVien = c.Int(nullable: false, identity: true),
                        ID_Nguoi = c.Int(),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        ID_CoSoYTe = c.Int(),
                    })
                .PrimaryKey(t => t.ID_NhanVien);
            
            CreateTable(
                "dbo.PhongKham",
                c => new
                    {
                        ID_PhongKham = c.Int(nullable: false, identity: true),
                        TenPhongKham = c.String(maxLength: 50),
                        ID_NhanVienQuanLy = c.Int(nullable: false),
                        DiaChi = c.String(maxLength: 50),
                        NgayBatDauTrongTuan = c.Int(),
                        NgayKetThucTrongTuan = c.Int(),
                        GioBatDau = c.Time(precision: 7),
                        GioketThuc = c.Time(precision: 7),
                        SoDienThoaiLienHe = c.String(maxLength: 50),
                        ThongTinKhac = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_PhongKham);
            
            CreateTable(
                "dbo.PhuNuMangThai",
                c => new
                    {
                        ID_NguoiMangThai = c.Int(nullable: false, identity: true),
                        ID_Nguoi = c.Int(nullable: false),
                        SoBHYTe = c.String(maxLength: 15),
                        ChieuCao = c.Int(nullable: false),
                        CanNang = c.Int(nullable: false),
                        ThongTinNguoiCanBaoTin = c.String(),
                    })
                .PrimaryKey(t => t.ID_NguoiMangThai)
                .Index(t => t.SoBHYTe, unique: true);
            
            CreateTable(
                "dbo.SuDungVacXin",
                c => new
                    {
                        ID_Nguoi = c.Int(nullable: false),
                        ID_VacXin = c.Int(nullable: false),
                        ThoiDiemTiem = c.DateTime(nullable: false),
                        ID_PhongKham = c.Int(nullable: false),
                        SoMuiTiem = c.Int(),
                        AnhVoHopThuoc = c.Binary(),
                        AnhHoaDon = c.Binary(),
                        AnhSoTiem = c.Binary(),
                    })
                .PrimaryKey(t => new { t.ID_Nguoi, t.ID_VacXin, t.ThoiDiemTiem });
            
            CreateTable(
                "dbo.ThongKeSuDungVacXin",
                c => new
                    {
                        SoLoVacXin = c.String(nullable: false, maxLength: 10),
                        NgaySuDung = c.DateTime(nullable: false),
                        ID_VacXin = c.Int(nullable: false),
                        SoLuongSuDung = c.Int(),
                    })
                .PrimaryKey(t => new { t.SoLoVacXin, t.NgaySuDung });
            
            CreateTable(
                "dbo.ThongTinThaiKi",
                c => new
                    {
                        ID_NguoiMangThai = c.Int(nullable: false),
                        ThoiGianKham = c.DateTime(nullable: false),
                        LanKhamTiepTheo = c.DateTime(nullable: false),
                        ThoiGianSinhDuKien = c.DateTime(),
                        ID_PhongKham = c.Int(nullable: false),
                        ID_NhanVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_NguoiMangThai, t.ThoiGianKham });
            
            CreateTable(
                "dbo.TreEm",
                c => new
                    {
                        ID_TreEm = c.Int(nullable: false, identity: true),
                        MaTheBHYTe = c.String(maxLength: 15),
                        ID_Bo = c.Int(nullable: false),
                        ID_Me = c.Int(nullable: false),
                        ThongTinNguoiBaoTin = c.String(),
                        ID_Nguoi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_TreEm)
                .Index(t => t.MaTheBHYTe, unique: true);
            
            CreateTable(
                "dbo.VacXin",
                c => new
                    {
                        ID_VacXin = c.Int(nullable: false, identity: true),
                        TenVacXin = c.String(maxLength: 50),
                        SoLoVacXin = c.String(maxLength: 10),
                        GiaThanh = c.String(maxLength: 50),
                        NgaySanXuat = c.DateTime(),
                        HanSuDung = c.DateTime(),
                        NgayNhapKho = c.DateTime(),
                        ThoiGianSuDungLai = c.Int(),
                        SoMuiCanTiem = c.Int(),
                        SoLuongNhapKho = c.Int(),
                        SoLuongConLai = c.Int(),
                        ChongChiDinh = c.String(maxLength: 200),
                        ThongTinKhac = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID_VacXin)
                .Index(t => t.SoLoVacXin, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.VacXin", new[] { "SoLoVacXin" });
            DropIndex("dbo.TreEm", new[] { "MaTheBHYTe" });
            DropIndex("dbo.PhuNuMangThai", new[] { "SoBHYTe" });
            DropIndex("dbo.HoGiaDinh", new[] { "SoHoKhau" });
            DropIndex("dbo.ConNguoi", new[] { "SoCMND" });
            DropTable("dbo.VacXin");
            DropTable("dbo.TreEm");
            DropTable("dbo.ThongTinThaiKi");
            DropTable("dbo.ThongKeSuDungVacXin");
            DropTable("dbo.SuDungVacXin");
            DropTable("dbo.PhuNuMangThai");
            DropTable("dbo.PhongKham");
            DropTable("dbo.NhanVienYTe");
            DropTable("dbo.NguoiQuanLy");
            DropTable("dbo.HoGiaDinh");
            DropTable("dbo.DatLichKham");
            DropTable("dbo.ConNguoi");
            DropTable("dbo.ChiSoTrungBinh");
            DropTable("dbo.ChiSoTreCon");
        }
    }
}
