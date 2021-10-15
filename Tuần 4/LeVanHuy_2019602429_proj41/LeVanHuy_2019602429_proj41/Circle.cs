using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj41
{
    class Circle
    {
        public double r { set; get; }
        public Circle() { }
        public Circle(double x)
        {
            this.r = x;
        }
        public double Area()
        {
            return Math.PI * r * r;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * r;
        }
    }
}
