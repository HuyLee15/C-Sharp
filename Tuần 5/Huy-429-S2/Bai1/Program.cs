using System;
using System.Collections.Generic;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nguoi> arr = new List<Nguoi>();
            string luachon = "";
            Console.Write("Nhap vao 1 de nhap thong tin nguoi, nhap 2 de nhap thong tin cong nhan, nhap ky tu khac de ket thuc chuong trinh: ");
            luachon = Console.ReadLine();
            while(luachon == "1" || luachon == "2")
            {
                if(luachon == "1")
                {
                    Console.Write("Ho ten: ");
                    string HoTen = Console.ReadLine();
                    Console.Write("Gioi tinh: ");
                    string GioiTinh = Console.ReadLine();
                    Console.Write("Nam sinh: ");
                    int NamSinh = int.Parse(Console.ReadLine());
                    Nguoi a = new Nguoi(HoTen,GioiTinh,NamSinh);
                    arr.Add(a);

                }
                else
                {
                    Console.Write("Ho ten: ");
                    string HoTen = Console.ReadLine();
                    Console.Write("Gioi tinh: ");
                    string GioiTinh = Console.ReadLine();
                    Console.Write("Nam sinh: ");
                    int NamSinh = int.Parse(Console.ReadLine());
                    Console.Write("So gio lam viec: ");
                    double SoGio = double.Parse(Console.ReadLine());
                    Console.Write("Tien luong 1 gio: ");
                    double Luong1H = double.Parse(Console.ReadLine());
                    CongNhan y = new CongNhan(HoTen, GioiTinh, NamSinh, SoGio, Luong1H);
                    arr.Add(y);
                }
                Console.Write("Nhap vao 1 de nhap thong tin nguoi, nhap 2 de nhap thong tin cong nhan, nhap ky tu khac de hien thi danh sach: ");
                luachon = Console.ReadLine();
            }
            foreach(Nguoi item in arr)
            {
                item.Output();
                Console.WriteLine();
            }
        }
    }
}
