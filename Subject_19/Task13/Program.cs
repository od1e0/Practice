using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // Чтение строк из файлов
            string[] lines1 = File.ReadAllLines("file1.txt");
            string[] lines2 = File.ReadAllLines("file2.txt");

            // Проверка на равенство количества строк в файлах
            if (lines1.Length != lines2.Length)
            {
                throw new InvalidDataException("Файлы должны содержать одинаковое количество строк");
            }

            // Запись строк из первого файла во временный файл
            File.WriteAllLines("temp.txt", lines1);
            Console.WriteLine("Записано во временный файл");

            // Запись строк из второго файла в первый файл
            File.WriteAllLines("file1.txt", lines2);
            Console.WriteLine("Записано в file1");

            // Запись строк из временного файла во второй файл
            File.WriteAllLines("file2.txt", File.ReadAllLines("temp.txt"));
            Console.WriteLine("Записано в file2");

            // Удаление временного файла
            File.Delete("temp.txt");

            Console.ReadLine();
        }
    }
}
