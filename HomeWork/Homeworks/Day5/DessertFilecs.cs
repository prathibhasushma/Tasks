using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task_6
{
    internal class DessertFilecs
    {
        public static void Main()
        {
            ArrayList dessert = new ArrayList();
            dessert.Add("Vanilla IceCream");
            dessert.Add("Brownie");
            dessert.Add("Gulab Jamun");
            dessert.Add("Cake");
            FileStream fs = new FileStream("D:\\Training and Learning\\Git Project\\HomeWork\\Homeworks\\Day5\\output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            FileInfo info = new FileInfo("D:\\Training and Learning\\Git Project\\HomeWork\\Homeworks\\Day5\\output.txt");
            sw.WriteLine(info.CreationTime);
            sw.WriteLine(info.Length);
            foreach (object i in dessert)
                sw.WriteLine(i);
            sw.Flush();
            sw.Close();
            fs.Close();
            //FileInfo info = new FileInfo("D:\\Training and Learning\\HomeWork\\Homeworks\\Day5\\output.txt");
            //sw.WriteLine(info.CreationTime);
            //sw.WriteLine(info.Length);
        }
    }
}

