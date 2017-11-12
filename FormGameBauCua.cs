using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Media;
using System.Configuration;

namespace VuongQuocTroChoi
{
    public partial class FormGameBauCua : Form
    {
        public FormGameBauCua()
        {
            Thread t = new Thread(new ThreadStart(VuongQuocTroChoi));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        private void VuongQuocTroChoi()
        {
            Application.Run(new Form1());
        }

        Random rd = new Random();
        string duongdan = Application.StartupPath + @"\Hinh\";
        string chuoiketnoi = @"N:\VuongQuocTroChoi\NhacNen\"; // đường dẫn đến nhạc
        int dem = 0;
        int tienconlai = 1000; // lưu số tiền còn lại của người chơi
        int trangthai = 0; // xác định xem kết quả đã save hay chưa.

        private SqlConnection cnn = null;
        private string cnstr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        private void btnquay_Click(object sender, EventArgs e)
        {
            int tien = Convert.ToInt16(txttiencuoc.SelectedItem.ToString());
            if( tienconlai == 0)
            {
                // nhạc khi thua.
                SoundPlayer loadgame = new SoundPlayer(chuoiketnoi+ "ChocoboRacingLose-HoaTau-3316610.wav");
                loadgame.Play();
                if (MessageBox.Show("Tiền cược của bạn đã hết!\n Bạn có muốn chơi lại?", "Thông báo!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Load lại nhạc nền
                    SoundPlayer loadgam = new SoundPlayer(chuoiketnoi + "CungHyCungHyCungHyBan-LongPhieuPhieu-4744108.wav");
                    loadgam.Play();

                    tienconlai = 1000;
                    txttiencuoc.SelectedIndex = 0;
                    cbchon.SelectedIndex = 0;
                    pic1.Image = pic2.Image = pic3.Image = Image.FromFile(duongdan + "0.jpg");
                    lbltienconlai.Text = tienconlai.ToString();

                    // Lưu kết quả khi kết thúc trò chơi.
                    cnn = new SqlConnection(cnstr);
                    cnn.Open();
                    string sql = "select * from ThongKeKetQua";
                    SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["TenDangNhap"] = DangNhap.id;
                    dr["TenTroChoi"] = "Game Bầu Cua";
                    dr["KetQua"] = tienconlai.ToString();
                    ds.Tables[0].Rows.Add(dr);
                    SqlCommandBuilder cm = new SqlCommandBuilder(ad);
                    ad.Update(ds);
                    trangthai = 1;
                }
                else
                    txttiencuoc.SelectedIndex = 0;
            }
            //else if( tien == 0)
            //{
            //    MessageBox.Show("Bạn chưa nhập tiền cược", "Thông báo!", MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //}
            else if (tien > tienconlai)
            {
                MessageBox.Show("Tiền cược không thể lớn hơn tiền còn lại", "Thông báo!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                int a = rd.Next(0, 6);
                int b = rd.Next(0, 6);
                int c = rd.Next(0, 6);
                pic1.Image = Image.FromFile(duongdan + a.ToString() + ".jpg");
                pic2.Image = Image.FromFile(duongdan + b.ToString() + ".jpg");
                pic3.Image = Image.FromFile(duongdan + c.ToString() + ".jpg");
                if (cbchon.SelectedIndex == a)
                    dem++;
                if (cbchon.SelectedIndex == b)
                    dem++;
                if (cbchon.SelectedIndex == c)
                    dem++;
                if (dem == 0)
                {
                    tienconlai -= int.Parse(txttiencuoc.SelectedItem.ToString());
                    lbltienconlai.Text = tienconlai.ToString();
                    dem = 0;
                }
                if (dem != 0)
                {
                    tienconlai += (dem * int.Parse(txttiencuoc.SelectedItem.ToString()));
                    lbltienconlai.Text = tienconlai.ToString();
                    dem = 0;
                }
            }
        }
 
        private void FormGameBauCua_Load(object sender, EventArgs e)
        {
            // Nhạc nền game
            SoundPlayer loadgame = new SoundPlayer(chuoiketnoi + "CungHyCungHyCungHyBan-LongPhieuPhieu-4744108.wav");
            loadgame.Play();

            cbchon.SelectedIndex = 0;
            lbltienconlai.Text = tienconlai.ToString();
            txttiencuoc.SelectedIndex = 0;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            SoundPlayer loadgames = new SoundPlayer(chuoiketnoi + "button-3.wav");
            loadgames.Play();
            this.Close();
        }

        private void FormGameBauCua_FormClosing(object sender, FormClosingEventArgs e)
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
                    dr["TenTroChoi"] = "Game Bầu Cua";
                    dr["KetQua"] = tienconlai.ToString();
                    ds.Tables[0].Rows.Add(dr);
                    SqlCommandBuilder cm = new SqlCommandBuilder(ad);
                    ad.Update(ds);
                }
                FormMenu fr = new FormMenu();
                fr.Show();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblthoigian.Text = lblthoigian.Text.Substring(1)
               + lblthoigian.Text.Substring(0, 1);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbchon_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(duongdan+ cbchon.SelectedIndex.ToString()+".jpg");
        }
    }
}
