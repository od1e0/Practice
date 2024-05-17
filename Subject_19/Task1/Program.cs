using System;
using Spectre.Console;
using static Spectre.Console.AnsiConsole;

namespace Task1
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            double a = Ask<double>("Введите значение a:");
            double b = Ask<double>("Введите значение b:");
            double h = Ask<double>("Введите значение шана h:");

            var table = new Table().Border(TableBorder.Rounded);
            table.AddColumn("x");
            table.AddColumn("f(x)");

            for (double x = a; x < b; x += h)
            {
                double fx = Function(x, a, b);
                table.AddRow(
                new Markup($"[green]{x:F4}[/]"),
                new Markup($"[blue]{fx:F4}[/]"));
            }

            Render(table);

            System.Console.ReadKey();
        }

        /// <summary>
        /// Функция для вычисления значения функции в зависимости от входного значения x.
        /// </summary>
        /// <param name="x">Входное значение.</param>
        /// <param name="a">Параметр a функции.</param>
        /// <param name="b">Параметр b функции.</param>
        /// <returns>Возвращает значение функции в точке x.</returns>
        static double Function(double x, double a, double b)
        {
            if (x < 0)
            {
                return a + b * x;
            }
            else if (x >= 0 && x <= 5)
            {
                return b * x * a * x;
            }
            else
            {
                return Math.Log(b * x) + Math.Sin(a * x);
            }
        }
    }
}
