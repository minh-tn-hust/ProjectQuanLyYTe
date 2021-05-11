namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuaDoiNhanVien1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NhanVienYTe", "ID_CoSoYTe", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhanVienYTe", "ID_CoSoYTe", c => c.Int(nullable: false));
        }
    }
}
