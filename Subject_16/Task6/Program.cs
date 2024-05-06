using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Чтение строк из исходного файла");
            string[] lines = File.ReadAllLines("input.txt");

            int lengthThreshold = 150;

            Console.WriteLine("Переписывание строк в output1.txt, добавляя номер строки и количество символов");
            File.WriteAllLines("output1.txt", lines.Select((line, index) => $"{line} (Строка {index + 1}, символов: {line.Length})"));

            Console.WriteLine("Переписывание строк в output2.txt, длина которых больше заданного числа");
            File.WriteAllLines("output2.txt", lines.Where(line => line.Length > lengthThreshold));

            Console.WriteLine("Переписывание строк в output3.txt, длина которых четная");
            File.WriteAllLines("output3.txt", lines.Where(line => line.Length % 2 == 0));

            Console.WriteLine("Переписывание строк в output4.txt, удаляя символы на четных местах");
            File.WriteAllLines("output4.txt", lines.Select(line => new string(line.Where((c, i) => i % 2 != 0).ToArray())));

            Console.ReadLine();
        }
    }
}
