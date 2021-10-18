using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj62
{
    class Truck:Vehicle
    {
        public int truckload { get; set; }
        public Truck() : base()
        {

        }
        public Truck(string id, string maker, string model, int year, double price, int truckload) : base(id, maker, model, year, price)
        {
            this.truckload = truckload;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Truckload: ");
            this.truckload = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.Write($" \t{this.truckload}");
        }
        public override string ToString()
        {
            return String.Format("{0, -8}{1, -10}{2, -10}{3, 5}{4, 10}{5, 10}", this.id, this.maker, this.model, this.year, this.price, this.truckload);
        }
    }
}
