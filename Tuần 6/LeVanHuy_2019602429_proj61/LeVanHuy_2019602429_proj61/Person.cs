using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj61
{
    class Person
    {
        public int id { set; get; }
        static int count = 0;
        public string name { get; set; }
        public string address { get; set; }
        public Person()
        {
            count++;
        }
        public Person(string name, string address)
        {
            count++;
            this.id = count;
            this.name = name;
            this.address = address;
        }
    /*    public virtual void Input(string name, string address)
        {
            this.id++;
            this.name = name;
            this.address = address;
        }
    */
        public virtual void Output()
        {
            Console.Write($"\t{this.id} \t{this.name} \t\t{this.address}");
        }
    }
    
}
