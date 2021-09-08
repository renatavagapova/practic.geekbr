using System;

namespace lesson4._1
{
    class Program
    {
        static void GetFullName(string firstname, string lastname, string patronymic)
        {
            Console.WriteLine($"{firstname} {lastname} {patronymic }");
        }
        static void Main(string[] args)
        {
            GetFullName("Сидоров","Кирилл","Кириллович");
            GetFullName("Иванов", "Иван", "Иванович");
            GetFullName("Артемов", "Артем", "Артемочик");
            GetFullName("Олегов", "Олег", "Олегович");
            
        }
    }
}
