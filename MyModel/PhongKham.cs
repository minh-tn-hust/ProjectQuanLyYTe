namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongKham")]
    public partial class PhongKham
    {
        [Key]
        public int ID_PhongKham { get; set; }

        [StringLength(50)]
        public string TenPhongKham { get; set; }
        public int ID_NhanVienQuanLy { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public int? NgayBatDauTrongTuan { get; set; }

        public int? NgayKetThucTrongTuan { get; set; }

        public TimeSpan? GioBatDau { get; set; }

        public TimeSpan? GioketThuc { get; set; }

        [StringLength(50)]
        public string SoDienThoaiLienHe { get; set; }

        [StringLength(50)]
        public string ThongTinKhac { get; set; }
    }
}
