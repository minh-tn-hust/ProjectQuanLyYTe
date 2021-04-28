namespace YTeDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add2class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiSoTrungBinh",
                c => new
                    {
                        Thang = c.Int(nullable: false, identity: true),
                        CanNang = c.Double(),
                        ChieuCao = c.Double(),
                    })
                .PrimaryKey(t => t.Thang);
            
            CreateTable(
                "dbo.ThongKeSuDungVacXin",
                c => new
                    {
                        ID_VacXin = c.Int(nullable: false, identity: true),
                        SoLoVacXin = c.String(maxLength: 50),
                        TenVacXin = c.String(maxLength: 50),
                        NgaySuDung = c.DateTime(),
                        SoLuongSuDung = c.Int(),
                    })
                .PrimaryKey(t => t.ID_VacXin);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThongKeSuDungVacXin");
            DropTable("dbo.ChiSoTrungBinh");
        }
    }
}
