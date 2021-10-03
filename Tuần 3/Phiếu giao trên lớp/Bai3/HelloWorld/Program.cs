using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap vao so nguyen a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap vao so nguyen b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
