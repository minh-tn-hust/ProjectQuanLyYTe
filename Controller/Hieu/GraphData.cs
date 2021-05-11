using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Controller.Hieu
{
    public class GraphData
    {
        public List<int?> GetData(DateTime begin, DateTime end, String name)
        {
            using (var context = new YTeDbContext())
            {
                var thongkes = context.ThongKeSuDungVacXins
                                .Where(b => b.TenVacXin == name && b.NgaySuDung >= begin && b.NgaySuDung <= end)
                                .ToList();
                thongkes = thongkes.OrderBy(o => o.NgaySuDung).ToList();
                List<int?> data = new List<int?>();
                int sum = 0;
                foreach (var record in thongkes)
                {
                    if (record.SoLuongSuDung == null)
                        data.Add(0);
                    else
                    {
                        data.Add(record.SoLuongSuDung);
                        sum += (int)record.SoLuongSuDung;
                    }
                }
                data.Add(sum);
                return data;
            }

        }

    }
}
