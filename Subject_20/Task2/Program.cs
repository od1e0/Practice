using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task2{
    class Program
    {
        static void Main()
        {
            Task[] tasks = new Task[2];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(2000); 
                double a = 1, alpha = 2; 
                double z1 = (1 + a * Math.Pow(alpha, 2)) / (2 * a + Math.Pow(alpha, 2)) + Math.Pow((5 - 2 * Math.Pow(alpha, 2)), -1);
                Console.WriteLine($"Значение z1: {z1}");
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(5000); 
                double m = 3; 
                double z2 = 1 / (Math.Sqrt(2 * Math.PI)) * Math.Exp(-Math.Pow(m, 2) / 2);
                Console.WriteLine($"Значение z2: {z2}");
            });

            Task.WhenAll(tasks).Wait();
            Console.WriteLine("Все задачи выполнены");

            int taskIndex = Task.WaitAny(tasks);
            Console.WriteLine($"Задача {taskIndex + 1} выполнена первой");

            Console.ReadLine();
        }
    }
}
