using System;
using System.Linq;

namespace Task3.Models
{
    /// <summary>
    /// Класс для работы с матрицами вещественных чисел.
    /// </summary>
    public class RealMatrix
    {
        private double[,] matrix;

        /// <summary>
        /// Конструктор класса. Создает матрицу заданного размера.
        /// </summary>
        /// <param name="rows">Количество строк в матрице.</param>
        /// <param name="cols">Количество столбцов в матрице.</param>
        public RealMatrix(int rows, int cols)
        {
            matrix = new double[rows, cols];
        }

        /// <summary>
        /// Индексатор для доступа к элементам матрицы.
        /// </summary>
        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        /// <summary>
        /// Метод для инвертирования ненулевых элементов матрицы и замены нулевых на 1.
        /// </summary>
        public void InvertNonZeroReplaceZero()
        {
            var flattened = matrix.Cast<double>().Select(x => x == 0 ? 1 : -x).ToArray();
            Buffer.BlockCopy(flattened, 0, matrix, 0, flattened.Length * sizeof(double));
        }

        /// <summary>
        /// Оператор сложения двух матриц.
        /// </summary>
        public static RealMatrix operator +(RealMatrix a, RealMatrix b)
        {
            if (a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
            {
                throw new ArgumentException("Матрицы должны быть одного размера для сложения.");
            }

            var result = new RealMatrix(a.matrix.GetLength(0), a.matrix.GetLength(1));
            var aFlattened = a.matrix.Cast<double>().ToArray();
            var bFlattened = b.matrix.Cast<double>().ToArray();
            var sum = aFlattened.Zip(bFlattened, (x, y) => x + y).ToArray();

            Buffer.BlockCopy(sum, 0, result.matrix, 0, sum.Length * sizeof(double));

            return result;
        }

        /// <summary>
        /// Оператор вычитания двух матриц.
        /// </summary>
        public static RealMatrix operator -(RealMatrix a, RealMatrix b)
        {
            if (a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
            {
                throw new ArgumentException("Матрицы должны быть одного размера для вычитания.");
            }

            var result = new RealMatrix(a.matrix.GetLength(0), a.matrix.GetLength(1));
            var aFlattened = a.matrix.Cast<double>().ToArray();
            var bFlattened = b.matrix.Cast<double>().ToArray();
            var diff = aFlattened.Zip(bFlattened, (x, y) => x - y).ToArray();

            Buffer.BlockCopy(diff, 0, result.matrix, 0, diff.Length * sizeof(double));

            return result;
        }

        /// <summary>
        /// Метод для преобразования матрицы в строку.
        /// </summary>
        public override string ToString()
        {
            return string.Join("\n", Enumerable.Range(0, matrix.GetLength(0))
                .Select(i => string.Join("\t", Enumerable.Range(0, matrix.GetLength(1))
                .Select(j => matrix[i, j].ToString()))));
        }
    }
}
