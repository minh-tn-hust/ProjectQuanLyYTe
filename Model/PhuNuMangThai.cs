namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhuNuMangThai")]
    public partial class PhuNuMangThai
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_NguoiMangThai { get; set; }

        public int ID_Nguoi { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(15,ErrorMessage ="Bảo hiểm y tế có 15 kí tự!")]
        public string SoBHYTe { get; set; }
        public int ChieuCao { get; set; }
        public int CanNang { get; set; }
        public string ThongTinNguoiCanBaoTin { get; set; }

    }
}
