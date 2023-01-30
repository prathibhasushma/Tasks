//A Plain Old CLR Objects (POCO) is a class, which doesn't depend on any framework-specific base class. It is like any other normal .
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkproj
{
    internal class Pococlass
    {
        public int Studid { get; set; }
        public string? name { get; set; } // ? is used to say that name can or cannot be declared if not declared take it as null
        public int age { get; set; }
        public Pococlass(int Studid, string? name, int age) 
        { 
            this.name = name;
            this.age = age; 
            this.Studid = Studid;

        }

        public static void Main(string[] args)
        {
            Pococlass p = new Pococlass(1,"Prathibha",22);
            //p.Studid = 1;
            //p.name = "Prathibha";
            //p.age = 22;
            Console.WriteLine("Student id is {0} and name is {1} and age is {2} years old", p.Studid, p.name, p.age);
        }
    }
}
