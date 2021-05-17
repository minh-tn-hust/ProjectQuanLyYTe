using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller.Object
{
    public class BangNhanVien
    {
        public ConNguoi connguoi;
        public NhanVienYTe nhanvienyte;
        public BangNhanVien(ConNguoi a, NhanVienYTe b)
        {
            this.connguoi = a;
            this.nhanvienyte = b;
        }
    }
}
