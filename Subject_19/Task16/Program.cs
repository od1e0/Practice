using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
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
            // Получение списка логических дисков
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                Console.WriteLine($"Диск: {drive}");
                try
                {
                    // Получение списка файлов на диске
                    string[] files = Directory.GetFiles(drive, "*.*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        Console.WriteLine(file);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // Обработка исключения при отсутствии доступа
                    Console.WriteLine("Нет доступа");
                }
            }

            // Создание нового каталога на диске D
            Console.WriteLine("Создание каталога \"Example_36tp\" на диске D");
            Directory.CreateDirectory(@"F:\Example_36tp");

            // Копирование трех файлов из другого каталога
            Console.WriteLine("Копирование 3 разных файлов из другого каталога");
            File.Copy(@"C:\Users\Вова\Downloads\Telegram Desktop\doc_2024-04-26_13-15-13.gitignore", @"F:\Example_36tp\file1.txt");
            File.Copy(@"C:\Users\Вова\Downloads\Telegram Desktop\doc_2024-04-26_13-15-13.gitignore", @"F:\Example_36tp\file2.txt");
            File.Copy(@"C:\Users\Вова\Downloads\Telegram Desktop\doc_2024-04-26_13-15-13.gitignore", @"F:\Example_36tp\file3.txt");

            // Изменение атрибутов скопированных файлов на "Скрытый"
            Console.WriteLine("Изменение атрибутов скопированных файлов на \"Скрытый\"");
            new FileInfo(@"F:\Example_36tp\file1.txt").Attributes = FileAttributes.Hidden;
            new FileInfo(@"F:\Example_36tp\file2.txt").Attributes = FileAttributes.Hidden;
            new FileInfo(@"F:\Example_36tp\file3.txt").Attributes = FileAttributes.Hidden;

            // Создание файлов ссылок (здесь создаются пустые файлы вместо скрытых)
            Console.WriteLine("Создание файлов ссылок (здесь создаются пустые файлы вместо скрытых)");
            File.Create(@"F:\Example_36tp\link1.txt");
            File.Create(@"F:\Example_36tp\link2.txt");
            File.Create(@"F:\Example_36tp\link3.txt");

            Console.ReadLine();
        }
    }
}
