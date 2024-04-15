using System;
using Spectre.Console;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = AnsiConsole.Ask<string>("Введите 4-ех значное число: ");

            if (number.Length != 4)
            {
                AnsiConsole.MarkupLine("[red]Введенное число не является четырехзначным.[/]");
            }
            else
            {
                string newNumber = $"{number[1]}{number[0]}{number[3]}{number[2]}";

                AnsiConsole.MarkupLine($"[white]Новое число после перестановки цифр: {newNumber}[/]");
            }

            AnsiConsole.MarkupLine("[lime]Для продолжения нажмите любую кнопку...[/]");
            Console.ReadKey();
        }
    }
}
