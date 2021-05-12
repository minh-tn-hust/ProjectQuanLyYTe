using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("ThongKeSuDungVacXin")]
    public partial class ThongKeSuDungVacXin
    {
        [Key]
        public int ID_VacXin { get; set; }
        [StringLength(50)]
        public string SoLoVacXin { get; set; }
        [StringLength(50)]
        public string TenVacXin { get; set; }
        public DateTime? NgaySuDung { get; set; }
        public int? SoLuongSuDung { get; set; }

    }
}
