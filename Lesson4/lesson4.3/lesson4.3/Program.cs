using System;

namespace lesson4._3
{
    class Program
    {
        enum Season
        {
            Winter,
            Spring, 
            Autemn,
            Summer
        }
    
        static void Seasons()
        {
            Console.WriteLine("Введите порядковый номер месяца");
            int i = int.Parse(Console.ReadLine());

            if ( i == 1 || i == 2 || i == 12)
            {
                Season currentSeason = Season.Winter;
                Season_vivod(currentSeason);
            }
            else if (i == 3 || i == 4 || i == 5)
            {
                Season currentSeason = Season.Spring;
                Season_vivod(currentSeason) ;
            }
            else if (i == 6 || i == 7 || i == 8)
            {
                Season currentSeason = Season.Summer;
                Season_vivod(currentSeason);
            }
            else if (i == 9||i==10||i==11)
            {
                Season currentSeason = Season.Autemn;
                Season_vivod(currentSeason);
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 12");
            }
        }
        static void Season_vivod(Season a)
        {
           
            if (Convert.ToInt32(a)==0)
            {
                Console.WriteLine("Зима");
            }

            else if (Convert.ToInt32(a) == 1)
            {
                Console.WriteLine("Весна");
            }
            else if (Convert.ToInt32(a) == 2)
            {
                Console.WriteLine("Осень");
            }
            else if (Convert.ToInt32(a) == 3)
            {
                Console.WriteLine("Лето");
            }
        }

        static void Main(string[] args)
        {
            Seasons();
        }
    }
}
