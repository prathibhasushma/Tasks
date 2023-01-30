using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkproj
{
    internal class Collection1
    {
        public static void Main(string[] args)
        {
            ArrayList li1= new ArrayList(); // ArrayList is a class under collections namespace that stores an array of different data type
            li1.Add(1);
            li1.Add("Two");
            li1.Add("Three");
            li1.Add(4.003);
            foreach (object obj in li1)
            Console.WriteLine(obj);
        }


    }
}
