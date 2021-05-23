using QuanLyYTe.Admin;
using QuanLyYTe.QL_NVien;
using QuanLyYTe.QL_PKham;
using QuanLyYTe.QL_VacXin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyYTe
{
    public partial class MenuUI : Form
    {
        public MenuUI()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            pnSubMenu.Visible = false;
            pnSubMenuPhongKham.Visible = false;
            pnSubMenuPlayMedia.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnSubMenu.Visible == true)
            {
                pnSubMenu.Visible = false;
            }
            if (pnSubMenuPhongKham.Visible == true)
            {
                pnSubMenuPhongKham.Visible = false;
            }
            if (pnSubMenuPlayMedia.Visible == true)
            {
                pnSubMenuPlayMedia.Visible = false;
            }

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenu);
        }
        #region subMenuMedia
        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new ThemMoiNhanVien());
            //your code
            //**
            //end Code

            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new SuaChiTietNhanVien());
            //your code
            //**
            //end Code

            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new HienThiToanBoNhanVien());
            //your code
            //**
            //end Code

            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //your code
            //**
            //end Code

            hideSubMenu();
        }
        #endregion
        private void btnPlayMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenuPlayMedia);
        }
        #region subMenuPlayMedia
        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new ThemMoiVacXin());
            //your code
            //**
            //end Code

            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new ChinhSuaThongTinVacXin());
            //your code
            //**
            //end Code

            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new HienThiToanBoVacXin());
            //your code
            //**
            //end Code

            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //your code
            //**
            //end Code

            hideSubMenu();
        }
        #endregion
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new ThemMoiCoSoYTe());
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenuPhongKham);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new ChinhSuaThongTinCoSoYTe());
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new HienThiToanBoCoSoYTe());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PnSideMenu.Visible == true)
            {
                splitContainer2.SplitterDistance = 0;
                PnSideMenu.Visible = false;
                            }
            else
            {
                splitContainer2.SplitterDistance = 200;
                PnSideMenu.Visible = true;
                           }

            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
            this.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            this.Close();
            signIn.ShowDialog();

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();
            this.Close();
                }

        private void MenuUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //SignIn signIn = new SignIn();
            //signIn.ShowDialog();
            //this.Close();
        }

        private void MenuUI_Load(object sender, EventArgs e)
        {
                              }
        int flag = 0;

        private void btnAnHienMenu_Click(object sender, EventArgs e)
        {
            if (PnSideMenu.Visible == true)
            {
                splitContainer2.SplitterDistance = 0;
                PnSideMenu.Visible = false;
            }
            else
            {
                splitContainer2.SplitterDistance = 200;
                PnSideMenu.Visible = true;
            }
        }

        private void MenuUI_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
