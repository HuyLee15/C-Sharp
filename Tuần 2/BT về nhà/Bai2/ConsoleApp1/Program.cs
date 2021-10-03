using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ThanhPho = new List<string>();
            ThanhPho.Add("Ha Noi");
            ThanhPho.Add("HCM");
            ThanhPho.Add("Hai Phong");
            ThanhPho.Add("Da Nang");
            ThanhPho.Add("Can Tho");
            ThanhPho.Sort();
            foreach (string i in ThanhPho)
            {
                Console.WriteLine($"\t{i}");
            }
            ThanhPho.Remove("Ha Noi");
            ThanhPho.Add("Hai Duong");
            ThanhPho.Add("Son La");
            ThanhPho.Add("Hung Yen");
            ThanhPho.Add("Thanh Hoa");
            ThanhPho.Add("Bac Ninh");
            Console.WriteLine("Xoa thanh pho Ha Noi va them 5 thanh pho khac:");
            foreach (string i in ThanhPho)
            {
                Console.WriteLine($"\t{i}");
            }
        }
    }
}
