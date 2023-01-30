using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class TaxCalculation
    {
        
        class set1
        {
            
            public void calculatetax(int price)
            {
               Console.WriteLine("the VAT is {0}" , price * 0.2);
            }
        }
        class set2 : set1
        {
           

            public void calculatetax(int price)

            {

                Console.WriteLine("the GST is {0}", price * 0.12); 
            }
        }
        public static void Main(string[] args)

        {
            int price;

            Console.WriteLine("Enter your Price");
            price = Convert.ToInt32(Console.ReadLine());

            set2 taxCalculation = new set2();
       
            taxCalculation.calculatetax(price);
                


        }
    }
}
