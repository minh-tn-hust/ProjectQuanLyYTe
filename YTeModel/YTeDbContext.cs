namespace YTeDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YTeDbContext : DbContext
    {
        public YTeDbContext()
            : base("YTeDbContext")
        {
            Database.SetInitializer<YTeDbContext>(new CreateDatabaseIfNotExists<YTeDbContext>());
        }

        
        public virtual DbSet<ChiSoTreCon> ChiSoTreCons { get; set; }
        public virtual DbSet<ConNguoi> ConNguois { get; set; }
        public virtual DbSet<HoGiaDinh> HoGiaDinhs { get; set; }
        public virtual DbSet<NguoiQuanLy> NguoiQuanLies { get; set; }
        public virtual DbSet<NhanVienYTe> NhanVienYTes { get; set; }
        public virtual DbSet<PhongKham> PhongKhams { get; set; }
        public virtual DbSet<PhuNuMangThai> PhuNuMangThais { get; set; }
        public virtual DbSet<SuDungVacXin> SuDungVacXins { get; set; }
        public virtual DbSet<ThongTinThaiKi> ThongTinThaiKis { get; set; }
        public virtual DbSet<ThongKeSuDungVacXin> ThongKeSuDungVacXins { get; set; }
        public virtual DbSet<ChiSoTrungBinh> ChiSoTrungBinhs { get; set; }
        public virtual DbSet<TreEm> TreEms { get; set; }
        public virtual DbSet<VacXin> VacXins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
