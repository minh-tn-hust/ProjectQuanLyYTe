using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using QuanLyYTe;
using QuanLyVaxin;
using QLPK;


namespace QuanLyYTe.GD_Chung
{
    public partial class CuaNhanVien : Form
    {
        NhanVienYTe nhanvien;
        public CuaNhanVien()
        {
            InitializeComponent();
        }
        public CuaNhanVien(NhanVienYTe nhanvien)
        {
            InitializeComponent();
            this.nhanvien = nhanvien;

        }

        QuanLyVaxin.Menu qlvc = new QuanLyVaxin.Menu();
        PhuNuTreEm pnte = new PhuNuTreEm();
        FormDatlLich datlich;

        
        private void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            loadingFormPanel.Controls.Add(childForm);
            loadingFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CuaNhanVien_Load(object sender, EventArgs e)
        {
            loadingFormPanel.Height = this.Height - 85;
            using (var context = new YTeDbContext())
            {
                var connguoi = context.ConNguois.Where(b => b.ID_Nguoi == nhanvien.ID_Nguoi).FirstOrDefault();
                label1.Text = "Xin chào " + connguoi.HoTen;
                this.datlich = new FormDatlLich(connguoi);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            vacxinButton.BackColor = Color.FromArgb(150, 200, 255);
            treemButton.BackColor = Color.Transparent;
            booklichButton.BackColor = Color.Transparent;
            openChildForm(qlvc);

            
        }
        bool menuExpanded = true;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!guna2Transition1.IsCompleted) return;
            if (mainMenuPanel.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!menuExpanded)
                {
                    menuExpanded = true;
                    mainMenuPanel.Visible = false;
                    mainMenuPanel.Height = 47;
                    loadingFormPanel.Height -= (47 - 10);
                    guna2Transition1.Show(loadingFormPanel);
                    guna2Transition1.Show(mainMenuPanel);
                }
            }
            else
            {
                if (menuExpanded)
                {
                    menuExpanded = false;
                    mainMenuPanel.Height = 10;
                    loadingFormPanel.Height += (47 - 10);
                    guna2Transition1.Show(mainMenuPanel);
                    guna2Transition1.Show(loadingFormPanel);
                    
                }
            }

        }

        private void treemButton_Click(object sender, EventArgs e)
        {
            vacxinButton.BackColor = Color.Transparent;
            treemButton.BackColor = Color.FromArgb(150, 200, 255);
            booklichButton.BackColor = Color.Transparent;
            openChildForm(pnte);
        }

        private void phunuButton_Click(object sender, EventArgs e)
        {
        }

        private void booklichButton_Click(object sender, EventArgs e)
        {
            vacxinButton.BackColor = Color.Transparent;
            treemButton.BackColor = Color.Transparent;
            booklichButton.BackColor = Color.FromArgb(150, 200, 255);
            openChildForm(datlich);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); 
            SignIn logout = new SignIn();
            logout.ShowDialog();
            this.Close();
        }

        private void CuaNhanVien_MaximizedBoundsChanged(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(this.Height.ToString());
        }

        private void CuaNhanVien_Resize(object sender, EventArgs e)
        {
            loadingFormPanel.Height = this.Height - 85;
        }

        private void CuaNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            SignIn si = new SignIn();
            si.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            SignIn si = new SignIn();
            si.Show();
            this.Hide();

        }
    }
}
