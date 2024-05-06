using System;
using System.IO;
using System.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\Вова\\Desktop\\Practice\\Subject_16\\Task1\\f.txt");
            double[] numbers = lines.Select(line => double.Parse(line)).ToArray();

            double sum = numbers.Sum();
            double absoluteSum = Math.Abs(sum);

            double product = numbers.Aggregate(1.0, (a, b) => a * b);
            double squareProduct = Math.Pow(product, 2);

            Console.WriteLine($"Модуль суммы: {absoluteSum}");
            Console.WriteLine($"Квадрат произведения: {squareProduct}");

            Console.ReadLine();
        }
    }
}
