using System;
using System.IO;
namespace DemoDirectoryInforClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Admin\Documents\PRN211_HE151190\Slot 12_File_System.IO");
            Console.WriteLine("Search pattern demo* returns:");
            foreach (var fi in di.GetDirectories("demo*")) 
            {
                Console.WriteLine(fi.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Search pattern TopDirectoryOnly returns:");
            foreach(var fi in di.GetFiles("*.cs", SearchOption.TopDirectoryOnly))
            {
                Console.WriteLine(fi.Name);
            }
            Console.ReadLine();
        }
    }
}
