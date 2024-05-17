using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            double A = -7;
            double B = 5;

            double step = 0.1;

            int steps = (int)((B - A) / step);

            Parallel.For(0, steps + 1, i =>
            {
                double x = A + i * step;
                double y = Math.Sin(1 / x);
                Console.WriteLine($"x = {x}, y = {y}");
            });

            Console.ReadLine();
        }
    }
}
