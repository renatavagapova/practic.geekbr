using System;
using System.IO;

namespace lesson5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            DateTime time = DateTime.Now;
            File.WriteAllText(filename, $"I add to 'startup.txt' new time, is {time.ToLongTimeString()} , go to chek.");
            string FileText = File.ReadAllText(filename);
            Console.WriteLine(FileText);
        }
    }
}
