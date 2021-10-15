using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj41
{
    class Person
    {
        private string id { get; set; }
        private string name { set; get; }
        private int age { set; get; }
        private string email { set; get; }
        private string address { set; get; }

        public void CheckAge()
        {
            if (this.age >= 18) Console.WriteLine("Ban du tuoi bau cu");
            else Console.WriteLine("Ban con non lam, nhok!!");
        }
        public void Input()
        {
            Console.Write("id: "); this.id = Console.ReadLine();
            Console.Write("name: "); this.name = Console.ReadLine();
            Console.Write("age: "); this.age = int.Parse(Console.ReadLine());
            Console.Write("email: "); this.email = Console.ReadLine();
            Console.Write("address: "); this.address = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"id: {this.id};\tname: {this.name};\tage: {this.age};\temail: {this.email};\taddress: {this.address}.";
        }

    }
}
