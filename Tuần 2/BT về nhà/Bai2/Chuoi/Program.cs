using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string a = Console.ReadLine();
            for(int i=0; i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            a = a.Trim();
            while(a.Contains("  "))
            {
                a = a.Replace("  ", " ");
            }
            Console.WriteLine(a);
        }
    }
}
