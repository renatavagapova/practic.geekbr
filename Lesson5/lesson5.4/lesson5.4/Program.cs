using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;


namespace lesson5._4
{
    class Program
    {


        static void Main(string[] args)
        {
            string path = @"C:\users\vagap\desktop\TestDir";
            string subpath = @"Dir2\Dir2.1";
            string subpath2 = @"Dir1\Dir1";

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            dirInfo.CreateSubdirectory(subpath2);
            Console.WriteLine("Содержание файла:");
            string text = @"C:  
                                users
                                        vagap
                                                 desktop
                                                            TestDir
                                                                        Dir 1
                                                                        Dir 2
                                                                                  Dir2.1
                                                                                            test.txt";
            // запись в файл
            using (FileStream fstream = new FileStream(@"C:\users\vagap\desktop\TestDir\Dir2\Dir2.1\test.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }
            // чтение из файла
            using (FileStream fstream = File.OpenRead(@"C:\users\vagap\desktop\TestDir\Dir2\Dir2.1\test.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }

            Console.ReadLine();
        }

    }
}
