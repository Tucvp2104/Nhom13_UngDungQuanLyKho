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

namespace QuanLyKho.Forms
{
    public partial class Chi_tiet_hang_hoa : Form
    {
        string _maHH;
        Ket_noi_CSDL db = new Ket_noi_CSDL();
        public Chi_tiet_hang_hoa()
        {
            InitializeComponent();
            _maHH = null; 
            this.Text = "Thêm hàng hóa mới";
        }
        public Chi_tiet_hang_hoa(string maHH)
        {
            InitializeComponent();
            _maHH = maHH;
            this.Text = "Cập nhật hàng hóa";
        }
        private void Chi_tiet_hang_hoa_Load(object sender, EventArgs e)
        {
            if (_maHH != null) 
            {
                textMaHH.Enabled = false; 
                LoadData();
            }
        }
        void LoadData()
        {
            string query = "SELECT * FROM HANG_HOA WHERE MaHH = @id";
            SqlParameter[] p = { new SqlParameter("@id", _maHH) };
            DataTable dt = db.Lay_Du_Lieu(query, p);

            if (dt.Rows.Count > 0)
            {
                textMaHH.Text = dt.Rows[0]["MaHH"].ToString();
                textTen.Text = dt.Rows[0]["Ten"].ToString();
                textLoai.Text = dt.Rows[0]["Loai"].ToString();              
                textGia.Text = string.Format("{0:0.##}", dt.Rows[0]["Gia_tien"]);
                textSoLuong.Text = dt.Rows[0]["So_luong"].ToString();
                textTinhTrang.Text = dt.Rows[0]["Tinh_trang"].ToString();
            }
        }
        private void buttLuu_Click(object sender, EventArgs e)
        {           
            if (string.IsNullOrEmpty(textMaHH.Text) || string.IsNullOrEmpty(textTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên hàng hóa!");
                return;
            }

            string query = "";
            SqlParameter[] p =
            {
                new SqlParameter("@ma", textMaHH.Text),
                new SqlParameter("@ten", textTen.Text),
                new SqlParameter("@loai", textLoai.Text),
                new SqlParameter("@gia", textGia.Text), 
                new SqlParameter("@sl", textSoLuong.Text),
                new SqlParameter("@tt", textTinhTrang.Text)
            };
            
            if (_maHH == null)
            {
               
                query = "INSERT INTO HANG_HOA (MaHH, Ten, Loai, Gia_tien, So_luong, Tinh_trang) " +
                        "VALUES (@ma, @ten, @loai, @gia, @sl, @tt)";
            }
            else
            {               
                query = "UPDATE HANG_HOA SET Ten=@ten, Loai=@loai, Gia_tien=@gia, " +
                        "So_luong=@sl, Tinh_trang=@tt WHERE MaHH = @ma";
            }
           
            if (db.Thuc_thi(query, p))
            {
                MessageBox.Show("Lưu thành công!");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }
      
        private void buttHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

