namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConNguoi")]
    public partial class ConNguoi
    {
        [Key]
        public int ID_Nguoi { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string SoCMND { get; set; }

        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }

        [StringLength(50)]
        public string NgheNghiep { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? QuanHeVoiChuHo { get; set; }

        public int? ID_HoGiaDinh { get; set; }
    }
}
