using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class NhanVienHopDong:NhanVien
    {
        public double SoGio { get; set; }
        public double Luong1H { get; set; }
        public NhanVienHopDong() : base()
        {

        }
        public NhanVienHopDong(string ma, string ten, int nam, double gio, double luong):base(ma, ten, nam)
        {
            this.SoGio = gio;
            this.Luong1H = luong;
        }
        public override string ToString()
        {
            return String.Format("{0, -8}{1, -10}{2, -10}{3, -10}{4, -10}", this.MaNV, this.Ten, this.NamSinh, this.SoGio, this.Luong1H);
        }
    }
}
