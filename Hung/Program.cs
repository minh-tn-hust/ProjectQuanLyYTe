using QuanLyYTe.Admin;
using QuanLyYTe.QL_NVien;
using QuanLyYTe.QL_PKham;
using QuanLyYTe.QL_VacXin;
using QuanLyYTe.GD_Chung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVaxin;

namespace QuanLyYTe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
    }
}
