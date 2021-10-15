using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeVanHuy_2019602429_proj41
{
    class Student
    {
        public string id { set; get; }
        public string name { set; get; }
        public int mark { set; get; }
        public int scholarship { set; get; }
        
        public Student() { }    
        public Student(string id)
        {
            this.id = id;
        }
        public Student(string id, string name, int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
            if (mark > 8) this.scholarship = 500;
            else if (mark >= 7) this.scholarship = 300;
            else this.scholarship = 0;
        }
        public override string ToString()
        {
            return $"id: {this.id};\tname: {this.name};\tmark: {this.mark};\tscholarship: {this.scholarship}.";
        }
    }
}
