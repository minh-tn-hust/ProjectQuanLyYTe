namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiSoTreCon")]
    public partial class ChiSoTreCon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TreEm { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime ThoiGianKham { get; set; }

        public int? Tuoi { get; set; }

        public int? CanNang { get; set; }

        public int? ChieuCao { get; set; }

        public int ID_PhongKham { get; set; }

        public virtual TreEm TreEm { get; set; }
    }
}
