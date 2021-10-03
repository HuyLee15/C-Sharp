using System;

namespace Giaithua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            int gt = 1;
            if (n < 0) Console.WriteLine("Nhap lai n (n>=0)");
            else if (n == 0) Console.WriteLine($"Giai thua cua {n} la 1");
            else
            {
                for(int i=1; i<=n; i++)
                {
                    gt *= i;
                }
                Console.WriteLine($"Giai thua cua {n} la {gt}");
                Console.WriteLine($"Giai thua cua {n} nhung tinh theo de quy la {deQuy(n)}");
            }
        }
        static int deQuy(int n)
        {
            if (n == 1) return 1;
            else return n * deQuy(n - 1);
        }
    }
}
