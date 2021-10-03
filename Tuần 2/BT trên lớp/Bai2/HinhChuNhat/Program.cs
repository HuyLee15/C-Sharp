using System;

namespace HinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao chieu dai: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao chieu rong: ");
            float b = float.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0) Console.WriteLine("Chieu dai hoac chieu rong khong hop le, vui long chay va nhap lai");
            else
            {
                Console.WriteLine($"Chu vi hinh chu nhat la: {(a + b) * 2}");
                Console.WriteLine($"Dien tich hinh chu nhat la: {a * b}");
            }
        }
    }
}
