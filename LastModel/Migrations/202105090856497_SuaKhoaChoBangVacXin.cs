namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuaKhoaChoBangVacXin : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.VacXin");
            AlterColumn("dbo.VacXin", "SoLoVacXin", c => c.String(maxLength: 10));
            AlterColumn("dbo.VacXin", "NgayNhapKho", c => c.DateTime());
            AddPrimaryKey("dbo.VacXin", "ID_VacXin");
            CreateIndex("dbo.VacXin", "SoLoVacXin", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.VacXin", new[] { "SoLoVacXin" });
            DropPrimaryKey("dbo.VacXin");
            AlterColumn("dbo.VacXin", "NgayNhapKho", c => c.DateTime(nullable: false));
            AlterColumn("dbo.VacXin", "SoLoVacXin", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.VacXin", new[] { "SoLoVacXin", "NgayNhapKho" });
        }
    }
}
