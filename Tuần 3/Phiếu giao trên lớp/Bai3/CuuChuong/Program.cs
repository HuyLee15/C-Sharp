using System;

namespace CuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In ra bang cuu chuong");
            for(int i=1; i<10; i++)
            {
                for(int j=1; j<10; j++)
                {
                    Console.Write($"\t{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
