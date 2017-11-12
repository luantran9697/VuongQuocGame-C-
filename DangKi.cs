using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.Configuration;

namespace VuongQuocTroChoi
{
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

       
        SqlConnection cnn = null;
        string cnstr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        string chuoiketnoi = @"N:\VuongQuocTroChoi\NhacNen\";
        private void btndangki_Click(object sender, EventArgs e)
        {
            SoundPlayer loadgames = new SoundPlayer(chuoiketnoi + "button-3.wav");
            loadgames.Play();
            cnn = new SqlConnection(cnstr);
            cnn.Open();
            string sql = "select * from DangKiTaiKhoan";
            SqlDataAdapter ad = new SqlDataAdapter(sql,cnn);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            int trangthai = 0; // tai khoan chua duoc dang ki
            if (txttendangki.Text == "" || txtpassdangki.Text == "" || txtho.Text == "" || txtten.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "")
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin để đăng kí", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if(txtpassdangki.Text.Length < 8)
                MessageBox.Show("Mật khẩu ít nhất 8 kí tự", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else
            {

                foreach (DataRow d in ds.Tables[0].Rows)
                {
                    if (d["TenDangNhap"].ToString() == txttendangki.Text)
                    {
                        trangthai = 1;
                    }
                }
                if (trangthai == 0)
                {
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["TenDangNhap"] = txttendangki.Text;
                    dr["Password"] = txtpassdangki.Text;
                    dr["Ho"] = txtho.Text;
                    dr["Ten"] = txtten.Text;
                    dr["SoDienThoai"] = txtsdt.Text;
                    dr["DiaChi"] = txtdiachi.Text;

                    ds.Tables[0].Rows.Add(dr);

                    SqlCommandBuilder cm = new SqlCommandBuilder(ad);
                    ad.Update(ds);

                    if (MessageBox.Show("Đăng kí thành công!\nQuay lai đăng nhập!", "Thông báo", MessageBoxButtons.OK,
               MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        DangNhap dn = new DangNhap();
                        this.Hide();
                        dn.Show();
                    }
                }
                else if (trangthai == 1)
                {
                    MessageBox.Show("Tên tài khoản đã được đăng kí !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            SoundPlayer loadgames = new SoundPlayer(chuoiketnoi + "button-3.wav");
            loadgames.Play();
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
