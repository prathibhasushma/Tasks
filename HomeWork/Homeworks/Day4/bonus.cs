using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class bonus

    {
        public void calculatebonus(int salary)
        {
            double bonuses,totalsalary;
            Console.WriteLine("Do you belong to 1.Sales and marketing \n 2.Production");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    bonuses = salary * 0.2;
                    totalsalary = salary + bonuses;

                    Console.WriteLine(totalsalary); 
                    break;
                case 2:

                    bonuses = salary * 0.1;
                    totalsalary = salary + bonuses;

                    Console.WriteLine(totalsalary);
                    break;
            }
        }
        class result : bonus
        {



            public static void Main(string[] args)
            {
                result obj = new result();
                Console.WriteLine("Enter your id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your gender");
                string gender = Console.ReadLine();
                Console.WriteLine(" Years of experience");
                double exp = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                obj.calculatebonus(salary);


            }
        }
    }
}
