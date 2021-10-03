using System;
using System.IO;

namespace TapTin
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("ghifile.txt");
            int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            int[,] arr = new int[a, b];
            for(int i=0; i<a; i++)
                for(int j=0; j<b; j++)
                {
                    arr[i,j] = int.Parse(sr.ReadLine());
                }
            sr.Close();
            Console.WriteLine($"{a}  {b}");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"\t{arr[i, j]}");
                }
            }
            int sum = 0;
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                {
                    sum += arr[i, j];
                }
            StreamWriter sw = new StreamWriter("ghifile.txt", true);
            sw.WriteLine($"\nGhi noi tong cua cac phan tu trong ma tran: {sum}");
            sw.Close();
            
        }
        static void filecoppy()
        {
            //ghi file
            StreamWriter sw = new StreamWriter("ghifile.txt");
            sw.WriteLine("Chung toi danh tien hanh ghi file");
            sw.Close();
            //doc file
            StreamReader sr = new StreamReader("ghifile.txt");
            string x = sr.ReadLine();
            Console.WriteLine("Thong tin trong file ghi la:" + x);
            //ghi sang file khac
            StreamWriter cp = new StreamWriter("filemoi.txt");
            cp.WriteLine("Chung toi danh tien hanh coppy file" + x);
            cp.Close();
        }
    }
}
