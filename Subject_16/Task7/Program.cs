using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                Console.WriteLine($"Диск: {drive}");
                try
                {
                    string[] files = Directory.GetFiles(drive, "*.*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        Console.WriteLine(file);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Нет доступа");
                }
            }

            Console.WriteLine("Создание каталога \"Example_36tp\" на диске D");
            Directory.CreateDirectory(@"F:\Example_36tp");

            Console.WriteLine("Копирование 3 разных файлов из другого каталога");
            File.Copy(@"C:\Users\Вова\Downloads\Telegram Desktop\doc_2024-04-26_13-15-13.gitignore", @"F:\Example_36tp\file1.txt");
            File.Copy(@"C:\Users\Вова\Downloads\Telegram Desktop\doc_2024-04-26_13-15-13.gitignore", @"F:\Example_36tp\file2.txt");
            File.Copy(@"C:\Users\Вова\Downloads\Telegram Desktop\doc_2024-04-26_13-15-13.gitignore", @"F:\Example_36tp\file3.txt");

            Console.WriteLine("Изменение атрибутов скопированных файлов на \"Скрытый\"");
            new FileInfo(@"F:\Example_36tp\file1.txt").Attributes = FileAttributes.Hidden;
            new FileInfo(@"F:\Example_36tp\file2.txt").Attributes = FileAttributes.Hidden;
            new FileInfo(@"F:\Example_36tp\file3.txt").Attributes = FileAttributes.Hidden;

            Console.WriteLine("Создание файлов ссылок (здесь создаются пустые файлы вместо скрытых)");
            File.Create(@"F:\Example_36tp\link1.txt");
            File.Create(@"F:\Example_36tp\link2.txt");
            File.Create(@"F:\Example_36tp\link3.txt");

            Console.ReadLine();
        }
    }
}
