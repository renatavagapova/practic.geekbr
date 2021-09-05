using System;


namespace lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = new string[5, 2]
            {
                { "Саша", "8975565968"},
                { "Анна", "ppochta@bk.com"},
                { "Гена", "+7917468596"},
                { "Катя", "nazvanie@mail.ru"},
                { "Оля", "+79656956852"},
            };

            for (var i = 0; i < mass.GetLength(0); i++)
            {
                for (var j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            

               
        }
    }
}
