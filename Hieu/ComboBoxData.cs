using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Hieu
{
    public class ComboBoxData 
    {
        public List<String> sudungvacxin()
        {
            using (var context = new YTeDbContext()) {
                List<SuDungVacXin> suDungVacXins = context.SuDungVacXins.ToList();
                List<String> vacxin = new List<String>();
                foreach (var record in suDungVacXins)
                {
                    var vc = context.VacXins
                                .Where(b => b.ID_VacXin == record.ID_VacXin)
                                .FirstOrDefault();
                    vacxin.Add(vc.TenVacXin);
                }
                var h = new HashSet<String>(vacxin);
                var ans = h.ToList();
                foreach (var a in ans)
                {
                    MessageBox.Show(a.ToString());
                }
                return ans;
            }
        }
        public List<String> vacxin()
        {
            using (var context = new YTeDbContext())
            {
                var vacxins = context.VacXins.ToList();
                List<String> tenVacXin = new List<String>();
                foreach (var vacxin in vacxins)
                    tenVacXin.Add(vacxin.TenVacXin);
                var h = new HashSet<String>(tenVacXin);
                return h.ToList();
            }
        }

        public List<String> thongke()
        {
            using (var context = new YTeDbContext())
            {
                var thongkes = context.ThongKeSuDungVacXins.ToList();
                List<String> tenVacXin = new List<String>();
                foreach (var record in thongkes)
                {
                    var vacxin = context.VacXins
                                    .Where(b => b.ID_VacXin == record.ID_VacXin)
                                    .FirstOrDefault();
                    tenVacXin.Add(vacxin.TenVacXin);
                }
                return tenVacXin.Distinct().ToList();
            }
        }

        public List<String> phongkham()
        {
            using (var context = new YTeDbContext())
            {
                var phongkhams = context.PhongKhams.ToList();
                List<String> tenPhongKham = new List<String>();
                foreach (var vacxin in phongkhams)
                    tenPhongKham.Add(vacxin.TenPhongKham);
                var h = new HashSet<String>(tenPhongKham);
                return h.ToList();
            }
        }
        public List<String> solo( String tenVacXin)
        {
            using (var context = new YTeDbContext())
            {
                var vacxin = context.VacXins.Where(b => b.TenVacXin == tenVacXin).ToList();
                List<String> solo = new List<String>();
                foreach (var record in vacxin)
                {
                    solo.Add(record.SoLoVacXin);
                }
                return solo.Distinct().ToList();
            }
        }

    }
}
