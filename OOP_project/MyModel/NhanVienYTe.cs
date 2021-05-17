namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVienYTe")]
    public partial class NhanVienYTe
    {
        [Key]
        public int ID_NhanVien { get; set; }

        public int? ID_Nguoi { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? ID_CoSoYTe { get; set; }
    }
}
