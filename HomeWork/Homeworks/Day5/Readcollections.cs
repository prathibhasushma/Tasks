using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Readcollections
    {
        public static void Main()
        {
            ArrayList dessert = new ArrayList();
            dessert.Add("Vanilla IceCream");
            dessert.Add("Brownie");
            dessert.Add("Gulab Jamun");
            dessert.Add("Cake");
            FileStream fs = new FileStream("D:\\Training and Learning\\HomeWork\\Homeworks\\Day5\\output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (object i in dessert)
                sw.WriteLine(i);
            sw.Flush();
            sw.Close();
            fs.Close();
            FileInfo info = new FileInfo("D:\\Training and Learning\\HomeWork\\Homeworks\\Day5\\output.txt");
            Console.WriteLine(info.CreationTime);
            Console.WriteLine(info.Length);
        }

    }
}
