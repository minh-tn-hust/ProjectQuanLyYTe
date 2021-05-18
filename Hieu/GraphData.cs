using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Controller;
using Hieu;


namespace Hieu
{
    public class GraphData
    {
        TruyVan truyVan = new TruyVan();
        public List<int?> GetDataY(DateTime begin, DateTime end, String name)
        {
            int ID = truyVan.Tim_ID_Vacxin(name);
            using (var context = new YTeDbContext())
            {
                var thongkes = context.ThongKeSuDungVacXins
                                .Where(b => b.ID_VacXin == ID && b.NgaySuDung >= begin && b.NgaySuDung <= end)
                                .ToList();
                thongkes = thongkes.OrderByDescending(o => o.NgaySuDung).ToList();
                List<int?> data = new List<int?>();
                foreach (var record in thongkes)
                {
                    if (record.SoLuongSuDung == null)
                        data.Add(0);
                    else
                    {
                        data.Add(record.SoLuongSuDung);
                    }
                }
                return data;
            }

        }
        public List<DateTime> GetDataX(DateTime begin, DateTime end, String name)
        {
            int ID = truyVan.Tim_ID_Vacxin(name);
            using (var context = new YTeDbContext())
            {
                var thongkes = context.ThongKeSuDungVacXins
                                .Where(b => b.ID_VacXin == ID && b.NgaySuDung >= begin && b.NgaySuDung <= end)
                                .ToList();
                thongkes = thongkes.OrderByDescending(o => o.NgaySuDung).ToList();
                List<DateTime> date = new List<DateTime>();
                
                foreach (var record in thongkes)
                {
                    date.Add(record.NgaySuDung);
                }
                return date;
            }

        }

    }
}
