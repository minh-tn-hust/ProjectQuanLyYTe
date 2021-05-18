using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller.dataGridView;

namespace QLPK
{
    public partial class FormDatLichNeuDaCoThongTin : Form
    {
        public FormDatLichNeuDaCoThongTin()
        {
            InitializeComponent();
        }
        public int ID_Nguoi;
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadingTable ld = new LoadingTable();
            guna2DataGridView1.DataSource = ld.connguoi();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string c = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show(c);
        }
      
    }
}
