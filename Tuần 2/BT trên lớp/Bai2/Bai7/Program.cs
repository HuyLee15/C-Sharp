using System;
using System.IO;

namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            filecoppy();
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