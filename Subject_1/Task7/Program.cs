using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int minDigit = 9, maxDigit = 0;

            while (number > 0)
            {
                int digit = number % 10;
                minDigit = Math.Min(minDigit, digit);
                maxDigit = Math.Max(maxDigit, digit);
                number /= 10;
            }

            Console.WriteLine($"Наибольшая цифра: {maxDigit}.\nНаименьшая цифра: {minDigit}.");

            Console.ReadKey();
        }
    }
}
