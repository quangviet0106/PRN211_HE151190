using System;
using System.IO;
namespace DemoStreamWriterAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string fileName = @"MyData.txt";
            Console.WriteLine("*****Demo StreamWriter and StreamReader*****\n");
            //Get a StreamWriter and write string data.
            using StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine("Hello");
            writer.WriteLine("World");
            writer.WriteLine("!");
            for(int i = 1; i <= 10; i++)
            {
                writer.Write(i + " ");
            }
            //Insert a new line.
            writer.Write(writer.NewLine);
            writer.Close();
            Console.WriteLine("File was created.");
            Console.WriteLine("***********************");
            using StreamReader sr = new StreamReader(fileName);
            while((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            sr.Close();
            Console.ReadLine();
        }//end Main
    }//end Program
}
