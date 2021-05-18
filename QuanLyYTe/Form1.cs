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

namespace QuanLyYTe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'model2DataSet.PhongKham' table. You can move, or remove it, as needed.
            this.phongKhamTableAdapter.Fill(this.model2DataSet.PhongKham);
            LoadingTable lt = new LoadingTable();
            guna2DataGridView1.DataSource = lt.vacxin();

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
 
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
