using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_task2_jan_21
{
    internal class Calculator
    {
        abstract class Declaration

        {
            public abstract void add(int num1, int num2);
            
            public abstract void subtract(int num1, int num2);
            public abstract void multiply(int num1, int num2);
            public abstract void division(int num1, int num2);

        }
        class Calculations :Declaration
        {
            int res = 0;
            public override void add(int num1, int num2)
            {
                res = num1 + num2;
                Console.WriteLine("The sum is ",res);
            }
            public override void subtract(int num1, int num2)
            {
                Console.WriteLine("The difference is", res = num1 - num2);
            }
            public override void multiply(int num1, int num2)
            {
                Console.WriteLine("The product is ", num1 * num2);
            }
            public override void division(int num1, int num2)
            {

                Console.WriteLine("The quotient is ", num1 / num2);
            }
        }
        public static void Main(string[] args)
        {
            Calculations calc = new Calculations();
            Console.WriteLine("Enter two nos");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division");
            int select = Convert.ToInt32(Console.ReadLine());
            switch(select)
            {
                case 1:
                    {
                        calc.add(num1, num2);
                        break;
                    }
                case 2:
                    {
                        calc.subtract(num1, num2);
                        break;
                    }
                case 3:
                    {
                        calc.multiply(num1, num2);
                        break;
                    }
                    case 4:
                    {
                        calc.division(num1, num2);  
                        break;
                    }
            }
        }

    }
}
