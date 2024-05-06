using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines1 = File.ReadAllLines("file1.txt");
            string[] lines2 = File.ReadAllLines("file2.txt");

            if (lines1.Length != lines2.Length)
            {
                throw new InvalidDataException("Файлы должны содержать одинаковое количество строк");
            }

            File.WriteAllLines("temp.txt", lines1);
            Console.WriteLine("Записано во временный файл");

            File.WriteAllLines("file1.txt", lines2);
            Console.WriteLine("Записано в file1");

            File.WriteAllLines("file2.txt", File.ReadAllLines("temp.txt"));
            Console.WriteLine("Записано в file2");

            File.Delete("temp.txt");

            Console.ReadLine();
        }
    }
}
