using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao canh a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao canh c: ");
            float c = float.Parse(Console.ReadLine());
            if(a>0 && b>0 && c > 0)
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    float p = (a + b + c) / 2;
                    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"Chu vi tam giac la: {p * 2} \nDien tich tam giac la: {s}");
                }
                else
                {
                    Console.WriteLine("Day khong phai la 3 canh cua tam giac");
                }
                
            }
            else
            {
                Console.WriteLine("cac canh nhap vao phai lon hon 0 ");
            }
        }
    }
}
