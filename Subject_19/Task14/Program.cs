using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
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
            // Исходный массив чисел
            int[] originalNumbers = { 20, 10, 4, -1, -2, 0, 0, 0, -10, 41, 62 };
            // Запись чисел в файл
            File.WriteAllLines("original.txt", originalNumbers.Select(n => n.ToString()));

            // Чтение чисел из файла
            int[] numbers = File.ReadAllLines("original.txt").Select(int.Parse).ToArray();

            // Создание файла для записи результата
            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                int sum = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    // Если текущее число и сумма имеют одинаковый знак
                    if ((numbers[i] >= 0 && sum >= 0) || (numbers[i] <= 0 && sum <= 0))
                    {
                        sum += numbers[i];
                    }
                    else
                    {
                        // Запись суммы в файл и начало новой суммы
                        writer.WriteLine(sum);
                        sum = numbers[i];
                    }
                }
                // Запись последней суммы в файл
                writer.WriteLine(sum);
            }

            Console.ReadLine();
        }
    }
}
