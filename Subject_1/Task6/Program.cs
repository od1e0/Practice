using System;
using Spectre.Console;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = Math.PI / 8; 
            double B = 2 / Math.PI;
            int M = 15; 

            double H = (B - A) / M;

            var table = new Table().Border(TableBorder.Rounded);
            table.AddColumn("x");
            table.AddColumn("F(x)");

            for (int i = 0; i <= M; i++)
            {
                double x = A + i * H;
                double F = Math.Sin(1 / x);
                table.AddRow(x.ToString(), F.ToString());
            }

            AnsiConsole.Render(table);

            Console.ReadKey();
        }
    }
}
