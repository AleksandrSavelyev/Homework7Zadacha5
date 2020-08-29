using System;

namespace Homework7Zadacha5
{
    enum WeekDay
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            int day = CheckValid();
            CheckWeek(day);
        }
        static int CheckValid()
        {
            Console.Write("enter the day of the week:\t");
            int a = 0;
            bool i = false;
            while (i == false)
            {
                if (int.TryParse(Console.ReadLine(), out a) && a > 0)
                {
                    if (a > 0 && a < 8)
                        break;
                    else
                        Console.Write("wrong data. re-enter:\t");
                }
                else
                    Console.Write("wrong data. re-enter:\t");
            }
            return a;
        }
        static void CheckWeek(int a)
        {
            WeekDay day = 0;
            switch (a)
            {
                case 1:
                    day = WeekDay.Monday;
                    break;
                case 2:
                    day = WeekDay.Tuesday;
                    break;
                case 3:
                    day = WeekDay.Wednesday;
                    break;
                case 4:
                    day = WeekDay.Thursday;
                    break;
                case 5:
                    day = WeekDay.Friday;
                    break;
                case 6:
                    day = WeekDay.Saturday;
                    break;
                case 7:
                    day = WeekDay.Sunday;
                    break;
            }
            Console.WriteLine($"you chose {day}");
        }
    }
}
