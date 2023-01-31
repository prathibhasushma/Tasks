using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_task3_jan_23
{
    internal class Readcollections
    {
        public static void Main()
        {
            ArrayList dessert = new ArrayList();
            dessert.Add("Brownie");
            dessert.Add("Vannila ice cream");
            dessert.Add("chocolate truffel");
            dessert.Add("Gulab jamun");
            dessert.Add("Rasagulla");
            FileStream fs = new FileStream("D:\\Training and Learning\\Git Project\\HomeWork\\Homeworks\\Day5\\output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (object i in dessert)
                sw.WriteLine(i);
            sw.Flush();
            sw.Close();
            fs.Close();
            FileInfo info = new FileInfo("D:\\Training and Learning\\Git Project\\HomeWork\\Homeworks\\Day5\\output.txt");
            Console.WriteLine(info.CreationTime);
            Console.WriteLine(info.Length);
        }

    }
}
