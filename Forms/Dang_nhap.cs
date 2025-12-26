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
using QuanLyKho.Data;
using QuanLyKho.Security;

namespace QuanLyKho.Forms
{
    public partial class Dang_nhap : Form
    {
        Ket_noi_CSDL Ket_noi_CSDL = new Ket_noi_CSDL();
        public Dang_nhap()
        {
            InitializeComponent();
            textMK.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttDN_Click(object sender, EventArgs e)
        {
            string Ten_DN = textTenDN.Text;
            string Mat_khau = Bao_Mat.Mahoa(textMK.Text);
            string query = "SELECT * FROM NGUOI_DUNG WHERE Ten =@u AND Matkhau = @p";
            SqlParameter[] p =
            {
                new SqlParameter("@u", Ten_DN),
                new SqlParameter("@p", Mat_khau)
            };
            DataTable dt = Ket_noi_CSDL.Lay_Du_Lieu(query, p);
            if (dt.Rows.Count > 0)
            {
                GiaoDienChinh main = new GiaoDienChinh();
                main.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            }        
        }

        private void buttDK_Click(object sender, EventArgs e)
        {
            Dang_ky DK = new Dang_ky();
            DK.ShowDialog();
        }

        private void Dang_nhap_Load(object sender, EventArgs e)
        {

        }
    }
}
