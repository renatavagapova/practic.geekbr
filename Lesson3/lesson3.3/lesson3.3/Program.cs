using System;

namespace lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            char[] mass = str.ToCharArray();
            Array.Reverse(mass);
            Console.Write("Вывод вашей строки в обратном порядке: ");
            Console.Write(mass);
        }
    }
}
