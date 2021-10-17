using System;
using static System.Console;


namespace ifelsedays
{
    class Program
    {
        static void Main(string[] args)

        {


            WriteLine("---------------");
            WriteLine("Domingo/Sunday = 0.");
            WriteLine("Segunda/Monday = 1.");
            WriteLine("Terça/Tuesday = 2.");
            WriteLine("Quarta/Wednesday = 3.");
            WriteLine("Quinta/Wednesday = 4.");
            WriteLine("Sexta/Friday = 5.");
            WriteLine("Sabado/Saturday = 6.");
            WriteLine("---------------");
            WriteLine("Escreva um dia da semana em numeros.");

            int day = Convert.ToInt32(ReadLine());

            if (day == 0)
            {
                WriteLine($"Today is {DayOfWeek.Sunday}");
            }

            else if (day == 1)
            {
                WriteLine($"Today is {DayOfWeek.Monday}");
            }

            else if (day == 2)
            {
                WriteLine($"Today is {DayOfWeek.Tuesday}");
            }

            else if (day == 3)
            {
                WriteLine($"Today is {DayOfWeek.Wednesday}");
            }

            else if (day == 4)
            {
                WriteLine($"Today is {DayOfWeek.Thursday}");
            }

            else if (day == 5)
            {
                WriteLine($"Today is {DayOfWeek.Friday}");
            }

            else if (day == 6)
            {
                WriteLine($"Today is {DayOfWeek.Saturday}");
            }

            else
            {
                WriteLine("Digite um numero de 0 a 6 ");
            }

        }
    }
}




