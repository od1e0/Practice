﻿using System;
using Spectre.Console;
using System.Collections.Generic;
using static Spectre.Console.AnsiConsole;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            int N = Ask<int>("Введите размер матрицы N: ");
            int a = Ask<int>("Введите нижнюю границу диапазона a: ");
            int b = Ask<int>("Введите верхнюю границу диапазона b: ");
            int K = Ask<int>("Введите нижнюю границу промежутка K: ");
            int L = Ask<int>("Введите верхнюю границу промежутка L: ");
            int k = Ask<int>("Введите номер столбца k: ");

            Random rand = new Random();
            int[,] matrix = new int[N, N];
            int sum = 0, max = int.MinValue;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(a, b + 1);

                    if (i == k && matrix[i, j] > max)
                        max = matrix[i, j];

                    if (matrix[i, j] >= K && matrix[i, j] < L)
                        sum += matrix[i, j];
                }
            }

            AnsiConsole.Render(new Table().AddColumns("Матрица:"));
            for (int i = 0; i < N; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < N; j++)
                    row.Add(matrix[i, j].ToString());
                AnsiConsole.Render(new Table().AddRow(row.ToArray()));
            }

            AnsiConsole.MarkupLine($"Сумма чисел, принадлежащих промежутку [K, L): [green]{sum}[/]");
            AnsiConsole.MarkupLine($"Наибольший элемент k-того столбца: [green]{max}[/]");

            System.Console.ReadLine();
        }
    }
}
