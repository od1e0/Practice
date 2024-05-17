using System;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            int number = 223;

            Task<int> task1 = Task.Run(() =>
            {
                int firstDigit = number / 100; 
                int lastDigit = number % 10;
                return firstDigit * lastDigit; 
            });

            Task task2 = task1.ContinueWith(t =>
            {
                Console.WriteLine($"Произведение первой и последней цифры числа {number}: {t.Result}");
            });

            task2.Wait();

            Console.ReadLine();
        }
    }
}
