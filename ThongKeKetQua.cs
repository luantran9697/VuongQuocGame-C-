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
using System.Configuration;

namespace VuongQuocTroChoi
{
    public partial class ThongKeKetQua : Form
    {
        public ThongKeKetQua()
        {
            InitializeComponent();
        }

        private SqlConnection cnn = null;
        private string cnstr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        private void ThongKeKetQua_Load(object sender, EventArgs e)
        {
           
            cnn = new SqlConnection(cnstr);
            cnn.Open();
            string sql = "select * from ThongKeKetQua";
            SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dt.Clear();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                // Duyet lịch sử chơi theo tên người dùng hiện tại để hiện kết quả lên.
                if(dr["TenDangNhap"].ToString() == DangNhap.id)
                {
                    DataRow d = dt.NewRow();
                    d["TenDangNhap"] = dr["TenDangNhap"];
                    d["TenTroChoi"] = dr["TenTroChoi"];
                    d["KetQua"] = dr["KetQua"];
                    dt.Rows.Add(d);
                }
            }
            dgvthongke.DataSource =  dt;
        }

        private void ThongKeKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormMenu f = new FormMenu();
            f.Show();
        }

        private void dgvthongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnquay_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu mn = new FormMenu();
            mn.Show();
        }
    }
}
