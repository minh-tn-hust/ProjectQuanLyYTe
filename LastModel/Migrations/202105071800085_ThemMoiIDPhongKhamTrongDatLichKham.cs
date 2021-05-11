namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemMoiIDPhongKhamTrongDatLichKham : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DatLichKhams", "ID_PhongKham", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DatLichKhams", "ID_PhongKham");
        }
    }
}
