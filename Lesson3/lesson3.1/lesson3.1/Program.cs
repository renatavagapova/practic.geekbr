using System;

namespace lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходный массив:");
            int[,] mass = new int[3, 3];
            int[] help = new int[9];
            int x = 0;
            Random rnd = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rnd.Next(1, 9);
                    help[x] = mass[i, j];
                    x++;
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив по диагонали:");
            int[,] result = new int[9, 9];
            int k = 0;
            int index = 0;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(" ");
                }
                k++;
                Console.Write(help[index]);
                index++;
                Console.WriteLine();
            }


        }
    }
}
