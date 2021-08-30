using System;

namespace lesson2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какая температура была максимальной?");
            double max = double.Parse(Console.ReadLine());
            Console.WriteLine("Какая температутра была минимальной?");
            double min = double.Parse(Console.ReadLine());
            double todaytemp = (max + min) / 2;
            Console.WriteLine("Среднесуточная температура на сегодня " + Math.Round(todaytemp, 1) + " градусов");
            Console.WriteLine("Какой сейчас месяц? Введите порядковый номер этого месяца");
            byte mounth = byte.Parse(Console.ReadLine());
            string nameofmounth = "";
            switch (mounth)
            {
                case 1:
                    nameofmounth = "Январь";
                    break;
                case 2:
                    nameofmounth = "Февраль";
                    break;
                case 3:
                    nameofmounth = "Март";
                    break;
                case 4:
                    nameofmounth = "Апрель";
                    break;
                case 5:
                    nameofmounth = "Май";
                    break;
                case 6:
                    nameofmounth = "Июнь";
                    break;
                case 7:
                    nameofmounth = "Июль";
                    break;
                case 8:
                    nameofmounth = "Август";
                    break;
                case 9:
                    nameofmounth = "Сентябрь";
                    break;
                case 10:
                    nameofmounth = "Октябрь";
                    break;
                case 11:
                    nameofmounth = "Ноябрь";
                    break;
                case 12:
                    nameofmounth = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Error. Enter a number from 1 to 12");
                    break;
            }
            Console.WriteLine("Сейчас " + nameofmounth);
            if (nameofmounth == "Январь" || nameofmounth == "Февраль" || nameofmounth == "Декабрь" && todaytemp > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
        }
    }
}
