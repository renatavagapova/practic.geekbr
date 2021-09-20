using System;
using System.IO;
namespace lesson5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";
            Console.WriteLine("Введите набор данных, которые бы вы хотели сохранить в текстовый файл");
            string text = Console.ReadLine();
            File.WriteAllText(filename, $"Вы ввели следующие данные: {text}");
            File.ReadAllText(filename);
            Console.WriteLine(filename);
        }
    }
}
