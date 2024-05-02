using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3, 3);
            Matrix matrix2 = new Matrix(3, 3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = i + j;
                    matrix2[i, j] = i - j;
                }
            }

            Console.WriteLine($"matrix1 is square: {matrix1.IsSquare()}");
            Console.WriteLine($"matrix1 is diagonal: {matrix1.IsDiagonal()}");

            int comparisonResult = matrix1.CompareTo(matrix2);
            if (comparisonResult < 0)
                Console.WriteLine("matrix1 is less than matrix2");
            else if (comparisonResult > 0)
                Console.WriteLine("matrix1 is greater than matrix2");
            else
                Console.WriteLine("matrix1 is equal to matrix2");

            Console.ReadLine();
        }
    }

}
