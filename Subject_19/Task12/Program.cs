using System;
using System.IO;
using System.Linq;

namespace Task3
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
            // Создание массива строк
            string[] lines = { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };
            // Запись строк в файл
            File.WriteAllLines("file.txt", lines);

            // a) Вывод содержимого файла
            Console.WriteLine("Содержимое файла:");
            foreach (string line in File.ReadLines("file.txt"))
            {
                Console.WriteLine(line);
            }

            // b) Подсчет количества строк в файле
            int lineCount = File.ReadLines("file.txt").Count();
            Console.WriteLine($"Количество строк: {lineCount}");

            // c) Подсчет количества символов в каждой строке
            foreach (string line in File.ReadLines("file.txt"))
            {
                Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
            }

            // d) Создание нового файла с удалением последней строки
            File.WriteAllLines("new_file.txt", File.ReadLines("file.txt").Take(lineCount - 1));

            // e) Вывод строк с s1 по s2
            int s1 = 1, s2 = 3;
            Console.WriteLine($"Строки с {s1} по {s2}:");
            foreach (string line in File.ReadLines("file.txt").Skip(s1 - 1).Take(s2 - s1 + 1))
            {
                Console.WriteLine(line);
            }

            // f) Поиск самой длинной строки
            int maxLength = File.ReadLines("file.txt").Max(line => line.Length);
            Console.WriteLine($"Длина самой длинной строки: {maxLength}");

            // g) Вывод строк, начинающихся с определенной буквы
            char startChar = 'В';
            Console.WriteLine($"Строки, начинающиеся с буквы '{startChar}':");
            foreach (string line in File.ReadLines("file.txt").Where(line => line.StartsWith(startChar.ToString())))
            {
                Console.WriteLine(line);
            }

            // h) Создание нового файла с обратным порядком строк
            File.WriteAllLines("reversed_file.txt", File.ReadLines("file.txt").Reverse());

            Console.ReadLine();
        }
    }
}
