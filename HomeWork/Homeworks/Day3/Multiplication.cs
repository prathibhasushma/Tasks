using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Multiplication
    {
        public void multiply(int num)
        {
            int i = 0,res = 0;
            while (i<=20)
            {
                res = num * i;
                Console.WriteLine("{0} * {1} = {2}",num,i,res);
                i++;
            }
        }
        public static void Main(string[] args) 
        { 
            Multiplication multiplication = new Multiplication();
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());  
            multiplication.multiply(num);
        }

       
    }
}
