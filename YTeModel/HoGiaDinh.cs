namespace YTeDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoGiaDinh")]
    public partial class HoGiaDinh
    {
        [Key]
        public int ID_HoGiaDinh { get; set; }

        [Required]
        [StringLength(50)]
        public string SoHoKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string TenChuHo { get; set; }
    }
}
