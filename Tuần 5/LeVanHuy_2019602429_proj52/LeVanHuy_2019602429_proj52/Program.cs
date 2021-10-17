using System;
using System.Collections.Generic;

namespace LeVanHuy_2019602429_proj52
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee nv = new Employee();
            nv.Input();
            nv.Output();
            GiaiPhuongTrinhBac2 a = new  GiaiPhuongTrinhBac2(0, 2, -3);
            a.Giai();

            */
            List<TimUSCLN> arr = new List<TimUSCLN>();
            Console.Write("Nhap vao so phan tu cua doi tuong: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                arr.Add(nhap());
            }
            foreach(TimUSCLN item in arr)
            {
                Console.WriteLine($"{item.so1} va {item.so2} co UCLN la: {UCLN(item.so1, item.so2)}");
            }
        }

        private static TimUSCLN nhap()
        {
            TimUSCLN x = new TimUSCLN();
            Console.Write("\tSo thu nhat: ");
            x.so1 = int.Parse(Console.ReadLine());
            Console.Write("\tSo thu hai: ");
            x.so2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return x;
        }
        private static int UCLN(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b; // a = a - b
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
    }
}
