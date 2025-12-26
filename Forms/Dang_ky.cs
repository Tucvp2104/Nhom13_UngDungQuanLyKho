using QuanLyKho.Data;
using QuanLyKho.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.Forms
{
    public partial class Dang_ky : Form
    {
        Ket_noi_CSDL Ket_noi_CSDL = new Ket_noi_CSDL();
        public Dang_ky()
        {
            InitializeComponent();
        }

        private void buttDK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textTenDN.Text) || string.IsNullOrEmpty(textEmail.Text))
            {
                MessageBox.Show("Vui lòng không bỏ trống các thông tin");
                return;
            }    
            if (textPass.Text != textRePass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng nhập lại");
                return;
            }    
            string MaHoaMatKhau = Bao_Mat.Mahoa(textPass.Text);
            string query = "INSERT INTO NGUOI_DUNG (Ten, Matkhau, Email) VALUES (@u, @p, @e)";
            SqlParameter[] p =
            {
                new SqlParameter("@u", textTenDN.Text),
                new SqlParameter("@p", MaHoaMatKhau),
                new SqlParameter("@e", textEmail.Text)
            }; 
            if (Ket_noi_CSDL.Thuc_thi(query, p))
            {
                MessageBox.Show("Đăng ký thành công");
                this.Close();   
            }    
        }
    }
}
