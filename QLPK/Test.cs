using Controller.dataGridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {
            LoadingTable ld = new LoadingTable();
            dataGridView1.DataSource = ld.datlichkham();
        }
    }
}
