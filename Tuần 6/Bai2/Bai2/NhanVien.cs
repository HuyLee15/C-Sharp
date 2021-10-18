using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class NhanVien:IComparable
    {
        public string MaNV { get; set; }
        public string Ten { get; set; }
        public int NamSinh { get; set; }
        public NhanVien()
        {

        }
        public NhanVien(string ma, string ten, int nam)
        {
            this.MaNV = ma;
            this.Ten = ten;
            this.NamSinh = nam;
        }
        public override string ToString()
        {
            return String.Format("{0, -8}{1, -10}{2, -10}", this.MaNV, this.Ten, this.NamSinh);
        }

        public int CompareTo(object obj)
        {
            NhanVien v = (NhanVien)obj;
            return this.Ten.CompareTo(v.Ten);
        }
    }
    class CompareToYear : IComparer<NhanVien>
    {
        public int Compare(NhanVien x, NhanVien y)
        {
            return x.NamSinh - y.NamSinh;
        }
    }
}
