using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("ChiSoTrungBinh")]
    public partial class ChiSoTrungBinh
    {
        [Key]
        public int Thang { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
    }
}
