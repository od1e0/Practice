using System;
using static Spectre.Console.AnsiConsole;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                double x = Ask<double>("Введите значение x: ");

                double y1 = Math.Pow(Math.Sin(x), 3);
                WriteLine("y = sin^3(x) = " + y1);

                if (x == 1)
                {
                    throw new DivideByZeroException();
                }
                double y2 = (x / (x - 1)) - 3 * x;
                WriteLine("y = (x / (x-1)) - 3x = " + y2);
            }
            catch (FormatException)
            {
                WriteLine("Ошибка формата. Пожалуйста, введите число.");
            }
            catch (DivideByZeroException)
            {
                WriteLine("Ошибка деления на ноль. x не должен быть равен 1.");
            }

            System.Console.ReadKey();
        }
    }
}
