using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Models;
using static Spectre.Console.AnsiConsole;

namespace Task3
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
            var rand = new Random();
            int rows = 3;
            int cols = 3;

            // Создание двух матриц
            RealMatrix matrix = new RealMatrix(rows, cols);
            RealMatrix matrix1 = new RealMatrix(rows, cols);

            // Заполнение матриц случайными числами
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.NextDouble() * 10;
                    matrix1[i, j] = rand.NextDouble() * 10;
                }
            }

            MarkupLine("[green]Матрица:[/]");
            WriteLine(matrix.ToString());

            // Инвертирование ненулевых элементов матрицы и замена нулевых
            matrix.InvertNonZeroReplaceZero();

            MarkupLine("\n[red]Измененная:[/]");
            WriteLine(matrix.ToString());

            // Сложение двух матриц
            MarkupLine("\n[blue]Сложение матриц:[/]");
            WriteLine((matrix + matrix1).ToString());

            System.Console.ReadKey();
        }
    }
}
