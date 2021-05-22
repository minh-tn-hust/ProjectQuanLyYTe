using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Object
{
    public class BangPhuNuMangThai
    {
        public ConNguoi connguoi;
        public PhuNuMangThai phunumangthai;
        public BangPhuNuMangThai(ConNguoi a,  PhuNuMangThai c)
        {
            this.connguoi = a;
            this.phunumangthai = c;
        }
    }
}
