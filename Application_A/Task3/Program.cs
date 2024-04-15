using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = AnsiConsole.Ask<double>("Введите значение x: ");

            double y = 2 * Math.Atan(Math.Sqrt(1 - Math.Pow(x, 2))) + Math.Log(7 * x) / (1 + Math.Exp(x));
            
            AnsiConsole.MarkupLine($"[white]Значение функции: {y}[/]");

            AnsiConsole.MarkupLine("\n[lime]Для продолжения нажмите любую кнопку...[/]");
            Console.ReadKey();

        }
    }
}
