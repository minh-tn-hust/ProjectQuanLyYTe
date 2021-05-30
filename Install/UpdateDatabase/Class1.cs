using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using Model;

namespace LastModel
{
    public class YTeDBInitializer : DropCreateDatabaseAlways<YTeDbContext>
    {
        protected override void Seed(YTeDbContext context)
        {
            //NguoiQuanLy nql = new NguoiQuanLy()
            //{
            //    UserName = "admin",
            //    Password = "admin",
            //    MaXacNhan = "12345"
            //};
            //context.NguoiQuanLies.Add(nql);
            //base.Seed(context);
        }
    }
}
