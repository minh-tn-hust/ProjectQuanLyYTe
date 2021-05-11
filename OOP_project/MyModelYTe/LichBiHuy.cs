using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LichBiHuy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_LichBiHuy { get; set; }       
        public int ID_Nguoi { get; set; }
        public DateTime ThoiGianHenKham { get; set; }
        public string LyDoKham { get; set; }
        public string GhiChu { get; set; }
        public int ID_NguoiTaoDon { get; set; }
        public int ID_NhanVienYTe { get; set; }
        public string LyDoHuy { get; set; }

    }
}
