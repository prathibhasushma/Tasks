 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class dessertCollection
    {
        public static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("Brownie");
            arr.Add("Vannila ice cream");
            arr.Add("chocolate truffel");
            arr.Add("Gulab jamun");
            arr.Add("Rasagulla");
            foreach(object obj in arr)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
