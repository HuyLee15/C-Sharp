using System;
using System.Collections.Generic;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> arr = new List<NhanVien>();

            arr.Add(new NhanVien("001", "Le Huy", 2001));
            arr.Add(new NhanVienHopDong("002", "Huy Le", 2002, 10, 2));
            arr.Add(new NhanVien("003", "Le Huy", 2000));
            arr.Add(new NhanVienHopDong("004", "Nhan Le", 2003, 20, 5));
            arr.Add(new NhanVienHopDong("005", "Vu Anh", 2006, 6, 20));
            arr.Add(new NhanVien("006", "Le Anh", 2001));

            string luachon = "";
            Console.Write("Nhap vao lua chon: ");
            luachon = Console.ReadLine();
            while (luachon != "n" )
            {
                if (luachon == "1")
                {
                    Console.Write("Nhap 1 de nhap thong tin nhan vien, 2 de nhap thong tin nhan vien hop dong: ");
                    string n = (Console.ReadLine());
                    if (n == "1")
                    {
                        Console.Write("Ma nhan vien: ");
                        string ma = Console.ReadLine();
                        Console.Write("Ten nhan vien: ");
                        string ten = Console.ReadLine();
                        Console.Write("Nam sinh cua nhan vien: ");
                        int nam = int.Parse(Console.ReadLine());
                        NhanVien a = new NhanVien(ma, ten, nam);
                        arr.Add(a);
                    }
                    else if (n == "2")
                    {
                        Console.Write("Ma nhan vien: ");
                        string ma = Console.ReadLine();
                        Console.Write("Ten nhan vien: ");
                        string ten = Console.ReadLine();
                        Console.Write("Nam sinh cua nhan vien: ");
                        int nam = int.Parse(Console.ReadLine());
                        Console.Write("So gio lam viec: ");
                        double gio = double.Parse(Console.ReadLine());
                        Console.Write("Luogn 1 gio: ");
                        double luong = double.Parse(Console.ReadLine());
                        NhanVienHopDong a = new NhanVienHopDong(ma, ten, nam, gio, luong);
                        arr.Add(a);
                    }
                    else Console.WriteLine("Nhap sai dinh dang!");
                }
                else if(luachon == "2")
                {
                    foreach(var item in arr)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if(luachon == "3")
                {
                    Console.Write("Moi nhap vao ma nhan vien muon xoa: ");
                    string id = (Console.ReadLine());
                    for (int i = 0; i < arr.Count; i++)
                        if (arr[i].MaNV == id) arr.RemoveAt(i);
                }
                else if(luachon == "4")
                {
                    Console.WriteLine("Hien thi thong tin truoc khi sap xep: ");
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Hien thi thong tin sau khi sap xep theo ten: ");
                    arr.Sort();
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (luachon == "5")
                {
                    Console.WriteLine("Hien thi thong tin truoc khi sap xep: ");
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item);
                    }
                    arr.Sort();
                    Console.WriteLine("Hien thi thong tin sau khi sap xep theo ten va nam sinh: ");
                    for (int i = 0; i < arr.Count - 1; i++)
                        for (int j = i + 1; j < arr.Count; j++)
                        {
                            if(String.Compare(arr[i].Ten, arr[j].Ten) == 0)
                            {
                                if (arr[i].NamSinh > arr[j].NamSinh)
                                {
                                    NhanVien tg = arr[i];
                                    arr[i] = arr[j];
                                    arr[j] = tg;
                                }
                            }
                        }
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (luachon == "6")
                {
                    int year = DateTime.Now.Year;
                    int max = arr[0].NamSinh;
                    foreach(var item in arr)
                    {
                        if (item.NamSinh > max) max = item.NamSinh;
                    }
                    Console.WriteLine("Danh sach nhan vien co tuoi cao nhat:");
                    foreach (var item in arr)
                    {
                        if (item.NamSinh == max) Console.WriteLine(item);
                    }
                }

                Console.Write("Nhan n de ket thuc chuong trinh: ");
                luachon = Console.ReadLine();
            }
        }
    }
}
