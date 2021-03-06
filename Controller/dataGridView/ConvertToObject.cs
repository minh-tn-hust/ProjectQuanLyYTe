using System;
using System.Linq;
using System.Windows.Forms;
using Controller.Object;
using Model;

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
            if (e.RowIndex < 0)
            {
                return null;
            }
            NhanVienYTe des=null;
            ConNguoi connguoi = null;
            String SoCMND = source.Rows[e.RowIndex].Cells[2].Value.ToString();
            using (var context = new YTeDbContext())
            {
                                  connguoi = context.ConNguois
                                    .Where(b => b.SoCMND == SoCMND)
                                    .FirstOrDefault();
                if (connguoi == null) return null;
              
                try
                {
                    des = context.NhanVienYTes
                            .Where(b => b.ID_Nguoi == connguoi.ID_Nguoi)
                            .FirstOrDefault();
                }
                catch (NullReferenceException)
                {
                    return null;
                }
                return new BangNhanVien(connguoi, des);
            }
        }
        #endregion

        #region Convert Tre Em o bang tre em
        public BangTreEm bangtreem(DataGridView source, DataGridViewCellEventArgs e)
        {
            String name = source.Rows[e.RowIndex].Cells[1].Value.ToString();
            DateTime birth = DateTime.Parse(source.Rows[e.RowIndex].Cells[5].Value.ToString());
           // MessageBox.Show(name);
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
        public BangOnlyTreEm onlybangtreem(DataGridView source, DataGridViewCellEventArgs e)
        {

            String name = source.Rows[e.RowIndex].Cells[1].Value.ToString();
            DateTime birth = DateTime.Parse(source.Rows[e.RowIndex].Cells[3].Value.ToString());
            // MessageBox.Show(name);
            using (var context = new YTeDbContext())
            {
                var connguoi = context.ConNguois
                                .Where(b => b.HoTen == name && b.NgaySinh == birth)
                                .FirstOrDefault();
                var treem = context.TreEms
                                .Where(b => b.ID_Nguoi == connguoi.ID_Nguoi)
                                .FirstOrDefault();
                BangOnlyTreEm ans = new BangOnlyTreEm(connguoi, treem);
                return ans;
            }
        }


        #endregion


        #region Convert bang vacxin
        public VacXin bangvacxin(DataGridView source, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return null;
            VacXin vacxin = null;
            String solo = source.Rows[e.RowIndex].Cells[2].Value.ToString();
            using (var context = new YTeDbContext())
            {
                try
                {
                     vacxin = context.VacXins
                                    .Where(b => b.SoLoVacXin == solo)
                                    .FirstOrDefault();
                }
                catch (Exception)
                {
                    return null;
                }
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
                return new BangPhuNuMangThai(connguoi, phunumangthai);
            }
        }

        #endregion

        #region ConvertToPhongKham

        public PhongKham bangphongkham(DataGridView source, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
              return null;
            }
            else
            {
                PhongKham phongkham = null;
                String diachi = source.Rows[e.RowIndex].Cells[3].Value.ToString();
                using (var context = new YTeDbContext())
                {
                    try
                    {
                        phongkham = context.PhongKhams
                                            .Where(b => b.DiaChi == diachi)
                                            .FirstOrDefault();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Vui lòng lựa chọn đúng hàng để hiển thị!");
                        return null;
                    }
                    return phongkham;
                }
            }
        }

        #endregion
    }
}

