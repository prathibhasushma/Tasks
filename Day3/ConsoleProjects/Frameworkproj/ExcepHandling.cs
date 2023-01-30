//Exception Handling is used to avoid abortion of program when its user side mistake of giving wrong input
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkproj
{
    internal class ExcepHandling
    {
        public static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 0;
            int res = 0;
            try
            {
                res = num1 / num2;

            }
            catch(Exception ex) // Exception is a class that is present in a namespace that is a base class
            {
                Console.WriteLine(ex.Message);  //Prints the error message
            }
            finally
            {
                Console.WriteLine(res);
            }
        }
    }
}
