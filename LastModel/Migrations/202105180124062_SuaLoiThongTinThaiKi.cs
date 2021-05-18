namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuaLoiThongTinThaiKi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ThongTinThaiKi", "ChieuCaoMe", c => c.Int(nullable: false));
            AddColumn("dbo.ThongTinThaiKi", "CanNangMe", c => c.Int(nullable: false));
            DropColumn("dbo.PhuNuMangThai", "ChieuCao");
            DropColumn("dbo.PhuNuMangThai", "CanNang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhuNuMangThai", "CanNang", c => c.Int(nullable: false));
            AddColumn("dbo.PhuNuMangThai", "ChieuCao", c => c.Int(nullable: false));
            DropColumn("dbo.ThongTinThaiKi", "CanNangMe");
            DropColumn("dbo.ThongTinThaiKi", "ChieuCaoMe");
        }
    }
}
