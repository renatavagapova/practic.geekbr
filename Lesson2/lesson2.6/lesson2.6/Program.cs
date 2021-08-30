using System;

namespace lesson2._6
{
    class Program
    {
        [Flags]
        public enum DayOfWeek
        {
            monday = 0b_0000001,
            tuesday = 0b_0000010,
            wednesday = 0b_0000100,
            thursday = 0b_0001000,
            friday = 0b_0010000,
            saturday = 0b_0100000,
            sunday = 0b_1000000,
        }
        static void Main(string[] args)
        {
            //маска работы офисов
            DayOfWeek office1 = DayOfWeek.tuesday | DayOfWeek.wednesday | DayOfWeek.thursday | DayOfWeek.friday;
            DayOfWeek office2 = (DayOfWeek)0b1111111;

            Console.WriteLine($"Office 1 opening days: {office1}");
            Console.WriteLine($"Office 2 opening days: {office2}");
        }
    }
}
