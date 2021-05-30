namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinThaiKi")]
    public partial class ThongTinThaiKi
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_NguoiMangThai { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime ThoiGianKham { get; set; }
        public DateTime LanKhamTiepTheo { get; set; }
        public int ChieuCaoMe { get; set; }
        public int CanNangMe { get; set; }
        public DateTime? ThoiGianSinhDuKien { get; set; }
        public int ID_PhongKham { get; set; }
        public int ID_NhanVien { get; set; }


    }
}
