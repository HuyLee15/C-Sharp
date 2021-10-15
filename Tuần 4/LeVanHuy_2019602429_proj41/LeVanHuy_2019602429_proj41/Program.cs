using System;

namespace LeVanHuy_2019602429_proj41
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            a.Input();
            Console.WriteLine(a);
            a.CheckAge();

            Console.WriteLine("\n\n");
            
            Circle x = new Circle();
            Console.WriteLine($"Ban kinh cua hinh tron x la: {x.r}\n");

            Circle y = new Circle(4);
            Console.WriteLine($"Ban kinh cua hinh tron y la: {y.r}");
            Console.WriteLine($"Dien tich cua hinh tron y la: {y.Area()}");
            Console.WriteLine($"Chu vi cua hinh tron y la: {y.Perimeter()}");

            Console.WriteLine("\n\n");

            Student m = new Student();
            Console.WriteLine($"Thong tin sinh vien m (khoi tao khong tham so): {m}");
            Student n = new Student("Sv001");
            Console.WriteLine($"Thong tin sinh vien n (khoi tao co tham so id): {n}");
            Student p = new Student("Sv002", "Huy", 9);
            Console.WriteLine($"Thong tin sinh vien p (khoi tao co tat ca tham so): {p}");
        }
    }
}
