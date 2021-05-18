using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVaxin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 250)
            {
                panelMenu.Width = 60;
            }
            else
                panelMenu.Width = 250;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHienthi.Controls.Add(childForm);
            panelHienthi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnThongtinvacxin_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinVacXin());
        }

        private void btnNhaplieu_Click(object sender, EventArgs e)
        {
            openChildForm(new NhapLieu());
        }

        private void btnThongkevacxin_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeSuDung());   
        }
    }
}
