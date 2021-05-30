namespace LastModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Model.YTeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Model.YTeDbContext context)
        {
            NguoiQuanLy nql = new NguoiQuanLy()
            {
                UserName = "admin",
                Password = "admin",
                MaXacNhan = "12345"
            };
            context.NguoiQuanLies.Add(nql);
            base.Seed(context);
        }
    }
}
