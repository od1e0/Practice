using System;
using Spectre.Console;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = AnsiConsole.Ask<int>("Введите А=");
            var B = AnsiConsole.Ask<int>("Введите B=");

            Console.WriteLine("С использованием цикла while:");
            PrintWithWhile(A, B);

            Console.WriteLine("\nС использованием цикла do while:");
            PrintWithDoWhile(A, B);

            Console.WriteLine("\nС использованием цикла for:");
            PrintWithFor(A, B);

            Console.ReadKey();
        }

        static void PrintWithWhile(int A, int B)
        {
            int i = A;
            while (i <= B)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        static void PrintWithDoWhile(int A, int B)
        {
            int i = A;
            do
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= B);
        }

        static void PrintWithFor(int A, int B)
        {
            for (int i = A; i <= B; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
