using System;
using static Spectre.Console.AnsiConsole;

namespace Task4
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
            double a1 = Ask<double>("Введите значение a1: ");
            double b1 = Ask<double>("Введите значение b1: ");
            double a2 = Ask<double>("Введите значение a2: ");
            double b2 = Ask<double>("Введите значение b2: ");
            double c2 = Ask<double>("Введите значение c2: ");

            // Вычисление результата
            double result = Mult(a1, b1) / Mult(a2, b2, c2);

            MarkupLine($"Результат: [red]{result}[/]");

            System.Console.ReadKey();
        }

        /// <summary>
        /// Функция для вычисления произведения двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Возвращает произведение двух чисел.</returns>
        static double Mult(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Функция для вычисления произведения трех чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <param name="c">Третье число.</param>
        /// <returns>Возвращает произведение трех чисел.</returns>
        static double Mult(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
