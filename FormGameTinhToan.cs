using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuongQuocTroChoi
{
    public partial class FormGameTinhToan : Form
    {
        public FormGameTinhToan()
        {
            InitializeComponent();
        }

        Random rd = new Random();
        double so1 ;
        double so2;
        int dau; // lưu dấu
        int diem ; // lưu số câu trả lời đúng
        double kqTamThoi; // Lưu kết quả tam thời.
        int laydungsai; // lấy ngẫu nhiên 1 đúng sai khi ra 1 câu hỏi.
        string chuoiketnoi = @"N:\VuongQuocTroChoi\NhacNen\";
        private void FormGameTinhToan_Load(object sender, EventArgs e)
        {
            // Load nhac nen
            SoundPlayer loadgame = new SoundPlayer(chuoiketnoi + "RenaiCirculation-HanazawaKana_36x8x.wav");
            loadgame.Play();


            lbldiem.Text = diem.ToString();
            // lấy random ngãu nhiên số và dấu
            so1 = rd.Next(1, 500);
            so2 = rd.Next(1, 500);
            dau = rd.Next(4);

            // gán giá trị cho số và dấu vào các control.
            lblso1.Text = so1.ToString();
            lblso2.Text = so2.ToString();
            string layDau = Dau(dau);
            lbldau.Text = layDau;

            lblketqua.Text = ketQuaDung().ToString();
            kqTamThoi = ketQuaDung();
        }

        // trả về dấy sau khi lấy random.
        public string Dau(int d)
        {
            if (d == 0)
                return "+";
            else if (dau == 1)
                return "-";
            else if (dau == 2)
                return "x";
            else 
                return "/";
        }

        public double ketQuaDung()
        {
            string daulayduoc = Dau(dau);
            if (daulayduoc == "+")
                return so1 + so2;
            if (daulayduoc == "-")
                return so1 - so2;
            if (daulayduoc == "x")
                return so1 * so2;
            if (daulayduoc == "/")
                return so1 / so2;
            return 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblthoigian.Text = lblthoigian.Text.Substring(1)
                + lblthoigian.Text.Substring(0, 1);
        }

        private SqlConnection cnn = null;
        private string cnstr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        int trangthai = 0; // kiểm tra xem đã lưu kết quả chưa.
        private void btnsai_Click(object sender, EventArgs e)
        {
            double a = ketQuaDung();
            if (a == kqTamThoi)
            {
                // Nhac khi thua.
                SoundPlayer loadgames = new SoundPlayer(chuoiketnoi + "fail-trombone-01.wav");
                loadgames.Play();

                MessageBox.Show("Chọn sai rồi nhé! \n Số câu trả lời đúng của bạn là: " + diem, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btndung.Enabled = btnsai.Enabled = false;
                //diem = 0; // cap nhat lai diem khi cho lai

                //Lưu kết quả khi kết thúc game
                cnn = new SqlConnection(cnstr);
                cnn.Open();
                string sql = "select * from ThongKeKetQua";
                SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                DataRow dr = ds.Tables[0].NewRow();
                dr["TenDangNhap"] = DangNhap.id;
                dr["TenTroChoi"] = "Thiên Tài Toán Học";
                dr["KetQua"] = diem.ToString();
                ds.Tables[0].Rows.Add(dr);
                SqlCommandBuilder cm = new SqlCommandBuilder(ad);
                ad.Update(ds);
                trangthai = 1;
            }
            else
            {
                diem++;
                lbldiem.Text = diem.ToString();
                so1 = rd.Next(1, 500);
                so2 = rd.Next(1, 500);
                dau = rd.Next(4);
                lblso1.Text = so1.ToString();
                lblso2.Text = so2.ToString();
                string layDau = Dau(dau);
                lbldau.Text = layDau;
                laydungsai = rd.Next(0, 4);
                double b = 0;
                if (laydungsai % 2 == 0)
                {
                    b = ketQuaDung();
                    lblketqua.Text = b.ToString();
                    kqTamThoi = ketQuaDung();
                }
                else
                {
                    b = rd.Next(0, 99999);
                    lblketqua.Text = b.ToString();
                }
            }

        }

        private void btndung_Click(object sender, EventArgs e)
        {
            double a = ketQuaDung();
            if( a == kqTamThoi)
            {
                
                diem++;
                lbldiem.Text = diem.ToString();

                so1 = rd.Next(1, 500);
                so2 = rd.Next(1, 500);
                dau = rd.Next(4);

                lblso1.Text = so1.ToString();
                lblso2.Text = so2.ToString();
                string layDau = Dau(dau);
                lbldau.Text = layDau;

                laydungsai = rd.Next(0,4);
                if(laydungsai % 2 == 0)
                {
                    kqTamThoi = ketQuaDung();
                    lblketqua.Text = kqTamThoi.ToString();
                }
                else
                {
                    kqTamThoi = rd.Next(0,9999);
                    lblketqua.Text = kqTamThoi.ToString();
                }
                    
                
            }
            else
            {
                // Nhac khi thua.
                SoundPlayer loadgame = new SoundPlayer(chuoiketnoi+ "fail-trombone-01.wav");
                loadgame.Play();
                MessageBox.Show("Chọn sai rồi nhé!\n Số câu trả lời đúng của bạn là: " + diem ,"Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btndung.Enabled = btnsai.Enabled = false;

                //Lưu kết quả khi kết thúc game
                cnn = new SqlConnection(cnstr);
                cnn.Open();
                string sql = "select * from ThongKeKetQua";
                SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                DataRow dr = ds.Tables[0].NewRow();
                dr["TenDangNhap"] = DangNhap.id;
                dr["TenTroChoi"] = "Thiên Tài Toán Học";
                dr["KetQua"] = diem.ToString();
                ds.Tables[0].Rows.Add(dr);
                SqlCommandBuilder cm = new SqlCommandBuilder(ad);
                ad.Update(ds);
                trangthai = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load nhac nen
         
            SoundPlayer loadgames = new SoundPlayer(chuoiketnoi + "button-3.wav");
            SoundPlayer loadgame = new SoundPlayer(chuoiketnoi+ "RenaiCirculation-HanazawaKana_36x8x.wav");
            loadgames.Play();
            loadgame.Play();
            // Gán lại giá trị khi chơi lại
            timer1.Start();
            diem = 0;
            btndung.Enabled = btnsai.Enabled = true;
            lbldiem.Text = "0";
            so1 = rd.Next(1, 999);
            so2 = rd.Next(1, 999);
            dau = rd.Next(4);
            lblso1.Text = so1.ToString();
            lblso2.Text = so2.ToString();
            string layDau = Dau(dau);
            lbldau.Text = layDau;
            lblketqua.Text = ketQuaDung().ToString();
            kqTamThoi = ketQuaDung();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            SoundPlayer loadgames = new SoundPlayer(chuoiketnoi + "button-3.wav");
            loadgames.Play();
            this.Close();

        }

        private void FormGameTinhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng ?", "Thông báo!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if(trangthai == 0)
                {
                    cnn = new SqlConnection(cnstr);
                    cnn.Open();
                    string sql = "select * from ThongKeKetQua";
                    SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["TenDangNhap"] = DangNhap.id;
                    dr["TenTroChoi"] = "Thiên Tài Toán Học";
                    dr["KetQua"] = diem.ToString();
                    ds.Tables[0].Rows.Add(dr);
                    SqlCommandBuilder cm = new SqlCommandBuilder(ad);
                    ad.Update(ds);
                }
                FormMenu fr = new FormMenu();
                fr.Show();
            }
        }

        private void lblthoigian_Click(object sender, EventArgs e)
        {

        }
    }
}
