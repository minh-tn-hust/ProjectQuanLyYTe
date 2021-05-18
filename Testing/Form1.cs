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

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int?[] Height = new int?[60];
            DateTime TGKham = new DateTime(2005, 11, 20, 12, 1, 10); 
            int?[] Tuoi = new int?[60];
            using (var database = new YTeDbContext())
            {
                //List < ConNguoi > listConNguoi = database.ConNguois.ToList();
                //foreach (var record in listConNguoi)
                //{
                //    Height[i] = record.HoTen;
                //}
                //List<ConNguoi> listConNguoi = database.ConNguois.Where(connguoi => connguoi.ID_Nguoi == 1).ToList();
                //foreach (var record in listConNguoi)
                //{
                //    MessageBox.Show(record.HoTen);
                //}
                //List<ChiSoTreCon> listChiSoTreCon = database.ChiSoTreCons.Where(trecon => trecon.ID_TreEm == 1).ToList();
                //int i = 0;
                //foreach (var record in listChiSoTreCon)
                //{

                //}
                //for (int j = 0; j < Height.Length; j++)
                //{
                //    MessageBox.Show(Height[j].ToString());
                //}
                //MessageBox.Show(((DateTime.Now-TGKham).TotalDays/30).ToString());

            }
        }
    }
}
