using System;
using static Spectre.Console.AnsiConsole;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] array = new int[10];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100); 

                if (array[i] > 0)
                {
                    MarkupLine($"[green]{array[i]}[/]");
                    count++;
                }
            }

            MarkupLine($"Количество положительных элементов: [green]{count}[/]");

            System.Console.ReadLine();
        }

    }
}
