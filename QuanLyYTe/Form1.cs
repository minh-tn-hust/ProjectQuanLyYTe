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
        LoadingTable ld = new LoadingTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            loading.DataSource = ld.onlytrecon();
            btnTreem.FillColor = Color.FromArgb(94, 148, 255);
            btnPhunu.FillColor = Color.FromArgb(192, 192, 192);
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
 
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTreem_Click(object sender, EventArgs e)
        {
            btnTreem.FillColor = Color.FromArgb(94, 148, 255);
            btnPhunu.FillColor = Color.FromArgb(192, 192, 192);
            loading.DataSource = ld.onlytrecon();
        }

        private void btnPhunu_Click(object sender, EventArgs e)
        {
            btnTreem.FillColor = Color.FromArgb(192, 192, 192);
            btnPhunu.FillColor = Color.FromArgb(94, 148, 255);
            loading.DataSource = ld.phunumangthai();
        }
    }
}
