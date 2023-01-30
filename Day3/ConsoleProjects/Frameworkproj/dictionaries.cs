using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkproj
{
    internal class dictionaries
    {
        public static void Main(string[] args)
        {
            Dictionary<int,string > dic = new Dictionary<int,string>();
            dic.Add(1, "Prathibha");
            dic.Add(2, "boomica");
            dic.Add(3, "vignesh");
            dic.Add(4, "Pragadeesh");
            foreach (object item in dic)
            {
                Console.WriteLine(item);
            }
        }
    }
}
