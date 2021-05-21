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

namespace QuanLyYTe.GD_Chung
{
    public partial class CuaNhanVien : Form
    {
        public CuaNhanVien()
        {
            InitializeComponent();
        }
        Form1 x1 = new Form1();
        Form1 x2 = new Form1();
        Form1 x3 = new Form1();
        Form1 x4 = new Form1();
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
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            vacxinButton.BackColor = Color.FromArgb(94, 148, 255);
            treemButton.BackColor = Color.Transparent;
            phunuButton.BackColor = Color.Transparent;
            booklichButton.BackColor = Color.Transparent;
            openChildForm(x1);

            
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
            treemButton.BackColor = Color.FromArgb(94, 148, 255);
            phunuButton.BackColor = Color.Transparent;
            booklichButton.BackColor = Color.Transparent;
            openChildForm(x2);
        }

        private void phunuButton_Click(object sender, EventArgs e)
        {
            vacxinButton.BackColor = Color.Transparent;
            treemButton.BackColor = Color.Transparent;
            phunuButton.BackColor = Color.FromArgb(94, 148, 255);
            booklichButton.BackColor = Color.Transparent;
            openChildForm(x3);

        }

        private void booklichButton_Click(object sender, EventArgs e)
        {
            vacxinButton.BackColor = Color.Transparent;
            treemButton.BackColor = Color.Transparent;
            phunuButton.BackColor = Color.Transparent;
            booklichButton.BackColor = Color.FromArgb(94, 148, 255);
            openChildForm(x4);

        }
    }
}
