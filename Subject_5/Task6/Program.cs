using System;
using System.Collections.Generic;
using Spectre.Console;
using static Spectre.Console.AnsiConsole;

namespace Task6
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = new int[7, 7];
            int value = 1;
            int minIndex = 0;
            int maxIndex = 6;
            while (value <= 49)
            {
                for (int i = minIndex; i <= maxIndex; i++)
                {
                    matrix[minIndex, i] = value++;
                }

                for (int i = minIndex + 1; i <= maxIndex; i++)
                {
                    matrix[i, maxIndex] = value++;
                }

                for (int i = maxIndex - 1; i >= minIndex; i--)
                {
                    matrix[maxIndex, i] = value++;
                }

                for (int i = maxIndex - 1; i > minIndex; i--)
                {
                    matrix[i, minIndex] = value++;
                }

                minIndex++;
                maxIndex--;
            }

            var table = new Table();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    table.AddColumn(matrix[i, j].ToString());
                }
                AnsiConsole.Render(table);
                table = new Table();
            }

            System.Console.ReadKey();
        }
    }
}
