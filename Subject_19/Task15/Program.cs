using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
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
            // Чтение строк из исходного файла
            Console.WriteLine("Чтение строк из исходного файла");
            string[] lines = File.ReadAllLines("input.txt");

            // Пороговое значение длины строки
            int lengthThreshold = 150;

            // Переписывание строк в output1.txt, добавляя номер строки и количество символов
            Console.WriteLine("Переписывание строк в output1.txt, добавляя номер строки и количество символов");
            File.WriteAllLines("output1.txt", lines.Select((line, index) => $"{line} (Строка {index + 1}, символов: {line.Length})"));

            // Переписывание строк в output2.txt, длина которых больше заданного числа
            Console.WriteLine("Переписывание строк в output2.txt, длина которых больше заданного числа");
            File.WriteAllLines("output2.txt", lines.Where(line => line.Length > lengthThreshold));

            // Переписывание строк в output3.txt, длина которых четная
            Console.WriteLine("Переписывание строк в output3.txt, длина которых четная");
            File.WriteAllLines("output3.txt", lines.Where(line => line.Length % 2 == 0));

            // Переписывание строк в output4.txt, удаляя символы на четных местах
            Console.WriteLine("Переписывание строк в output4.txt, удаляя символы на четных местах");
            File.WriteAllLines("output4.txt", lines.Select(line => new string(line.Where((c, i) => i % 2 != 0).ToArray())));

            Console.ReadLine();
        }
    }
}
