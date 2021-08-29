using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine("Hello, " + name + ", today is " + date.ToShortDateString());
            Console.ReadLine();
        }
    }
}
