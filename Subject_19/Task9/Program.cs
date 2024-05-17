using System;

namespace Task4
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Делегат для генерации случайных чисел.
        /// </summary>
        public delegate int RandomDelegate();

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            Random random = new Random();

            // Создание массива делегатов
            RandomDelegate[] delegates = new RandomDelegate[3];
            delegates[0] = () => random.Next(1, 100);
            delegates[1] = () => random.Next(1, 100);
            delegates[2] = () => random.Next(1, 100);

            // Функция для вычисления среднего значения
            Func<RandomDelegate[], double> Average = (delArray) =>
            {
                double sum = 0;
                foreach (var del in delArray)
                {
                    sum += del();
                }
                return sum / delArray.Length;
            };

            Console.WriteLine($"Среднее арифметическое: {Average(delegates)}");

            Console.ReadLine();
        }
    }
}
