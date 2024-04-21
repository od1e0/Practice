using System;
using static Spectre.Console.AnsiConsole;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Ask<int>("Введите значение n: ");
            double result = CalculateFunction(n);

            MarkupLine($"Результат: [green]{result}[/]");

            System.Console.ReadLine();
        }
        static double CalculateFunction(int n)
        {
            return 1 / Factorial(n + 3);
        }

        static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        
    }
}
