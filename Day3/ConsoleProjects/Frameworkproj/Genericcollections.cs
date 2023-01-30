using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkproj
{
    internal class Genericcollections
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();//class inside the collections namespace
            list.Add("Black Forest");
            list.Add("White Forest");
            list.Add("chocolate truffle");
            list.Add("Brownie");
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            LinkedList<int> lst = new LinkedList<int>();
            lst.AddFirst(100);
            var nnode = lst.AddLast(200);
            var pnode = lst.AddLast(2000);
            lst.AddBefore(nnode, 466);
            lst.AddAfter(pnode, 200);
            foreach (int items in lst)
            {
                Console.WriteLine(items);
            }


        }
    }
}
