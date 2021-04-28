namespace YTeDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SuDungVacXin")]
    public partial class SuDungVacXin
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Nguoi { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_VacXin { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime ThoiDiemTiem { get; set; }

        public int ID_PhongKham { get; set; }

        public int? SoMuiTiem { get; set; }
    }
}
