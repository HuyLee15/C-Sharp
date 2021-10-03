using System;
using System.IO;
using System.Collections.Generic;

namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thao tac voi file");
            StreamReader sr = new StreamReader("ghifile.txt");
            List<SinhVien> sv = new List<SinhVien>();
            for(int i=0; ; i++)
            {
                if (sr.Peek() == -1)
                {
                    break;
                }


            }
        }
        

        struct SinhVien
        {
            public int id;
            public string ten;
            public string gt;
            public int tuoi;
            public double diemtoan;
            public double diemly;
            public double diemhoa;
            public double diemtb;
            public string hocluc;
        }
    }
}
