using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj52
{
    class Employee
    {
        const double PRICE = 50;
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int workingdays { get; set; }
        public double salary { 
            get 
            {
                return (double)workingdays * PRICE;
            }
        }
        public void Input()
        {
            Console.Write("Nhap vao id: ");
            this.id = Console.ReadLine();
            Console.Write("Nhap vao ten: ");
            this.name = Console.ReadLine();
            Console.Write("Nhap vao tuoi: ");
            this.age = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao ngay cong: ");
            this.workingdays = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"\t{this.id} \t{this.name} \t{this.age} \t{this.workingdays} \t{this.salary}");
        }
    }
}
