using System;

namespace Demo_consle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Readline(), Read(), ReadKey()
            Console.Write("Nhap vao ho ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap vao tuoi: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name} {age} tuoi!");
        }
    }
    class MyClass
    {

    }
}
