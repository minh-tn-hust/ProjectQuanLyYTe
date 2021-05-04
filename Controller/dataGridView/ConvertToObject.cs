using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTeDB;
using System.Windows.Forms;

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
        public ConNguoi connguoiNew(DataGridView source, DataGridViewCellEventArgs e)
        {
            int i = 1;
            ConNguoi des = new ConNguoi();
            des.HoTen = source.Rows[e.RowIndex].Cells[i++].Value.ToString();
            des.SoCMND = source.Rows[e.RowIndex].Cells[i++].Value.ToString();
            des.NgaySinh = DateTime.Parse(source.Rows[e.RowIndex].Cells[i++].Value.ToString());
            des.GioiTinh = int.Parse(source.Rows[e.RowIndex].Cells[i++].Value.ToString());
            des.NgheNghiep = source.Rows[e.RowIndex].Cells[i++].Value.ToString();
            des.DiaChi = source.Rows[e.RowIndex].Cells[i++].Value.ToString();
            des.SoDienThoai = source.Rows[e.RowIndex].Cells[i++].Value.ToString();
            des.Email = source.Rows[e.RowIndex].Cells[i++].Value.ToString();
            return des;
        }

        #endregion
        #region Convert NhanVienYTe
        public NhanVienYTe nhanvienNew(DataGridView source, DataGridViewCellEventArgs e)
        {
            int i = 1;
            NhanVienYTe des = new NhanVienYTe();
            String SoCMND = source.Rows[e.RowIndex].Cells[1].Value.ToString();
            using (var context = new YTeDbContext())
            {
                var connguoi = context.ConNguois
                                .Where(b => b.SoCMND == SoCMND)
                                .FirstOrDefault();
                des.ID_Nguoi = connguoi.ID_Nguoi;
                des.UserName = source.Rows[e.RowIndex].Cells[9].Value.ToString();
                des.Password = source.Rows[e.RowIndex].Cells[10].Value.ToString();
                return des;
            }
        }
        public NhanVienYTe nhanvien(DataGridView source, DataGridViewCellEventArgs e)
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
                return des;
            }
        }
        #endregion
        #region Convert Tre Em
        public TreEm treem(DataGridView source, DataGridViewCellEventArgs e)
        {
            TreEm des = new TreEm();
            int ID_Bo = int.Parse(source.Rows[e.RowIndex].Cells[1].Value.ToString());
            int ID_Me = int.Parse(source.Rows[e.RowIndex].Cells[2].Value.ToString());
            using (var context = new YTeDbContext())
            {
                var connguoi = context.TreEms
                                .Where(b => b.ID_Bo == ID_Bo && b.ID_Me == ID_Me)
                                .FirstOrDefault();
                return des;
            }
        }
        public TreEm treemNew(DataGridView source, DataGridViewCellEventArgs e)
        {
            int i = 1;
            TreEm des = new TreEm();
            int ID_Bo = int.Parse(source.Rows[e.RowIndex].Cells[1].Value.ToString());
            int ID_Me = int.Parse(source.Rows[e.RowIndex].Cells[2].Value.ToString());
            int ID_Nguoi = int.Parse(source.Rows[e.RowIndex].Cells[3].Value.ToString());
            des.ID_Nguoi = ID_Nguoi;
            des.ID_Bo = ID_Bo;
            des.ID_Me = ID_Me;
            return des;
        }

        public ChiSoTreCon chisotrecon(DataGridView source, DataGridViewCellEventArgs e)
        {
            ChiSoTreCon des = new ChiSoTreCon();
            int ID_Bo = int.Parse(source.Rows[e.RowIndex].Cells[1].Value.ToString());
            int ID_Me = int.Parse(source.Rows[e.RowIndex].Cells[2].Value.ToString());
            using (var context = new YTeDbContext())
            {
                var connguoi = context.TreEms
                                .Where(b => b.ID_Bo == ID_Bo && b.ID_Me == ID_Me)
                                .FirstOrDefault();
                return des;
            }
        }
        //public ChiSoTreCon chisotreconNew(DataGridView source, DataGridViewCellEventArgs e)
        //{
        //    int i = 1;
        //    ChiSoTreCon des = new ChiSoTreCon();
        //    int ID_Bo = int.Parse(source.Rows[e.RowIndex].Cells[1].Value.ToString());
        //    int ID_Me = int.Parse(source.Rows[e.RowIndex].Cells[2].Value.ToString());
        //    int ID_Nguoi = int.Parse(source.Rows[e.RowIndex].Cells[3].Value.ToString());
        //    des.ID_Nguoi = ID_Nguoi;
        //    des.ID_Bo = ID_Bo;
        //    des.ID_Me = ID_Me;
        //    return des;
        //}
        #endregion

    }
}

