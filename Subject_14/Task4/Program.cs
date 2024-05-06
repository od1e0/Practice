using System;
using System.Linq;
using System.Threading;

namespace Task4
{
    class Program
    {
        static int[] numbers;
        static int sum = 0;
        static object lockObject = new object();

        static void Main()
        {
            numbers = Enumerable.Range(0, 100).ToArray();

            Thread t1 = new Thread(SumEvenNumbers);
            Thread t2 = new Thread(SumEvenNumbers);

            t1.Start(0);  
            t2.Start(1);  

            t1.Join();
            t2.Join();

            Console.WriteLine($"Сумма четных чисел: {sum}");

            System.Console.ReadLine();
        }

        static void SumEvenNumbers(object start)
        {
            int startIndex = (int)start;
            for (int i = startIndex; i < numbers.Length; i += 2)
            {
                if (numbers[i] % 2 == 0)
                {
                    lock (lockObject)
                    {
                        sum += numbers[i];
                    }
                }
            }
        }
    }
}
