using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models
{
    public class Nguoi_dung
    {
        public string Ten { get; set; }
        public string Matkhau { get; set; }
        public string Email { get; set; }
        public Nguoi_dung() { }
        public Nguoi_dung(string ten, string matkhau, string email)
        {
            this.Ten = ten;
            this.Matkhau = matkhau;
            this.Email = email;
        }
    }
}
