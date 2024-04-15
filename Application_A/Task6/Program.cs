using System;
using Spectre.Console;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = AnsiConsole.Ask<string>("Введите трехзначное число: ");
            if (number.Length != 3)
            {
                Console.WriteLine("Введенное число не является трехзначным.");
            }
            else
            {
                int product = int.Parse(number[0].ToString()) * int.Parse(number[2].ToString());
                AnsiConsole.MarkupLine($"[white]Произведение первой и последней цифры: {product}[/]");
            }

            AnsiConsole.MarkupLine("\n[lime]Для продолжения нажмите любую кнопку...[/]");
            Console.ReadKey();
        }
    }
}
