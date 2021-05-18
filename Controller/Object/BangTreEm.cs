using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller.Object
{
    public class BangTreEm
    {
        public TreEm treEm;
        public ChiSoTreCon chiSoTreCon;
        public ConNguoi conNguoi;
        public BangTreEm(TreEm a, ChiSoTreCon b, ConNguoi c)
        {
            this.treEm = a;
            this.chiSoTreCon = b;
            this.conNguoi = c;
        }
    }
}
