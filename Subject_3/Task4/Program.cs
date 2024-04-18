using System;
using static Spectre.Console.AnsiConsole;
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1 = Ask<double>("Введите значение a1: ");
            double b1 = Ask<double>("Введите значение b1: ");
            double a2 = Ask<double>("Введите значение a2: ");
            double b2 = Ask<double>("Введите значение b2: ");
            double c2 = Ask<double>("Введите значение c2: ");

            double result = Mult(a1, b1) / Mult(a2, b2, c2);

            MarkupLine($"Результат: [red]{result}[/]");

            System.Console.ReadKey();
        }

        static double Mult(double a, double b)
        {
            return a * b;
        }

        static double Mult(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
