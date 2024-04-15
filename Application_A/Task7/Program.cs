using System;
using Spectre.Console;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m = AnsiConsole.Ask<double>("Введите m: ");
            var n = AnsiConsole.Ask<double>("Введите n: ");


            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

            AnsiConsole.MarkupLine($"[white]Для m={m} и n={n}: z1={z1}, z2={z2}[/]");

            AnsiConsole.MarkupLine("\n[lime]Для продолжения нажмите любую кнопку...[/]");
            Console.ReadKey();
        }
    }
}
