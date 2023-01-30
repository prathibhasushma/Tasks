using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    
    internal class objectinitialize
    {
        public string name;
        public int age;
       public objectinitialize(int age,string name)
        {
            this.age = age;
            this.name = name;
            
        }
        public void display()
        {
            Console.WriteLine("The name is {0} and the age is {1}", name, age);
        }
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Your age");
            int sage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your name");
            string sname = Console.ReadLine();
            objectinitialize obj = new objectinitialize(sage, sname);
            obj.display();

        }
    }
}
