using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKho.Data
{
    public class Ket_noi_CSDL
    {
        private string StringConnec = @"Data Source=SQL1004.site4now.net;Initial Catalog=db_ac2d79_quanlyhh;User Id=db_ac2d79_quanlyhh_admin;Password=Mcdonal123";
        public bool KiemTraKetNoi()
        {
            try
            {
                using (SqlConnection Ketnoi = new SqlConnection(StringConnec))
                {
                    Ketnoi.Open();
                    return true;
                }
            }
            catch { return false; }
        }
        public DataTable Lay_Du_Lieu(string query, SqlParameter[] param = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Ketnoi = new SqlConnection(StringConnec))
                {
                    Ketnoi.Open();
                    SqlCommand cmd = new SqlCommand(query, Ketnoi);
                    if (param != null) cmd.Parameters.AddRange(param);
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(dt);
                }
            }catch (Exception ) 
            {
                MessageBox.Show("Mất kết nối Server");
            }
            return dt;
        }
        public bool Thuc_thi(string query, SqlParameter[] param)
        {
            try
            {
                using (SqlConnection Ketnoi = new SqlConnection (StringConnec))
                {
                    Ketnoi.Open();
                    SqlCommand cmd = new SqlCommand(query, Ketnoi);
                    if (param != null) cmd.Parameters.AddRange(param);
                    cmd.ExecuteNonQuery();
                    return true;
                }    
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu" +ex.Message);
                return false;
            }
        }
    }
}
