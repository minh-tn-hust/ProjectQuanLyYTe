using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ChiSoTreCon> ChiSoTreCons { get; set; }
        public virtual DbSet<ConNguoi> ConNguois { get; set; }
        public virtual DbSet<HoGiaDinh> HoGiaDinhs { get; set; }
        public virtual DbSet<NguoiQuanLy> NguoiQuanLies { get; set; }
        public virtual DbSet<NhanVienYTe> NhanVienYTes { get; set; }
        public virtual DbSet<PhongKham> PhongKhams { get; set; }
        public virtual DbSet<PhuNuMangThai> PhuNuMangThais { get; set; }
        public virtual DbSet<SuDungVacXin> SuDungVacXins { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThongTinThaiKi> ThongTinThaiKis { get; set; }
        public virtual DbSet<TreEm> TreEms { get; set; }
        public virtual DbSet<VacXin> VacXins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
