namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSuaDataDatLich : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DatLichKhams", "ID_NhanVien", c => c.Int(nullable: false));
            DropColumn("dbo.DatLichKhams", "ID_NguoiTaoDon");
            DropColumn("dbo.DatLichKhams", "ID_NhanVienYTe");
            DropColumn("dbo.DatLichKhams", "ID_LichKham");
            DropTable("dbo.LichBiHuys");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LichBiHuys",
                c => new
                    {
                        ID_LichBiHuy = c.Int(nullable: false, identity: true),
                        ID_Nguoi = c.Int(nullable: false),
                        ThoiGianHenKham = c.DateTime(nullable: false),
                        LyDoKham = c.String(),
                        GhiChu = c.String(),
                        ID_NguoiTaoDon = c.Int(nullable: false),
                        ID_NhanVienYTe = c.Int(nullable: false),
                        LyDoHuy = c.String(),
                    })
                .PrimaryKey(t => t.ID_LichBiHuy);
            
            AddColumn("dbo.DatLichKhams", "ID_LichKham", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.DatLichKhams", "ID_NhanVienYTe", c => c.Int(nullable: false));
            AddColumn("dbo.DatLichKhams", "ID_NguoiTaoDon", c => c.Int(nullable: false));
            DropColumn("dbo.DatLichKhams", "ID_NhanVien");
        }
    }
}
