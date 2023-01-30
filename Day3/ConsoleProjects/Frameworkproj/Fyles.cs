using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkproj
{
    internal class Fyles
    {
        public void write2file()
        {
            //Filestream is a class generated in system.io namespace and has upto 10 parameters 
            //out of which three are compulsory
            // first parameter = file path
            //second parameter = file mode whether to open or create if the file does or does not exist
            //third parameter = file access is to read or write
            FileStream fs1 = new FileStream(@"D:\Training and Learning\Day3\samples.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs1);
            bw.Write("Hello World");
            bw.Flush();
            bw.Close();
            fs1.Close();



        }
        public void Readfromfile()
        {
            FileStream fs = new FileStream(@"D:\Training and Learning\Day3\samples.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(br.ReadString());

        }
            // public void r2file()
            //{
            //    FileStream fs = new FileStream(@"D:\Training and Learning\Day3\ample.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //    StreamWriter sw = new StreamWriter(fs);
            //    sw.Write("Republic Day celebration");
            //    sw.Flush();
            //    sw.Close();
            //    fs.Close(); 

            // }
            //public void rfFile()
            //{
            //    FileStream fs = new FileStream(@"D:\Training and Learning\Day3\ample.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //    StreamReader sr = new StreamReader(fs);
            //    sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //    string str = sr.ReadToEnd();
            //    Console.WriteLine(str);

            //}

            public static void Main(string[] args)
        {
            Fyles f = new Fyles();
            f.write2file();
           // f.r2file();
            //f.rfFile();
            f.Readfromfile();
            //FileInfo info = new FileInfo("D:\\Training and Learning\\Day3\\ConsoleProjects\\ConsoleOops\\Abstcls.cs");
            //Console.WriteLine(info.FullName);
            //Console.WriteLine(info.Length);
            //Console.WriteLine(info.CreationTime);
            //Console.WriteLine(info.LastAccessTime);
            //DriveInfo dir = new DriveInfo("C");
            //Console.WriteLine(dir.DriveType);
            //Console.Write(dir.AvailableFreeSpace);
            //Console.WriteLine(dir.Name);
            //Console.WriteLine(dir.DriveFormat);
            //DirectoryInfo infor = new DirectoryInfo("C:\\Windows");
            //foreach (DirectoryInfo d in infor.GetDirectories())
            //{ 
            //    Console.WriteLine(d.ToString());
            //}
        }
    }
    
}
