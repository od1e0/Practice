using System;
using System.Linq;
using Spectre.Console;
using static Spectre.Console.AnsiConsole;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {

            string text = Ask<string>("Введите фрагмент текста: ");
            var digits = "0123456789";
            int maxCount = 0;
            int currentCount = 0;

            foreach (var c in text)
            {
                if (digits.Contains(c))
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0;
                }
            }

            WriteLine("Наибольшее количество цифр, идущих подряд: " + maxCount);

            System.Console.ReadLine();
        }
    }
}
