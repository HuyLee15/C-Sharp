using System;
using System.IO;

namespace TapTin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thao tac voi file");
            StreamReader sr = new StreamReader("ghifile.txt");

            string[] n = File.ReadAllLines("ghifile.txt");
            sr.Close();
            for(int i=0; i<n.Length; i++)
            {
                n[i] = n[i].Trim().ToUpper();
            }
            string st = string.Join(" ", n);
            string[] arr = st.Split(" ");
            int dem = arr.Length;
            StreamWriter sw = new StreamWriter("ghifile2.txt", false);
            foreach (string item in n)
            {
                sw.WriteLine(item);
            }
            sw.WriteLine($"File co {dem} tu");

            sw.Close();
        }
    }
}
