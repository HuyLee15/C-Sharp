using System;

namespace CanBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so a: ");
            double a = double.Parse(Console.ReadLine());
            if (a == 0) Console.Write($"Can bac 2 cua {a} la: 1");
            else Console.Write($"Can bac 2 cua {a} la: {epsilon(a)}");
        }
        static double epsilon(double number)
        {
            double ep = 0.0001f;
            double result = 1.0f;
            while (Math.Abs(result * result - number) / number >= ep)
                result = (number / result - result) / 2 + result;
            return result;
        }
    }
}
