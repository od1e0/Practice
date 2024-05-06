using System.Threading;
using System;
using static Spectre.Console.AnsiConsole;

namespace Task3
{
    class Program
    {
        static object lockObject = new object();

        static void Main()
        {
            int A = Ask<int>("Введите значение A: ");

            int N = Ask<int>("Введите значение N: ");

            Thread t1 = new Thread(() => SumMethod(A, N));
            t1.Start();

            Thread t2 = new Thread(() => SumMethod(A, N));
            t2.Start();

            Thread t3 = new Thread(() => MultiplyMethod(A, N));
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            System.Console.ReadLine();
        }

        static void SumMethod(int A, int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += A + i;
            }
            MarkupLine($"Сумма чисел от A до A+N в [red]{Thread.CurrentThread.ManagedThreadId}[/]: [green]{sum}[/]");
        }

        static void MultiplyMethod(int A, int N)
        {
            lock (lockObject)
            {
                int product = 1;
                for (int i = 1; i <= N; i++)
                {
                    product *= A * i;
                }
                MarkupLine($"Произведение чисел от A до A*N в [red]{Thread.CurrentThread.ManagedThreadId}[/]: [green]{product}[/]");
            }
        }
    }
}
