using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class UserLogin
    {
        public void UserCredentials(string emailid, string password)
        {
            Console.WriteLine("OptionA");
        }
        public void UserCredentials(int empid,int pin)
        {
            Console.WriteLine("OptionB");
        }
        public void UserCredentials(long mobilenumber,int pin)
        {
            Console.WriteLine("OptionC");
        }
        public static void Main(string[] args)
        {
            UserLogin userLogin = new UserLogin();
            Console.WriteLine("Enter your credentials");
            var parameter1 = Console.ReadLine();
            var parameter2 = Console.ReadLine();    
            userLogin.UserCredentials(parameter1, parameter2);
        }
    }
}
