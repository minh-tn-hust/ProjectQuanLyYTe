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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_VacXin { get; set; }
        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string SoLoVacXin { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime NgaySuDung { get; set; }
        public int? SoLuongSuDung { get; set; }

    }
}
