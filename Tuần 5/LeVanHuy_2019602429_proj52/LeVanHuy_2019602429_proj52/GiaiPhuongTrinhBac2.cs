using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj52
{
    class GiaiPhuongTrinhBac2
    {
        public int a { set; get; }
        public int b { set; get; }
        public int c { set; get; }
        public GiaiPhuongTrinhBac2()
        {

        }
        public GiaiPhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Giai()
        {
            if (a == 0)
            {
                Console.WriteLine("Day khong phai phuong trinh bac 2");
            }
            else
            {
                int delta = this.b * this.b - 4 * this.a * this.c;
                if (delta < 0) Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta == 0) Console.WriteLine($"Phuong trinh co nghiem kep la x1 = x2 = {(double)-b / (2 * a)}");
                else Console.WriteLine($"Phuong trinh co 2 nghiem phan biet la x1 = {(double)(-b + Math.Sqrt(delta)) / (2 * a)} va x2 = {(double)(-b - Math.Sqrt(delta)) / (2 * a)}");
            }

        }
    }
    
}
