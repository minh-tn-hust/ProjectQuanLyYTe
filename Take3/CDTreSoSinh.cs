using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BieuDo;
using Bieudo2;

namespace Take3
{
    public partial class CDTreSoSinh : Form
    {
        public string Gioitinh;
        public CDTreSoSinh()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Gioitinh == "Nam")
            {
                BDNam BD1 = new BDNam();
                BD1.Show();
            }
            else
            {
                BDNu BD2 = new BDNu();
                BD2.Show();
            }
        }
    }
}
