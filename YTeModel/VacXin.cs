namespace YTeDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VacXin")]
    public partial class VacXin
    {
        [Key]
        public int ID_VacXin { get; set; }

        [StringLength(50)]
        public string TenVacXin { get; set; }

        [StringLength(50)]
        public string TenLoVacXin { get; set; }

        [StringLength(50)]
        public string GiaThanh { get; set; }

        public int? SoMuiCanTiem{get;set;}

        public DateTime? NgaySanXuat { get; set; }

        public DateTime? HanSuDung { get; set; }

        public DateTime? NgayNhapKho { get; set; }

        public int? ThoiGianSuDungLai { get; set; }

        public int? SoLuongConLai { get; set; }

        [StringLength(200)]
        public string ChongChiDinh { get; set; }

        [StringLength(200)]
        public string ThongTinKhac { get; set; }
    }
}
