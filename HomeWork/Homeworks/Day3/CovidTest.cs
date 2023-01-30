using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class CovidTest
    {
        public static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Do you have travel history?");
            answer = Console.ReadLine();
            if (answer == "no")
            {
                Console.WriteLine("You are Safe");
            }
            else if (answer == "yes")
            {
                Console.WriteLine("Do you have temperature?");
                answer = Console.ReadLine();
                if (answer == "no")

                    Console.WriteLine("Home Quarantine for 28 days");

                else if (answer == "yes")
                {
                    Console.WriteLine("Do you have cough or sneeze?");
                    answer = Console.ReadLine();
                    if (answer == "no")

                        Console.WriteLine("Quarantine fever medicine");

                    else if (answer == "yes")

                        Console.WriteLine("Swab Test");


                }
            }
        }
    }
}
