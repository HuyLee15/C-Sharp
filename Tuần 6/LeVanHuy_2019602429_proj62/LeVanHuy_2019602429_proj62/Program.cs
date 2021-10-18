using System;
using System.Collections.Generic;

namespace LeVanHuy_2019602429_proj62
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> arr = new List<Vehicle>();
            int luachon = 0;
            while(luachon != 7)
            {
                Console.Write("Nhap vao lua chon: ");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        arr.Add(new Car("Veh01", "HuyLee", "BWM", 2020, 100000, "Blue"));
                        arr.Add(new Car("Veh02", "Felix", "Audi", 2021, 200000, "Black"));
                        arr.Add(new Car("Veh03", "LeeHuy", "ConCho", 2010, 300000, "White"));

                        arr.Add(new Truck("Veh04", "LeeHuy", "ConCho", 2022, 300000, 3));
                        arr.Add(new Truck("Veh05", "Felix", "ConMeo", 2019, 340000, 5));
                        arr.Add(new Truck("Veh06", "HuyLee", "ConGa", 2018, 305000, 2));
                        break;
                    case 2:
                        foreach(var item in arr)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        Console.Write("Nhap vao id muon tim: ");
                        string id = Console.ReadLine();
                        Vehicle v = new Vehicle(id);
                        int index = arr.IndexOf(v);
                        if (index == -1) Console.WriteLine("Khong tim thay ");
                        else Console.WriteLine(arr[index]);
                        break;
                    case 4:
                        Console.Write("Nhap vao maker muon tim: ");
                        string maker = Console.ReadLine();
                        int count = 0;
                        foreach (var item in arr)
                        {
                            if (item.maker == maker) count++;
                        }
                        if (count > 0)
                        {
                            foreach (var item in arr)
                            {
                                if (item.maker == maker) Console.WriteLine(item);
                            }
                        }
                        else Console.WriteLine("Khong tin thay");
                        break;
                    case 5:
                        Console.WriteLine("Danh sach truoc khi sap xep: ");
                        foreach (var item in arr)
                        {
                            Console.WriteLine(item);
                        }
                        arr.Sort();
                        Console.WriteLine("Danh sach sau khi sap xep theo price: ");
                        foreach (var item in arr)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Danh sach truoc khi sap xep: ");
                        foreach (var item in arr)
                        {
                            Console.WriteLine(item);
                        }
                        arr.Sort(new CompareToYear());
                        Console.WriteLine("Danh sach sau khi sap xep theo year: ");
                        foreach (var item in arr)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        if(luachon != 7) Console.WriteLine("Nhap sai dinh dang");
                        break;
                }
            }
        }
    }
}
