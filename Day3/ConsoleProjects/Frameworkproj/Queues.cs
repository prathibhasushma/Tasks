using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Frameworkproj
{
    internal class Queues
    {
        public static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Enqueue("Vannila");
            q1.Enqueue("Butterscotch");
            q1.Enqueue("Chocolate");
            q1.Enqueue("Mango");
            //for (int i = 0;i<q1.Count;i++)//count of q1 gets decremented everytime it deques inside a for loop
            //{
            //    Console.WriteLine(q1.Dequeue());    
            //}
            //Console.WriteLine("***************************************");
            for (int i = 0;i<4;i++)
            {
                Console.WriteLine(q1.Dequeue());
            }
            foreach(object o in q1)
                Console.WriteLine(q1.Peek());
        }
    }
}
