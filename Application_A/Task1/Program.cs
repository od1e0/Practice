using System;
using Spectre.Console;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = AnsiConsole.Ask<double>("a=");
            var b = AnsiConsole.Ask<double>("b=");
            var c = AnsiConsole.Ask<double>("c=");

            AnsiConsole.MarkupLine($"({a:F4}+({b:F4}+{c:F4})=({a:F4}+{b:F4}+{c:F4})");
            
            AnsiConsole.MarkupLine("\n[lime]Для продолжения нажмите любую кнопку...[/]");
            Console.ReadKey();
        }
    }
}
