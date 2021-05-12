namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSua : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ConNguoi", "Hello");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ConNguoi", "Hello", c => c.String());
        }
    }
}
