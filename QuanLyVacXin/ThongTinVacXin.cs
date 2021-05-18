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

namespace QuanLyVaxin
{
    public partial class ThongTinVacXin : Form
    {
        public ThongTinVacXin()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        DTGFilter filter = new DTGFilter();
        LoadingTable loadingTable = new LoadingTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable = loadingTable.vacxin();
            dtgThongTinVacXin.DataSource = dataTable;
        }
        private void btnTimKiemVacXin_Click(object sender, EventArgs e)
        {
            dtgThongTinVacXin.DataSource = dataTable;
            dtgThongTinVacXin.DataSource = filter.searchRow(dtgThongTinVacXin, "Tên vắc-xin", txtTimKiemVacXin.Text);
        }
    }
}
