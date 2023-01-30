using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Frameworkproj
{
    internal class Fyle
    {
        public void write2file()
        {
            //Filestream is a class generated in system.io namespace and has upto 10 parameters 
            //out of which three are compulsory
            // first parameter = file path
            //second parameter = file mode whether to open or create if the file does or does not exist
            //third parameter = file access is to read or write
            FileStream fs1 = new FileStream(@"D:\Training and Learning\Day3\sample.txt",FileMode.OpenOrCreate,FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs1);
            bw.Write("Hello World");
            bw.Flush();
            bw.Close();
            fs1.Close();
           
            

        }
        public static void Main(string[] args)
        {
            Fyle f1 = new Fyle();
            f1.write2file();
        }
    }
}
