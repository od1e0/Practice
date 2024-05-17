using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 43, 87, 33, 5 };

            ParallelLoopResult result = Parallel.ForEach(numbers, (number, state) =>
            {
                int sum = Enumerable.Range(0, number + 1).Sum();
                Console.WriteLine($"Сумма чисел от 0 до {number}: {sum}");

                long product = Enumerable.Range(1, number).Aggregate(1, (a, b) => a * b);
                Console.WriteLine($"Произведение чисел от 0 до {number}: {product}");

                if (number == 33)
                {
                    Console.WriteLine($"Прерывание выполнения на числе {number}");
                    state.Break();
                }
            });

            if (!result.IsCompleted)
            {
                Console.WriteLine($"Выполнение было прервано на итерации {result.LowestBreakIteration}");
            }

            Console.ReadLine();
        }
    }
}
