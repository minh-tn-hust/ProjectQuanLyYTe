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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhuNuMangThai()
        {
            ThongTinThaiKis = new HashSet<ThongTinThaiKi>();
        }

        [Key]
        public int ID_NguoiMangThai { get; set; }

        public int ID_Nguoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinThaiKi> ThongTinThaiKis { get; set; }
    }
}
