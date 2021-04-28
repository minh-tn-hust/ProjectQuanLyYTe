namespace YTeDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiSoTreCon",
                c => new
                    {
                        ID_TreEm = c.Int(nullable: false),
                        ThoiGianKham = c.DateTime(nullable: false),
                        CanNang = c.Int(),
                        ChieuCao = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID_TreEm, t.ThoiGianKham })
                .ForeignKey("dbo.TreEm", t => t.ID_TreEm, cascadeDelete: true)
                .Index(t => t.ID_TreEm);
            
            CreateTable(
                "dbo.TreEm",
                c => new
                    {
                        ID_TreEm = c.Int(nullable: false, identity: true),
                        ID_Nguoi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_TreEm);
            
            CreateTable(
                "dbo.ConNguoi",
                c => new
                    {
                        ID_Nguoi = c.Int(nullable: false, identity: true),
                        HoTen = c.String(maxLength: 50),
                        SoCMND = c.String(maxLength: 50),
                        NgaySinh = c.DateTime(),
                        GioiTinh = c.Int(),
                        NgheNghiep = c.String(maxLength: 50),
                        DiaChi = c.String(maxLength: 50),
                        SoDienThoai = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        QuanHeVoiChuHo = c.Int(),
                        ID_HoGiaDinh = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Nguoi);
            
            CreateTable(
                "dbo.HoGiaDinh",
                c => new
                    {
                        ID_HoGiaDinh = c.Int(nullable: false, identity: true),
                        SoHoKhau = c.String(nullable: false, maxLength: 50),
                        TenChuHo = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_HoGiaDinh);
            
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
                    })
                .PrimaryKey(t => t.ID_NhanVien);
            
            CreateTable(
                "dbo.PhongKham",
                c => new
                    {
                        ID_PhongKham = c.Int(nullable: false, identity: true),
                        TenPhongKham = c.String(maxLength: 50),
                        TenNguoiQuanLy = c.String(maxLength: 50),
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
                    })
                .PrimaryKey(t => t.ID_NguoiMangThai);
            
            CreateTable(
                "dbo.ThongTinThaiKi",
                c => new
                    {
                        ID_NguoiMangThai = c.Int(nullable: false),
                        ThoiGianKham = c.DateTime(nullable: false),
                        CanNangThaiNhi = c.Int(),
                        ThoiGianSinhDuKien = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.ID_NguoiMangThai, t.ThoiGianKham })
                .ForeignKey("dbo.PhuNuMangThai", t => t.ID_NguoiMangThai, cascadeDelete: true)
                .Index(t => t.ID_NguoiMangThai);
            
            CreateTable(
                "dbo.SuDungVacXin",
                c => new
                    {
                        ID_Nguoi = c.Int(nullable: false),
                        ID_VacXin = c.Int(nullable: false),
                        ThoiDiemTiem = c.DateTime(nullable: false),
                        DiaDiemTiem = c.String(maxLength: 50),
                        SoMuiTiem = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID_Nguoi, t.ID_VacXin, t.ThoiDiemTiem });
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.VacXin",
                c => new
                    {
                        ID_VacXin = c.Int(nullable: false, identity: true),
                        TenVacXin = c.String(maxLength: 50),
                        TenLoVacXin = c.String(maxLength: 50),
                        GiaThanh = c.String(maxLength: 50),
                        NgaySanXuat = c.DateTime(),
                        HanSuDung = c.DateTime(),
                        NgayNhapKho = c.DateTime(),
                        ThoiGianSuDungLai = c.Int(),
                        SoLuongConLai = c.Int(),
                        ChongChiDinh = c.String(maxLength: 200),
                        ThongTinKhac = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID_VacXin);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThongTinThaiKi", "ID_NguoiMangThai", "dbo.PhuNuMangThai");
            DropForeignKey("dbo.ChiSoTreCon", "ID_TreEm", "dbo.TreEm");
            DropIndex("dbo.ThongTinThaiKi", new[] { "ID_NguoiMangThai" });
            DropIndex("dbo.ChiSoTreCon", new[] { "ID_TreEm" });
            DropTable("dbo.VacXin");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.SuDungVacXin");
            DropTable("dbo.ThongTinThaiKi");
            DropTable("dbo.PhuNuMangThai");
            DropTable("dbo.PhongKham");
            DropTable("dbo.NhanVienYTe");
            DropTable("dbo.NguoiQuanLy");
            DropTable("dbo.HoGiaDinh");
            DropTable("dbo.ConNguoi");
            DropTable("dbo.TreEm");
            DropTable("dbo.ChiSoTreCon");
        }
    }
}
