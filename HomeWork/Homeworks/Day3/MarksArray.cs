using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class MarksArray
    {
        public static void Main(string[] args)
        {
            int[] marks = new int[5];
            Console.WriteLine("Enter your marks in:1.English,2.Maths,3.Science,4.Social,5.Tamil");
            int total = 0, avg = 0;
            foreach (int i in marks)
            {
             marks[i] = Convert.ToInt32(Console.ReadLine());
                total = total + marks[i];

            }
            avg = total / marks.Length;
            Console.WriteLine("The total is {0} and the average is {1}", total, avg);
           
        }
    }
}
