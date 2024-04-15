using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            AnsiConsole.MarkupLine($"({a.ToString("F4")}+({b.ToString("F4")}+{c.ToString("F4")})=({a.ToString("F4")}+{b.ToString("F4")}+{c.ToString("F4")})");
            
            AnsiConsole.MarkupLine("[lime]Для продолжения нажмите любую кнопку...[/]");
            Console.ReadKey();
        }
    }
}
