using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models
{
    public class Hang_hoa
    {
        public string MaHH { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public decimal Gia_tien { get; set; }
        public int So_luong { get; set; }
        public DateTime Ngay_nhap_kho { get; set; }
        public DateTime Ngay_xuat_kho { get; set; }
        public string Tinh_trang { get; set; }
        public string HienThiGia
        {
            get { return string.Format("{0:N0} VND", Gia_tien); }
        }
    }
}
