using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj61
{
    class Student:Person
    {
        public byte maths { get; set; }
        public byte physics { get; set; }
        public Student() : base()
        {

        }
        public Student(string name, string address, byte maths, byte physics):base(name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }
    /*    public override void Input(string name, string address, byte maths, byte physics)
        {
            base.Input(name, address);
            this.maths = maths;
            this.physics = physics;
        }
    */
        public override void Output()
        {
            base.Output();
            Console.Write($" \t{this.maths} \t{this.physics} \t{this.tongDiem()}");
        }
        public int tongDiem()
        {
            return this.maths + this.physics;
        }
    }
    
}
