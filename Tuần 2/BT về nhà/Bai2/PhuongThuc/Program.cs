using System;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhap vao so phan tu cua mang n: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nHien thi so nguyen to cua mang n: ");
            for (int i = 0; i < n; i++)
            {
                if (isPrimeNumber(arr[i])) Console.Write($"\t{arr[i]}");
            }

        }
        static Boolean isPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return false;
            }
            // check so nguyen to khi n >= 2
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
