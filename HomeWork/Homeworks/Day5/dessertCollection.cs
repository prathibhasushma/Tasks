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
            arr.Add("Gulab Jamun");
            arr.Add("Rasagulla");
            arr.Add("Rasamalai");
            arr.Add("Brownie");
            arr.Add("Cake");
            foreach(object obj in arr)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
