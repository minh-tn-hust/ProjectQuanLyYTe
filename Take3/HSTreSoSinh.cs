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
        ChiSoTreCon chisotrecon;
        ConNguoi connguoi;
        public HSTreSoSinh(TreEm treem, ChiSoTreCon chisotrecon, ConNguoi connguoi)
        {
            InitializeComponent();
            guna2TextBox1.Text = connguoi.HoTen;
            using (var context = new YTeDbContext())
            {
                var bo = context.ConNguois.Where(b => b.ID_Nguoi == treem.ID_Bo).FirstOrDefault();
                if (guna2TextBox8 != null) guna2TextBox8.Text = bo.HoTen;
                if (guna2TextBox9 != null) guna2TextBox9.Text = bo.NgheNghiep;
                if (guna2TextBox10 != null) guna2TextBox10.Text = bo.SoDienThoai;
                if (guna2TextBox11 != null) guna2TextBox11.Text = bo.SoCMND;
                if (guna2TextBox13 != null) guna2TextBox13.Text = bo.DiaChi;

                var me = context.ConNguois.Where(b => b.ID_Nguoi == treem.ID_Me).FirstOrDefault();
                guna2TextBox3.Text = me.HoTen;
                guna2TextBox4.Text = me.NgheNghiep;
                guna2TextBox5.Text = me.SoDienThoai;
                guna2TextBox7.Text = me.SoCMND;
                guna2TextBox12.Text = me.DiaChi;

                var BHYT = context.TreEms.FirstOrDefault();
                guna2TextBox2.Text = BHYT.MaTheBHYTe;
                var GT = context.ConNguois.Where(b => b.ID_Nguoi == treem.ID_Nguoi).FirstOrDefault();
                if (GT.GioiTinh == 0)
                {
                    guna2ComboBox1.SelectedItem = "Nam";
                }
                else guna2ComboBox1.SelectedItem = "Nữ";
            }
        }



        public void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem != null  && guna2TextBox2.Text != "" && guna2TextBox7.Text.Length <=13 && guna2TextBox11.Text.Length <= 13 && guna2TextBox2.Text.Length <=15 )
            {
                CDTreSoSinh CD1 = new CDTreSoSinh();
                bool co = false;
                string ktBHYT = guna2TextBox2.Text;
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

                        //bug của chị ở đây là cmnd không được trùng, ví dụ chị chèn một thằng không có cmnd rồi thì khôn ghtể chèn được thằng thứ 2 không có thử xem qua csdl nhé
                        }

                        catch
                        {
                            MessageBox.Show("Không thêm con người được");
                            return;
                        }
                    }

                    // Kiem tra xem da co bo me chua
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

                    //Neu ma chua co bo, them bo
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
                            MessageBox.Show("Thêm mới thất bại, kiểm tra lại dữ liệu đã nhập!");
                            return;
                        }
                            IDcuabo = bo.ID_Nguoi;
                        }
                    }

                    //Neu ma chua co me, them me
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
                                MessageBox.Show("Thêm mới thất bại, kiểm tra lại dữ liệu đã nhập!");
                                return;
                            }
                            IDcuame = me.ID_Nguoi;
                        }
                    }

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
                co = true;
                CD1.Gioitinh = guna2ComboBox1.SelectedItem.ToString();
                CD1.born = DateTime.Parse(guna2DateTimePicker1.Value.ToString());
                CD1.Show();
            }
            else MessageBox.Show("Vui kiểm tra lại thông tin!");

        }
    }
}
