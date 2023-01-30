using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOops
{
    internal class Abstcls
    {
        abstract class Food
        {
            public abstract void foodrestriction();
        }
        class diabetes:Food
        {
            public override void foodrestriction()
            {
                Console.WriteLine("Avoid Carbohydrates");
            }
            public void Diabeteswelcome()
            {
                Console.WriteLine("Welcome to the club");
            }  
        }
        class cardiac:Food
        {
            public override void foodrestriction()
            {
                Console.WriteLine("Avoid Fried items");
            }
        }
        public static void Main(string[] args)  
        {
            cardiac dobj = new cardiac(); 
            dobj.foodrestriction();
            
        }
    }
}
