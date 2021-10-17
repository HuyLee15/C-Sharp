using System;
using System.Collections.Generic;

namespace LeVanHuy_2019602429_proj61
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> sv = new List<Student>();
            string luachon = "";
            while(luachon != "6")
            {
                Console.Write("\nNhan 6 de ket thuc chuong trinh: ");
                luachon = Console.ReadLine();
                if (luachon == "1")
                {
                    Console.Write("Ho ten: ");
                    string name = Console.ReadLine();
                    Console.Write("Dia chi: ");
                    string address = Console.ReadLine();
                    Console.Write("Diem toan: ");
                    byte maths = byte.Parse(Console.ReadLine());
                    Console.Write("Diem ly: ");
                    byte physics = byte.Parse(Console.ReadLine());
                    Student a = new Student(name, address, maths, physics);
                    sv.Add(a);
                }
                else if (luachon == "2")
                {
                    foreach (Student item in sv)
                    {
                        item.Output();
                        Console.WriteLine();
                    }
                }
                else if (luachon == "3")
                {
                    Console.Write("Moi nhap vao id: ");
                    int id = int.Parse(Console.ReadLine());
                    foreach (Student item in sv)
                    {
                        if (item.id == id)
                        {
                            item.Output();
                            Console.WriteLine();
                        }
                    }
                }
                else if (luachon == "4")
                {
                    Console.Write("Moi nhap vao address: ");
                    string address = (Console.ReadLine());
                    foreach (Student item in sv)
                    {
                        if (item.address == address)
                        {
                            item.Output();
                            Console.WriteLine();
                        }
                    }
                }
                else if (luachon == "5")
                {
                    Console.Write("Moi nhap vao id: ");
                    int id = int.Parse(Console.ReadLine());
                    for (int i = 0; i < sv.Count; i++)
                        if (sv[i].id == id) sv.RemoveAt(i);
                }
                else if (luachon != "6") Console.WriteLine("Nhap sai dinh dang");
            }
        }
    }
}
