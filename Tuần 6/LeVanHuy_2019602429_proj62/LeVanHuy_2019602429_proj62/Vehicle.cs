using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj62
{
    class Vehicle : IVehicle, IComparable
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string id)
        {
            this.id = id;
        }
        public Vehicle(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public  virtual void Input()
        {
            Console.Write("id: "); this.id = Console.ReadLine();
            Console.Write("id: "); this.maker = Console.ReadLine();
            Console.Write("id: "); this.model = Console.ReadLine();
            Console.Write("id: "); this.year = int.Parse(Console.ReadLine());
            Console.Write("id: "); this.price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.Write($" \t{this.id} \t{this.maker} \t{this.model} \t{this.year} \t{this.price}");
        }
        public override string ToString()
        {
            return String.Format("{0, -8}{1, -10}{2, -25}{3, 10}{4,10}", this.id, this.maker, this.model, this.year, this.price);
        }
        public override bool Equals(object obj)
        {
            Vehicle v = (Vehicle)obj;
            return this.id.Equals(v.id);
        }

        public int CompareTo(object obj)
        {
            Vehicle v = (Vehicle)obj;
            return this.price.CompareTo(v.price);
        }
    }
    class CompareToYear : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            return x.year - y.year;
        }
    }
}
