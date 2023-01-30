using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class ArithmeticOperation
    {
        
        class set1
        {
            int result = 0;

            public void addition(int value1, int value2)
            {
               Console.WriteLine( result = value1 + value2);

            }
            public void subtraction(int value1, int value2)
            {
                Console.WriteLine( result = value1 - value2);
            }
        }
        class set2 :set1
        {
            float result = 0;
            public void multiplication(int value1, int value2)
            {
                Console.WriteLine(result = value1 * value2); 
            }
            public void division(int value1, int value2)
            {
                Console.WriteLine(result = value1 / value2);
            }
        }
        public static void Main(string[] args)
        {
            set2 obj = new set2();
            Console.WriteLine("Enter the values");
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select \n 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division");
            int i = Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case 1:
                    obj.addition(value1, value2);

                break;
                    case 2:
                    obj.subtraction(value1, value2);
                    break;
                case 3:
                    obj.multiplication(value1, value2);

                    break;
                    case 4:
                    obj.division(value1, value2);   
                    break;
                    default:
                    Console.WriteLine("Invalid option");
                    break;
            }
           
        }
    }
}
