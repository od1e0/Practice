using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Spectre.Console.AnsiConsole;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Ask<string>("Введите строку: ");
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (word[i] == word[i + 1])
                    {
                        MarkupLine($"[green]{word}[/]");
                        break;
                    }
                }
            }

            System.Console.ReadLine();
        }
    }
}
