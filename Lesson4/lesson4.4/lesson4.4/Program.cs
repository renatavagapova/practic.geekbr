using System;

namespace lesson4._4
{
    class Program
    {
        static int Fibonachi (int a)
        {
            if (a==0||a==1)
            {
                return a;
            }
            else
            {
                return Fibonachi(a - 1) + Fibonachi(a - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, до которого будет считаться ряд Фибоначчи");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++) 
            {
                Console.Write(Fibonachi(i)+ " ");
            }
            Console.ReadKey();
        }
    }
}
