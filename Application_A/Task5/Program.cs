using System;
using Spectre.Console;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = AnsiConsole.Ask<double>("Введите радиус основания (см): ");
            var h = AnsiConsole.Ask<double>("Введите высоту цилиндра (см): ");

            double S = 2 * Math.PI * r * (r + h);

            AnsiConsole.MarkupLine($"[white]Площадь поверхности цилиндра: {S:F2} кв.см.[/]");

            AnsiConsole.MarkupLine("\n[lime]Для продолжения нажмите любую кнопку...[/]");
            Console.ReadKey();
        }
    }
}
