using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using Model;

namespace Bieudo2
{
    public partial class BDNu : Form
    {
        public BDNu()
        {
            InitializeComponent();
        }
        int IDtreem; //dùng cái này cho toàn form
        public BDNu(int ID) // cóntructỏ này chỉ truyền cho biến // thôi chị vứt cả đống cái kia vào mà không khai báo thì làm sâo mà chạy
        {
            InitializeComponent();
            IDtreem = ID;
        }
        public void BDNu_Load(object sender, EventArgs e)
        {
            //this.IDtreem = IDtreem;
            int flagBP = 0, flagNCBP = 0, flagTC = 0;
            int[] BP = new int[61];
            int[] NCBP = new int[61];
            int[] TC = new int[61];
            int[] Age = new int[61];
            // mấy cái này cần phải viết code để load ra từ csdl thông qua cái IDTreem được truyền vào ở trên kia
            int?[] Weight = new int?[61];
            int?[] Height = new int?[61];
            double[] Moc = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 30, 36, 42, 48, 54, 60 };
            double[] Heightarg = { 49.1, 53.7, 57.1, 59.8, 62.1, 64.0, 65.7, 67.3, 68.8, 70.1, 71.5, 72.8, 74, 75.2, 76.4, 77.5, 78.6, 79.7, 80.7, 81.7, 82.7, 83.7, 84.6, 85.5, 86.4, 90.7, 95.1, 99.0, 102.7, 106.2, 109.4 };
            double[] Weightarg = { 3.2, 4.2, 5.1, 5.8, 6.4, 6.9, 7.3, 7.6, 7.9, 8.2, 8.5, 8.7, 8.9, 9.2, 9.4, 9.6, 9.8, 10.0, 10.2, 10.4, 10.6, 10.9, 11.1, 11.3, 11.5, 12.7, 13.9, 15.0, 16.1, 17.2, 18.2 };
            double[] BMI = new double[61];
            //Day vao mang
            int p = 0;
            using (var database = new YTeDbContext())
            {
                List<ChiSoTreCon> listtreem = database.ChiSoTreCons.ToList();
                foreach (var record in listtreem)
                {
                    if (record.ID_TreEm == IDtreem)
                    {
                        Height[p] = record.ChieuCao;
                        Weight[p] = record.CanNang;
                        Age[p] = Convert.ToInt32(record.Tuoi);
                        p++;
                    }
                }
            }
            // Sap xep lai cac mang lien quan
            int tg1 = 0;
            int? tg2;
            for (int i = 0; i < p - 1; i++)
            {
                for (int j = i + 1; j < p; j++)
                    if (Age[i] > Age[j])
                    {
                        tg1 = Age[i]; Age[i] = Age[j]; Age[j] = tg1;
                        tg2 = Height[i]; Height[i] = Height[j]; Height[j] = tg2;
                        tg2 = Weight[i]; Weight[i] = Weight[j]; Weight[j] = tg2;
                    }
            }

            // Tao bang ve chieu cao
            GraphPane myPane = zed.GraphPane;
            myPane.Title.Text = "Biểu đồ phân tích chiều cao";
            myPane.XAxis.Title.Text = "Tuổi (tháng)";
            myPane.YAxis.Title.Text = "Chiều cao (cm)";

            RollingPointPairList list = new RollingPointPairList(60000);
            RollingPointPairList list1 = new RollingPointPairList(60000);

            LineItem curve = myPane.AddCurve("Đường chuẩn", list, Color.Red, SymbolType.None);
            LineItem curve1 = myPane.AddCurve("Đường hiện tại", list1, Color.Blue, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 60;
            myPane.XAxis.Scale.MinorStep = 2;
            myPane.XAxis.Scale.MajorStep = 12;
            myPane.YAxis.Scale.Min = 40;
            myPane.YAxis.Scale.Max = 120;
            myPane.YAxis.Scale.MinorStep = 2;
            myPane.YAxis.Scale.MajorStep = 20;
            zed.AxisChange();

            PointPairList DuongChuan = new PointPairList();
            LineItem item = myPane.AddCurve("", DuongChuan, Color.Red, SymbolType.None);
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 90.0f);
            myPane.AxisChange();


            // Tao bang ve can nang
            GraphPane mmyPane = zed2.GraphPane;
            mmyPane.Title.Text = "Biểu đồ phân tích cân nặng";
            mmyPane.XAxis.Title.Text = "Tuổi (tháng)";
            mmyPane.YAxis.Title.Text = "Cân nặng (kg)";

            RollingPointPairList llist = new RollingPointPairList(60000);
            RollingPointPairList llist1 = new RollingPointPairList(60000);

            LineItem ccurve = mmyPane.AddCurve("Đường chuẩn", llist, Color.Red, SymbolType.None);
            LineItem ccurve1 = mmyPane.AddCurve("Đường hiện tại", llist1, Color.Blue, SymbolType.None);

            mmyPane.XAxis.Scale.Min = 0;
            mmyPane.XAxis.Scale.Max = 60;
            mmyPane.XAxis.Scale.MinorStep = 2;
            mmyPane.XAxis.Scale.MajorStep = 12;
            mmyPane.YAxis.Scale.Min = 3;
            mmyPane.YAxis.Scale.Max = 20;
            mmyPane.YAxis.Scale.MinorStep = 1;
            mmyPane.YAxis.Scale.MajorStep = 4;
            zed.AxisChange();

            PointPairList DDuongChuan = new PointPairList();
            for (int i = 0; i < Moc.Length; i++)
            {
                DuongChuan.Add(Moc[i], Heightarg[i]);
                DDuongChuan.Add(Moc[i], Weightarg[i]);
            }
            LineItem iitem = mmyPane.AddCurve("", DDuongChuan, Color.Red, SymbolType.None);
            mmyPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 90.0f);
            mmyPane.AxisChange();
            PointPairList DuongThuc = new PointPairList();
            PointPairList DDuongThuc = new PointPairList();
            double x, y1, y2;
            double dem;
            for (int i = 0; i < p; i++)
            {
                x = Convert.ToDouble(Age[i]);
                y1 = Convert.ToDouble(Weight[i]);
                y2 = Convert.ToDouble(Height[i]);
                DuongThuc.Add(Age[i], y2);
                DDuongThuc.Add(Age[i], y1);
                BMI[i] = y1 / (y2 * y2 / 10000);
                dem = Math.Round(BMI[i], 2);
                if (dem > 18.5)
                {
                    BP[flagBP] = Age[i];
                    flagBP++;
                }
                if (dem <= 18.5 && dem > 18)
                {
                    NCBP[flagNCBP] = Age[i];
                    flagNCBP++;
                }
                if (dem < 13.5)
                {
                    TC[flagTC] = Age[i];
                    flagTC++;
                }

            }
            LineItem item1 = myPane.AddCurve("", DuongThuc, Color.Blue, SymbolType.None);
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 90.0f);
            LineItem iitem1 = mmyPane.AddCurve("", DDuongThuc, Color.Blue, SymbolType.None);
            mmyPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 90.0f);
            if (flagBP == 0 && flagNCBP == 0 && flagTC == 0)
            {
                label3.Text = "Trẻ phát triển bình thường.";
            }
            else
            {
                string Z = "";
                if (flagBP != 0)
                {
                    for (int i = 0; i < flagBP; i++)
                    {
                        Z = string.Concat(Z, Convert.ToString(BP[i]), " ");
                    }
                    label2.Text = "Trẻ bị béo phì ở các tháng tuổi: " + Z;
                }
                Z = "";
                if (flagNCBP != 0)
                {
                    for (int i = 0; i < flagNCBP; i++)
                    {
                        Z = string.Concat(Z, Convert.ToString(NCBP[i]), " ");
                    }
                    label3.Text = "Trẻ có nguy cơ béo phì ở các tháng tuổi: " + Z;
                }
                Z = "";
                if (flagTC != 0)
                {
                    for (int i = 0; i < flagTC; i++)
                    {
                        Z = string.Concat(Z, Convert.ToString(TC[i]), " ");
                    }
                    label4.Text = "Trẻ bị thiếu cân ở các tháng tuổi: " + Z;
                }
            }
        }

    }
}

