namespace YTeDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhuNuMangThai")]
    public partial class PhuNuMangThai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhuNuMangThai()
        {
            ThongTinThaiKis = new HashSet<ThongTinThaiKi>();
        }

        [Key]
        public int ID_NguoiMangThai { get; set; }

        public int ID_Nguoi { get; set; }
        [MaxLength(13,ErrorMessage ="Bảo hiểm y tế có 15 kí tự!")]
        public string SoBHYTe { get; set; }
        public DateTime? NgayHetHanBHYTe { get; set; }
        public int ChieuCao { get; set; }
        public int CanNang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinThaiKi> ThongTinThaiKis { get; set; }
    }
}
