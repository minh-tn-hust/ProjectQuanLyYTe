namespace YTeDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TreEm")]
    public partial class TreEm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TreEm()
        {
            ChiSoTreCons = new HashSet<ChiSoTreCon>();
        }

        [Key]
        public int ID_TreEm { get; set; }

        public int ID_Bo { get; set; }
        public int ID_Me { get; set; }
        public int ID_Nguoi { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiSoTreCon> ChiSoTreCons { get; set; }
    }
}
