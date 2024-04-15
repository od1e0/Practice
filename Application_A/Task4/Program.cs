using System;
using Spectre.Console;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = AnsiConsole.Ask<double>("Введите длину стороны a: ");
            var b = AnsiConsole.Ask<double>("Введите длину стороны b: ");
            var c = AnsiConsole.Ask<double>("Введите длину стороны c: ");

            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double h = 2 * S / a;

            AnsiConsole.MarkupLine($"[white]Высота треугольника, опущенная на сторону a: {h}[/]");

            AnsiConsole.MarkupLine("\n[lime]Для продолжения нажмите любую кнопку...[/]");
            Console.ReadKey();
        }
    }
}
