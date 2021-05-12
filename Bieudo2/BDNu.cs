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

namespace Bieudo2
{
    public partial class BDNu : Form
    {
        public BDNu()
        {
            InitializeComponent();
        }
        int flagBP = 0, flagNCBP = 0, flagTC = 0;
        int[] BP = new int[61];
        int[] NCBP = new int[61];
        int[] TC = new int[61];
        int[] Age = { 0, 54, 55, 60 };
        double[] Weight = { 90, 90, 90, 0, 19.2, 19.4, 19.6, 19.8, 19.9, 20.100000, 20.300000, 20.500000, 20.700000, 20.900000, 21.100000, 21.300000, 21.500000, 21.700000, 21.900000, 22.100000, 22.300000, 22.500000, 22.700000, 22.900000, 23.100000, 23.300000, 23.500000, 23.700000, 23.900000, 24.100000, 24.300000, 24.600000, 24.800000, 25.000000, 25.200000, 25.400000, 25.600000, 25.900000, 26.100000, 26.300000, 26.500000, 26.700000, 27.000000, 27.200000, 27.400000, 27.600000, 27.900000, 28.100000, 28.300000, 28.600000, 28.800000, 29.100000, 29.300000, 29.600000, 29.800000, 30.100000, 30.400000, 30.600000, 30.900000, 31.200000 };
        double[] Height = { 110.3, 110.8, 111.3, 111.9, 112.4, 112.9, 113.4, 113.9, 114.500000, 115.000000, 115.500000, 116.000000, 116.400000, 116.900000, 117.400000, 117.900000, 118.400000, 118.900000, 119.400000, 119.800000, 120.300000, 120.800000, 121.300000, 121.700000, 122.200000, 122.700000, 123.100000, 123.600000, 124.100000, 124.500000, 125.000000, 125.500000, 125.900000, 126.400000, 126.800000, 127.300000, 127.700000, 128.200000, 128.600000, 129.000000, 129.500000, 129.900000, 130.400000, 130.800000, 131.300000, 131.700000, 132.100000, 132.600000, 133.000000, 133.400000, 133.900000, 134.300000, 134.700000, 135.200000, 135.600000, 136.100000, 136.500000, 136.900000, 137.300000, 137.80000 };
        double[] Moc = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 30, 36, 42, 48, 54, 60 };
        double[] Heightarg = { 49.1, 53.7, 57.1, 59.8, 62.1, 64.0, 65.7, 67.3, 68.8, 70.1, 71.5, 72.8, 74, 75.2, 76.4, 77.5, 78.6, 79.7, 80.7, 81.7, 82.7, 83.7, 84.6, 85.5, 86.4, 90.7, 95.1, 99.0, 102.7, 106.2, 109.4 };
        double[] Weightarg = { 3.2, 4.2, 5.1, 5.8, 6.4, 6.9, 7.3, 7.6, 7.9, 8.2, 8.5, 8.7, 8.9, 9.2, 9.4, 9.6, 9.8, 10.0, 10.2, 10.4, 10.6, 10.9, 11.1, 11.3, 11.5, 12.7, 13.9, 15.0, 16.1, 17.2, 18.2 };
        double[] BMI = new double[61];
        private void BDNu_Load(object sender, EventArgs e)
        {
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
            for (int i = 0; i < 31; i++)
            {
                DuongChuan.Add(Moc[i], Heightarg[i]);
                DDuongChuan.Add(Moc[i], Weightarg[i]);
            }
            LineItem iitem = mmyPane.AddCurve("", DDuongChuan, Color.Red, SymbolType.None);
            mmyPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 90.0f);
            mmyPane.AxisChange();

            PointPairList DuongThuc = new PointPairList();
            PointPairList DDuongThuc = new PointPairList();

            double dem;
            for (int i = 0; i < Age.Length; i++)
            {
                Math.Round(Height[i], 1);
                Math.Round(Weight[i], 1);
                DuongThuc.Add(Age[i], Height[i]);
                DDuongThuc.Add(Age[i], Weight[i]);
                BMI[i] = Weight[i] / (Height[i] * Height[i] / 10000);
                dem = Math.Round(BMI[i], 2);
                if (dem > 18.5)
                {
                    BP[flagBP] = i;
                    flagBP++;
                }
                if (dem <= 18.5 && dem > 18)
                {
                    NCBP[flagNCBP] = i;
                    flagNCBP++;
                }
                if (dem < 13.5)
                {
                    TC[flagTC] = i;
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
