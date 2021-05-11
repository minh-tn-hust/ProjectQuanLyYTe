namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemRangBuocUnique : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PhuNuMangThai");
            DropPrimaryKey("dbo.TreEm");
            AlterColumn("dbo.PhuNuMangThai", "SoBHYTe", c => c.String(maxLength: 15));
            AlterColumn("dbo.TreEm", "MaTheBHYTe", c => c.String(maxLength: 15));
            AddPrimaryKey("dbo.PhuNuMangThai", "ID_NguoiMangThai");
            AddPrimaryKey("dbo.TreEm", "ID_TreEm");
            CreateIndex("dbo.ConNguoi", "SoCMND", unique: true);
            CreateIndex("dbo.HoGiaDinh", "SoHoKhau", unique: true);
            CreateIndex("dbo.PhuNuMangThai", "SoBHYTe", unique: true);
            CreateIndex("dbo.TreEm", "MaTheBHYTe", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.TreEm", new[] { "MaTheBHYTe" });
            DropIndex("dbo.PhuNuMangThai", new[] { "SoBHYTe" });
            DropIndex("dbo.HoGiaDinh", new[] { "SoHoKhau" });
            DropIndex("dbo.ConNguoi", new[] { "SoCMND" });
            DropPrimaryKey("dbo.TreEm");
            DropPrimaryKey("dbo.PhuNuMangThai");
            AlterColumn("dbo.TreEm", "MaTheBHYTe", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.PhuNuMangThai", "SoBHYTe", c => c.String(nullable: false, maxLength: 15));
            AddPrimaryKey("dbo.TreEm", "MaTheBHYTe");
            AddPrimaryKey("dbo.PhuNuMangThai", "SoBHYTe");
        }
    }
}
