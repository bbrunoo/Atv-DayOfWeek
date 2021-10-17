using System;
using static System.Console;

namespace switchCaseEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = DateTime.Now.DayOfWeek;
            
            WriteLine($"Today is {day}");
         
        }
    }
}
