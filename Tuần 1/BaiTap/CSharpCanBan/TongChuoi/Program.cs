using System;

namespace TongChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao n: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            double b = 0;
            for(int i=1; i<=n; i++)
            {
                a += i;
                b += 1.0 / i;
            }
            Console.WriteLine($"S = 1+2+3+...+n = {a}");
            Console.WriteLine($"S = 1 + 1/2 + 1/3 +...+ 1/n = {b}");
        }
    }
}
