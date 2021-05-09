using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Controller.Hieu
{
    public class loadData
    {
        public List<String> ComboBoxData()
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
    }
}
