using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkproj
{
   
        public class NegativeAgeException : Exception
        {
            public NegativeAgeException()
            {
            }
            public NegativeAgeException(string message) : base(message)
            { }
        }
    internal class UserdefinedException
    {
        public void displayage()
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <0)
            {
                throw (new NegativeAgeException("Age can never be zero"));

            }
            else
            {
                Console.WriteLine(age);
            }
        }
        public static void Main(string[] args) 
        { 
            UserdefinedException userdefined= new UserdefinedException();   
            try
            {
                userdefined.displayage();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
        
    
}
