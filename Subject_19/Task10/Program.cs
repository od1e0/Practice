using System;
using System.IO;
using System.Linq;

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
            // Чтение строк из файла
            string[] lines = File.ReadAllLines("C:\\Users\\Вова\\Desktop\\Practice\\Subject_16\\Task1\\f.txt");
            // Преобразование строк в числа
            double[] numbers = lines.Select(line => double.Parse(line)).ToArray();

            // Вычисление суммы чисел
            double sum = numbers.Sum();
            // Вычисление модуля суммы
            double absoluteSum = Math.Abs(sum);

            // Вычисление произведения чисел
            double product = numbers.Aggregate(1.0, (a, b) => a * b);
            // Вычисление квадрата произведения
            double squareProduct = Math.Pow(product, 2);

            Console.WriteLine($"Модуль суммы: {absoluteSum}");
            Console.WriteLine($"Квадрат произведения: {squareProduct}");

            Console.ReadLine();
        }
    }
}
