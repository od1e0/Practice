using System;
using System.Diagnostics;
using System.Threading;
using static Spectre.Console.AnsiConsole;

    namespace Task2
    {
        class Program
        {
            static void Main()
            {
                Thread t1 = new Thread(SumNumbers);
                t1.Name = "Thread 1";
                t1.Start();

                Thread t2 = new Thread(SumNumbers);
                t2.Name = "Thread 2";
                t2.Start();

                System.Console.ReadLine();
            }

            static void SumNumbers()
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    sum += i;
                }

                stopwatch.Stop();
                MarkupLine($"[red]{Thread.CurrentThread.Name}[/] completed. Sum: [green]{sum}[/]. Time elapsed: [green]{stopwatch.ElapsedMilliseconds}[/] ms");
            }
        }
    }
