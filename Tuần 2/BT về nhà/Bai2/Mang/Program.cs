using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao kich thuoc cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n]; 
            for(int i = 0; i<n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            int max = a[0], min = a[0], sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i]; 
            }
            Console.WriteLine($"So lon nhat la {max}, so nho nhat la {min} va tong gia tri cua mang la {sum}");
        }
    }
}
