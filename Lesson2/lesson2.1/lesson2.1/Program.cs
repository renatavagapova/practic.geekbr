using System;

namespace lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the maximum temperature today?");
            double max = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the minimum temperature today?");
            double min = double.Parse(Console.ReadLine());
            double todaytemp = (max + min) / 2;
            Console.WriteLine("The average daily temperature for today is: " + Math.Round(todaytemp, 1) + " градусов");
            Console.ReadLine();
        }
    }
}
