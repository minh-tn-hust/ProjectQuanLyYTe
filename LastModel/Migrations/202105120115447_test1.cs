namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ThongKeSuDungVacXin");
            AddPrimaryKey("dbo.ThongKeSuDungVacXin", new[] { "SoLoVacXin", "NgaySuDung" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ThongKeSuDungVacXin");
            AddPrimaryKey("dbo.ThongKeSuDungVacXin", new[] { "ID_VacXin", "SoLoVacXin", "NgaySuDung" });
        }
    }
}
