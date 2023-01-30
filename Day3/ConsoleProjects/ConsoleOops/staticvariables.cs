using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOops
{
    internal class staticvariables
    {
        int num1;
        static int num2;
        public staticvariables()
        {
            num1 = 0;
            num2 = 100;

        }
        public void counter()
        {
            Console.WriteLine(num1++);

        }
        public static void counter2()
        {
            Console.WriteLine(++num2);
        }
        public static void Main(string[] args)
        {
            staticvariables var = new staticvariables();
            var.counter();//prints 0 because its post increment operator
            var.counter();
            var.counter();
            counter2();//prints 1 because pre increment operator
            counter2();


        }
     

    }
     
}
