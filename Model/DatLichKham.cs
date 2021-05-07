using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DatLichKham
    {
        
        [Key]
        [Column(Order =1)]
        public int ID_Nguoi { get; set; }
        [Key]
        [Column(Order =2)]
        public DateTime ThoiGianHenKham { get; set; }
        public string LyDoKham { get; set; }
        public string GhiChu { get; set; }
        public int ID_NguoiTaoDon { get; set; }
        public int ID_NhanVienYTe { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_LichKham { get; set; }
        public int ID_PhongKham { get; set; }

    }
}
