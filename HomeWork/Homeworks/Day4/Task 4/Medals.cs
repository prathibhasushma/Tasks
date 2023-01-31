using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_task2_jan_21
{
    internal class Medals
    {
        abstract class Winners
        {
            public abstract void silver();
            public abstract void gold();
            public abstract void platinum();
        }
        class Accomodation : Winners
        {
            public override void silver()
            {
                Console.WriteLine("3 days accomodation at resort");
            }
            public override void gold()
            {
                Console.WriteLine(" 5 days accomodation at a resort and a dinners on the house");
            }

            public override void platinum()
            {
                Console.WriteLine("7 days accomodation at the resort and 5 days dinner on the house");
            }
        }
        public static void Main(string[] args)
        {
            Accomodation m = new Accomodation();
            Console.WriteLine("Enter your medal");
            string medal = Console.ReadLine();
            switch (medal)
            {
                case "gold": 
                    {
                        m.gold();
                        break;
                    }
                case "silver":
                    {
                        m.gold(); break;    
                    }
                case "platinum":
                    { m.platinum(); break; }
                default:
                    Console.WriteLine("Get your medal");
                    break;
            }

        }

    }
}
