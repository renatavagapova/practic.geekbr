using System;

namespace lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter random number");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            Console.ReadLine();
        }
    }
}
