using System;

namespace lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, состоящую из чисел, разделенных пробелом");
            string str = Console.ReadLine();
            string[] str1 = str.Split(new char[] { ' ' });
            int sum = 0;
            for (int i = 0; i < str1.Length; i++) 
            {
                int per = Convert.ToInt32(str1[i].ToString());
                sum += per;
            }
            Console.WriteLine(sum);
        }
    }

}