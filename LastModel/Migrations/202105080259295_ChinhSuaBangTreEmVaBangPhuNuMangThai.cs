namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSuaBangTreEmVaBangPhuNuMangThai : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ChiSoTreCon", "ID_TreEm", "dbo.TreEm");
            DropForeignKey("dbo.ThongTinThaiKi", "ID_NguoiMangThai", "dbo.PhuNuMangThai");
            DropIndex("dbo.ChiSoTreCon", new[] { "ID_TreEm" });
            DropIndex("dbo.ThongTinThaiKi", new[] { "ID_NguoiMangThai" });
            DropPrimaryKey("dbo.TreEm");
            AlterColumn("dbo.TreEm", "ID_TreEm", c => c.Int(nullable: false));
            AlterColumn("dbo.TreEm", "MaTheBHYTe", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.TreEm", "MaTheBHYTe");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.TreEm");
            AlterColumn("dbo.TreEm", "MaTheBHYTe", c => c.String(maxLength: 50));
            AlterColumn("dbo.TreEm", "ID_TreEm", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TreEm", "ID_TreEm");
            CreateIndex("dbo.ThongTinThaiKi", "ID_NguoiMangThai");
            CreateIndex("dbo.ChiSoTreCon", "ID_TreEm");
            AddForeignKey("dbo.ThongTinThaiKi", "ID_NguoiMangThai", "dbo.PhuNuMangThai", "ID_NguoiMangThai", cascadeDelete: true);
            AddForeignKey("dbo.ChiSoTreCon", "ID_TreEm", "dbo.TreEm", "ID_TreEm", cascadeDelete: true);
        }
    }
}
