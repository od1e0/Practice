using System;
using Spectre.Console;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = AnsiConsole.Ask<int>("Введите A= ");
            int B = AnsiConsole.Ask<int>("Введите B= ");

            if (A < B)
            {
                int sum = 0;
                for (int i = A; i <= B; i++)
                {
                    sum += i;
                }
                AnsiConsole.WriteLine($"Сумма всех целых чисел от {A} до {B} включительно равна {sum}");
            }
            else
            {
                AnsiConsole.MarkupLine("[red]A > B[/]");
            }

            Console.ReadKey();
        }
    }
}
