using System;
using System.IO;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };
            File.WriteAllLines("file.txt", lines);

            // a)
            Console.WriteLine("Содержимое файла:");
            foreach (string line in File.ReadLines("file.txt"))
            {
                Console.WriteLine(line);
            }

            // b)
            int lineCount = File.ReadLines("file.txt").Count();
            Console.WriteLine($"Количество строк: {lineCount}");

            // c)
            foreach (string line in File.ReadLines("file.txt"))
            {
                Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
            }

            // d)
            File.WriteAllLines("new_file.txt", File.ReadLines("file.txt").Take(lineCount - 1));

            // e) 
            int s1 = 1, s2 = 3; 
            Console.WriteLine($"Строки с {s1} по {s2}:");
            foreach (string line in File.ReadLines("file.txt").Skip(s1 - 1).Take(s2 - s1 + 1))
            {
                Console.WriteLine(line);
            }

            // f)
            int maxLength = File.ReadLines("file.txt").Max(line => line.Length);
            Console.WriteLine($"Длина самой длинной строки: {maxLength}");

            // g) 
            char startChar = 'В';  
            Console.WriteLine($"Строки, начинающиеся с буквы '{startChar}':");
            foreach (string line in File.ReadLines("file.txt").Where(line => line.StartsWith(startChar.ToString())))
            {
                Console.WriteLine(line);
            }

            // h)
            File.WriteAllLines("reversed_file.txt", File.ReadLines("file.txt").Reverse());

            Console.ReadLine();
        }
    }
}
