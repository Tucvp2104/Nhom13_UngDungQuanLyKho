using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyKho.Data;   
using QuanLyKho.Forms;
using System.Data.SqlClient;

namespace QuanLyKho.Forms
{
    public partial class GiaoDienChinh : Form
    {
        Ket_noi_CSDL db = new Ket_noi_CSDL();
        public GiaoDienChinh()
        {
            InitializeComponent();
        }
       
        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            KhoiDong();
        }
        private void buttTHEM_Click(object sender, EventArgs e)
        {
            Chi_tiet_hang_hoa frm = new Chi_tiet_hang_hoa(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                KhoiDong();
            }
        }
        void KhoiDong()
        {          
            string query = "SELECT * FROM HANG_HOA";
            divHienThi.DataSource = db.Lay_Du_Lieu(query);
           
            if (divHienThi.Columns["Gia_tien"] != null)
                divHienThi.Columns["Gia_tien"].DefaultCellStyle.Format = "N0"; 
        }

        private void buttSUA_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)divHienThi.CurrentRow.DataBoundItem;
            if (divHienThi.CurrentRow != null)
            {
                string maHH = row["MaHH"].ToString();                           
                Chi_tiet_hang_hoa frm = new Chi_tiet_hang_hoa(maHH);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    KhoiDong();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần sửa!");
            }
        }

        private void buttXOA_Click(object sender, EventArgs e)
        {
            if (divHienThi.CurrentRow != null)
            {
                DataRowView row = (DataRowView)divHienThi.CurrentRow.DataBoundItem;
                //string maHH = divHienThi.CurrentRow.Cells["MaHH"].Value.ToString();
                //string ten = divHienThi.CurrentRow.Cells["Ten"].Value.ToString();
                string maHH = row["MaHH"].ToString();
                string ten = row["Ten"].ToString();

                if (MessageBox.Show($"Bạn có chắc muốn xóa '{ten}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = "DELETE FROM HANG_HOA WHERE MaHH = @ma";
                    SqlParameter[] p = { new SqlParameter("@ma", maHH) };

                    if (db.Thuc_thi(query, p))
                    {
                        MessageBox.Show("Xóa thành công!");
                        KhoiDong();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần xóa!");
            }
        }

        private void buttThongKe_Click(object sender, EventArgs e)
        {
            Form statsForm = new Form { Text = "Biểu đồ Thống kê", Width = 900, Height = 600, StartPosition = FormStartPosition.CenterScreen };

            Chart chart = new Chart { Dock = DockStyle.Fill };
            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);
          
            chart.Titles.Add("Thống kê Số lượng và Giá tiền");
            chart.Legends.Add(new Legend("Legend"));
          
            Series seriesQty = new Series("Số Lượng") { ChartType = SeriesChartType.Column };
            Series seriesPrice = new Series("Giá Tiền (x1000)") { ChartType = SeriesChartType.Column };
           
            if (divHienThi.DataSource is DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string tenSP = row["Ten"].ToString();
                    int soLuong = Convert.ToInt32(row["So_luong"]);
                    decimal giaTien = Convert.ToDecimal(row["Gia_tien"]);

                    seriesQty.Points.AddXY(tenSP, soLuong);                   
                    seriesPrice.Points.AddXY(tenSP, giaTien / 1000);
                }
            }

            chart.Series.Add(seriesQty);
            chart.Series.Add(seriesPrice);

            statsForm.Controls.Add(chart);
            statsForm.ShowDialog();
        }
       
        private void textTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {           
                string keyword = textTimKiem.Text;
                string query = "SELECT * FROM HANG_HOA WHERE Ten LIKE @ten";
                SqlParameter[] p = { new SqlParameter("@ten", "%" + keyword + "%") };

                divHienThi.DataSource = db.Lay_Du_Lieu(query, p);
            }
        }
        private void divHienThi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {          
            if (divHienThi.Rows[e.RowIndex].Cells["coStt"] != null)
            {              
                divHienThi.Rows[e.RowIndex].Cells["coStt"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void divHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
