namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemHangSoLuongNhapVao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VacXin", "SoLuongNhapKho", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VacXin", "SoLuongNhapKho");
        }
    }
}
