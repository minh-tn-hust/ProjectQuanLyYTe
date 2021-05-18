namespace MyModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hen : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DatLichKham", newName: "DatLichKhams");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.DatLichKhams", newName: "DatLichKham");
        }
    }
}
