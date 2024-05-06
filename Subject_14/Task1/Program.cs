using System.Threading;
using static Spectre.Console.AnsiConsole;

namespace Task1
{
    class Program
    {
        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        static void Main()
        {
            Thread t1 = new Thread(PrintNumbers);
            t1.Name = "Thread 1";
            t1.Priority = ThreadPriority.Lowest;
            t1.Start(0);

            Thread t2 = new Thread(PrintNumbers);
            t2.Name = "Thread 2";
            t2.Priority = ThreadPriority.BelowNormal;
            t2.Start(10);

            Thread t3 = new Thread(PrintNumbers);
            t3.Name = "Thread 3";
            t3.Priority = ThreadPriority.Normal;
            t3.Start(20);

            System.Console.ReadLine();
        }

        static void PrintNumbers(object start)
        {
            int num = (int)start;
            for (int i = num; i < num + 10; i++)
            {
                lock (autoEvent)
                {
                    MarkupLine($"[green]{Thread.CurrentThread.Name} prints: {i}[/]");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
