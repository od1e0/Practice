using System;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1234;

            Task<int> task1 = Task.Factory.StartNew(() => SwapDigits(number));
            Task<int> task2 = Task.Run(() => SwapDigits(number));
            Task<int> task3 = new Task<int>(() => SwapDigits(number));
            task3.Start();

            Console.WriteLine($"Результат задачи 1: {task1.Result}");
            Console.WriteLine($"Результат задачи 2: {task2.Result}");
            Console.WriteLine($"Результат задачи 3: {task3.Result}");

            Console.ReadLine();
        }

        static int SwapDigits(int number)
        {
            int d1 = number / 1000; 
            int d2 = number / 100 % 10; 
            int d3 = number / 10 % 10; 
            int d4 = number % 10; 

            return d2 * 1000 + d1 * 100 + d4 * 10 + d3;
        }
    }
}