using System;
using Spectre.Console;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = AnsiConsole.Ask<double>("Введите a= ");
            var b = AnsiConsole.Ask<double>("Введите b= ");
            var c = AnsiConsole.Ask<double>("Введите c= ");

            bool isIsosceles = IsIsosceles(a, b, c);
            AnsiConsole.MarkupLine($"Треугольник с длинами сторон {a}, {b}, {c} - " +
                           $"{(isIsosceles ? "является" : "не является")} равнобедренным");
           Console.ReadKey();
        }

        static bool IsIsosceles(double a, double b, double c)
        {
            return a == b || a == c || b == c;
        }
    }
}
