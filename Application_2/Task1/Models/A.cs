using System;

namespace Task1.Models
{
    internal class A
    {
        private int _a;
        private int _b;

        public A(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public double СalculatExpressionValues() => ( 3 * _b - 2 / Math.Pow(_a,2)) / 4;

        public double CalculateCube() => Math.Pow(_a / _b, 3);
    }
}
