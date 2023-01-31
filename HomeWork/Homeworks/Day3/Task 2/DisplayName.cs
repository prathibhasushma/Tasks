using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_task1_jan_20
{
    internal class DisplayName
    {
        public void display(string name,int age)
        {
            
            while (age>0)
            {
                Console.WriteLine(name);
                age--;

            }

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            DisplayName dis = new DisplayName();
            dis.display(name,age);

           
            
        }

    }
}
