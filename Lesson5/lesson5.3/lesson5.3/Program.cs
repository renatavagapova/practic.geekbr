using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace lesson5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "test.bin";
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255");
            var input = Console.ReadLine().Split(' ');
            var array = new byte[input.Length];
            for (int i =0; i<array.Length; i++)
            {
                if (!byte.TryParse(input[i],out byte number)) 
                {
                    Console.WriteLine("Вы ввели неверные значения");
                    return;
                }
                array[i] = number;
            }
            // запись данных в двоичном формате
            using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(filename)))
            {
                writer.Write(array);
            }
            Console.WriteLine($"Что сейчас находится в файле {filename} :");
            // считывается запись данных в двоичном формате
            byte[] newArray;
            using (BinaryReader reader = new BinaryReader(File.OpenRead(filename)))
            {
                newArray = reader.ReadBytes(array.Length);
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }

        }
            
    }
}
