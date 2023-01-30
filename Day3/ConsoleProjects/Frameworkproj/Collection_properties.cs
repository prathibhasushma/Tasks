using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkproj
{
    internal class Collection_properties
    {
        public static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("Two");
            arr.Add(3);
            arr.Add("Four");
            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }
            ArrayList arr2 = new ArrayList();   
            arr2.Add("Gulab jamun");
            arr2.Add("Mysuru pa");
            arr2.Add("rasamalai");
            foreach (object obj in arr2)
            {
                Console.WriteLine(obj);
            }
            arr.AddRange(arr2);//Appends the arr2 into arr1
            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
                Console.WriteLine("************************************");
            }
            arr.Remove("Gulab jamun");
            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }
            arr.RemoveAt(0);
            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }
            arr.Insert(0, 1);
            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
