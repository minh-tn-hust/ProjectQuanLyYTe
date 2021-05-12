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
    public partial class HSTreSoSinh : Form
    {
        public HSTreSoSinh()
        {
            InitializeComponent();
        }
        
        public void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem != null)
            {
                CDTreSoSinh CD1 = new CDTreSoSinh();
                string tem = guna2ComboBox1.SelectedItem.ToString();
                CD1.Gioitinh = tem;
                CD1.Show();
            }
        }
    }
}
