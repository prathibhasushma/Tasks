using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOops
{
    internal class implement_interface
    {
        class herbivores : Foodhabits_interface,Shelter_interface
        {
            public void fh()
            {
                Console.WriteLine("Eats plants");
            }
            public void shelter()
            {
                Console.WriteLine("They live under trees and burrows");
            }
            public int sum()
            {
                return 0;
            }


        }
        class carniovores : herbivores
        {
            public void display()
            {
                Console.WriteLine("It worked");
            }
        }
        public static void Main(string[] args)
        {
            carniovores herbs = new carniovores();
            herbs.fh();
             herbs.shelter();   
            herbs.sum();
            herbs.display();

        }

    }
}
