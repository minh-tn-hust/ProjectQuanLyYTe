namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoGiaDinh", "Id_Nguoi", c => c.Int(nullable: false));
            AddColumn("dbo.PhongKham", "ID_NhanVienQuanLy", c => c.Int(nullable: false));
            DropColumn("dbo.HoGiaDinh", "TenChuHo");
            DropColumn("dbo.PhongKham", "TenNguoiQuanLy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhongKham", "TenNguoiQuanLy", c => c.String(maxLength: 50));
            AddColumn("dbo.HoGiaDinh", "TenChuHo", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.PhongKham", "ID_NhanVienQuanLy");
            DropColumn("dbo.HoGiaDinh", "Id_Nguoi");
        }
    }
}
