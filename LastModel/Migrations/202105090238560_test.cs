﻿namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConNguoi", "Hello", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConNguoi", "Hello");
        }
    }
}
