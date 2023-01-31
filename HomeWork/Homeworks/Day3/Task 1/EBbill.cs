using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_task1_jan_20
{
    internal class EBbill
    {
        public void calculations(int units)
        {
            int pay;
            if (units <= 200)
            {
                pay = 2 * units;
                Console.WriteLine("Your bill is {0}", pay);
            }
            if (units > 200 && units < 350)
            {
                pay = 200 * 2 + (units - 200) * 3;
                Console.WriteLine("Your bill is {0}", pay);
            }
            if (units > 350 && units < 500)
            {
                pay = 200 * 2 + 150 * 3 + (units - 350) * 5;
                Console.WriteLine("Your bill is {0}", pay);
            }
            
        }
            public static void Main(string[] args)
            {
            EBbill cal = new EBbill();
            Console.WriteLine("Write no of units");
            int units = Convert.ToInt32(Console.ReadLine());
            cal.calculations(units);
            

            }
        
    }
}
