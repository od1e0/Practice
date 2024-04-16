using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = AnsiConsole.Ask<double>("x= ");
            AnsiConsole.Render(new FigletText($"y = {CalculateY(x)}"));

            Console.ReadKey();
        }

        static double CalculateY(double x)
        {
            if (1 < x && x < 2)
            {
                return Math.Pow(x - 2, 2) + 6;
            }
            else if (x >= 2)
            {
                return Math.Log(x + 3 * Math.Sqrt(x));
            }
            else
            {
                throw new ArgumentException("x не входит в допустимый диапазон значений");
            }
        }
    }
}
