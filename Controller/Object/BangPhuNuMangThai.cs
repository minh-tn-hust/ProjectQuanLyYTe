using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTeDB;

namespace Controller.Object
{
    public class BangPhuNuMangThai
    {
        public ConNguoi connguoi;
        public ThongTinThaiKi thongtinthaiki;
        public PhuNuMangThai phunumangthai;
        public BangPhuNuMangThai(ConNguoi a, ThongTinThaiKi b, PhuNuMangThai c)
        {
            this.connguoi = a;
            this.thongtinthaiki = b;
            this.phunumangthai = c;
        }
    }
}
