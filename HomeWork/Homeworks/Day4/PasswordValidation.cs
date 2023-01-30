using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class PasswordValidation
    {
        string emailid = "Prathibhasushmanv@gmail.com";
        string password = "Prathibhasushma";
        long membershipid = 1084;
        long pin = 123456;
        long Mobileno = 6383962275;
        int pins = 1234;

        public void Validate(string id, string pword)
        {
            if (id == emailid && pword == password)
            {
                Console.WriteLine("Your are Logged in");
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }

        }
        public void Validate(long memid, long pinn)
        {
            if (memid == membershipid && pinn == pin)
            {
                Console.WriteLine("Your are Logged in");
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }

        }
        public void Validate(long mobno, int pinss)
        {
            if (mobno == Mobileno && pinss == pins)
            {
                Console.WriteLine("Your are Logged in");
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }

        }
        public static void Main(string[] args)
        {
            PasswordValidation sr = new PasswordValidation();
            Console.WriteLine("Enter 1.MailId 2.MembershipId 3.MobileNumber");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Console.WriteLine("Enter your mailid");
                    string id = Console.ReadLine();
                    Console.WriteLine("Enter your password");
                    string pword = Console.ReadLine();
                    sr.Validate(id,pword);
                    break;
                case 2:
                    Console.WriteLine("Enter your membershipid");
                    long memid = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter your Pin");
                    long pinn = Convert.ToInt64(Console.ReadLine());    
                    sr.Validate(memid,pinn);
                    break;
                case 3:
                    Console.WriteLine("Enter Your Mobile Number");
                    long mobno = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter your pin");
                    int pinss = Convert.ToInt32(Console.ReadLine());    
                    sr.Validate(mobno,pinss);
                    break;
            }
        }
    }
}
