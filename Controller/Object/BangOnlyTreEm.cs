using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Controller.Object
{
    public class BangOnlyTreEm
    {
        public ConNguoi connguoi;
        public TreEm treem;
        public BangOnlyTreEm(ConNguoi connguoi, TreEm treem)
        {
            this.connguoi = connguoi;
            this.treem = treem;
        }

    }
}
