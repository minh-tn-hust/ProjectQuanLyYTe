using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take3
{
    public partial class HSPhuSan : Form
    {
        public HSPhuSan()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CDPhuSan CD = new CDPhuSan();
            CD.Show();
        }
    }
}
