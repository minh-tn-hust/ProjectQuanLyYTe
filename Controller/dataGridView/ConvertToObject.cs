using System;
using System.Linq;
using YTeDB;
using System.Windows.Forms;
using Controller.Object;


namespace Controller.dataGridView
{
    public class ConvertToObject
    {
        #region Convert Con Nguoi
        public ConNguoi connguoi(DataGridView source, DataGridViewCellEventArgs e)
        {
            string SoCMND = source.Rows[e.RowIndex].Cells[2].Value.ToString();
            MessageBox.Show(SoCMND);
            using ( var context = new YTeDbContext())
            {
                var des = context.ConNguois
                            .Where(b => b.SoCMND == SoCMND)
                            .FirstOrDefault();
                return des;
            }
        }

        #endregion

        #region Convert NhanVienYTe // Can 2 doi tuong la Nhan vien + Con nguoi
        public BangNhanVien nhanvien(DataGridView source, DataGridViewCellEventArgs e)
        {
            int i = 1;
            NhanVienYTe des;
            String SoCMND = source.Rows[e.RowIndex].Cells[1].Value.ToString();
            using (var context = new YTeDbContext())
            {
                var connguoi = context.ConNguois
                                .Where(b => b.SoCMND == SoCMND)
                                .FirstOrDefault();
                des = context.NhanVienYTes
                        .Where(b => b.ID_Nguoi == connguoi.ID_Nguoi)
                        .FirstOrDefault();
                return new BangNhanVien(connguoi, des);
            }
        }
        #endregion

        #region Convert Tre Em o bang tre em
        public BangTreEm bangtreem(DataGridView source, DataGridViewCellEventArgs e)
        {
            String name = source.Rows[e.RowIndex].Cells[1].Value.ToString();
            DateTime birth = DateTime.Parse(source.Rows[e.RowIndex].Cells[5].Value.ToString());
            MessageBox.Show(name);
            using (var context = new YTeDbContext())
            {
                var connguoi = context.ConNguois
                                .Where(b => b.HoTen == name && b.NgaySinh == birth)
                                .FirstOrDefault();
                var treem = context.TreEms
                                .Where(b => b.ID_Nguoi == connguoi.ID_Nguoi)
                                .FirstOrDefault();
                MessageBox.Show(treem.ID_TreEm.ToString());
                var chiso = context.ChiSoTreCons
                                .Where(b => b.ID_TreEm == treem.ID_TreEm)
                                .FirstOrDefault();
                return new BangTreEm(treem, chiso, connguoi);
            }
        }


        #endregion


        #region Convert bang vacxin
        public VacXin bangvacxin(DataGridView source, DataGridViewCellEventArgs e)
        {
            String tenvacxin = source.Rows[e.RowIndex].Cells[0].Value.ToString();
            DateTime ngaysanxuat = DateTime.Parse(source.Rows[e.RowIndex].Cells[2].Value.ToString());
            String solo = source.Rows[e.RowIndex].Cells[1].Value.ToString();
            using (var context = new YTeDbContext())
            {
                var vacxin = context.VacXins
                                .Where(b => b.TenVacXin == tenvacxin && b.NgaySanXuat == ngaysanxuat && b.TenLoVacXin == solo)
                                .FirstOrDefault();
                return vacxin;
            }
        }

        #endregion

        #region Convert Thong Tin Thai Ki
        public BangPhuNuMangThai bangphunumangthai(DataGridView source, DataGridViewCellEventArgs e)
        {
            String SoCMND = source.Rows[e.RowIndex].Cells[2].Value.ToString();
            using (var context = new YTeDbContext())
            {
                var connguoi = context.ConNguois
                                .Where(b => b.SoCMND == SoCMND)
                                .FirstOrDefault();
                var phunumangthai = context.PhuNuMangThais
                                .Where(b => b.ID_Nguoi == connguoi.ID_Nguoi)
                                .FirstOrDefault();
                var thongtinthaiki = context.ThongTinThaiKis
                                .Where(b => b.ID_NguoiMangThai == phunumangthai.ID_NguoiMangThai)
                                .FirstOrDefault();
                return new BangPhuNuMangThai(connguoi, thongtinthaiki, phunumangthai);
            }
        }

        #endregion

    }
}

