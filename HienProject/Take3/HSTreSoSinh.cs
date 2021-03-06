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
using Controller.Object;

namespace Take3
{
    public partial class HSTreSoSinh : Form
    {
        
        public HSTreSoSinh()
        {
            InitializeComponent();
        }
        // Cai phan nay khong can quan tam
        TreEm treem;
        ConNguoi connguoi;
        int classify;
        public HSTreSoSinh(TreEm treem,  ConNguoi connguoi, int classify)
        {
            InitializeComponent();
            this.connguoi = connguoi;
            this.treem = treem;
            this.classify = classify;
        }



        public void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox7.Text.Length > 0 && guna2TextBox11.Text.Length > 0 && guna2ComboBox1.SelectedItem != null  && guna2TextBox2.Text != "" && guna2TextBox7.Text.Length <=13 && guna2TextBox11.Text.Length <= 13 && guna2TextBox2.Text.Length <=15 )
            {
                CDTreSoSinh CD1 = new CDTreSoSinh();
                bool co = false;
                string ktBHYT = guna2TextBox2.Text;
                //MessageBox.Show("Kiem tra xem tre co trong danh sach khong " + CD1.IDtreem);
                // Kiem tra xem tre co trong danh sach khong
                using (var database = new YTeDbContext())
                {
                    List<TreEm> listtreem = database.TreEms.ToList();
                    foreach (var record in listtreem)
                    {
                        if (record.MaTheBHYTe == ktBHYT)
                        {
                            co = true;
                            CD1.IDtreem = record.ID_TreEm;
                        }
                    } 
                }
                //MessageBox.Show("Kiem tra xem tre co trong danh sach khong " + CD1.IDtreem);
                #region Kiem tra tre em co trong danh sach hay khong
                // Neu tre khong co trong danh sach
                if (co == false)
                {
                    //Them 1 con nguoi
                    using (var yTeDbContext = new YTeDbContext())
                    {
                        ConNguoi connguoi = new ConNguoi();
                        yTeDbContext.ConNguois.Add(connguoi);
                        var listConNguoi = yTeDbContext.ConNguois.ToList();
                        connguoi.SoCMND = listConNguoi.Count.ToString();
                        connguoi.HoTen = guna2TextBox1.Text;
                        if (guna2ComboBox1.SelectedItem.ToString() == "Nam")
                        {
                            connguoi.GioiTinh = 0;
                        }
                        else connguoi.GioiTinh = 1;
                        connguoi.NgaySinh = DateTime.Parse(guna2DateTimePicker1.Value.ToString());
                        try
                        {
                            yTeDbContext.SaveChanges();
                            MessageBox.Show("Ta??o m????i th??ng tin tha??nh c??ng!");
                            CD1.IDtreem = connguoi.ID_Nguoi;

                        }
                        catch
                        {
                            MessageBox.Show("Kh??ng th??m con ng??????i ????????c");
                            return;
                        }
                    }

                    #region Kiem tra xem da co bo me chua
                    int IDcuame = 0, IDcuabo = 0;
                    int CMTme = 1, CMTbo = 1;
                    using (var yteDbContext = new YTeDbContext())
                    {
                        List<ConNguoi> listConNguoi = yteDbContext.ConNguois.ToList();
                        foreach (var record in listConNguoi)
                        {
                            if (record.SoCMND == guna2TextBox7.Text)
                            {
                                IDcuame = record.ID_Nguoi;
                                CMTme = 0;
                            }
                            if (record.SoCMND == guna2TextBox11.Text)
                            {
                                IDcuabo = record.ID_Nguoi;
                                CMTbo = 0;
                            }
                        }
                    }
                    #endregion

                    #region Neu ma chua co bo, them bo
                    if (CMTbo == 1)
                    {
                        //MessageBox.Show("tao moi bo");
                        using (var yteDbContext = new YTeDbContext())
                        {
                            ConNguoi bo = new ConNguoi();
                            yteDbContext.ConNguois.Add(bo);
                            bo.HoTen = guna2TextBox8.Text;
                            bo.NgheNghiep = guna2TextBox9.Text;
                            bo.SoDienThoai = guna2TextBox10.Text;
                            bo.NgaySinh = DateTime.Parse(guna2DateTimePicker3.Value.ToString());
                            bo.SoCMND = guna2TextBox11.Text;
                            bo.DiaChi = guna2TextBox13.Text;
                            bo.GioiTinh = 0;
                        try
                        {
                            yteDbContext.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Th??m m???i th???t b???i, ki???m tra l???i d??? li???u ???? nh???p!");
                            return;
                        }
                            IDcuabo = bo.ID_Nguoi;
                        }
                    }
                    #endregion

                    #region Neu ma chua co me, them me
                    if (CMTme == 1)
                    {
                        //MessageBox.Show("Tao moi me");
                        using (var db = new YTeDbContext())
                        {
                            ConNguoi me = new ConNguoi();
                            db.ConNguois.Add(me);
                            me.HoTen = guna2TextBox3.Text;
                            me.NgheNghiep = guna2TextBox4.Text;
                            me.SoDienThoai = guna2TextBox5.Text;
                            me.NgaySinh = DateTime.Parse(guna2DateTimePicker2.Value.ToString());
                            me.SoCMND = guna2TextBox7.Text;
                            me.DiaChi = guna2TextBox12.Text;
                            me.GioiTinh = 1;
                            try
                            {
                                db.SaveChanges();
                            }
                            catch
                            {
                                MessageBox.Show("Th??m m???i th???t b???i, ki???m tra l???i d??? li???u ???? nh???p!");
                                return;
                            }
                            IDcuame = me.ID_Nguoi;
                        }
                    }
                    #endregion

                    //Them 1 tre em
                    using (var db = new YTeDbContext())
                    {
                        TreEm tre = new TreEm();
                        db.TreEms.Add(tre);
                        tre.ID_Nguoi = CD1.IDtreem;
                        tre.MaTheBHYTe = guna2TextBox2.Text;
                        tre.ID_Bo = IDcuabo;
                        tre.ID_Me = IDcuame;
                        tre.ThongTinNguoiBaoTin = guna2TextBox14.Text;
                        db.SaveChanges();
                        CD1.IDtreem = tre.ID_TreEm;
                    }
                }
                #endregion
                co = true;
                CD1.Gioitinh = guna2ComboBox1.SelectedItem.ToString();
                CD1.born = DateTime.Parse(guna2DateTimePicker1.Value.ToString());
                //MessageBox.Show(CD1.IDtreem.ToString());
                CD1.Show();
            }
            else MessageBox.Show("Vui ki????m tra la??i th??ng tin!");

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HSTreSoSinh_Load(object sender, EventArgs e)
        {
            if (classify == 1)
            {
                //MessageBox.Show(treem.ID_TreEm.ToString());
                guna2TextBox1.Text = connguoi.HoTen;
                using (var context = new YTeDbContext())
                {
                    var bo = context.ConNguois.Where(b => b.ID_Nguoi == treem.ID_Bo).FirstOrDefault();
                    guna2TextBox8.Text = bo.HoTen;
                    guna2TextBox9.Text = bo.NgheNghiep;
                    guna2TextBox10.Text = bo.SoDienThoai;
                    guna2TextBox11.Text = bo.SoCMND;
                    guna2TextBox13.Text = bo.DiaChi;
                    guna2DateTimePicker3.Value = DateTime.Parse(bo.NgaySinh.ToString());


                    var me = context.ConNguois.Where(b => b.ID_Nguoi == treem.ID_Me).FirstOrDefault();
                    guna2TextBox3.Text = me.HoTen;
                    guna2TextBox4.Text = me.NgheNghiep;
                    guna2TextBox5.Text = me.SoDienThoai;
                    guna2TextBox7.Text = me.SoCMND;
                    guna2TextBox12.Text = me.DiaChi;
                    guna2DateTimePicker2.Value = DateTime.Parse(me.NgaySinh.ToString());

                    var BHYT = context.TreEms.Where(b => b.ID_TreEm == treem.ID_TreEm).FirstOrDefault();
                    guna2TextBox2.Text = BHYT.MaTheBHYTe;
                    guna2TextBox14.Text = BHYT.ThongTinNguoiBaoTin;
                    var GT = context.ConNguois.Where(b => b.ID_Nguoi == treem.ID_Nguoi).FirstOrDefault();
                    if (GT.GioiTinh == 0)
                    {
                        guna2ComboBox1.SelectedItem = "Nam";
                    }
                    else guna2ComboBox1.SelectedItem = "N????";
                    guna2DateTimePicker1.Value = DateTime.Parse(GT.NgaySinh.ToString());
                }
            }
        }
    }
}
