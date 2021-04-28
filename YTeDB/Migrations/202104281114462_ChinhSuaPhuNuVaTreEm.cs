namespace YTeDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSuaPhuNuVaTreEm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChiSoTreCon", "Tuoi", c => c.Int());
            AddColumn("dbo.ChiSoTreCon", "ID_PhongKham", c => c.Int(nullable: false));
            AddColumn("dbo.TreEm", "ID_Bo", c => c.Int(nullable: false));
            AddColumn("dbo.TreEm", "ID_Me", c => c.Int(nullable: false));
            AddColumn("dbo.PhuNuMangThai", "SoBHYTe", c => c.String(maxLength: 13));
            AddColumn("dbo.PhuNuMangThai", "NgayHetHanBHYTe", c => c.DateTime());
            AddColumn("dbo.PhuNuMangThai", "ChieuCao", c => c.Int(nullable: false));
            AddColumn("dbo.PhuNuMangThai", "CanNang", c => c.Int(nullable: false));
            AddColumn("dbo.ThongTinThaiKi", "GioiTinhTreEm", c => c.Int(nullable: false));
            AddColumn("dbo.ThongTinThaiKi", "ID_PhongKham", c => c.Int(nullable: false));
            AddColumn("dbo.ThongTinThaiKi", "ID_NhanVien", c => c.Int(nullable: false));
            AddColumn("dbo.SuDungVacXin", "ID_PhongKham", c => c.Int(nullable: false));
            AlterColumn("dbo.ConNguoi", "SoCMND", c => c.String(maxLength: 13));
            DropColumn("dbo.SuDungVacXin", "DiaDiemTiem");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SuDungVacXin", "DiaDiemTiem", c => c.String(maxLength: 50));
            AlterColumn("dbo.ConNguoi", "SoCMND", c => c.String(maxLength: 50));
            DropColumn("dbo.SuDungVacXin", "ID_PhongKham");
            DropColumn("dbo.ThongTinThaiKi", "ID_NhanVien");
            DropColumn("dbo.ThongTinThaiKi", "ID_PhongKham");
            DropColumn("dbo.ThongTinThaiKi", "GioiTinhTreEm");
            DropColumn("dbo.PhuNuMangThai", "CanNang");
            DropColumn("dbo.PhuNuMangThai", "ChieuCao");
            DropColumn("dbo.PhuNuMangThai", "NgayHetHanBHYTe");
            DropColumn("dbo.PhuNuMangThai", "SoBHYTe");
            DropColumn("dbo.TreEm", "ID_Me");
            DropColumn("dbo.TreEm", "ID_Bo");
            DropColumn("dbo.ChiSoTreCon", "ID_PhongKham");
            DropColumn("dbo.ChiSoTreCon", "Tuoi");
        }
    }
}
