using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Matrix : IComparable<Matrix>
    {
        private double[,] data;

        public Matrix(int rows, int cols)
        {
            data = new double[rows, cols];
        }

        public double this[int i, int j]
        {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }

        public bool IsSquare()
        {
            return data.GetLength(0) == data.GetLength(1);
        }

        public bool IsDiagonal()
        {
            if (!IsSquare())
                return false;

            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                    if (i != j && data[i, j] != 0)
                        return false;

            return true;
        }

        public int CompareTo(Matrix other)
        {
            double sumThis = 0;
            double sumOther = 0;

            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                    sumThis += data[i, j];

            for (int i = 0; i < other.data.GetLength(0); i++)
                for (int j = 0; j < other.data.GetLength(1); j++)
                    sumOther += other.data[i, j];

            return sumThis.CompareTo(sumOther);
        }
    }

}
