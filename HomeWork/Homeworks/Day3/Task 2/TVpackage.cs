using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_task1_jan_20
{
    internal class TVpackage
    {
        public void packageA()
        {
            Console.WriteLine("South Special,\nChildren's \nclub,Movies and the rate is 250");

        }
        public void packageB()
        {
            Console.WriteLine(" News,\n Sports,\n Movies,\n Regional -2 and the rate is 450");
        }
        public void packageC()
        {
            Console.WriteLine(" Discovery,\nHistory,\n National and the rate is 350");
        }
        public static void Main(string[] args)
        {
            TVpackage vpackage = new TVpackage();
            Console.WriteLine("Select your package A or B or C");
            string package = Console.ReadLine();
           
            switch (package)
            {
                case "A" :
                    vpackage.packageA();
                    break;
                case "B":
                    vpackage.packageB();    
                    break;  
                    case "C":
                    vpackage.packageC();
                    break;
                    default:
                    Console.WriteLine("Please select the right package");
                    break;
            }

            
                
        }
    }
}
