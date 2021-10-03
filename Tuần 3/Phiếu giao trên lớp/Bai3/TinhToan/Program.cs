using System;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap vao so thuc a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Nhap vao so thuc b: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Nhap vao phep tinh: ");
                string pt = Console.ReadLine();
                if(pt == "+")
                {
                    Console.WriteLine($"{a} + {b} = {a + b}");
                }
                else if(pt == "-")
                {
                    Console.WriteLine($"{a} - {b} = {a - b}");
                }
                else if(pt == "*")
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
                else if(pt == "/")
                {
                    if (b == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nKhong thuc hien duoc phep chia cho 0  ");
                        Console.ResetColor();
                        return;
                    }
                    Console.WriteLine($"{a} / {b} = {a / b}");
                }
                else
                {
                    return;
                }
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                return;
            }

        }
    }
}
