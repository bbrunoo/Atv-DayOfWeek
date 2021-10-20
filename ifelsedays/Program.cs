using System;
using static System.Console;


namespace ifelsedays
{
    class Program
    {
        static void Main(string[] args)

        {
            var day = DateTime.Now.DayOfWeek;

            if (day == DayOfWeek.Sunday)
            {
                WriteLine($"Today is {DayOfWeek.Sunday}");
            }

            else if (day == DayOfWeek.Monday)
            {
                WriteLine($"Today is {DayOfWeek.Monday}");
            }

            else if (day == DayOfWeek.Tuesday)
            {
                WriteLine($"Today is {DayOfWeek.Tuesday}");
            }

            else if (day == DayOfWeek.Wednesday)
            {
                WriteLine($"Today is {DayOfWeek.Wednesday}");
            }

            else if (day == DayOfWeek.Thursday)
            {
                WriteLine($"Today is {DayOfWeek.Thursday}");
            }

            else if (day == DayOfWeek.Friday)
            {
                WriteLine($"Today is {DayOfWeek.Friday}");
            }

            else if (day == DayOfWeek.Saturday)
            {
                WriteLine($"Today is {DayOfWeek.Saturday}");
            }
        }
    }
}
