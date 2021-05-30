namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TreEm")]
    public partial class TreEm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_TreEm { get; set; }
        [Index(IsUnique = true)]
        [StringLength(15)]
        public string MaTheBHYTe { get; set; }
        public int ID_Bo { get; set; }
        public int ID_Me { get; set; }
        public string ThongTinNguoiBaoTin { get; set; }
        public int ID_Nguoi { get; set; }
    }
}
