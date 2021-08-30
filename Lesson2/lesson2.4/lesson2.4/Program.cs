using System;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string adress = "420140, г.Казань, Проспект Победы,91";
            long chs = 8800700800;
            double packet = 5.00;
            double shampoo = 189.90;
            double tee = 229.00;
            double kond = 245.00;
            double marker = 55.99;
            double pen = 26.99;
            var date = DateTime.Now;
            string card = "xxxxxxxxxxxx6514";
            int kvitanc = 002340;
            int terminal = 10033007;
            string kodavtoriz = "LJQVG88";


            Console.WriteLine("ООО АШАН");
            Console.WriteLine(adress);
            Console.WriteLine(" ");
            Console.WriteLine("Телефон горячей линии");
            Console.WriteLine(chs);
            Console.WriteLine("Звонок по России бесплатный");
            Console.WriteLine(" ");
            Console.WriteLine("КАССОВЫЙ ЧЕК (ПРИХОД)");
            Console.WriteLine("ПАКЕТ АШАН                              " + packet);
            Console.WriteLine("ШАМПУНЬ                                 " + shampoo);
            double tee2 = tee * 2;
            Console.WriteLine("ЗЕЛЕНЫЙ ЧАЙ               " + tee + "x2         " + tee2);
            Console.WriteLine("КОНДИЦИОНЕР ДЛЯ ВЛОС                    " + kond);
            Console.WriteLine("ТЕКСТОВЫДЕЛИТЕЛЬ                        " + marker);
            double pen6 = pen * 6;
            Console.WriteLine("РУЧКА ШАРИКОВАЯ         " + pen + "x6         " + pen6);
            Console.WriteLine("");
            double itogo = packet + shampoo + tee2 + kond + marker + pen6;
            Console.WriteLine("ИТОГО                                   " + itogo);
            Console.WriteLine("БЕЗНАЛИЧНЫМИ                            " + itogo);
            double ndc = itogo * 0.2;
            Console.WriteLine("Сумма НДС 20%                           " + ndc);
            Console.WriteLine("ОПЛАТА ТОВАРА");
            Console.WriteLine("");
            Console.WriteLine(date);
            Console.WriteLine("");
            Console.WriteLine("МИР                     " + card);
            Console.WriteLine("НОМЕР КВИТАНЦИИ:        " + kvitanc);
            Console.WriteLine("НОМЕР ТЕРМИНАЛА         " + terminal);
            Console.WriteLine("КОД АВТОРИЗВЦИИ         " + kodavtoriz);
            Console.WriteLine("СУММА                   " + itogo);
            Console.WriteLine("");
            Console.WriteLine("ОПЕРАЦИЯ РАЗРЕШЕНА");
            Console.WriteLine("");
            Console.WriteLine("ПОДПИСЬ КЛИЕНТА НЕ ТРЕБУЕТСЯ");
        }
    }
}
