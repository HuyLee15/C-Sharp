using System;

namespace HeCoSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuyen doi tu he 10 sang he 2! ");
            Console.Write("Nhap vao so N cua he co so 10: ");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine($"So {n} cua he co so 10 chuyen sang he co so 2 la: {Convert.ToString(n,2)}");
            Console.WriteLine("Chuyen doi tu he 2 sang he 10!");
            Console.Write("Nhap vao so N cua he co so 2: ");
            n = long.Parse(Console.ReadLine());
            long i = 0, sum = 0, temp;
            while (n > 0)
            {
                temp = n % 10;
                n /= 10;
                sum += temp*binhphuong(i);
                i++;
            }
            Console.WriteLine($"Chuyen do he co so 10 chuyen sang he co so 2 la: {sum}");
        }
        static long binhphuong(long n)
        {
            if (n == 0) return 1;
            if (n == 1) return 2;
            long s = 2;
            for(int i=2; i<=n; i++)
            {
                s = s * 2;
            }
            return s;
        }
    }
}
