using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                do
                {
                    Console.Write("Nhap vao canh a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Nhap vao canh b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Nhap vao canh c: ");
                    c = int.Parse(Console.ReadLine());
                    if (a < 0 || b < 0 || c < 0 || a + b <= c || a + c <= b || b + c <= a)
                    {
                        Console.WriteLine("cac so phai lon hon 0 va 3 so phai la canh cua tam giac, vui long nhap lai");
                    }
                } while (a < 0 || b < 0 || c < 0 || a + b <= c || a + c <= b || b + c <= a);
                int p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Chu vi tam giac la: {p * 2} \nDien tich tam giac la: {s}");
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ky tu vua nhap vao khong phai la so nguyen, chuong trinh dung tai day, tam biet va hen gap lai!!!");
                Console.ResetColor();
                return;
            }

        }
    }
}
