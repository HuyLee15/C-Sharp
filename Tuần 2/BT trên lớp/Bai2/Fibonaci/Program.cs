using System;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = 0;
            arr[1] = 1;
            for(int i=2; i<n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            for (int i = 0; i < n; i++) Console.Write($"\t{arr[i]}");
            Console.WriteLine("");
            Console.WriteLine("Con day la day fibonaci de quy ne: ");
            for (int i = 0; i < n; i++) Console.Write($"\t{fibonaci(i+1)}");
        }
        
        static int fibonaci(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;
            return fibonaci(n - 1) + fibonaci(n - 2);
        }
    }
}
