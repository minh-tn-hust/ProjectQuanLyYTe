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
using Controller.Object;
using Model;
using Take3;

namespace QuanLyYTe
{
    public partial class PhuNuTreEm : Form
    {
        public PhuNuTreEm()
        {
            InitializeComponent();
        }
        LoadingTable ld = new LoadingTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            loading.DataSource = ld.onlytrecon();
            btnTreem.FillColor = Color.FromArgb(94, 148, 255);
            btnPhunu.FillColor = Color.FromArgb(192, 192, 192);
            searchField.Text = searchField.Items[0].ToString();
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

        private void loading_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnTreem.FillColor == Color.FromArgb(94, 148, 255)) 
            {
                ConvertToObject converter = new ConvertToObject();
                BangOnlyTreEm da = converter.onlybangtreem(loading, e);
                HSTreSoSinh hosotre = new HSTreSoSinh(da.treem, da.connguoi, 1);
                hosotre.Show();

            }
            else
            {
                ConvertToObject converter = new ConvertToObject();
                BangPhuNuMangThai ad = converter.bangphunumangthai(loading, e);
                HSPhuSan hoso = new HSPhuSan(ad.connguoi, ad.phunumangthai,1);
                hoso.Show();
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                DTGFilter dtg = new DTGFilter();
                loading.DataSource = dtg.searchRow(loading, searchField.Text, searchTextBox.Text);
        }

        private void loading_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_CausesValidationChanged(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

=======
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TreEm treem = new TreEm();
            ConNguoi connguoi = new ConNguoi();
            HSTreSoSinh hs = new HSTreSoSinh(treem,connguoi,0);
            hs.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ConNguoi connguoi = new ConNguoi();
            PhuNuMangThai phunu = new PhuNuMangThai();
            HSPhuSan hoso = new HSPhuSan(connguoi,phunu,0);
            hoso.Show();
>>>>>>> b6ce35cfc5578cf7be454882291b38f14fdebfe9
        }
    }
}
