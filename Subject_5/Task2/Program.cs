using static Spectre.Console.AnsiConsole;
using System;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] array = new int[100]; 
            int minIndex = 0, maxIndex = 0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);

                if (array[i] < array[minIndex])
                    minIndex = i;
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            if (minIndex > maxIndex)
            {
                int temp = minIndex;
                minIndex = maxIndex;
                maxIndex = temp;
            }

            for (int i = minIndex; i <= maxIndex; i++)
                sum += array[i];

            double average = sum / (maxIndex - minIndex + 1);

            MarkupLine($"Среднее арифметическое чисел, расположенных между минимальным и максимальным числами: [green]{average}[/]");

            System.Console.ReadLine();
        }
    }
}
