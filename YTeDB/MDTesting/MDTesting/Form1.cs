using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace MDTesting
{
    public partial class Form1 : Form
    {
        LoadingTable loadingTable = new LoadingTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable dt = loadingTable.trecon();
            //DataTable dt = loadingTable.nhanvien();
            DataTable dt = loadingTable.connguoi();
            dataGridView1.DataSource = dt;

        }
    }
}
