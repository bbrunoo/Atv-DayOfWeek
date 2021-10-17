using System;
using static System.Console;

namespace switchcasedias
{
    class Program
    {
        static void Main(string[] args)
        {

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    WriteLine($"Today is {DayOfWeek.Sunday}");
                break;

                case DayOfWeek.Monday:
                    WriteLine($"Today is {DayOfWeek.Monday}");
                break;

                case DayOfWeek.Tuesday:
                    WriteLine($"Today is {DayOfWeek.Tuesday}");
                break;

                case DayOfWeek.Wednesday:
                    WriteLine($"Today is {DayOfWeek.Wednesday}");
                break;

                case DayOfWeek.Thursday:
                    WriteLine($"Today is {DayOfWeek.Thursday}");
                break;

                case DayOfWeek.Friday:
                    WriteLine($"Today is {DayOfWeek.Friday}");
                break;

                case DayOfWeek.Saturday:
                    WriteLine($"Today is {DayOfWeek.Sunday}");
                break;

            }
        }
    }
}