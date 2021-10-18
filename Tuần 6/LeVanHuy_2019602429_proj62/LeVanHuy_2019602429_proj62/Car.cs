using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj62
{
    class Car:Vehicle
    {
        public string color { get; set; }
        public Car():base()
        {

        }
        public Car(string id, string maker, string model, int year, double price, string color):base(id, maker, model, year, price)
        {
            this.color = color;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Color: ");
            this.color = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.Write($" \t{this.color}");
        }
        public override string ToString()
        {
            return String.Format("{0, -8}{1, -10}{2, -10}{3, 5}{4, 10}{5, 10}", this.id, this.maker, this.model, this.year, this.price, this.color);
        }
    }

}
