using System;
using System.Collections.Generic;
using System.Linq;
using Spectre.Console;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A1 = 5, B1 = 3, C1 = 4;
            double A2 = 7, B2 = 2, C2 = 6;

            SortInc3(ref A1, ref B1, ref C1);
            SortInc3(ref A2, ref B2, ref C2);

            AnsiConsole.MarkupLine($"[green]{A1}[/], [yellow]{B1}[/], [red]{C1}[/]");
            AnsiConsole.MarkupLine($"[green]{A2}[/], [yellow]{B2}[/], [red]{C2}[/]");

            Console.ReadKey();
        }
        static void SortInc3(ref double A, ref double B, ref double C)
        {
            var sorted = new List<double> { A, B, C }.OrderBy(x => x).ToList();
            A = sorted[0];
            B = sorted[1];
            C = sorted[2];
        }
    }   
}
