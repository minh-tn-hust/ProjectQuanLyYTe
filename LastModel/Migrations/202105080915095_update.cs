namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PhuNuMangThai");
            DropPrimaryKey("dbo.ThongKeSuDungVacXin");
            DropPrimaryKey("dbo.TreEm");
            DropPrimaryKey("dbo.VacXin");
            AddColumn("dbo.ChiSoTreCon", "LanKhamTiepTheo", c => c.DateTime(nullable: false));
            AddColumn("dbo.PhuNuMangThai", "ThongTinNguoiCanBaoTin", c => c.String());
            AddColumn("dbo.ThongTinThaiKi", "LanKhamTiepTheo", c => c.DateTime(nullable: false));
            AddColumn("dbo.TreEm", "ThongTinNguoiBaoTin", c => c.String());
            AddColumn("dbo.VacXin", "SoLoVacXin", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.PhuNuMangThai", "SoBHYTe", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.ThongKeSuDungVacXin", "ID_VacXin", c => c.Int(nullable: false));
            AlterColumn("dbo.ThongKeSuDungVacXin", "SoLoVacXin", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.ThongKeSuDungVacXin", "NgaySuDung", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TreEm", "MaTheBHYTe", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.TreEm", "ID_TreEm", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PhuNuMangThai", "SoBHYTe");
            AddPrimaryKey("dbo.ThongKeSuDungVacXin", new[] { "SoLoVacXin", "NgaySuDung" });
            AddPrimaryKey("dbo.TreEm", "MaTheBHYTe");
            AddPrimaryKey("dbo.VacXin", new[] { "SoLoVacXin", "NgayNhapKho" });
            DropColumn("dbo.PhuNuMangThai", "NgayHetHanBHYTe");
            DropColumn("dbo.ThongKeSuDungVacXin", "TenVacXin");
            DropColumn("dbo.ThongTinThaiKi", "GioiTinhTreEm");
            DropColumn("dbo.ThongTinThaiKi", "CanNangThaiNhi");
            DropColumn("dbo.VacXin", "TenLoVacXin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VacXin", "TenLoVacXin", c => c.String(maxLength: 50));
            AddColumn("dbo.ThongTinThaiKi", "CanNangThaiNhi", c => c.Int());
            AddColumn("dbo.ThongTinThaiKi", "GioiTinhTreEm", c => c.Int(nullable: false));
            AddColumn("dbo.ThongKeSuDungVacXin", "TenVacXin", c => c.String(maxLength: 50));
            AddColumn("dbo.PhuNuMangThai", "NgayHetHanBHYTe", c => c.DateTime());
            DropPrimaryKey("dbo.VacXin");
            DropPrimaryKey("dbo.TreEm");
            DropPrimaryKey("dbo.ThongKeSuDungVacXin");
            DropPrimaryKey("dbo.PhuNuMangThai");
            AlterColumn("dbo.TreEm", "ID_TreEm", c => c.Int(nullable: false));
            AlterColumn("dbo.TreEm", "MaTheBHYTe", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ThongKeSuDungVacXin", "NgaySuDung", c => c.DateTime());
            AlterColumn("dbo.ThongKeSuDungVacXin", "SoLoVacXin", c => c.String(maxLength: 50));
            AlterColumn("dbo.ThongKeSuDungVacXin", "ID_VacXin", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PhuNuMangThai", "SoBHYTe", c => c.String(maxLength: 13));
            DropColumn("dbo.VacXin", "SoLoVacXin");
            DropColumn("dbo.TreEm", "ThongTinNguoiBaoTin");
            DropColumn("dbo.ThongTinThaiKi", "LanKhamTiepTheo");
            DropColumn("dbo.PhuNuMangThai", "ThongTinNguoiCanBaoTin");
            DropColumn("dbo.ChiSoTreCon", "LanKhamTiepTheo");
            AddPrimaryKey("dbo.VacXin", new[] { "ID_VacXin", "NgayNhapKho" });
            AddPrimaryKey("dbo.TreEm", "MaTheBHYTe");
            AddPrimaryKey("dbo.ThongKeSuDungVacXin", "ID_VacXin");
            AddPrimaryKey("dbo.PhuNuMangThai", "ID_NguoiMangThai");
        }
    }
}
