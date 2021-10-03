using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao chuoi: ");
            string s = Console.ReadLine();
            if (doixung(s)) Console.WriteLine($"Chuoi {s} la chuoi doi xung");
            else Console.WriteLine($"Chuoi {s} khong phai chuoi doi xung");
        }
        static bool doixung(string s1)
        {
            int i;
            int n = s1.Length;
            for (i = 0; i < n / 2; i++)
            {
                if (s1[i] != s1[n - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
